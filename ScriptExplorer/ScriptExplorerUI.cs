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
                controller.ExecuteScriptAsync();
            }
            else
            {
                MessageBox.Show("No item selected, can't run any script", "Error");
            }
        }
    }
}
