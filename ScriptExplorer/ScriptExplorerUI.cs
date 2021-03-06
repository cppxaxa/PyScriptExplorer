﻿using ScriptExplorer.Configuration;
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
using System.IO;
using ScriptExplorer.Properties;

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

            Size = new Size(1000, 600);
            
            ImageList iconList = new ImageList();
            iconList.Images.Add(Resources.FolderIcon);
            iconList.Images.Add(Resources.DocumentsIcon);

            TvBaseInput.StateImageList = iconList;
            TvBaseOutput.StateImageList = iconList;


            if (controller.CurrentConfiguration.BaseInputDirectory != null)
            {
                LoadDirectory(TvBaseInput, controller.CurrentConfiguration.BaseInputDirectory);
                if (TvBaseInput.Nodes.Count > 0)
                {
                    TvBaseInput.Visible = true;
                }
            }

            if (controller.CurrentConfiguration.BaseOutputDirectory != null)
            {
                LoadDirectory(TvBaseOutput, controller.CurrentConfiguration.BaseOutputDirectory);
                if (TvBaseOutput.Nodes.Count > 0)
                {
                    TvBaseOutput.Visible = true;
                }
            }
        }

        private void LbScriptList_DoubleClick(object sender, EventArgs e)
        {
            if (LbScriptList.SelectedIndex != -1)
            {
                string selectedValue = LbScriptList.SelectedItem.ToString();

                string inputPath = "";
                string outputPath = "";

                inputPath = TvBaseInput.SelectedNode?.Tag.ToString();
                outputPath = TvBaseOutput.SelectedNode?.Tag.ToString();

                if (inputPath == null || inputPath.Trim() == "")
                {
                    MessageBox.Show("Input path not selected");
                    return;
                }

                if (outputPath == null || outputPath.Trim() == "")
                {
                    MessageBox.Show("Output path not selected");
                    return;
                }

                controller.ExecuteScriptAsync(selectedValue, "\"" + inputPath + "\" --output \"" + outputPath + "\"");
            }
            else
            {
                MessageBox.Show("No item selected, can't run any script", "Error");
            }
        }

        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("Workspace Path", "Set Configuration", controller.CurrentConfiguration.DirectoryPath);

            if (result.Trim() != "")
            {
                controller.SetNewDirectory(result);
                LbScriptList.DataSource = controller.GetScriptNames();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("PythonExe Path", "Set Configuration", controller.CurrentConfiguration.PythonExePath);

            if (result.Trim() != "")
            {
                controller.CurrentConfiguration.PythonExePath = result;
            }
        }

        private void ScriptExplorerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.SaveConfiguration();
        }

        private void setPythonWExePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("PythonWExe Path", "Set Configuration", controller.CurrentConfiguration.PythonWExePath);

            if (result.Trim() != "")
            {
                controller.CurrentConfiguration.PythonWExePath = result;
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

        private void TvOutputDirectory_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                controller.SetOutputDirectory(dialog.SelectedPath);
            }
        }






        private void clearInputTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TvBaseInput.Nodes.Clear();
            TvBaseInput.Visible = false;
        }

        private void clearOutputTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TvBaseOutput.Nodes.Clear();
            TvBaseOutput.Visible = false;
        }

        private void addDirectoryToInputTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TvInputPanel_DoubleClick(null, null);
        }

        private void addDirectoryToOutputTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TvOutputPanel_DoubleClick(null, null);
        }


        private void TvInputPanel_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                SelectedPath = controller.CurrentConfiguration.BaseInputDirectory
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TvBaseInput.Visible = true;
                controller.SetInputDirectory(dialog.SelectedPath);
                LoadDirectory(TvBaseInput, controller.CurrentConfiguration.BaseInputDirectory);
            }
        }

        private void TvOutputPanel_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                SelectedPath = controller.CurrentConfiguration.BaseOutputDirectory
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TvBaseOutput.Visible = true;
                controller.SetOutputDirectory(dialog.SelectedPath);
                LoadDirectory(TvBaseOutput, controller.CurrentConfiguration.BaseOutputDirectory);
            }
        }
        






        private void LoadDirectory(TreeView treeView, string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            TreeNode tds = treeView.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories 

            if (subdirectoryEntries.Length < 200)
            {
                foreach (string subdirectory in subdirectoryEntries)
                {
                    DirectoryInfo di = new DirectoryInfo(subdirectory);
                    TreeNode tds = td.Nodes.Add(di.Name);
                    tds.StateImageIndex = 0;
                    tds.Tag = di.FullName;
                    LoadFiles(subdirectory, tds);
                    LoadSubDirectories(subdirectory, tds);
                }
            }
            else
            {
                TreeNode tds = td.Nodes.Add("<Folders more than 200> ...");
                tds.StateImageIndex = 0;
                tds.Tag = dir;
            }
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            if (Files.Length < 200)
            {
                // Loop through them to see files  
                foreach (string file in Files)
                {
                    FileInfo fi = new FileInfo(file);
                    TreeNode tds = td.Nodes.Add(fi.Name);
                    tds.Tag = fi.FullName;
                    tds.StateImageIndex = 1;
                }
            }
            else
            {
                TreeNode tds = td.Nodes.Add("<Files more than 200> ...");
                tds.Tag = dir;
                tds.StateImageIndex = 1;
            }
        }

        private void TvBaseInput_MouseMove(object sender, MouseEventArgs e)
        {
            CheckAndShowTooltip(TvBaseInput, e);
        }

        private void TvBaseOutput_MouseMove(object sender, MouseEventArgs e)
        {
            CheckAndShowTooltip(TvBaseOutput, e);
        }

        private void CheckAndShowTooltip(TreeView treeViewWidget, MouseEventArgs e)
        {
            // Get the node at the current mouse pointer location.  
            TreeNode theNode = treeViewWidget.GetNodeAt(e.X, e.Y);

            // Set a ToolTip only if the mouse pointer is actually paused on a node.  
            if (theNode != null && theNode.Tag != null)
            {
                // Change the ToolTip only if the pointer moved to a new node.  
                if (theNode.Tag.ToString() != this.toolTip1.GetToolTip(treeViewWidget))
                    this.toolTip1.SetToolTip(treeViewWidget, theNode.Tag.ToString());

            }
            else     // Pointer is not over a node so clear the ToolTip.  
            {
                this.toolTip1.SetToolTip(treeViewWidget, "");
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LbScriptList.DataSource = controller.GetScriptNames();

            TvBaseInput.Nodes.Clear();
            TvBaseInput.Visible = false;

            TvBaseOutput.Nodes.Clear();
            TvBaseOutput.Visible = false;

            if (controller.CurrentConfiguration.BaseInputDirectory != null)
            {
                LoadDirectory(TvBaseInput, controller.CurrentConfiguration.BaseInputDirectory);
                if (TvBaseInput.Nodes.Count > 0)
                {
                    TvBaseInput.Visible = true;
                }
            }

            if (controller.CurrentConfiguration.BaseOutputDirectory != null)
            {
                LoadDirectory(TvBaseOutput, controller.CurrentConfiguration.BaseOutputDirectory);
                if (TvBaseOutput.Nodes.Count > 0)
                {
                    TvBaseOutput.Visible = true;
                }
            }
        }

        private void TvBaseInput_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point p = new Point(e.X, e.Y);

                TreeNode node = TvBaseInput.GetNodeAt(p);
                activeMiTvNode = node;
                if (node != null)
                {
                    TvBaseInput.SelectedNode = node;
                    CmsTvGeneric.Show(TvBaseInput, p);
                }
            }
        }

        private void TvBaseOutput_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point p = new Point(e.X, e.Y);

                TreeNode node = TvBaseOutput.GetNodeAt(p);
                activeMiTvNode = node;
                if (node != null)
                {
                    TvBaseOutput.SelectedNode = node;
                    CmsTvGeneric.Show(TvBaseOutput, p);
                }
            }
        }

        private TreeNode activeMiTvNode = null;
        private void MiOpenInExplorer_Click(object sender, EventArgs e)
        {
            controller.OpenFileExplorer(activeMiTvNode.Tag as string);
        }

        private void setFileExplorerPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("FileExplorer Path", "Set Configuration", controller.CurrentConfiguration.FileExplorerPath);

            if (result.Trim() != "")
            {
                controller.CurrentConfiguration.FileExplorerPath = result;
            }
        }
    }
}
