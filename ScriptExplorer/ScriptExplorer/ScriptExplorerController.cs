﻿using ScriptExplorer.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptExplorer.ScriptExplorer
{
    public class ScriptExplorerController
    {
        ConfigurationProvider configurationProvider;
        ConfigurationType configuration;
        List<string> allScriptFiles = new List<string>();

        List<Process> processList = new List<Process>();

        public ConfigurationType CurrentConfiguration { get { return configuration; } }

        public ScriptExplorerController(ConfigurationProvider provider)
        {
            this.configurationProvider = provider;

            configuration = configurationProvider.GetConfiguration();

            configuration = Sanitize(configuration);
        }

        public List<string> GetErrors()
        {
            List<string> errorList = new List<string>();

            if (!File.Exists(configuration.PythonExePath))
            {
                errorList.Add("PythonExe path not correct. App can't execute scripts");
            }

            if (!File.Exists(configuration.PythonWExePath))
            {
                errorList.Add("PythonWExe path not correct. App can't execute non console scripts.");
            }

            return errorList;
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

            allScriptFiles = Directory.GetFiles(configuration.DirectoryPath).ToList();
            foreach (var file in allScriptFiles)
            {
                if (IsPythonScript(file))
                {
                    scriptFilesList.Add(Path.GetFileNameWithoutExtension(file));
                }
            }

            return scriptFilesList;
        }



        public void ExecuteScript(string scriptFilename, string arguments = "")
        {
            // Incomplete
        }

        public void SetNewDirectory(string selectedPath)
        {
            configuration.DirectoryPath = selectedPath;
        }

        public string ExecuteScriptScalar(string scriptFilename, string arguments = "")
        {
            // Incomplete
            return null;
        }

        public void ExecuteScriptAsync(string scriptFilename, string arguments = "")
        {
            // Incomplete
            string scriptPath = GetPythonFilename(scriptFilename);
            string processArguments = "\"" + scriptPath + "\" " + arguments;
            Console.WriteLine("\"" + configuration.PythonExePath + "\" " + processArguments);

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo(configuration.PythonExePath, processArguments)
            };

            if (process.Start())
            {
                processList.Add(process);
            }
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

        public string ReadScriptFileContents(string selectedValue)
        {
            string result = "";
            result = File.ReadAllText(GetPythonFilename(selectedValue));
            return result;
        }

        private string GetPythonFilename(string selectedValue)
        {
            return Path.Combine(configuration.DirectoryPath, selectedValue + ".py");
        }

        public void SetInputDirectory(string selectedPath)
        {
            configuration.BaseInputDirectory = selectedPath;
        }

        public void SetOutputDirectory(string selectedPath)
        {
            configuration.BaseOutputDirectory = selectedPath;
        }

        public void OpenFileExplorer(string path)
        {
            if (configuration.FileExplorerPath == null)
            {
                MessageBox.Show("File explorer path not set");
                return;
            }

            string directoryToExplore = path;

            if (!Directory.Exists(directoryToExplore))
            {
                directoryToExplore = Path.GetDirectoryName(directoryToExplore);
            }

            Console.WriteLine(configuration.FileExplorerPath + " " + directoryToExplore);

            Process explorer = new Process
            {
                StartInfo = new ProcessStartInfo(configuration.FileExplorerPath, directoryToExplore)
            };

            if (!explorer.Start())
            {
                MessageBox.Show("Failed to start explorer, " + configuration.FileExplorerPath + " with " + directoryToExplore);
            }
            
        }
    }
}
