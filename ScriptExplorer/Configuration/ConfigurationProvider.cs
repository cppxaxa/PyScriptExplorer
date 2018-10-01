using Newtonsoft.Json;
using ScriptExplorer.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptExplorer.Configuration
{
    public class ConfigurationProvider
    {
        string filename;

        public ConfigurationProvider(string filename)
        {
            this.filename = filename;
        }

        public ConfigurationProvider()
        {
            filename = "ScriptExplorerConfiguration.json";
        }

        private ConfigurationType GetDefaultConfiguration()
        {
            ConfigurationType config = new ConfigurationType
            {
                DirectoryPath = null
            };

            return config;
        }

        public ConfigurationType GetConfiguration()
        {
            ConfigurationType configuration;

            if (File.Exists(this.filename))
            {
                string fileContents = File.ReadAllText(filename);
                configuration = JsonConvert.DeserializeObject<ConfigurationType>(fileContents);
            }
            else
            {
                configuration = this.GetDefaultConfiguration();
            }

            configuration = Sanitize(configuration);

            return configuration;
        }

        private ConfigurationType Sanitize(ConfigurationType config)
        {
            if (config.DirectoryPath != null && config.DirectoryPath.Trim() == string.Empty)
                config.DirectoryPath = null;

            return config;
        }

        public void SaveConfiguration(ConfigurationType configuration)
        {
            string jsonContent = JsonConvert.SerializeObject(configuration);

            File.WriteAllText(filename, jsonContent);
        }
    }
}
