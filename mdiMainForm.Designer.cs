namespace xEntry
{
    partial class mdiMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiMainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.jeconnectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntryNursery = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.dataExpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEssence = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.userMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.quittoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.connToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEntry = new System.Windows.Forms.ToolStripButton();
            this.mnuNursery = new System.Windows.Forms.ToolStripButton();
            this.mnuDataexpl = new System.Windows.Forms.ToolStripButton();
            this.mnuEsenc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuReports2 = new System.Windows.Forms.ToolStripSplitButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbinfoform = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.photoGpsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.formStripMenuItem,
            this.viewMenu,
            this.photoGpsToolStripMenuItem,
            this.toolsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(778, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeconnectMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileMenu.Size = new System.Drawing.Size(50, 20);
            this.fileMenu.Text = "&Fichier";
            // 
            // jeconnectMenuItem
            // 
            this.jeconnectMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jeconnectMenuItem.Image")));
            this.jeconnectMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.jeconnectMenuItem.Name = "jeconnectMenuItem";
            this.jeconnectMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.jeconnectMenuItem.Size = new System.Drawing.Size(166, 22);
            this.jeconnectMenuItem.Text = "Connection";
            this.jeconnectMenuItem.Click += new System.EventHandler(this.jeconnectMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // formStripMenuItem
            // 
            this.formStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDEntry,
            this.mnuEntryNursery,
            this.toolStripSeparator5,
            this.dataExpMenu,
            this.mnuEssence});
            this.formStripMenuItem.Name = "formStripMenuItem";
            this.formStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.formStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.formStripMenuItem.Text = "Fo&rms";
            // 
            // mnuDEntry
            // 
            this.mnuDEntry.Image = ((System.Drawing.Image)(resources.GetObject("mnuDEntry.Image")));
            this.mnuDEntry.Name = "mnuDEntry";
            this.mnuDEntry.Size = new System.Drawing.Size(195, 22);
            this.mnuDEntry.Text = "Entry TAR/PR";
            this.mnuDEntry.Click += new System.EventHandler(this.mnuDEntry_Click);
            // 
            // mnuEntryNursery
            // 
            this.mnuEntryNursery.Image = ((System.Drawing.Image)(resources.GetObject("mnuEntryNursery.Image")));
            this.mnuEntryNursery.Name = "mnuEntryNursery";
            this.mnuEntryNursery.Size = new System.Drawing.Size(195, 22);
            this.mnuEntryNursery.Text = "Entry Nursery";
            this.mnuEntryNursery.Click += new System.EventHandler(this.mnuEntryNursery_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(192, 6);
            // 
            // dataExpMenu
            // 
            this.dataExpMenu.Image = ((System.Drawing.Image)(resources.GetObject("dataExpMenu.Image")));
            this.dataExpMenu.Name = "dataExpMenu";
            this.dataExpMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.dataExpMenu.Size = new System.Drawing.Size(195, 22);
            this.dataExpMenu.Text = "Exploitation Data";
            this.dataExpMenu.Click += new System.EventHandler(this.dataExpMenu_Click);
            // 
            // mnuEssence
            // 
            this.mnuEssence.Image = ((System.Drawing.Image)(resources.GetObject("mnuEssence.Image")));
            this.mnuEssence.Name = "mnuEssence";
            this.mnuEssence.Size = new System.Drawing.Size(195, 22);
            this.mnuEssence.Text = "Essence";
            this.mnuEssence.Click += new System.EventHandler(this.mnuEssence_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem,
            this.toolStripSeparator6,
            this.toolStripMenuItem1});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.viewMenu.Size = new System.Drawing.Size(41, 20);
            this.viewMenu.Text = "&View";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toolBarToolStripMenuItem.Text = "&Toolbar";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "&Reports";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toolsMenu.Size = new System.Drawing.Size(44, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // userMenuItem
            // 
            this.userMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userMenuItem.Image")));
            this.userMenuItem.Name = "userMenuItem";
            this.userMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userMenuItem.Text = "&Users";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpMenu.Size = new System.Drawing.Size(40, 20);
            this.helpMenu.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(159, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quittoolStripButton,
            this.connToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.toolStripSeparator2,
            this.mnuEntry,
            this.mnuNursery,
            this.mnuDataexpl,
            this.mnuEsenc,
            this.toolStripSeparator4,
            this.mnuReports2});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(778, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // quittoolStripButton
            // 
            this.quittoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quittoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("quittoolStripButton.Image")));
            this.quittoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quittoolStripButton.Name = "quittoolStripButton";
            this.quittoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.quittoolStripButton.ToolTipText = "Quit";
            this.quittoolStripButton.Click += new System.EventHandler(this.quittoolStripButton_Click);
            // 
            // connToolStripButton
            // 
            this.connToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.connToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("connToolStripButton.Image")));
            this.connToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.connToolStripButton.Name = "connToolStripButton";
            this.connToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.connToolStripButton.ToolTipText = "Connect to the Database";
            this.connToolStripButton.Click += new System.EventHandler(this.connToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "Print";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuEntry
            // 
            this.mnuEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuEntry.Image = ((System.Drawing.Image)(resources.GetObject("mnuEntry.Image")));
            this.mnuEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuEntry.Name = "mnuEntry";
            this.mnuEntry.Size = new System.Drawing.Size(23, 22);
            this.mnuEntry.Text = "Saisie TAR/PR";
            this.mnuEntry.ToolTipText = "Data Entry";
            this.mnuEntry.Click += new System.EventHandler(this.mnuEntry_Click);
            // 
            // mnuNursery
            // 
            this.mnuNursery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuNursery.Image = ((System.Drawing.Image)(resources.GetObject("mnuNursery.Image")));
            this.mnuNursery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuNursery.Name = "mnuNursery";
            this.mnuNursery.Size = new System.Drawing.Size(23, 22);
            this.mnuNursery.Text = "Saisie des pepinieres";
            this.mnuNursery.Click += new System.EventHandler(this.btnNursery_Click);
            // 
            // mnuDataexpl
            // 
            this.mnuDataexpl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuDataexpl.Image = ((System.Drawing.Image)(resources.GetObject("mnuDataexpl.Image")));
            this.mnuDataexpl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuDataexpl.Name = "mnuDataexpl";
            this.mnuDataexpl.Size = new System.Drawing.Size(23, 22);
            this.mnuDataexpl.Text = "Nouvelle donnee d\'exploitation";
            this.mnuDataexpl.Click += new System.EventHandler(this.mnuDataexpl_Click);
            // 
            // mnuEsenc
            // 
            this.mnuEsenc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuEsenc.Image = ((System.Drawing.Image)(resources.GetObject("mnuEsenc.Image")));
            this.mnuEsenc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuEsenc.Name = "mnuEsenc";
            this.mnuEsenc.Size = new System.Drawing.Size(23, 22);
            this.mnuEsenc.Text = "Nouvelle essence";
            this.mnuEsenc.Click += new System.EventHandler(this.mnuEsenc_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuReports2
            // 
            this.mnuReports2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuReports2.Image = ((System.Drawing.Image)(resources.GetObject("mnuReports2.Image")));
            this.mnuReports2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuReports2.Name = "mnuReports2";
            this.mnuReports2.Size = new System.Drawing.Size(32, 22);
            this.mnuReports2.ToolTipText = "View reports";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.statLabel,
            this.stbinfoform});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(778, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // statLabel
            // 
            this.statLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(15, 17);
            this.statLabel.Text = "--";
            // 
            // stbinfoform
            // 
            this.stbinfoform.ForeColor = System.Drawing.Color.Red;
            this.stbinfoform.Name = "stbinfoform";
            this.stbinfoform.Size = new System.Drawing.Size(21, 17);
            this.stbinfoform.Text = "el1";
            this.stbinfoform.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // photoGpsToolStripMenuItem
            // 
            this.photoGpsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
            this.photoGpsToolStripMenuItem.Name = "photoGpsToolStripMenuItem";
            this.photoGpsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.photoGpsToolStripMenuItem.Text = "Photo&Gps";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageToolStripMenuItem.Image")));
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manageToolStripMenuItem.Text = "View & Manage";
            // 
            // mdiMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mdiMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xEntry : Gestion des donnees EcoMakala";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mdiMainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mdiMainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem jeconnectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem userMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton connToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formStripMenuItem;
        private System.Windows.Forms.ToolStripButton quittoolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel statLabel;
        private System.Windows.Forms.ToolStripSplitButton mnuReports2;
        private System.Windows.Forms.ToolStripStatusLabel stbinfoform;
        private System.Windows.Forms.ToolStripMenuItem mnuDEntry;
        private System.Windows.Forms.ToolStripButton mnuEntry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton mnuNursery;
        private System.Windows.Forms.ToolStripMenuItem mnuEntryNursery;
        private System.Windows.Forms.ToolStripMenuItem dataExpMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton mnuDataexpl;
        private System.Windows.Forms.ToolStripMenuItem mnuEssence;
        private System.Windows.Forms.ToolStripButton mnuEsenc;
        private System.Windows.Forms.ToolStripMenuItem photoGpsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
    }
}



