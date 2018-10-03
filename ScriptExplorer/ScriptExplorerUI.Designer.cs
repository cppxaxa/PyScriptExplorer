namespace ScriptExplorer
{
    partial class ScriptExplorerUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbScriptList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RtbContentViewer = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPythonWExePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.executeWithArgumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeScalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeScalarWithArgumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeAsyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeAsyncWithArgumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TvInputPanel = new System.Windows.Forms.Panel();
            this.TvOutputPanel = new System.Windows.Forms.Panel();
            this.TvBaseInput = new System.Windows.Forms.TreeView();
            this.TvBaseOutput = new System.Windows.Forms.TreeView();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearInputTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOutputTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDirectoryToInputTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDirectoryToOutputTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TvInputPanel.SuspendLayout();
            this.TvOutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            this.TableLayout.BackColor = System.Drawing.Color.Azure;
            this.TableLayout.ColumnCount = 3;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayout.Controls.Add(this.RtbContentViewer, 2, 0);
            this.TableLayout.Controls.Add(this.panel1, 0, 0);
            this.TableLayout.Controls.Add(this.panel2, 1, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 40);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Size = new System.Drawing.Size(1970, 709);
            this.TableLayout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.LbScriptList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 703);
            this.panel1.TabIndex = 0;
            // 
            // LbScriptList
            // 
            this.LbScriptList.BackColor = System.Drawing.SystemColors.Info;
            this.LbScriptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LbScriptList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbScriptList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbScriptList.FormattingEnabled = true;
            this.LbScriptList.ItemHeight = 33;
            this.LbScriptList.Location = new System.Drawing.Point(0, 0);
            this.LbScriptList.Name = "LbScriptList";
            this.LbScriptList.Size = new System.Drawing.Size(494, 703);
            this.LbScriptList.TabIndex = 0;
            this.LbScriptList.SelectedIndexChanged += new System.EventHandler(this.LbScriptList_SelectedIndexChanged);
            this.LbScriptList.DoubleClick += new System.EventHandler(this.LbScriptList_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(503, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 703);
            this.panel2.TabIndex = 1;
            // 
            // RtbContentViewer
            // 
            this.RtbContentViewer.BackColor = System.Drawing.Color.White;
            this.RtbContentViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbContentViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbContentViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbContentViewer.Location = new System.Drawing.Point(1303, 3);
            this.RtbContentViewer.Name = "RtbContentViewer";
            this.RtbContentViewer.ReadOnly = true;
            this.RtbContentViewer.Size = new System.Drawing.Size(664, 703);
            this.RtbContentViewer.TabIndex = 0;
            this.RtbContentViewer.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1970, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDirectoryToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.setPythonWExePathToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openDirectoryToolStripMenuItem
            // 
            this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            this.openDirectoryToolStripMenuItem.Size = new System.Drawing.Size(341, 38);
            this.openDirectoryToolStripMenuItem.Text = "&Open Directory";
            this.openDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openDirectoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(341, 38);
            this.exitToolStripMenuItem.Text = "Set PythonExe Path";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // setPythonWExePathToolStripMenuItem
            // 
            this.setPythonWExePathToolStripMenuItem.Name = "setPythonWExePathToolStripMenuItem";
            this.setPythonWExePathToolStripMenuItem.Size = new System.Drawing.Size(341, 38);
            this.setPythonWExePathToolStripMenuItem.Text = "Set PythonWExe Path";
            this.setPythonWExePathToolStripMenuItem.Click += new System.EventHandler(this.setPythonWExePathToolStripMenuItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeToolStripMenuItem1,
            this.executeWithArgumentsToolStripMenuItem,
            this.executeScalarToolStripMenuItem,
            this.executeScalarWithArgumentsToolStripMenuItem,
            this.executeAsyncToolStripMenuItem,
            this.executeAsyncWithArgumentsToolStripMenuItem});
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(69, 36);
            this.executeToolStripMenuItem.Text = "&Run";
            // 
            // executeToolStripMenuItem1
            // 
            this.executeToolStripMenuItem1.Name = "executeToolStripMenuItem1";
            this.executeToolStripMenuItem1.Size = new System.Drawing.Size(441, 38);
            this.executeToolStripMenuItem1.Text = "Execute";
            this.executeToolStripMenuItem1.Click += new System.EventHandler(this.executeToolStripMenuItem1_Click);
            // 
            // executeWithArgumentsToolStripMenuItem
            // 
            this.executeWithArgumentsToolStripMenuItem.Name = "executeWithArgumentsToolStripMenuItem";
            this.executeWithArgumentsToolStripMenuItem.Size = new System.Drawing.Size(441, 38);
            this.executeWithArgumentsToolStripMenuItem.Text = "Execute with Arguments";
            this.executeWithArgumentsToolStripMenuItem.Click += new System.EventHandler(this.executeWithArgumentsToolStripMenuItem_Click);
            // 
            // executeScalarToolStripMenuItem
            // 
            this.executeScalarToolStripMenuItem.Name = "executeScalarToolStripMenuItem";
            this.executeScalarToolStripMenuItem.Size = new System.Drawing.Size(441, 38);
            this.executeScalarToolStripMenuItem.Text = "Execute &Scalar";
            // 
            // executeScalarWithArgumentsToolStripMenuItem
            // 
            this.executeScalarWithArgumentsToolStripMenuItem.Name = "executeScalarWithArgumentsToolStripMenuItem";
            this.executeScalarWithArgumentsToolStripMenuItem.Size = new System.Drawing.Size(441, 38);
            this.executeScalarWithArgumentsToolStripMenuItem.Text = "E&xecute Scalar with Arguments";
            // 
            // executeAsyncToolStripMenuItem
            // 
            this.executeAsyncToolStripMenuItem.Name = "executeAsyncToolStripMenuItem";
            this.executeAsyncToolStripMenuItem.Size = new System.Drawing.Size(441, 38);
            this.executeAsyncToolStripMenuItem.Text = "&Execute Async";
            // 
            // executeAsyncWithArgumentsToolStripMenuItem
            // 
            this.executeAsyncWithArgumentsToolStripMenuItem.Name = "executeAsyncWithArgumentsToolStripMenuItem";
            this.executeAsyncWithArgumentsToolStripMenuItem.Size = new System.Drawing.Size(441, 38);
            this.executeAsyncWithArgumentsToolStripMenuItem.Text = "Execute Async with &Arguments";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 712);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1970, 37);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusText
            // 
            this.StatusText.BackColor = System.Drawing.Color.Transparent;
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(79, 32);
            this.StatusText.Text = "Ready";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TvInputPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TvOutputPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 703);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TvInputPanel
            // 
            this.TvInputPanel.BackColor = System.Drawing.Color.White;
            this.TvInputPanel.Controls.Add(this.TvBaseInput);
            this.TvInputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvInputPanel.Location = new System.Drawing.Point(3, 3);
            this.TvInputPanel.Name = "TvInputPanel";
            this.TvInputPanel.Size = new System.Drawing.Size(788, 335);
            this.TvInputPanel.TabIndex = 0;
            this.TvInputPanel.DoubleClick += new System.EventHandler(this.TvInputPanel_DoubleClick);
            // 
            // TvOutputPanel
            // 
            this.TvOutputPanel.BackColor = System.Drawing.Color.White;
            this.TvOutputPanel.Controls.Add(this.TvBaseOutput);
            this.TvOutputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvOutputPanel.Location = new System.Drawing.Point(3, 344);
            this.TvOutputPanel.Name = "TvOutputPanel";
            this.TvOutputPanel.Size = new System.Drawing.Size(788, 335);
            this.TvOutputPanel.TabIndex = 1;
            this.TvOutputPanel.DoubleClick += new System.EventHandler(this.TvOutputPanel_DoubleClick);
            // 
            // TvBaseInput
            // 
            this.TvBaseInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TvBaseInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvBaseInput.Location = new System.Drawing.Point(0, 0);
            this.TvBaseInput.Name = "TvBaseInput";
            this.TvBaseInput.Size = new System.Drawing.Size(788, 335);
            this.TvBaseInput.TabIndex = 0;
            this.TvBaseInput.Visible = false;
            this.TvBaseInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TvBaseInput_MouseMove);
            // 
            // TvBaseOutput
            // 
            this.TvBaseOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TvBaseOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvBaseOutput.Location = new System.Drawing.Point(0, 0);
            this.TvBaseOutput.Name = "TvBaseOutput";
            this.TvBaseOutput.Size = new System.Drawing.Size(788, 335);
            this.TvBaseOutput.TabIndex = 0;
            this.TvBaseOutput.Visible = false;
            this.TvBaseOutput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TvBaseOutput_MouseMove);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearInputTreeToolStripMenuItem,
            this.clearOutputTreeToolStripMenuItem,
            this.addDirectoryToInputTreeToolStripMenuItem,
            this.addDirectoryToOutputTreeToolStripMenuItem});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(78, 38);
            this.clearToolStripMenuItem.Text = "&View";
            // 
            // clearInputTreeToolStripMenuItem
            // 
            this.clearInputTreeToolStripMenuItem.Name = "clearInputTreeToolStripMenuItem";
            this.clearInputTreeToolStripMenuItem.Size = new System.Drawing.Size(303, 38);
            this.clearInputTreeToolStripMenuItem.Text = "Clear Input Tree";
            this.clearInputTreeToolStripMenuItem.Click += new System.EventHandler(this.clearInputTreeToolStripMenuItem_Click);
            // 
            // clearOutputTreeToolStripMenuItem
            // 
            this.clearOutputTreeToolStripMenuItem.Name = "clearOutputTreeToolStripMenuItem";
            this.clearOutputTreeToolStripMenuItem.Size = new System.Drawing.Size(303, 38);
            this.clearOutputTreeToolStripMenuItem.Text = "Clear Output Tree";
            this.clearOutputTreeToolStripMenuItem.Click += new System.EventHandler(this.clearOutputTreeToolStripMenuItem_Click);
            // 
            // addDirectoryToInputTreeToolStripMenuItem
            // 
            this.addDirectoryToInputTreeToolStripMenuItem.Name = "addDirectoryToInputTreeToolStripMenuItem";
            this.addDirectoryToInputTreeToolStripMenuItem.Size = new System.Drawing.Size(432, 38);
            this.addDirectoryToInputTreeToolStripMenuItem.Text = "Add Directory to Input Tree";
            this.addDirectoryToInputTreeToolStripMenuItem.Click += new System.EventHandler(this.addDirectoryToInputTreeToolStripMenuItem_Click);
            // 
            // addDirectoryToOutputTreeToolStripMenuItem
            // 
            this.addDirectoryToOutputTreeToolStripMenuItem.Name = "addDirectoryToOutputTreeToolStripMenuItem";
            this.addDirectoryToOutputTreeToolStripMenuItem.Size = new System.Drawing.Size(425, 38);
            this.addDirectoryToOutputTreeToolStripMenuItem.Text = "Add Directory to Output Tree";
            this.addDirectoryToOutputTreeToolStripMenuItem.Click += new System.EventHandler(this.addDirectoryToOutputTreeToolStripMenuItem_Click);
            // 
            // ScriptExplorerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1970, 749);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TableLayout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScriptExplorerUI";
            this.Text = "Script Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScriptExplorerUI_FormClosing);
            this.Load += new System.EventHandler(this.ScriptExplorerUI_Load);
            this.TableLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TvInputPanel.ResumeLayout(false);
            this.TvOutputPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox LbScriptList;
        private System.Windows.Forms.RichTextBox RtbContentViewer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem executeWithArgumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeScalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeScalarWithArgumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeAsyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeAsyncWithArgumentsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
        private System.Windows.Forms.ToolStripMenuItem setPythonWExePathToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel TvInputPanel;
        private System.Windows.Forms.Panel TvOutputPanel;
        private System.Windows.Forms.TreeView TvBaseInput;
        private System.Windows.Forms.TreeView TvBaseOutput;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearInputTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOutputTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDirectoryToInputTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDirectoryToOutputTreeToolStripMenuItem;
    }
}

