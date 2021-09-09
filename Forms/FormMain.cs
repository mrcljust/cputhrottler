using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using CPUThrottler.Language;

namespace CPUThrottler.Forms
{
    public partial class FormMain : Form
    {
        private bool _escalateClose = false;
        private bool _languageChangeable = false;
        private bool _performNewEnergyChange = true;
        private string _lastEnergyChange = "";
        public string Language = "en-US"; //set default language
        private bool _doNotSafeLanguage = false;
        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(string startarg)
        {
            InitializeComponent();
            if (startarg.Equals("minimized"))
            {
                HideForm();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if(MenuBarCheckUpdatesOnStart.Checked)
            {
                CheckForUpdates();
            }
            CheckForProcesses();
            //ReadConfig();
        }

        private void CheckForProcesses()
        {
            if(ProcessCheckedList.Items.Count>0)
            {
                var processList = Process.GetProcesses();
                var processNameList = new string[processList.Length];
                var processArrayId = 0;
                foreach(var p in processList)
                {
                    processNameList[processArrayId] = p.ProcessName;
                    processArrayId++;
                }
                bool processFound = false;
                foreach (ListViewItem lvi in ProcessCheckedList.Items)
                {
                    if (!lvi.Checked) continue;
                    if (lvi.Text.Contains(".exe"))
                    {
                        if (processNameList.Contains(lvi.Text) || processNameList.Contains(lvi.Text.Replace(".exe", "")))
                        {
                            processFound = true;
                        }
                    }
                    else
                    {
                        if (processNameList.Contains(lvi.Text) || processNameList.Contains(lvi.Text + ".exe"))
                        {
                            processFound = true;
                        }
                    }
                }
                if (processFound && (_performNewEnergyChange || _lastEnergyChange != "Process found"))
                {
                    EnergyChange(true);
                }

                if (!processFound && (_performNewEnergyChange || _lastEnergyChange != "No process found"))
                {
                    EnergyChange(false);
                }
            }
            else if(_performNewEnergyChange || _lastEnergyChange != "No process found")
            {
                EnergyChange(false);
            }
        }
        private static Guid GetCurrentScheme()
        {
            //returns guid of active power scheme
            var zero = IntPtr.Zero;
            var activeScheme = (int)WinAPI.PowerGetActiveScheme(IntPtr.Zero, ref zero);
            return (Guid)System.Runtime.InteropServices.Marshal.PtrToStructure(zero, typeof(Guid));
        }

        private void EnergyChange(bool processFound)
        {
            //guids
            var cpuMinGuid = new Guid("893dee8e-2bef-41e0-89c6-b55d0929964c");
            var cpuMaxGuid = new Guid("75b0ae3f-bce0-45a7-8c89-c9611c25e100");
            var processorPowerSettingGuid = new Guid("54533251-82be-4824-96c1-47b60b740d00");
            var schemeGuid = GetCurrentScheme();


            try
            {
                _performNewEnergyChange = false;

                if (processFound)
                {
                    //process found
                    _lastEnergyChange = "Process found";

                    switch (ComboBoxProcessFound.SelectedIndex)
                    {
                        case 0:
                            //Balanced
                            schemeGuid = new Guid("381b4222-f694-41f0-9685-ff5bb260df2e");
                            break;
                        case 1:
                            //Energy saving
                            schemeGuid = new Guid("a1841308-3541-4fab-bc81-f71556f20b4a");
                            break;
                        case 2:
                            //High performance
                            schemeGuid = new Guid("8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
                            break;
                    }

                    WinAPI.PowerWriteACValueIndex(IntPtr.Zero, ref schemeGuid, ref processorPowerSettingGuid, ref cpuMinGuid, uint.Parse(this.TrackBarProcessFound.Value.ToString()));
                }
                else
                {
                    //no process found
                    _lastEnergyChange = "No process found";

                    switch (ComboBoxNoProcessFound.SelectedIndex)
                    {
                        case 0:
                            //Balanced
                            schemeGuid = new Guid("381b4222-f694-41f0-9685-ff5bb260df2e");
                            break;
                        case 1:
                            //Energy saving
                            schemeGuid = new Guid("a1841308-3541-4fab-bc81-f71556f20b4a");
                            break;
                        case 2:
                            //High performance
                            schemeGuid = new Guid("8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
                            break;
                    }

                    WinAPI.PowerWriteACValueIndex(IntPtr.Zero, ref schemeGuid, ref processorPowerSettingGuid, ref cpuMinGuid, uint.Parse(this.TrackBarNoProcessFound.Value.ToString()));
                }

                WinAPI.PowerWriteACValueIndex(IntPtr.Zero, ref schemeGuid, ref processorPowerSettingGuid, ref cpuMaxGuid, 0U);
                WinAPI.PowerSetActiveScheme(IntPtr.Zero, ref schemeGuid);
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private static void SetAutoStart(bool boolTemp)
        {
            Microsoft.Win32.RegistryKey key;
            if(boolTemp)
            {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                var applicationPath = "\"" + Application.ExecutablePath.ToString() + "\" -minimized";
                key.SetValue("CPUThrottler", applicationPath);
                key.Close();
            }
            else
            {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                if (key == null) return;
                key.DeleteValue("CPUThrottler", false);
                key.Close();
            }
        }

        private void ShowForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            ContextMenuShowHide.Text = Resources.ContextMenu_ShowHide_TextMinimize;
        }

        private void HideForm()
        {
            //SaveConfig(true);
            this.Hide();
            ContextMenuShowHide.Text = Resources.Show;
        }

        private void SaveConfig(bool full)
        {
            var key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Just IT Solutions\CPUThrottler\Config");
            key.SetValue("AutoStart", MenuBarAutoStart.Checked);
            key.SetValue("CheckForUpdatesOnStart", MenuBarCheckUpdatesOnStart.Checked);
            key.SetValue("CloseToTray", MenuBarCloseToTray.Checked);
            key.SetValue("MinimizeToTray", MenuBarMinimizeToTray.Checked);
            if(!_doNotSafeLanguage)
            {
                key.SetValue("Language", Language);
            }


            /*if (full)
            {
                bool desktopX = false;
                bool desktopY = false;
                foreach (var screen in Screen.AllScreens)
                {
                    // For each screen, add the screen properties to a list box.
                    if (this.DesktopLocation.X <= screen.Bounds.X + screen.Bounds.Width)
                    {
                        desktopX = true;
                    }
                    if (this.DesktopLocation.Y <= screen.Bounds.Y + screen.Bounds.Height)
                    {
                        desktopY = true;
                    }
                }

                if (desktopX)
                {
                    key.SetValue("LastPosX", this.DesktopLocation.X, Microsoft.Win32.RegistryValueKind.String);
                }

                if (desktopY)
                {
                    key.SetValue("LastPosY", this.DesktopLocation.Y, Microsoft.Win32.RegistryValueKind.String);
                }
            }*/
            key.Close();


            SetAutoStart(MenuBarAutoStart.Checked);

            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Just IT Solutions\CPUThrottler\Profiles\1");
            key.SetValue("ProcessFoundMinCPU", TrackBarProcessFound.Value, Microsoft.Win32.RegistryValueKind.String);
            key.SetValue("ProcessFoundStateIndex", ComboBoxProcessFound.SelectedIndex, Microsoft.Win32.RegistryValueKind.String);
            key.SetValue("NoProcessFoundMinCPU", TrackBarNoProcessFound.Value, Microsoft.Win32.RegistryValueKind.String);
            key.SetValue("NoProcessFoundStateIndex", ComboBoxNoProcessFound.SelectedIndex, Microsoft.Win32.RegistryValueKind.String);
            key.SetValue("ScanInterval", TrackBarInterval.Value, Microsoft.Win32.RegistryValueKind.String);
            key.Close();

            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Just IT Solutions\CPUThrottler\Profiles\1\Processes");
            for(var processId=0; processId < ProcessCheckedList.Items.Count; processId++)
            {
                key.SetValue(ProcessCheckedList.Items[processId].Text, ProcessCheckedList.Items[processId].Checked);
            }
            key.Close();
        }

        private void ReadConfig()
        {
            var key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Just IT Solutions\CPUThrottler\Config");
            string menu = key.GetValue("AutoStart").ToString();
            MenuBarAutoStart.Checked = Convert.ToBoolean(key.GetValue("AutoStart", "True"));
            MenuBarCheckUpdatesOnStart.Checked = Convert.ToBoolean(key.GetValue("CheckForUpdatesOnStart", "True"));
            MenuBarCloseToTray.Checked = Convert.ToBoolean(key.GetValue("CloseToTray", "True"));
            MenuBarMinimizeToTray.Checked = Convert.ToBoolean(key.GetValue("MinimizeToTray", "True"));
            //Language already set in Program.cs
            switch(Language)
            {
                case "en-US":
                    MenuBarLanguage.SelectedIndex = 0;
                    break;
                case "de-DE":
                    MenuBarLanguage.SelectedIndex = 1;
                    break;
            }
            _languageChangeable = true;


            bool desktopX = false;
            bool desktopY = false;
            /*foreach (var screen in Screen.AllScreens)
            {
                // For each screen, add the screen properties to a list box.
                if (key.GetValue("LastPosX") != null && Convert.ToInt32(key.GetValue("LastPosX")) <= screen.Bounds.X + screen.Bounds.Width)
                {
                    desktopX = true;
                }
                if (key.GetValue("LastPosY") != null && Convert.ToInt32(key.GetValue("LastPosY")) <= screen.Bounds.Y + screen.Bounds.Height)
                {
                    desktopY = true;
                }
            }
            if (desktopX && desktopY)
            {
            this.DesktopLocation = new Point(Convert.ToInt32(key.GetValue("LastPosX")), Convert.ToInt32(key.GetValue("LastPosY")));
        }*/
            key.Close();

            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Just IT Solutions\CPUThrottler\Profiles\1");
            TrackBarProcessFound.Value = Convert.ToInt32(key.GetValue("ProcessFoundMinCPU", "100"));
            ComboBoxProcessFound.SelectedIndex = Convert.ToInt32(key.GetValue("ProcessFoundStateIndex", 2));
            TrackBarNoProcessFound.Value = Convert.ToInt32(key.GetValue("NoProcessFoundMinCPU", "50"));
            ComboBoxNoProcessFound.SelectedIndex = Convert.ToInt32(key.GetValue("NoProcessFoundStateIndex", 0));
            TrackBarInterval.Value = Convert.ToInt32(key.GetValue("ScanInterval", 10));
            key.Close();

            if (Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
                @"SOFTWARE\Just IT Solutions\CPUThrottler\Profiles\1\Processes", false) == null) return;
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Just IT Solutions\CPUThrottler\Profiles\1\Processes");
            if(key?.ValueCount>0)
            {
                var processNamesRegistry = key.GetValueNames();
                foreach(var processNameTemp in processNamesRegistry)
                {
                    var itemTemp = new ListViewItem(processNameTemp)
                    {
                        Checked = Convert.ToBoolean(key.GetValue(processNameTemp, "True"))
                    };
                    ProcessCheckedList.Items.Add(itemTemp);
                }
            }
            key?.Close();
        }

        private void CheckForUpdates()
        {

        }

        private void MenuBarExit_Click(object sender, EventArgs e)
        {
            _escalateClose = true;
            this.Close();
        }

        private void ContextMenuExit_Click(object sender, EventArgs e)
        {
            _escalateClose = true;
            this.Close();
        }

        private void ContextMenuShowHide_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                HideForm();
            }
            else
            {
                ShowForm();
            }
        }

        private void MenuBarHide_Click(object sender, EventArgs e)
        {
            HideForm();
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
            {
                if(this.WindowState == FormWindowState.Minimized)
                {
                    ShowForm();
                }
                else
                {
                    HideForm();
                }
            }
            else
            {
                ShowForm();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MenuBarCloseToTray.Checked && !_escalateClose && e.CloseReason == CloseReason.UserClosing)
            {
                if (!this.ContainsFocus) return;
                e.Cancel = true;
                var fi = typeof(Form).GetField("closeReason", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(this, CloseReason.None);
                HideForm();
                TrayIcon.ShowBalloonTip(5, this.Text, Resources.MinimizedToTray, ToolTipIcon.Info);
            }
            else
            {
                SaveConfig(true);
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized || !MenuBarMinimizeToTray.Checked) return;
            HideForm();
            TrayIcon.ShowBalloonTip(5, this.Text, Resources.MinimizedToTray, ToolTipIcon.Info);
        }

        private void MenuBarAbout_Click(object sender, EventArgs e)
        {
            var formAboutNew = new FormAbout();
            formAboutNew.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var newFormAddProcess = new FormAddProcess();
            newFormAddProcess.ShowDialog();
            if (newFormAddProcess.Result == null) return;
            var itemTemp = new ListViewItem(newFormAddProcess.Result) {Checked = true};
            ProcessCheckedList.Items.Add(itemTemp);
            SaveConfig(true);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, Resources.RemoveProcessesQuestion, this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            foreach(ListViewItem lvi in ProcessCheckedList.SelectedItems)
            {
                lvi.Remove();
            }
            SaveConfig(true);
        }

        private void MenuBarCheckUpdates_Click(object sender, EventArgs e)
        {
            CheckForUpdates();
        }

        private void TrackBarInterval_ValueChanged(object sender, EventArgs e)
        {
            LabelInterval.Text = TrackBarInterval.Value.ToString() + Resources.SecondChar;
            TimerCheck.Interval = TrackBarInterval.Value * 1000;
            _performNewEnergyChange = true;
        }

        private void TimerCheck_Tick(object sender, EventArgs e)
        {
            CheckForProcesses();
        }

        private void TrackBarNoProcessFound_ValueChanged(object sender, EventArgs e)
        {
            LabelNoProcessFound.Text = TrackBarNoProcessFound.Value.ToString() + Resources.PercentChar;
            _performNewEnergyChange = true;
        }

        private void TrackBarProcessFound_Scroll(object sender, EventArgs e)
        {
            LabelProcessFound.Text = TrackBarProcessFound.Value.ToString() + Resources.PercentChar;
        }

        private void MenuBarLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_languageChangeable) return;
            switch (MenuBarLanguage.SelectedIndex)
            {
                case 0:
                    Language = "en-US";
                    break;
                case 1:
                    Language = "de-DE";
                    break;
            }
            SaveConfig(false);
            Process.Start(Application.ExecutablePath);
            _doNotSafeLanguage = true;
            _escalateClose = true;
            Environment.Exit(0);
        }

        private void TrackBarProcessFound_ValueChanged(object sender, EventArgs e)
        {
            LabelProcessFound.Text = TrackBarProcessFound.Value.ToString() + Resources.PercentChar;
            _performNewEnergyChange = true;
        }

        private void ProcessCheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProcessCheckedList.SelectedItems.Count > 0)
            {
                ContextMenuRemoveProcess.Enabled = true;
                BtnRemove.Enabled = true;
            }
            else
            {
                ContextMenuRemoveProcess.Enabled = false;
                BtnRemove.Enabled = false;
            }
        }

        private void ContextMenuAddProcess_Click(object sender, EventArgs e)
        {
            BtnAdd.PerformClick();
        }

        private void ContextMenuRemoveProcess_Click(object sender, EventArgs e)
        {
            BtnRemove.PerformClick();
        }

        private void ComboBoxProcessFound_SelectedIndexChanged(object sender, EventArgs e)
        {
            _performNewEnergyChange = true;
        }

        private void ComboBoxNoProcessFound_SelectedIndexChanged(object sender, EventArgs e)
        {
            _performNewEnergyChange = true;
        }

        private void FormMain_LocationChanged(object sender, EventArgs e)
        {
            //SaveConfig(true);
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            ReadConfig();
        }
    }
}
