namespace Photon.Forms
{
    partial class SplashForm
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
            this.HeaderParent = new System.Windows.Forms.Panel();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.Label();
            this.HeaderParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderParent
            // 
            this.HeaderParent.Controls.Add(this.LogoBox);
            this.HeaderParent.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderParent.Location = new System.Drawing.Point(0, 0);
            this.HeaderParent.Name = "HeaderParent";
            this.HeaderParent.Padding = new System.Windows.Forms.Padding(8, 54, 8, 54);
            this.HeaderParent.Size = new System.Drawing.Size(160, 256);
            this.HeaderParent.TabIndex = 1;
            // 
            // LogoBox
            // 
            this.LogoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoBox.Image = global::Photon.Properties.Resources.Logo_White;
            this.LogoBox.Location = new System.Drawing.Point(8, 54);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(144, 148);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BottomPanel);
            this.MainPanel.Controls.Add(this.AppName);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(160, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(16);
            this.MainPanel.Size = new System.Drawing.Size(320, 256);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.LoadingLabel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(16, 221);
            this.BottomPanel.MaximumSize = new System.Drawing.Size(0, 19);
            this.BottomPanel.MinimumSize = new System.Drawing.Size(0, 19);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.BottomPanel.Size = new System.Drawing.Size(288, 19);
            this.BottomPanel.TabIndex = 2;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoadingLabel.Font = new System.Drawing.Font("Arial Black", 10F);
            this.LoadingLabel.Location = new System.Drawing.Point(174, 0);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(98, 19);
            this.LoadingLabel.TabIndex = 1;
            this.LoadingLabel.Text = "Loading . . .";
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppName.Font = new System.Drawing.Font("Arial Black", 24F);
            this.AppName.Location = new System.Drawing.Point(16, 16);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(174, 45);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "PHOTON";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 256);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.HeaderParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.HeaderParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HeaderParent;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.Panel BottomPanel;
    }
}