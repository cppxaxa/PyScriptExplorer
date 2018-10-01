using ScriptExplorer.Configuration;
using ScriptExplorer.ScriptExplorer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace ScriptExplorer
{
    public partial class ScriptExplorerUI : Form
    {
        ScriptExplorerController controller;
        ConfigurationProvider configurationProvider;

        public ScriptExplorerUI()
        {
            InitializeComponent();
        }

        private void ScriptExplorerUI_Load(object sender, EventArgs e)
        {
            configurationProvider = new ConfigurationProvider();
            controller = new ScriptExplorerController(configurationProvider);

            LbScriptList.DataSource = controller.GetScriptNames();
        }

        private void LbScriptList_DoubleClick(object sender, EventArgs e)
        {
            if (LbScriptList.SelectedIndex != -1)
            {
                string selectedValue = LbScriptList.SelectedItem.ToString();
                controller.ExecuteScriptAsync(selectedValue);
            }
            else
            {
                MessageBox.Show("No item selected, can't run any script", "Error");
            }
        }

        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                controller.SetNewDirectory(dialog.SelectedPath);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("PythonExe Path", "Set Configuration", controller.PythonExePath);

            if (result.Trim() != "")
            {
                controller.PythonExePath = result;
            }
        }

        private void ScriptExplorerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.SaveConfiguration();
        }

        private void setPythonWExePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("PythonWExe Path", "Set Configuration", controller.PythonWExePath);

            if (result.Trim() != "")
            {
                controller.PythonWExePath = result;
            }
        }

        private void executeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (LbScriptList.SelectedIndex != -1)
            {
                string selectedValue = LbScriptList.SelectedItem.ToString();
                controller.ExecuteScript(selectedValue);
            }
            else
            {
                MessageBox.Show("No item selected, can't run any script", "Error");
            }
        }

        private void executeWithArgumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LbScriptList.SelectedIndex != -1)
            {
                string selectedValue = LbScriptList.SelectedItem.ToString();
                string result = Interaction.InputBox("Enter arguments", "Execute with arguments");

                if (result.Trim() == "")
                {
                    MessageBox.Show("Cancelling execution");
                    return;
                }

                controller.ExecuteScript(selectedValue, result);
            }
            else
            {
                MessageBox.Show("No item selected, can't run any script", "Error");
            }
        }

        private void LbScriptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbScriptList.SelectedIndex != -1)
            {
                string selectedValue = LbScriptList.SelectedItem.ToString();
                string scriptContent = controller.ReadScriptFileContents(selectedValue);
                RtbContentViewer.Text = scriptContent;
            }
            else
            {
                MessageBox.Show("No item selected, no script preview", "Error");
            }
        }
    }
}
