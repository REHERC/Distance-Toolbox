using System.ComponentModel;

namespace Photon.Pages.Home
{
    [ToolboxItem(false)]
    partial class HomePage
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ToolsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.photonButton1 = new Photon.GUI.PhotonButton();
            this.SettingsBtn = new Photon.GUI.PhotonButton();
            this.SpectrumBtn = new Photon.GUI.PhotonButton();
            this.MainPanel.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Controls.Add(this.ToolsPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(16);
            this.MainPanel.Size = new System.Drawing.Size(640, 480);
            this.MainPanel.TabIndex = 3;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.AutoSize = true;
            this.ToolsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolsPanel.ColumnCount = 3;
            this.ToolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ToolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ToolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ToolsPanel.Controls.Add(this.photonButton1, 2, 0);
            this.ToolsPanel.Controls.Add(this.SettingsBtn, 0, 0);
            this.ToolsPanel.Controls.Add(this.SpectrumBtn, 1, 0);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsPanel.Location = new System.Drawing.Point(16, 16);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.RowCount = 2;
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ToolsPanel.Size = new System.Drawing.Size(608, 300);
            this.ToolsPanel.TabIndex = 2;
            // 
            // photonButton1
            // 
            this.photonButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photonButton1.Enabled = false;
            this.photonButton1.Font = new System.Drawing.Font("Arial Black", 10F);
            this.photonButton1.Location = new System.Drawing.Point(412, 8);
            this.photonButton1.Margin = new System.Windows.Forms.Padding(8);
            this.photonButton1.Name = "photonButton1";
            this.photonButton1.Size = new System.Drawing.Size(188, 134);
            this.photonButton1.TabIndex = 8;
            this.photonButton1.Text = "View\r\nSpectrum Logs";
            this.photonButton1.UseVisualStyleBackColor = true;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.SettingsBtn.Location = new System.Drawing.Point(8, 8);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(8);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(186, 134);
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // SpectrumBtn
            // 
            this.SpectrumBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpectrumBtn.Enabled = false;
            this.SpectrumBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.SpectrumBtn.Location = new System.Drawing.Point(210, 8);
            this.SpectrumBtn.Margin = new System.Windows.Forms.Padding(8);
            this.SpectrumBtn.Name = "SpectrumBtn";
            this.SpectrumBtn.Size = new System.Drawing.Size(186, 134);
            this.SpectrumBtn.TabIndex = 7;
            this.SpectrumBtn.Text = "Manage\r\nSpectrum Plugins";
            this.SpectrumBtn.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.Controls.Add(this.MainPanel);
            this.Name = "HomePage";
            this.PageName = "pages:home";
            this.PageTitle = "Home";
            this.Size = new System.Drawing.Size(640, 480);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ToolsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel ToolsPanel;
        private GUI.PhotonButton photonButton1;
        private GUI.PhotonButton SettingsBtn;
        private GUI.PhotonButton SpectrumBtn;
    }
}
