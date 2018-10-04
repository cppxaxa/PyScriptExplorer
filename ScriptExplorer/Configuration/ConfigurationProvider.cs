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

            int p = (int)Environment.OSVersion.Platform;
            if ((p == 4) || (p == 6) || (p == 128))
            {
                // Unix
                config.FileExplorerPath = "nautilus";
            }
            else
            {
                // Non-unix
                config.FileExplorerPath = @"C:\Windows\explorer.exe";
            }

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
            else if (!Directory.Exists(config.DirectoryPath))
                config.DirectoryPath = null;

            if (config.BaseInputDirectory != null && config.BaseInputDirectory.Trim() == string.Empty)
                config.BaseInputDirectory = null;
            else if (!Directory.Exists(config.BaseInputDirectory))
                config.BaseInputDirectory = null;

            if (config.BaseOutputDirectory != null && config.BaseOutputDirectory.Trim() == string.Empty)
                config.BaseOutputDirectory = null;
            else if (!Directory.Exists(config.BaseOutputDirectory))
                config.BaseOutputDirectory = null;

            if (config.PythonExePath != null && config.PythonExePath.Trim() == string.Empty)
                config.PythonExePath = null;
            else if (!File.Exists(config.PythonExePath))
                config.PythonExePath = null;

            if (config.PythonWExePath != null && config.PythonWExePath.Trim() == string.Empty)
                config.PythonWExePath = null;
            else if (!File.Exists(config.PythonWExePath))
                config.PythonWExePath = null;



            return config;
        }

        public void SaveConfiguration(ConfigurationType configuration)
        {
            string jsonContent = JsonConvert.SerializeObject(configuration);

            File.WriteAllText(filename, jsonContent);
        }
    }
}
