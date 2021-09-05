namespace CPUThrottler.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuShowHide = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuBarFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarHide = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBarExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarAutoStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarCheckUpdatesOnStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarCloseToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarMinimizeToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarLanguage = new System.Windows.Forms.ToolStripComboBox();
            this.MenuBarHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarCheckUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBarAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelMenuBar = new System.Windows.Forms.Panel();
            this.GroupProcesses = new System.Windows.Forms.GroupBox();
            this.ProcessCheckedList = new System.Windows.Forms.ListView();
            this.ContextMenuProcessCheckedList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuAddProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuRemoveProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.GroupProcessFound = new System.Windows.Forms.GroupBox();
            this.LabelProcessFound = new System.Windows.Forms.Label();
            this.ComboBoxProcessFound = new System.Windows.Forms.ComboBox();
            this.LabelPowerPlanProcessFound = new System.Windows.Forms.Label();
            this.TrackBarProcessFound = new System.Windows.Forms.TrackBar();
            this.LabelMinimumCPUStateProcessFound = new System.Windows.Forms.Label();
            this.GroupNoProcessFound = new System.Windows.Forms.GroupBox();
            this.LabelNoProcessFound = new System.Windows.Forms.Label();
            this.ComboBoxNoProcessFound = new System.Windows.Forms.ComboBox();
            this.LabelPowerPlanNoProcessFound = new System.Windows.Forms.Label();
            this.TrackBarNoProcessFound = new System.Windows.Forms.TrackBar();
            this.LabelMinimumCPUStateNoProcessFound = new System.Windows.Forms.Label();
            this.GroupInterval = new System.Windows.Forms.GroupBox();
            this.LabelInterval = new System.Windows.Forms.Label();
            this.TrackBarInterval = new System.Windows.Forms.TrackBar();
            this.TimerCheck = new System.Windows.Forms.Timer(this.components);
            this.ContextMenuTrayIcon.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.GroupProcesses.SuspendLayout();
            this.ContextMenuProcessCheckedList.SuspendLayout();
            this.GroupProcessFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarProcessFound)).BeginInit();
            this.GroupNoProcessFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarNoProcessFound)).BeginInit();
            this.GroupInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.ContextMenuTrayIcon;
            resources.ApplyResources(this.TrayIcon, "TrayIcon");
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // ContextMenuTrayIcon
            // 
            this.ContextMenuTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuShowHide,
            this.ContextMenuSeparator1,
            this.ContextMenuExit});
            this.ContextMenuTrayIcon.Name = "ContextMenuTrayIcon";
            resources.ApplyResources(this.ContextMenuTrayIcon, "ContextMenuTrayIcon");
            // 
            // ContextMenuShowHide
            // 
            this.ContextMenuShowHide.Name = "ContextMenuShowHide";
            resources.ApplyResources(this.ContextMenuShowHide, "ContextMenuShowHide");
            this.ContextMenuShowHide.Click += new System.EventHandler(this.ContextMenuShowHide_Click);
            // 
            // ContextMenuSeparator1
            // 
            this.ContextMenuSeparator1.Name = "ContextMenuSeparator1";
            resources.ApplyResources(this.ContextMenuSeparator1, "ContextMenuSeparator1");
            // 
            // ContextMenuExit
            // 
            this.ContextMenuExit.Name = "ContextMenuExit";
            resources.ApplyResources(this.ContextMenuExit, "ContextMenuExit");
            this.ContextMenuExit.Click += new System.EventHandler(this.ContextMenuExit_Click);
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.White;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarFile,
            this.MenuBarSettings,
            this.MenuBarHelp});
            resources.ApplyResources(this.MenuBar, "MenuBar");
            this.MenuBar.Name = "MenuBar";
            // 
            // MenuBarFile
            // 
            this.MenuBarFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarHide,
            this.MenuBarSeparator1,
            this.MenuBarExit});
            this.MenuBarFile.Name = "MenuBarFile";
            resources.ApplyResources(this.MenuBarFile, "MenuBarFile");
            // 
            // MenuBarHide
            // 
            this.MenuBarHide.Name = "MenuBarHide";
            resources.ApplyResources(this.MenuBarHide, "MenuBarHide");
            this.MenuBarHide.Click += new System.EventHandler(this.MenuBarHide_Click);
            // 
            // MenuBarSeparator1
            // 
            this.MenuBarSeparator1.Name = "MenuBarSeparator1";
            resources.ApplyResources(this.MenuBarSeparator1, "MenuBarSeparator1");
            // 
            // MenuBarExit
            // 
            this.MenuBarExit.Name = "MenuBarExit";
            resources.ApplyResources(this.MenuBarExit, "MenuBarExit");
            this.MenuBarExit.Click += new System.EventHandler(this.MenuBarExit_Click);
            // 
            // MenuBarSettings
            // 
            this.MenuBarSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarAutoStart,
            this.MenuBarCheckUpdatesOnStart,
            this.MenuBarCloseToTray,
            this.MenuBarMinimizeToTray,
            this.MenuBarLanguage});
            this.MenuBarSettings.Name = "MenuBarSettings";
            resources.ApplyResources(this.MenuBarSettings, "MenuBarSettings");
            // 
            // MenuBarAutoStart
            // 
            this.MenuBarAutoStart.Checked = true;
            this.MenuBarAutoStart.CheckOnClick = true;
            this.MenuBarAutoStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuBarAutoStart.Name = "MenuBarAutoStart";
            resources.ApplyResources(this.MenuBarAutoStart, "MenuBarAutoStart");
            // 
            // MenuBarCheckUpdatesOnStart
            // 
            this.MenuBarCheckUpdatesOnStart.Checked = true;
            this.MenuBarCheckUpdatesOnStart.CheckOnClick = true;
            this.MenuBarCheckUpdatesOnStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuBarCheckUpdatesOnStart.Name = "MenuBarCheckUpdatesOnStart";
            resources.ApplyResources(this.MenuBarCheckUpdatesOnStart, "MenuBarCheckUpdatesOnStart");
            // 
            // MenuBarCloseToTray
            // 
            this.MenuBarCloseToTray.Checked = true;
            this.MenuBarCloseToTray.CheckOnClick = true;
            this.MenuBarCloseToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuBarCloseToTray.Name = "MenuBarCloseToTray";
            resources.ApplyResources(this.MenuBarCloseToTray, "MenuBarCloseToTray");
            // 
            // MenuBarMinimizeToTray
            // 
            this.MenuBarMinimizeToTray.Checked = true;
            this.MenuBarMinimizeToTray.CheckOnClick = true;
            this.MenuBarMinimizeToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuBarMinimizeToTray.Name = "MenuBarMinimizeToTray";
            resources.ApplyResources(this.MenuBarMinimizeToTray, "MenuBarMinimizeToTray");
            // 
            // MenuBarLanguage
            // 
            this.MenuBarLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MenuBarLanguage.Items.AddRange(new object[] {
            resources.GetString("MenuBarLanguage.Items"),
            resources.GetString("MenuBarLanguage.Items1")});
            this.MenuBarLanguage.Name = "MenuBarLanguage";
            resources.ApplyResources(this.MenuBarLanguage, "MenuBarLanguage");
            this.MenuBarLanguage.SelectedIndexChanged += new System.EventHandler(this.MenuBarLanguage_SelectedIndexChanged);
            // 
            // MenuBarHelp
            // 
            this.MenuBarHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarCheckUpdates,
            this.MenuBarSeparator2,
            this.MenuBarAbout});
            this.MenuBarHelp.Name = "MenuBarHelp";
            resources.ApplyResources(this.MenuBarHelp, "MenuBarHelp");
            // 
            // MenuBarCheckUpdates
            // 
            this.MenuBarCheckUpdates.Name = "MenuBarCheckUpdates";
            resources.ApplyResources(this.MenuBarCheckUpdates, "MenuBarCheckUpdates");
            this.MenuBarCheckUpdates.Click += new System.EventHandler(this.MenuBarCheckUpdates_Click);
            // 
            // MenuBarSeparator2
            // 
            this.MenuBarSeparator2.Name = "MenuBarSeparator2";
            resources.ApplyResources(this.MenuBarSeparator2, "MenuBarSeparator2");
            // 
            // MenuBarAbout
            // 
            this.MenuBarAbout.Name = "MenuBarAbout";
            resources.ApplyResources(this.MenuBarAbout, "MenuBarAbout");
            this.MenuBarAbout.Click += new System.EventHandler(this.MenuBarAbout_Click);
            // 
            // PanelMenuBar
            // 
            this.PanelMenuBar.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.PanelMenuBar, "PanelMenuBar");
            this.PanelMenuBar.Name = "PanelMenuBar";
            // 
            // GroupProcesses
            // 
            resources.ApplyResources(this.GroupProcesses, "GroupProcesses");
            this.GroupProcesses.Controls.Add(this.ProcessCheckedList);
            this.GroupProcesses.Controls.Add(this.BtnRemove);
            this.GroupProcesses.Controls.Add(this.BtnAdd);
            this.GroupProcesses.Name = "GroupProcesses";
            this.GroupProcesses.TabStop = false;
            // 
            // ProcessCheckedList
            // 
            this.ProcessCheckedList.CheckBoxes = true;
            this.ProcessCheckedList.ContextMenuStrip = this.ContextMenuProcessCheckedList;
            this.ProcessCheckedList.FullRowSelect = true;
            this.ProcessCheckedList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ProcessCheckedList.HideSelection = false;
            resources.ApplyResources(this.ProcessCheckedList, "ProcessCheckedList");
            this.ProcessCheckedList.Name = "ProcessCheckedList";
            this.ProcessCheckedList.UseCompatibleStateImageBehavior = false;
            this.ProcessCheckedList.View = System.Windows.Forms.View.List;
            this.ProcessCheckedList.SelectedIndexChanged += new System.EventHandler(this.ProcessCheckedList_SelectedIndexChanged);
            // 
            // ContextMenuProcessCheckedList
            // 
            this.ContextMenuProcessCheckedList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuAddProcess,
            this.ContextMenuRemoveProcess});
            this.ContextMenuProcessCheckedList.Name = "ContextMenuProcessCheckedList";
            resources.ApplyResources(this.ContextMenuProcessCheckedList, "ContextMenuProcessCheckedList");
            // 
            // ContextMenuAddProcess
            // 
            this.ContextMenuAddProcess.Name = "ContextMenuAddProcess";
            resources.ApplyResources(this.ContextMenuAddProcess, "ContextMenuAddProcess");
            this.ContextMenuAddProcess.Click += new System.EventHandler(this.ContextMenuAddProcess_Click);
            // 
            // ContextMenuRemoveProcess
            // 
            resources.ApplyResources(this.ContextMenuRemoveProcess, "ContextMenuRemoveProcess");
            this.ContextMenuRemoveProcess.Name = "ContextMenuRemoveProcess";
            this.ContextMenuRemoveProcess.Click += new System.EventHandler(this.ContextMenuRemoveProcess_Click);
            // 
            // BtnRemove
            // 
            resources.ApplyResources(this.BtnRemove, "BtnRemove");
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            resources.ApplyResources(this.BtnAdd, "BtnAdd");
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // GroupProcessFound
            // 
            resources.ApplyResources(this.GroupProcessFound, "GroupProcessFound");
            this.GroupProcessFound.Controls.Add(this.LabelProcessFound);
            this.GroupProcessFound.Controls.Add(this.ComboBoxProcessFound);
            this.GroupProcessFound.Controls.Add(this.LabelPowerPlanProcessFound);
            this.GroupProcessFound.Controls.Add(this.TrackBarProcessFound);
            this.GroupProcessFound.Controls.Add(this.LabelMinimumCPUStateProcessFound);
            this.GroupProcessFound.Name = "GroupProcessFound";
            this.GroupProcessFound.TabStop = false;
            // 
            // LabelProcessFound
            // 
            resources.ApplyResources(this.LabelProcessFound, "LabelProcessFound");
            this.LabelProcessFound.Name = "LabelProcessFound";
            // 
            // ComboBoxProcessFound
            // 
            this.ComboBoxProcessFound.DisplayMember = "1";
            this.ComboBoxProcessFound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProcessFound.FormattingEnabled = true;
            this.ComboBoxProcessFound.Items.AddRange(new object[] {
            resources.GetString("ComboBoxProcessFound.Items"),
            resources.GetString("ComboBoxProcessFound.Items1"),
            resources.GetString("ComboBoxProcessFound.Items2")});
            resources.ApplyResources(this.ComboBoxProcessFound, "ComboBoxProcessFound");
            this.ComboBoxProcessFound.Name = "ComboBoxProcessFound";
            this.ComboBoxProcessFound.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProcessFound_SelectedIndexChanged);
            // 
            // LabelPowerPlanProcessFound
            // 
            resources.ApplyResources(this.LabelPowerPlanProcessFound, "LabelPowerPlanProcessFound");
            this.LabelPowerPlanProcessFound.Name = "LabelPowerPlanProcessFound";
            // 
            // TrackBarProcessFound
            // 
            resources.ApplyResources(this.TrackBarProcessFound, "TrackBarProcessFound");
            this.TrackBarProcessFound.Maximum = 100;
            this.TrackBarProcessFound.Name = "TrackBarProcessFound";
            this.TrackBarProcessFound.Value = 100;
            this.TrackBarProcessFound.ValueChanged += new System.EventHandler(this.TrackBarProcessFound_ValueChanged);
            // 
            // LabelMinimumCPUStateProcessFound
            // 
            resources.ApplyResources(this.LabelMinimumCPUStateProcessFound, "LabelMinimumCPUStateProcessFound");
            this.LabelMinimumCPUStateProcessFound.Name = "LabelMinimumCPUStateProcessFound";
            // 
            // GroupNoProcessFound
            // 
            resources.ApplyResources(this.GroupNoProcessFound, "GroupNoProcessFound");
            this.GroupNoProcessFound.Controls.Add(this.LabelNoProcessFound);
            this.GroupNoProcessFound.Controls.Add(this.ComboBoxNoProcessFound);
            this.GroupNoProcessFound.Controls.Add(this.LabelPowerPlanNoProcessFound);
            this.GroupNoProcessFound.Controls.Add(this.TrackBarNoProcessFound);
            this.GroupNoProcessFound.Controls.Add(this.LabelMinimumCPUStateNoProcessFound);
            this.GroupNoProcessFound.Name = "GroupNoProcessFound";
            this.GroupNoProcessFound.TabStop = false;
            // 
            // LabelNoProcessFound
            // 
            resources.ApplyResources(this.LabelNoProcessFound, "LabelNoProcessFound");
            this.LabelNoProcessFound.Name = "LabelNoProcessFound";
            // 
            // ComboBoxNoProcessFound
            // 
            this.ComboBoxNoProcessFound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxNoProcessFound.FormattingEnabled = true;
            this.ComboBoxNoProcessFound.Items.AddRange(new object[] {
            resources.GetString("ComboBoxNoProcessFound.Items"),
            resources.GetString("ComboBoxNoProcessFound.Items1"),
            resources.GetString("ComboBoxNoProcessFound.Items2")});
            resources.ApplyResources(this.ComboBoxNoProcessFound, "ComboBoxNoProcessFound");
            this.ComboBoxNoProcessFound.Name = "ComboBoxNoProcessFound";
            this.ComboBoxNoProcessFound.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNoProcessFound_SelectedIndexChanged);
            // 
            // LabelPowerPlanNoProcessFound
            // 
            resources.ApplyResources(this.LabelPowerPlanNoProcessFound, "LabelPowerPlanNoProcessFound");
            this.LabelPowerPlanNoProcessFound.Name = "LabelPowerPlanNoProcessFound";
            // 
            // TrackBarNoProcessFound
            // 
            resources.ApplyResources(this.TrackBarNoProcessFound, "TrackBarNoProcessFound");
            this.TrackBarNoProcessFound.Maximum = 100;
            this.TrackBarNoProcessFound.Name = "TrackBarNoProcessFound";
            this.TrackBarNoProcessFound.Value = 50;
            this.TrackBarNoProcessFound.ValueChanged += new System.EventHandler(this.TrackBarNoProcessFound_ValueChanged);
            // 
            // LabelMinimumCPUStateNoProcessFound
            // 
            resources.ApplyResources(this.LabelMinimumCPUStateNoProcessFound, "LabelMinimumCPUStateNoProcessFound");
            this.LabelMinimumCPUStateNoProcessFound.Name = "LabelMinimumCPUStateNoProcessFound";
            // 
            // GroupInterval
            // 
            resources.ApplyResources(this.GroupInterval, "GroupInterval");
            this.GroupInterval.Controls.Add(this.LabelInterval);
            this.GroupInterval.Controls.Add(this.TrackBarInterval);
            this.GroupInterval.Name = "GroupInterval";
            this.GroupInterval.TabStop = false;
            // 
            // LabelInterval
            // 
            resources.ApplyResources(this.LabelInterval, "LabelInterval");
            this.LabelInterval.Name = "LabelInterval";
            // 
            // TrackBarInterval
            // 
            resources.ApplyResources(this.TrackBarInterval, "TrackBarInterval");
            this.TrackBarInterval.Maximum = 60;
            this.TrackBarInterval.Minimum = 5;
            this.TrackBarInterval.Name = "TrackBarInterval";
            this.TrackBarInterval.Value = 10;
            this.TrackBarInterval.ValueChanged += new System.EventHandler(this.TrackBarInterval_ValueChanged);
            // 
            // TimerCheck
            // 
            this.TimerCheck.Enabled = true;
            this.TimerCheck.Interval = 10000;
            this.TimerCheck.Tick += new System.EventHandler(this.TimerCheck_Tick);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupInterval);
            this.Controls.Add(this.GroupNoProcessFound);
            this.Controls.Add(this.GroupProcessFound);
            this.Controls.Add(this.GroupProcesses);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.PanelMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.MenuBar;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.LocationChanged += new System.EventHandler(this.FormMain_LocationChanged);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.ContextMenuTrayIcon.ResumeLayout(false);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.GroupProcesses.ResumeLayout(false);
            this.ContextMenuProcessCheckedList.ResumeLayout(false);
            this.GroupProcessFound.ResumeLayout(false);
            this.GroupProcessFound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarProcessFound)).EndInit();
            this.GroupNoProcessFound.ResumeLayout(false);
            this.GroupNoProcessFound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarNoProcessFound)).EndInit();
            this.GroupInterval.ResumeLayout(false);
            this.GroupInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.Panel PanelMenuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuBarFile;
        private System.Windows.Forms.ToolStripMenuItem MenuBarSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuBarHelp;
        private System.Windows.Forms.GroupBox GroupProcesses;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox GroupProcessFound;
        private System.Windows.Forms.Label LabelProcessFound;
        private System.Windows.Forms.ComboBox ComboBoxProcessFound;
        private System.Windows.Forms.Label LabelPowerPlanProcessFound;
        private System.Windows.Forms.TrackBar TrackBarProcessFound;
        private System.Windows.Forms.Label LabelMinimumCPUStateProcessFound;
        private System.Windows.Forms.GroupBox GroupNoProcessFound;
        private System.Windows.Forms.Label LabelNoProcessFound;
        private System.Windows.Forms.ComboBox ComboBoxNoProcessFound;
        private System.Windows.Forms.Label LabelPowerPlanNoProcessFound;
        private System.Windows.Forms.TrackBar TrackBarNoProcessFound;
        private System.Windows.Forms.Label LabelMinimumCPUStateNoProcessFound;
        private System.Windows.Forms.GroupBox GroupInterval;
        private System.Windows.Forms.Label LabelInterval;
        private System.Windows.Forms.TrackBar TrackBarInterval;
        private System.Windows.Forms.ToolStripMenuItem MenuBarHide;
        private System.Windows.Forms.ToolStripSeparator MenuBarSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuBarExit;
        private System.Windows.Forms.ToolStripMenuItem MenuBarAutoStart;
        private System.Windows.Forms.ToolStripMenuItem MenuBarCheckUpdatesOnStart;
        private System.Windows.Forms.ToolStripMenuItem MenuBarCheckUpdates;
        private System.Windows.Forms.ToolStripSeparator MenuBarSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuBarAbout;
        private System.Windows.Forms.ContextMenuStrip ContextMenuTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuShowHide;
        private System.Windows.Forms.ToolStripSeparator ContextMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuBarCloseToTray;
        private System.Windows.Forms.ToolStripMenuItem MenuBarMinimizeToTray;
        private System.Windows.Forms.ToolStripComboBox MenuBarLanguage;
        private System.Windows.Forms.Timer TimerCheck;
        private System.Windows.Forms.ListView ProcessCheckedList;
        private System.Windows.Forms.ContextMenuStrip ContextMenuProcessCheckedList;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuAddProcess;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuRemoveProcess;
    }
}

