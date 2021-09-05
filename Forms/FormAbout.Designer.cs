namespace CPUThrottler.Forms
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelVersionAndCPU = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.LabelCopyrightLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureLogo
            // 
            resources.ApplyResources(this.PictureLogo, "PictureLogo");
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.TabStop = false;
            // 
            // LabelTitle
            // 
            resources.ApplyResources(this.LabelTitle, "LabelTitle");
            this.LabelTitle.Name = "LabelTitle";
            // 
            // LabelVersionAndCPU
            // 
            resources.ApplyResources(this.LabelVersionAndCPU, "LabelVersionAndCPU");
            this.LabelVersionAndCPU.Name = "LabelVersionAndCPU";
            // 
            // LabelCopyright
            // 
            resources.ApplyResources(this.LabelCopyright, "LabelCopyright");
            this.LabelCopyright.Name = "LabelCopyright";
            // 
            // LabelCopyrightLink
            // 
            resources.ApplyResources(this.LabelCopyrightLink, "LabelCopyrightLink");
            this.LabelCopyrightLink.Name = "LabelCopyrightLink";
            this.LabelCopyrightLink.TabStop = true;
            this.LabelCopyrightLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelCopyrightLink_LinkClicked);
            // 
            // FormAbout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelCopyrightLink);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.LabelVersionAndCPU);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.PictureLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelVersionAndCPU;
        private System.Windows.Forms.Label LabelCopyright;
        private System.Windows.Forms.LinkLabel LabelCopyrightLink;
    }
}