namespace Photon.Forms
{
    partial class MainForm
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
            this.MenuBar = new System.Windows.Forms.Panel();
            this.PageNameBackground = new System.Windows.Forms.Panel();
            this.PageName = new System.Windows.Forms.Label();
            this.MenuBarSeparator = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BugReportBtn = new Photon.GUI.PhotonTrayButton();
            this.MenuBar.SuspendLayout();
            this.PageNameBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Controls.Add(this.BugReportBtn);
            this.MenuBar.Controls.Add(this.PageNameBackground);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.MenuBar.Size = new System.Drawing.Size(640, 27);
            this.MenuBar.TabIndex = 1;
            // 
            // PageNameBackground
            // 
            this.PageNameBackground.AutoSize = true;
            this.PageNameBackground.Controls.Add(this.PageName);
            this.PageNameBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this.PageNameBackground.Location = new System.Drawing.Point(16, 0);
            this.PageNameBackground.Name = "PageNameBackground";
            this.PageNameBackground.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PageNameBackground.Size = new System.Drawing.Size(119, 27);
            this.PageNameBackground.TabIndex = 0;
            // 
            // PageName
            // 
            this.PageName.AutoSize = true;
            this.PageName.BackColor = System.Drawing.Color.Transparent;
            this.PageName.Dock = System.Windows.Forms.DockStyle.Left;
            this.PageName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageName.Location = new System.Drawing.Point(8, 0);
            this.PageName.Name = "PageName";
            this.PageName.Size = new System.Drawing.Size(103, 27);
            this.PageName.TabIndex = 1;
            this.PageName.Text = "Page title";
            this.PageName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuBarSeparator
            // 
            this.MenuBarSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBarSeparator.Location = new System.Drawing.Point(0, 27);
            this.MenuBarSeparator.MaximumSize = new System.Drawing.Size(0, 2);
            this.MenuBarSeparator.MinimumSize = new System.Drawing.Size(0, 2);
            this.MenuBarSeparator.Name = "MenuBarSeparator";
            this.MenuBarSeparator.Size = new System.Drawing.Size(640, 2);
            this.MenuBarSeparator.TabIndex = 3;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 29);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(640, 451);
            this.MainPanel.TabIndex = 4;
            // 
            // BugReportBtn
            // 
            this.BugReportBtn.AutoSize = true;
            this.BugReportBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.BugReportBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BugReportBtn.Location = new System.Drawing.Point(515, 0);
            this.BugReportBtn.Name = "BugReportBtn";
            this.BugReportBtn.Size = new System.Drawing.Size(125, 27);
            this.BugReportBtn.TabIndex = 1;
            this.BugReportBtn.Text = "Bug report";
            this.BugReportBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuBarSeparator);
            this.Controls.Add(this.MenuBar);
            this.Icon = global::Photon.Properties.Resources.Logo;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photon";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.PageNameBackground.ResumeLayout(false);
            this.PageNameBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Panel PageNameBackground;
        private System.Windows.Forms.Label PageName;
        private System.Windows.Forms.Panel MenuBarSeparator;
        private GUI.PhotonTrayButton BugReportBtn;
        private System.Windows.Forms.Panel MainPanel;
    }
}