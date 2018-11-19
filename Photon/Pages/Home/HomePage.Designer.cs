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
            this.UtilitiesHeader = new Photon.GUI.PhotonHeaderLabel();
            this.GameHeader = new Photon.GUI.PhotonHeaderLabel();
            this.BrowseBtn = new Photon.GUI.PhotonButton();
            this.RunGameBtn = new Photon.GUI.PhotonButton();
            this.ConfigureGameBtn = new Photon.GUI.PhotonButton();
            this.SpectrumHeader = new Photon.GUI.PhotonHeaderLabel();
            this.PluginManifestButton = new Photon.GUI.PhotonButton();
            this.SpectrumLogsBtn = new Photon.GUI.PhotonButton();
            this.SpectrumPluginsBtn = new Photon.GUI.PhotonButton();
            this.BackupBtn = new Photon.GUI.PhotonButton();
            this.OnlineHeader = new Photon.GUI.PhotonHeaderLabel();
            this.ManagePlaylistsBtn = new Photon.GUI.PhotonButton();
            this.OnlineServersBtn = new Photon.GUI.PhotonButton();
            this.SocialMediaBtn = new Photon.GUI.PhotonButton();
            this.SettingsBtn = new Photon.GUI.PhotonButtonSimple();
            this.TopBar = new System.Windows.Forms.Panel();
            this.Separator_1 = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Controls.Add(this.ToolsPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 32);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(8);
            this.MainPanel.Size = new System.Drawing.Size(640, 881);
            this.MainPanel.TabIndex = 3;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.AutoSize = true;
            this.ToolsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToolsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolsPanel.ColumnCount = 3;
            this.ToolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.ToolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ToolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ToolsPanel.Controls.Add(this.UtilitiesHeader, 0, 5);
            this.ToolsPanel.Controls.Add(this.GameHeader, 0, 0);
            this.ToolsPanel.Controls.Add(this.BrowseBtn, 2, 1);
            this.ToolsPanel.Controls.Add(this.RunGameBtn, 0, 1);
            this.ToolsPanel.Controls.Add(this.ConfigureGameBtn, 0, 2);
            this.ToolsPanel.Controls.Add(this.SpectrumHeader, 0, 3);
            this.ToolsPanel.Controls.Add(this.PluginManifestButton, 2, 4);
            this.ToolsPanel.Controls.Add(this.SpectrumLogsBtn, 1, 4);
            this.ToolsPanel.Controls.Add(this.SpectrumPluginsBtn, 0, 4);
            this.ToolsPanel.Controls.Add(this.BackupBtn, 1, 6);
            this.ToolsPanel.Controls.Add(this.OnlineHeader, 0, 7);
            this.ToolsPanel.Controls.Add(this.ManagePlaylistsBtn, 0, 6);
            this.ToolsPanel.Controls.Add(this.OnlineServersBtn, 0, 8);
            this.ToolsPanel.Controls.Add(this.SocialMediaBtn, 1, 8);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsPanel.Location = new System.Drawing.Point(8, 8);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.RowCount = 9;
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.ToolsPanel.Size = new System.Drawing.Size(624, 865);
            this.ToolsPanel.TabIndex = 2;
            // 
            // UtilitiesHeader
            // 
            this.UtilitiesHeader.AutoSize = true;
            this.ToolsPanel.SetColumnSpan(this.UtilitiesHeader, 3);
            this.UtilitiesHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UtilitiesHeader.Font = new System.Drawing.Font("Arial Black", 10F);
            this.UtilitiesHeader.Location = new System.Drawing.Point(8, 505);
            this.UtilitiesHeader.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.UtilitiesHeader.Name = "UtilitiesHeader";
            this.UtilitiesHeader.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.UtilitiesHeader.Size = new System.Drawing.Size(608, 35);
            this.UtilitiesHeader.TabIndex = 21;
            this.UtilitiesHeader.Text = "Utilities";
            // 
            // GameHeader
            // 
            this.GameHeader.AutoSize = true;
            this.ToolsPanel.SetColumnSpan(this.GameHeader, 3);
            this.GameHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameHeader.Font = new System.Drawing.Font("Arial Black", 10F);
            this.GameHeader.Location = new System.Drawing.Point(8, 0);
            this.GameHeader.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.GameHeader.Name = "GameHeader";
            this.GameHeader.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.GameHeader.Size = new System.Drawing.Size(608, 35);
            this.GameHeader.TabIndex = 19;
            this.GameHeader.Text = "Game";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.AutoSize = true;
            this.BrowseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseBtn.Enabled = false;
            this.BrowseBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.BrowseBtn.Location = new System.Drawing.Point(423, 43);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(8);
            this.BrowseBtn.Name = "BrowseBtn";
            this.ToolsPanel.SetRowSpan(this.BrowseBtn, 2);
            this.BrowseBtn.Size = new System.Drawing.Size(193, 274);
            this.BrowseBtn.TabIndex = 16;
            this.BrowseBtn.Text = "Browse Game Files";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            // 
            // RunGameBtn
            // 
            this.RunGameBtn.AutoSize = true;
            this.ToolsPanel.SetColumnSpan(this.RunGameBtn, 2);
            this.RunGameBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RunGameBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.RunGameBtn.Location = new System.Drawing.Point(8, 43);
            this.RunGameBtn.Margin = new System.Windows.Forms.Padding(8);
            this.RunGameBtn.Name = "RunGameBtn";
            this.RunGameBtn.Size = new System.Drawing.Size(399, 129);
            this.RunGameBtn.TabIndex = 9;
            this.RunGameBtn.Text = "Launch Distance";
            this.RunGameBtn.UseVisualStyleBackColor = true;
            this.RunGameBtn.Click += new System.EventHandler(this.RunGameBtn_Click);
            // 
            // ConfigureGameBtn
            // 
            this.ConfigureGameBtn.AutoSize = true;
            this.ToolsPanel.SetColumnSpan(this.ConfigureGameBtn, 2);
            this.ConfigureGameBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigureGameBtn.Enabled = false;
            this.ConfigureGameBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.ConfigureGameBtn.Location = new System.Drawing.Point(8, 188);
            this.ConfigureGameBtn.Margin = new System.Windows.Forms.Padding(8);
            this.ConfigureGameBtn.Name = "ConfigureGameBtn";
            this.ConfigureGameBtn.Size = new System.Drawing.Size(399, 129);
            this.ConfigureGameBtn.TabIndex = 13;
            this.ConfigureGameBtn.Text = "Configure Distance Startup Arguments";
            this.ConfigureGameBtn.UseVisualStyleBackColor = true;
            // 
            // SpectrumHeader
            // 
            this.SpectrumHeader.AutoSize = true;
            this.ToolsPanel.SetColumnSpan(this.SpectrumHeader, 3);
            this.SpectrumHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpectrumHeader.Font = new System.Drawing.Font("Arial Black", 10F);
            this.SpectrumHeader.Location = new System.Drawing.Point(8, 325);
            this.SpectrumHeader.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.SpectrumHeader.Name = "SpectrumHeader";
            this.SpectrumHeader.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.SpectrumHeader.Size = new System.Drawing.Size(608, 35);
            this.SpectrumHeader.TabIndex = 20;
            this.SpectrumHeader.Text = "Spectrum extension system";
            // 
            // PluginManifestButton
            // 
            this.PluginManifestButton.AutoSize = true;
            this.PluginManifestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginManifestButton.Enabled = false;
            this.PluginManifestButton.Font = new System.Drawing.Font("Arial Black", 10F);
            this.PluginManifestButton.Location = new System.Drawing.Point(423, 368);
            this.PluginManifestButton.Margin = new System.Windows.Forms.Padding(8);
            this.PluginManifestButton.Name = "PluginManifestButton";
            this.PluginManifestButton.Size = new System.Drawing.Size(193, 129);
            this.PluginManifestButton.TabIndex = 17;
            this.PluginManifestButton.Text = "Create Spectrum Plugin Manifest";
            this.PluginManifestButton.UseVisualStyleBackColor = true;
            // 
            // SpectrumLogsBtn
            // 
            this.SpectrumLogsBtn.AutoSize = true;
            this.SpectrumLogsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpectrumLogsBtn.Enabled = false;
            this.SpectrumLogsBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.SpectrumLogsBtn.Location = new System.Drawing.Point(215, 368);
            this.SpectrumLogsBtn.Margin = new System.Windows.Forms.Padding(8);
            this.SpectrumLogsBtn.Name = "SpectrumLogsBtn";
            this.SpectrumLogsBtn.Size = new System.Drawing.Size(192, 129);
            this.SpectrumLogsBtn.TabIndex = 8;
            this.SpectrumLogsBtn.Text = "View Spectrum Logs";
            this.SpectrumLogsBtn.UseVisualStyleBackColor = true;
            // 
            // SpectrumPluginsBtn
            // 
            this.SpectrumPluginsBtn.AutoSize = true;
            this.SpectrumPluginsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpectrumPluginsBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.SpectrumPluginsBtn.Location = new System.Drawing.Point(8, 368);
            this.SpectrumPluginsBtn.Margin = new System.Windows.Forms.Padding(8);
            this.SpectrumPluginsBtn.Name = "SpectrumPluginsBtn";
            this.SpectrumPluginsBtn.Size = new System.Drawing.Size(191, 129);
            this.SpectrumPluginsBtn.TabIndex = 7;
            this.SpectrumPluginsBtn.Text = "Manage Spectrum Plugins";
            this.SpectrumPluginsBtn.UseVisualStyleBackColor = true;
            this.SpectrumPluginsBtn.Click += new System.EventHandler(this.SpectrumPluginsBtn_Click);
            // 
            // BackupBtn
            // 
            this.BackupBtn.AutoSize = true;
            this.BackupBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackupBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.BackupBtn.Location = new System.Drawing.Point(215, 548);
            this.BackupBtn.Margin = new System.Windows.Forms.Padding(8);
            this.BackupBtn.Name = "BackupBtn";
            this.BackupBtn.Size = new System.Drawing.Size(192, 129);
            this.BackupBtn.TabIndex = 15;
            this.BackupBtn.Text = "Backup User Files";
            this.BackupBtn.UseVisualStyleBackColor = true;
            this.BackupBtn.Click += new System.EventHandler(this.BackupBtn_Click);
            // 
            // OnlineHeader
            // 
            this.OnlineHeader.AutoSize = true;
            this.ToolsPanel.SetColumnSpan(this.OnlineHeader, 3);
            this.OnlineHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OnlineHeader.Font = new System.Drawing.Font("Arial Black", 10F);
            this.OnlineHeader.Location = new System.Drawing.Point(8, 685);
            this.OnlineHeader.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.OnlineHeader.Name = "OnlineHeader";
            this.OnlineHeader.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.OnlineHeader.Size = new System.Drawing.Size(608, 35);
            this.OnlineHeader.TabIndex = 22;
            this.OnlineHeader.Text = "Online";
            // 
            // ManagePlaylistsBtn
            // 
            this.ManagePlaylistsBtn.AutoSize = true;
            this.ManagePlaylistsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagePlaylistsBtn.Enabled = false;
            this.ManagePlaylistsBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.ManagePlaylistsBtn.Location = new System.Drawing.Point(8, 548);
            this.ManagePlaylistsBtn.Margin = new System.Windows.Forms.Padding(8);
            this.ManagePlaylistsBtn.Name = "ManagePlaylistsBtn";
            this.ManagePlaylistsBtn.Size = new System.Drawing.Size(191, 129);
            this.ManagePlaylistsBtn.TabIndex = 12;
            this.ManagePlaylistsBtn.Text = "Manage Levels Playlists";
            this.ManagePlaylistsBtn.UseVisualStyleBackColor = true;
            // 
            // OnlineServersBtn
            // 
            this.OnlineServersBtn.AutoSize = true;
            this.OnlineServersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OnlineServersBtn.Enabled = false;
            this.OnlineServersBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.OnlineServersBtn.Location = new System.Drawing.Point(8, 728);
            this.OnlineServersBtn.Margin = new System.Windows.Forms.Padding(8);
            this.OnlineServersBtn.Name = "OnlineServersBtn";
            this.OnlineServersBtn.Size = new System.Drawing.Size(191, 129);
            this.OnlineServersBtn.TabIndex = 11;
            this.OnlineServersBtn.Text = "View Online Servers";
            this.OnlineServersBtn.UseVisualStyleBackColor = true;
            // 
            // SocialMediaBtn
            // 
            this.SocialMediaBtn.AutoSize = true;
            this.SocialMediaBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SocialMediaBtn.Enabled = false;
            this.SocialMediaBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.SocialMediaBtn.Location = new System.Drawing.Point(215, 728);
            this.SocialMediaBtn.Margin = new System.Windows.Forms.Padding(8);
            this.SocialMediaBtn.Name = "SocialMediaBtn";
            this.SocialMediaBtn.Size = new System.Drawing.Size(192, 129);
            this.SocialMediaBtn.TabIndex = 14;
            this.SocialMediaBtn.Text = "Refract\'s Social Media";
            this.SocialMediaBtn.UseVisualStyleBackColor = true;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.AutoSize = true;
            this.SettingsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.SettingsBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.SettingsBtn.Location = new System.Drawing.Point(558, 0);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(8);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(82, 32);
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // TopBar
            // 
            this.TopBar.AutoSize = true;
            this.TopBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopBar.BackColor = System.Drawing.Color.White;
            this.TopBar.Controls.Add(this.SettingsBtn);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.MaximumSize = new System.Drawing.Size(0, 32);
            this.TopBar.MinimumSize = new System.Drawing.Size(0, 32);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(640, 32);
            this.TopBar.TabIndex = 4;
            // 
            // Separator_1
            // 
            this.Separator_1.AutoSize = true;
            this.Separator_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Separator_1.BackColor = System.Drawing.Color.White;
            this.Separator_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separator_1.Location = new System.Drawing.Point(0, 32);
            this.Separator_1.MaximumSize = new System.Drawing.Size(0, 1);
            this.Separator_1.MinimumSize = new System.Drawing.Size(0, 1);
            this.Separator_1.Name = "Separator_1";
            this.Separator_1.Size = new System.Drawing.Size(640, 1);
            this.Separator_1.TabIndex = 5;
            // 
            // HomePage
            // 
            this.AutoSize = true;
            this.Controls.Add(this.Separator_1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopBar);
            this.Name = "HomePage";
            this.PageName = "pages:home";
            this.PageTitle = "Home";
            this.Size = new System.Drawing.Size(640, 913);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.VisibleChanged += new System.EventHandler(this.HomePage_VisibleChanged);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ToolsPanel.ResumeLayout(false);
            this.ToolsPanel.PerformLayout();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel ToolsPanel;
        private GUI.PhotonButton SpectrumLogsBtn;
        private GUI.PhotonButtonSimple SettingsBtn;
        private GUI.PhotonButton SpectrumPluginsBtn;
        private GUI.PhotonButton RunGameBtn;
        private GUI.PhotonButton OnlineServersBtn;
        private GUI.PhotonButton ManagePlaylistsBtn;
        private GUI.PhotonButton ConfigureGameBtn;
        private GUI.PhotonButton SocialMediaBtn;
        private GUI.PhotonButton BackupBtn;
        private GUI.PhotonButton BrowseBtn;
        private GUI.PhotonButton PluginManifestButton;
        private GUI.PhotonHeaderLabel GameHeader;
        private GUI.PhotonHeaderLabel SpectrumHeader;
        private GUI.PhotonHeaderLabel UtilitiesHeader;
        private GUI.PhotonHeaderLabel OnlineHeader;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel Separator_1;
    }
}
