using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptiConfigLib.Models;
using Newtonsoft.Json;
using System.IO;

namespace OptiConfigLib
{
    public class DataProcessor
    {
        //private string JsonFilePath = System.Windows.Forms.Application.StartupPath + @"\SavedConfig.json";
        private string JsonFilePath = @"C:\Users\kuba\Desktop\projects\C#\OptiConfig\JsonTest\test.json";
        public List<ConfigModel> ConfigModelToJson(ConfigModel model)
        {
            string jsonFile = File.ReadAllText(JsonFilePath);
            List<ConfigModel> allConfigs = new List<ConfigModel>();
            allConfigs = JsonConvert.DeserializeObject<List<ConfigModel>>(jsonFile);
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
            List<ConfigModel> allConfigs = new List<ConfigModel>();
            allConfigs = JsonConvert.DeserializeObject<List<ConfigModel>>(jsonFile);
            return allConfigs;
        }

    }
}
