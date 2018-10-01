using ScriptExplorer.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptExplorer.ScriptExplorer
{
    public class ScriptExplorerController
    {
        ConfigurationProvider configurationProvider;
        ConfigurationType configuration;

        public ScriptExplorerController(ConfigurationProvider provider)
        {
            this.configurationProvider = provider;

            configuration = configurationProvider.GetConfiguration();

            configuration = Sanitize(configuration);
        }

        private ConfigurationType Sanitize(ConfigurationType configuration)
        {
            if (configuration.DirectoryPath == null)
                configuration.DirectoryPath = AppDomain.CurrentDomain.BaseDirectory;

            return configuration;
        }

        public void SaveConfiguration()
        {
            configurationProvider.SaveConfiguration(configuration);
        }

        public List<string> GetScriptNames()
        {
            List<string> scriptFilesList = new List<string>();

            foreach (var file in Directory.GetFiles(configuration.DirectoryPath))
            {
                if (IsPythonScript(file))
                {
                    scriptFilesList.Add(Path.GetFileNameWithoutExtension(file));
                }
            }

            return scriptFilesList;
        }



        public void ExecuteScript(string scriptFilename, string arguments)
        {
            // Incomplete
        }

        public string ExecuteScriptScalar(string scriptFilename, string arguments)
        {
            // Incomplete
            return null;
        }

        public void ExecuteScriptAsync(string scriptFilename, string arguments)
        {
            // Incomplete
        }




        public void ExecuteScript(string scriptFilename, Dictionary<string, string> arguments)
        {
            // Incomplete
        }

        public string ExecuteScriptScalar(string scriptFilename, Dictionary<string, string> arguments)
        {
            // Incomplete
            return null;
        }

        public void ExecuteScriptAsync(string scriptFilename, Dictionary<string, string> arguments)
        {
            // Incomplete
        }



        private bool IsPythonScript(string file)
        {
            if (Path.GetExtension(file) == ".py")
                return true;
            return false;
        }
    }
}
