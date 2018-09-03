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
            this.ManagePlaylistsBtn = new Photon.GUI.PhotonButton();
            this.OnlineServersBtn = new Photon.GUI.PhotonButton();
            this.RunGameBtn = new Photon.GUI.PhotonButton();
            this.SpectrumLogsBtn = new Photon.GUI.PhotonButton();
            this.SettingsBtn = new Photon.GUI.PhotonButton();
            this.SpectrumPluginsBtn = new Photon.GUI.PhotonButton();
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
            this.ToolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ToolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ToolsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ToolsPanel.Controls.Add(this.ManagePlaylistsBtn, 2, 1);
            this.ToolsPanel.Controls.Add(this.OnlineServersBtn, 1, 1);
            this.ToolsPanel.Controls.Add(this.RunGameBtn, 0, 1);
            this.ToolsPanel.Controls.Add(this.SpectrumLogsBtn, 2, 0);
            this.ToolsPanel.Controls.Add(this.SettingsBtn, 0, 0);
            this.ToolsPanel.Controls.Add(this.SpectrumPluginsBtn, 1, 0);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsPanel.Location = new System.Drawing.Point(8, 8);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.RowCount = 2;
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ToolsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ToolsPanel.Size = new System.Drawing.Size(624, 300);
            this.ToolsPanel.TabIndex = 2;
            // 
            // ManagePlaylistsBtn
            // 
            this.ManagePlaylistsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagePlaylistsBtn.Enabled = false;
            this.ManagePlaylistsBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.ManagePlaylistsBtn.Location = new System.Drawing.Point(423, 158);
            this.ManagePlaylistsBtn.Margin = new System.Windows.Forms.Padding(8);
            this.ManagePlaylistsBtn.Name = "ManagePlaylistsBtn";
            this.ManagePlaylistsBtn.Size = new System.Drawing.Size(193, 134);
            this.ManagePlaylistsBtn.TabIndex = 12;
            this.ManagePlaylistsBtn.Text = "Manage Levels Playlists";
            this.ManagePlaylistsBtn.UseVisualStyleBackColor = true;
            // 
            // OnlineServersBtn
            // 
            this.OnlineServersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OnlineServersBtn.Enabled = false;
            this.OnlineServersBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.OnlineServersBtn.Location = new System.Drawing.Point(215, 158);
            this.OnlineServersBtn.Margin = new System.Windows.Forms.Padding(8);
            this.OnlineServersBtn.Name = "OnlineServersBtn";
            this.OnlineServersBtn.Size = new System.Drawing.Size(192, 134);
            this.OnlineServersBtn.TabIndex = 11;
            this.OnlineServersBtn.Text = "View Online Servers";
            this.OnlineServersBtn.UseVisualStyleBackColor = true;
            // 
            // RunGameBtn
            // 
            this.RunGameBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RunGameBtn.Enabled = false;
            this.RunGameBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.RunGameBtn.Location = new System.Drawing.Point(8, 158);
            this.RunGameBtn.Margin = new System.Windows.Forms.Padding(8);
            this.RunGameBtn.Name = "RunGameBtn";
            this.RunGameBtn.Size = new System.Drawing.Size(191, 134);
            this.RunGameBtn.TabIndex = 9;
            this.RunGameBtn.Text = "Launch Distance";
            this.RunGameBtn.UseVisualStyleBackColor = true;
            // 
            // SpectrumLogsBtn
            // 
            this.SpectrumLogsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpectrumLogsBtn.Enabled = false;
            this.SpectrumLogsBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.SpectrumLogsBtn.Location = new System.Drawing.Point(423, 8);
            this.SpectrumLogsBtn.Margin = new System.Windows.Forms.Padding(8);
            this.SpectrumLogsBtn.Name = "SpectrumLogsBtn";
            this.SpectrumLogsBtn.Size = new System.Drawing.Size(193, 134);
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
            this.SettingsBtn.Size = new System.Drawing.Size(191, 134);
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
            this.SpectrumPluginsBtn.Size = new System.Drawing.Size(192, 134);
            this.SpectrumPluginsBtn.TabIndex = 7;
            this.SpectrumPluginsBtn.Text = "Manage Spectrum Plugins";
            this.SpectrumPluginsBtn.UseVisualStyleBackColor = true;
            this.SpectrumPluginsBtn.Click += new System.EventHandler(this.SpectrumPluginsBtn_Click);
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
        private GUI.PhotonButton SpectrumLogsBtn;
        private GUI.PhotonButton SettingsBtn;
        private GUI.PhotonButton SpectrumPluginsBtn;
        private GUI.PhotonButton RunGameBtn;
        private GUI.PhotonButton OnlineServersBtn;
        private GUI.PhotonButton ManagePlaylistsBtn;
    }
}
