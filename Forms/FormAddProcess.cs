using System;
using System.Windows.Forms;
using CPUThrottler.Language;

namespace CPUThrottler.Forms
{
    public partial class FormAddProcess : Form
    {
        public string Result = null;
        public FormAddProcess()
        {
            InitializeComponent();
        }

        private void FormAddProcess_Load(object sender, EventArgs e)
        {
            TextProcess.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TextProcess.Text))
            {
                MessageBox.Show(this, Resources.EnterProcessName, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Result = TextProcess.Text;
                this.Close();
            }
        }

        private void TextProcess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BtnAdd.PerformClick();
            }
        }
    }
}
