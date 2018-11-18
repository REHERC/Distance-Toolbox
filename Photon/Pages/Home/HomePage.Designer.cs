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
            this.BackupBtn = new Photon.GUI.PhotonButton();
            this.ConfigureGameBtn = new Photon.GUI.PhotonButton();
            this.ManagePlaylistsBtn = new Photon.GUI.PhotonButton();
            this.OnlineServersBtn = new Photon.GUI.PhotonButton();
            this.RunGameBtn = new Photon.GUI.PhotonButton();
            this.SpectrumLogsBtn = new Photon.GUI.PhotonButton();
            this.SettingsBtn = new Photon.GUI.PhotonButton();
            this.SpectrumPluginsBtn = new Photon.GUI.PhotonButton();
            this.SocialMediaBtn = new Photon.GUI.PhotonButton();
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
            this.MainPanel.Padding = new System.Windows.Forms.Padding(8);
            this.MainPanel.Size = new System.Drawing.Size(640, 480);
            this.MainPanel.TabIndex = 3;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.AutoSize = true;
            this.ToolsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolsPanel.ColumnCount = 3;
            this.ToolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.ToolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ToolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ToolsPanel.Controls.Add(this.BackupBtn, 2, 2);
            this.ToolsPanel.Controls.Add(this.ConfigureGameBtn, 1, 1);
            this.ToolsPanel.Controls.Add(this.ManagePlaylistsBtn, 2, 1);
            this.ToolsPanel.Controls.Add(this.OnlineServersBtn, 1, 2);
            this.ToolsPanel.Controls.Add(this.RunGameBtn, 0, 1);
            this.ToolsPanel.Controls.Add(this.SpectrumLogsBtn, 2, 0);
            this.ToolsPanel.Controls.Add(this.SettingsBtn, 0, 0);
            this.ToolsPanel.Controls.Add(this.SpectrumPluginsBtn, 1, 0);
            this.ToolsPanel.Controls.Add(this.SocialMediaBtn, 0, 2);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsPanel.Location = new System.Drawing.Point(8, 8);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.RowCount = 3;
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.ToolsPanel.Size = new System.Drawing.Size(624, 435);
            this.ToolsPanel.TabIndex = 2;
            // 
            // BackupBtn
            // 
            this.BackupBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackupBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.BackupBtn.Location = new System.Drawing.Point(423, 298);
            this.BackupBtn.Margin = new System.Windows.Forms.Padding(8);
            this.BackupBtn.Name = "BackupBtn";
            this.BackupBtn.Size = new System.Drawing.Size(193, 129);
            this.BackupBtn.TabIndex = 15;
            this.BackupBtn.Text = "Backup User Files";
            this.BackupBtn.UseVisualStyleBackColor = true;
            this.BackupBtn.Click += new System.EventHandler(this.BackupBtn_Click);
            // 
            // ConfigureGameBtn
            // 
            this.ConfigureGameBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigureGameBtn.Enabled = false;
            this.ConfigureGameBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.ConfigureGameBtn.Location = new System.Drawing.Point(215, 153);
            this.ConfigureGameBtn.Margin = new System.Windows.Forms.Padding(8);
            this.ConfigureGameBtn.Name = "ConfigureGameBtn";
            this.ConfigureGameBtn.Size = new System.Drawing.Size(192, 129);
            this.ConfigureGameBtn.TabIndex = 13;
            this.ConfigureGameBtn.Text = "Configure Distance Startup Arguments";
            this.ConfigureGameBtn.UseVisualStyleBackColor = true;
            // 
            // ManagePlaylistsBtn
            // 
            this.ManagePlaylistsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagePlaylistsBtn.Enabled = false;
            this.ManagePlaylistsBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.ManagePlaylistsBtn.Location = new System.Drawing.Point(423, 153);
            this.ManagePlaylistsBtn.Margin = new System.Windows.Forms.Padding(8);
            this.ManagePlaylistsBtn.Name = "ManagePlaylistsBtn";
            this.ManagePlaylistsBtn.Size = new System.Drawing.Size(193, 129);
            this.ManagePlaylistsBtn.TabIndex = 12;
            this.ManagePlaylistsBtn.Text = "Manage Levels Playlists";
            this.ManagePlaylistsBtn.UseVisualStyleBackColor = true;
            // 
            // OnlineServersBtn
            // 
            this.OnlineServersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OnlineServersBtn.Enabled = false;
            this.OnlineServersBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.OnlineServersBtn.Location = new System.Drawing.Point(215, 298);
            this.OnlineServersBtn.Margin = new System.Windows.Forms.Padding(8);
            this.OnlineServersBtn.Name = "OnlineServersBtn";
            this.OnlineServersBtn.Size = new System.Drawing.Size(192, 129);
            this.OnlineServersBtn.TabIndex = 11;
            this.OnlineServersBtn.Text = "View Online Servers";
            this.OnlineServersBtn.UseVisualStyleBackColor = true;
            // 
            // RunGameBtn
            // 
            this.RunGameBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RunGameBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.RunGameBtn.Location = new System.Drawing.Point(8, 153);
            this.RunGameBtn.Margin = new System.Windows.Forms.Padding(8);
            this.RunGameBtn.Name = "RunGameBtn";
            this.RunGameBtn.Size = new System.Drawing.Size(191, 129);
            this.RunGameBtn.TabIndex = 9;
            this.RunGameBtn.Text = "Launch Distance";
            this.RunGameBtn.UseVisualStyleBackColor = true;
            this.RunGameBtn.Click += new System.EventHandler(this.RunGameBtn_Click);
            // 
            // SpectrumLogsBtn
            // 
            this.SpectrumLogsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpectrumLogsBtn.Enabled = false;
            this.SpectrumLogsBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.SpectrumLogsBtn.Location = new System.Drawing.Point(423, 8);
            this.SpectrumLogsBtn.Margin = new System.Windows.Forms.Padding(8);
            this.SpectrumLogsBtn.Name = "SpectrumLogsBtn";
            this.SpectrumLogsBtn.Size = new System.Drawing.Size(193, 129);
            this.SpectrumLogsBtn.TabIndex = 8;
            this.SpectrumLogsBtn.Text = "View Spectrum Logs";
            this.SpectrumLogsBtn.UseVisualStyleBackColor = true;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.SettingsBtn.Location = new System.Drawing.Point(8, 8);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(8);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(191, 129);
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // SpectrumPluginsBtn
            // 
            this.SpectrumPluginsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpectrumPluginsBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.SpectrumPluginsBtn.Location = new System.Drawing.Point(215, 8);
            this.SpectrumPluginsBtn.Margin = new System.Windows.Forms.Padding(8);
            this.SpectrumPluginsBtn.Name = "SpectrumPluginsBtn";
            this.SpectrumPluginsBtn.Size = new System.Drawing.Size(192, 129);
            this.SpectrumPluginsBtn.TabIndex = 7;
            this.SpectrumPluginsBtn.Text = "Manage Spectrum Plugins";
            this.SpectrumPluginsBtn.UseVisualStyleBackColor = true;
            this.SpectrumPluginsBtn.Click += new System.EventHandler(this.SpectrumPluginsBtn_Click);
            // 
            // SocialMediaBtn
            // 
            this.SocialMediaBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SocialMediaBtn.Enabled = false;
            this.SocialMediaBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.SocialMediaBtn.Location = new System.Drawing.Point(8, 298);
            this.SocialMediaBtn.Margin = new System.Windows.Forms.Padding(8);
            this.SocialMediaBtn.Name = "SocialMediaBtn";
            this.SocialMediaBtn.Size = new System.Drawing.Size(191, 129);
            this.SocialMediaBtn.TabIndex = 14;
            this.SocialMediaBtn.Text = "Refract\'s Social Media";
            this.SocialMediaBtn.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.Controls.Add(this.MainPanel);
            this.Name = "HomePage";
            this.PageName = "pages:home";
            this.PageTitle = "Home";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ToolsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel ToolsPanel;
        private GUI.PhotonButton SpectrumLogsBtn;
        private GUI.PhotonButton SettingsBtn;
        private GUI.PhotonButton SpectrumPluginsBtn;
        private GUI.PhotonButton RunGameBtn;
        private GUI.PhotonButton OnlineServersBtn;
        private GUI.PhotonButton ManagePlaylistsBtn;
        private GUI.PhotonButton ConfigureGameBtn;
        private GUI.PhotonButton SocialMediaBtn;
        private GUI.PhotonButton BackupBtn;
    }
}
