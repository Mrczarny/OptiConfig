using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptiConfigLib.Models;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;
using System.Net;
using System.Security;

namespace OptiConfigLib
{
    public class DataProcessor
    {
        private string JsonFilePath = System.Windows.Forms.Application.StartupPath + @"\SavedConfig.json";
        //private string JsonFilePath = @"C:\Users\kuba\Desktop\projects\C#\OptiConfig\JsonTest\test.json";
        public List<ConfigModel> ConfigModelToJson(ConfigModel model)
        {
            if (model.UserConfig.UserPassword.Length != 0 )
            {
                if (model.UserConfig.UserPasswordHashed == null)
                {
                    model.UserConfig.UserPasswordHashed = EncryptionProcessor.Encrypt(model.UserConfig.UserPassword, new NetworkCredential("", "pppppppp").SecurePassword); //TODO - make this better!
                } 
            }
            List<ConfigModel> allConfigs = GetConfigModels();
            int HighestId = 0;

            if (allConfigs.Count > 0)
            {
                HighestId = allConfigs.Max(x => x.Id) + 1;
            }
            model.Id = HighestId;
            allConfigs.Add(model);

            string jsonString = JsonConvert.SerializeObject(allConfigs);
            File.WriteAllText(JsonFilePath, jsonString);

            return allConfigs;
        }
        public List<ConfigModel> GetConfigModels()
        {
            string jsonFile = File.ReadAllText(JsonFilePath);
            List<ConfigModel> allConfigs = JsonConvert.DeserializeObject<List<ConfigModel>>(jsonFile);
            foreach (ConfigModel model in allConfigs)
            {
                if (model.UserConfig.UserPasswordHashed != null)
                {
                    model.UserConfig.UserPassword = EncryptionProcessor.Decrypt(model.UserConfig.UserPasswordHashed, new NetworkCredential("", "pppppppp").SecurePassword);
                }
            }
            return allConfigs;
        }


    }
}
