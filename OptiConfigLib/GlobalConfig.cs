using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EnvDTE;


namespace OptiConfigLib
{
    public static class GlobalConfig
    {
        public static ICommands Commands { get; private set; }
        public static void InitializeCommands()
         { 
            PowershellCommands cmd = new PowershellCommands();
            Commands = cmd;
        }

        


    }
}
