using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using OptiConfigLib.Models;
using System.IO;
using System.Management.Automation.Runspaces;
using System.Runtime.CompilerServices;

namespace OptiConfigLib
{
    public class PowershellCommands : ICommands
    {
        /// PS didn't want to work, so I'm using runspace.

        /// <summary>
        /// Core of entire class, runs scripts and returns report
        /// </summary>
        /// <param name="Script">Script filePath or whole script</param>
        /// <param name="Parameters">Script parameters</param>
        /// <returns>Returns report which contains list of errors and script's result</returns>
        private Dictionary<string, string> ScriptRun(string Script, List<CommandParameter> Parameters)
        {
            string executionPolicy = "set-executionpolicy -ExecutionPolicy \"remotesigned\" -Scope \"Process\" -Force";

            RunspaceConfiguration runspaceConfiguration = RunspaceConfiguration.Create();
            Runspace rs = RunspaceFactory.CreateRunspace(runspaceConfiguration);
            rs.Open();
            Pipeline pl = rs.CreatePipeline();

            pl.Commands.AddScript(executionPolicy);
            pl.Invoke();
            pl.Commands.Clear();                        // It looks awful.
            pl.Stop();

            pl = rs.CreatePipeline();
            Command scriptCommand = new Command(Script);
            foreach (CommandParameter cp in Parameters)
            {
                scriptCommand.Parameters.Add(cp);
            }
            pl.Commands.Add(scriptCommand);
            pl.Commands.Add("Out-String"); 
            
            //Run script here
            Collection<PSObject> resultObjects = pl.Invoke();
            string[] Info = new string[pl.Error.Count + 1];
            if (pl.Error.Count > 0)
            {
                for (int i = 0; i < pl.Error.Count; i++)
                {
                    Info[i] = pl.Error.ReadToEnd()[i].ToString();
                }
            }
            rs.Close();

            StringBuilder resultStringBuilder = new StringBuilder();
            foreach (PSObject resultObject in resultObjects)
            {
                resultStringBuilder.AppendLine(resultObject.ToString());
            }
           Info[Info.GetUpperBound(0)] = resultStringBuilder.ToString(); 
           Dictionary<string, string> report = new Dictionary<string, string>();
           for (int i = 0; i < Info.Length - 2; i++)
           {
               report.Add("Error_" + i, Info[i]);
           }
           report.Add("FinalResult", Info[Info.GetUpperBound(0)]);
           return report;
        }

        /// <summary>
        /// This method only get script filePath
        /// and adds parameters. 
        /// </summary>
        /// <param name="User">This user model</param>
        public string[] UserAdd(UserModel user)
        {

            string script = System.Windows.Forms.Application.StartupPath + @"\PSScripts\UserAddScript.ps1";

            CommandParameter userNameParameter = new CommandParameter("UserName", user.UserName);
            CommandParameter userPasswordParameter = new CommandParameter("Password", user.UserPassword);
            CommandParameter userGroupParameter = new CommandParameter("UserLocalGroup", user.UserLocalGroup);
            List<CommandParameter> parametersList = new List<CommandParameter>() {userPasswordParameter, userNameParameter, userGroupParameter};

            return ReportHandler(ScriptRun(script, parametersList));
        }

        /// <summary>
        /// This method only get script filePath
        /// and adds parameters. 
        /// </summary>
        /// <param name="Secpol">This secpol model</param>
        public string[] SecPolEdit(SecpolModel secpol)
        {
            string script = System.Windows.Forms.Application.StartupPath + @"\PSScripts\SecPolScript.ps1";

            CommandParameter passwordComplexityParameter = new CommandParameter("PasswordComplexity", 0);
            if (secpol.PasswordComplexity)
            {
                passwordComplexityParameter = new CommandParameter("PasswordComplexity", 1);
            }
            CommandParameter minimumPasswordLengthParameter = new CommandParameter("MinimumPasswordLength", secpol.MinimumPasswordLength);
            CommandParameter maximumPasswordAgeParameter = new CommandParameter("MaximumPasswordAge", secpol.MaximumPasswordAge);               //  (-_-) ...
            CommandParameter passwordHistorySizeNameParameter = new CommandParameter("PasswordHistorySize", secpol.PasswordHistorySize);
            List<CommandParameter> parametersList = new List<CommandParameter>() { passwordComplexityParameter, minimumPasswordLengthParameter, 
                                                                                maximumPasswordAgeParameter, passwordHistorySizeNameParameter };

            return ReportHandler(ScriptRun(script, parametersList));
        }

        /// <summary>
        ///This method only get script filePath
        /// and adds parameters. 
        /// </summary>
        /// <param name="bitlocker">This bitlocker model</param>
        /// <returns></returns>
        public string[] BitlockerEdit(BitlockerModel bitlocker)
        {
            string script = System.Windows.Forms.Application.StartupPath + @"\PSScripts\BitLockerScript.ps1";

            CommandParameter serviceTag = new CommandParameter("ServiceTag", bitlocker.ServiceTag);
            CommandParameter usbName = new CommandParameter("USBname", bitlocker.UsbName);

            List<CommandParameter> parametersList = new List<CommandParameter>() { serviceTag, usbName };

            return ReportHandler(ScriptRun(script, parametersList));
        }

        private string[] ReportHandler(Dictionary<string, string> result, [CallerMemberName] string callerName = "")
        {
            if (result != null)
            {
                string[] Report = new string[2];
                //Report values being add
                foreach (KeyValuePair<string, string> pair in result)
                {
                    Report[1] += pair.Key + ":   " + pair.Value + "\n";
                }
                //Report me pls ;_;
                Report[0] = callerName;
                return Report;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

    }
}
