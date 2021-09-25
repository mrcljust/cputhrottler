using CPUThrottler.Language;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CPUThrottler.Forms
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            var cpuType = "x86";
            if (IntPtr.Size == 8)
                cpuType = "x64";

            LabelVersionAndCPU.Text =
                Resources.Version + Application.ProductVersion + Resources.AboutSplitter + cpuType;
        }

        private void LabelCopyrightLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://just-it-solutions.de");
        }
    }
}