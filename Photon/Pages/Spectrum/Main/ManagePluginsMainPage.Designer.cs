using System.ComponentModel;

namespace Photon.Pages.Spectrum
{
    [ToolboxItem(false)]
    partial class ManagePluginsMainPage
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
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ActionButtonsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel = new Photon.GUI.PhotonTrayButton();
            this.Ok = new Photon.GUI.PhotonTrayButton();
            this.BottomSeparator = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.NoPluginsPanel = new System.Windows.Forms.Panel();
            this.NoPluginsLabel = new System.Windows.Forms.Label();
            this.PluginList = new System.Windows.Forms.Panel();
            this.BottomPanel.SuspendLayout();
            this.ActionButtonsFlow.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.NoPluginsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BottomPanel.Controls.Add(this.ActionButtonsFlow);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 416);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Padding = new System.Windows.Forms.Padding(16);
            this.BottomPanel.Size = new System.Drawing.Size(640, 64);
            this.BottomPanel.TabIndex = 4;
            // 
            // ActionButtonsFlow
            // 
            this.ActionButtonsFlow.Controls.Add(this.Cancel);
            this.ActionButtonsFlow.Controls.Add(this.Ok);
            this.ActionButtonsFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionButtonsFlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ActionButtonsFlow.Location = new System.Drawing.Point(16, 16);
            this.ActionButtonsFlow.Name = "ActionButtonsFlow";
            this.ActionButtonsFlow.Size = new System.Drawing.Size(608, 32);
            this.ActionButtonsFlow.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = true;
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cancel.Font = new System.Drawing.Font("Arial Black", 10F);
            this.Cancel.Location = new System.Drawing.Point(476, 0);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(128, 32);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Back";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.AutoSize = true;
            this.Ok.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ok.Font = new System.Drawing.Font("Arial Black", 10F);
            this.Ok.Location = new System.Drawing.Point(340, 0);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(128, 32);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Refresh";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // BottomSeparator
            // 
            this.BottomSeparator.BackColor = System.Drawing.Color.Silver;
            this.BottomSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomSeparator.Location = new System.Drawing.Point(0, 415);
            this.BottomSeparator.MaximumSize = new System.Drawing.Size(0, 1);
            this.BottomSeparator.MinimumSize = new System.Drawing.Size(0, 1);
            this.BottomSeparator.Name = "BottomSeparator";
            this.BottomSeparator.Size = new System.Drawing.Size(640, 1);
            this.BottomSeparator.TabIndex = 5;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Controls.Add(this.NoPluginsPanel);
            this.MainPanel.Controls.Add(this.PluginList);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(16);
            this.MainPanel.Size = new System.Drawing.Size(640, 415);
            this.MainPanel.TabIndex = 6;
            // 
            // NoPluginsPanel
            // 
            this.NoPluginsPanel.Controls.Add(this.NoPluginsLabel);
            this.NoPluginsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoPluginsPanel.Location = new System.Drawing.Point(16, 16);
            this.NoPluginsPanel.Name = "NoPluginsPanel";
            this.NoPluginsPanel.Size = new System.Drawing.Size(608, 383);
            this.NoPluginsPanel.TabIndex = 1;
            // 
            // NoPluginsLabel
            // 
            this.NoPluginsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoPluginsLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.NoPluginsLabel.Location = new System.Drawing.Point(0, 0);
            this.NoPluginsLabel.Name = "NoPluginsLabel";
            this.NoPluginsLabel.Size = new System.Drawing.Size(608, 383);
            this.NoPluginsLabel.TabIndex = 0;
            this.NoPluginsLabel.Text = "No plugins found";
            this.NoPluginsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PluginList
            // 
            this.PluginList.AutoSize = true;
            this.PluginList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PluginList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PluginList.Location = new System.Drawing.Point(16, 16);
            this.PluginList.Name = "PluginList";
            this.PluginList.Size = new System.Drawing.Size(608, 0);
            this.PluginList.TabIndex = 0;
            // 
            // ManagePluginsMainPage
            // 
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BottomSeparator);
            this.Controls.Add(this.BottomPanel);
            this.Name = "ManagePluginsMainPage";
            this.PageName = "pages:manageplugins.main";
            this.PageTitle = "Manage Plugins";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.ManagePluginsMainPage_Load);
            this.BottomPanel.ResumeLayout(false);
            this.ActionButtonsFlow.ResumeLayout(false);
            this.ActionButtonsFlow.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.NoPluginsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.FlowLayoutPanel ActionButtonsFlow;
        private GUI.PhotonTrayButton Cancel;
        private GUI.PhotonTrayButton Ok;
        private System.Windows.Forms.Panel BottomSeparator;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PluginList;
        private System.Windows.Forms.Panel NoPluginsPanel;
        private System.Windows.Forms.Label NoPluginsLabel;
    }
}
