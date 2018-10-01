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
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbScriptList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RtbContentViewer = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.executeWithArgumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeScalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeScalarWithArgumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeAsyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeAsyncWithArgumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.setPythonWExePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 2;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayout.Controls.Add(this.panel1, 0, 0);
            this.TableLayout.Controls.Add(this.panel2, 1, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 40);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Size = new System.Drawing.Size(1319, 753);
            this.TableLayout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.LbScriptList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 747);
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
            this.LbScriptList.Size = new System.Drawing.Size(494, 747);
            this.LbScriptList.TabIndex = 0;
            this.LbScriptList.SelectedIndexChanged += new System.EventHandler(this.LbScriptList_SelectedIndexChanged);
            this.LbScriptList.DoubleClick += new System.EventHandler(this.LbScriptList_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.RtbContentViewer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(503, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 747);
            this.panel2.TabIndex = 1;
            // 
            // RtbContentViewer
            // 
            this.RtbContentViewer.BackColor = System.Drawing.Color.White;
            this.RtbContentViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbContentViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbContentViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbContentViewer.Location = new System.Drawing.Point(0, 0);
            this.RtbContentViewer.Name = "RtbContentViewer";
            this.RtbContentViewer.ReadOnly = true;
            this.RtbContentViewer.Size = new System.Drawing.Size(813, 747);
            this.RtbContentViewer.TabIndex = 0;
            this.RtbContentViewer.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.executeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1319, 40);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openDirectoryToolStripMenuItem
            // 
            this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            this.openDirectoryToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
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
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(69, 38);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 756);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1319, 37);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusText
            // 
            this.StatusText.BackColor = System.Drawing.Color.Transparent;
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(79, 33);
            this.StatusText.Text = "Ready";
            // 
            // setPythonWExePathToolStripMenuItem
            // 
            this.setPythonWExePathToolStripMenuItem.Name = "setPythonWExePathToolStripMenuItem";
            this.setPythonWExePathToolStripMenuItem.Size = new System.Drawing.Size(341, 38);
            this.setPythonWExePathToolStripMenuItem.Text = "Set PythonWExe Path";
            this.setPythonWExePathToolStripMenuItem.Click += new System.EventHandler(this.setPythonWExePathToolStripMenuItem_Click);
            // 
            // ScriptExplorerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 793);
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
    }
}

