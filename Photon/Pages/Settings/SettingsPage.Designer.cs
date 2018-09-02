using System.ComponentModel;

namespace Photon.Pages.Settings
{
    [ToolboxItem(false)]
    partial class SettingsPage
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
            this.OptionsLayout = new Photon.GUI.PhotonPanel();
            this.OptionsTable = new System.Windows.Forms.TableLayoutPanel();
            this.GamePathName = new Photon.GUI.PhotonLabel();
            this.GamePathContainer = new System.Windows.Forms.Panel();
            this.GameDirBox = new Photon.GUI.PhotonTextBox();
            this.GamePathBtn = new Photon.GUI.PhotonButtonSimple();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ActionButtonsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel = new Photon.GUI.PhotonTrayButton();
            this.Ok = new Photon.GUI.PhotonTrayButton();
            this.BottomSeparator = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.OptionsLayout.SuspendLayout();
            this.OptionsTable.SuspendLayout();
            this.GamePathContainer.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.ActionButtonsFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.OptionsLayout);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(16);
            this.MainPanel.Size = new System.Drawing.Size(623, 415);
            this.MainPanel.TabIndex = 2;
            // 
            // OptionsLayout
            // 
            this.OptionsLayout.AutoSize = true;
            this.OptionsLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.OptionsLayout.Controls.Add(this.OptionsTable);
            this.OptionsLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionsLayout.Location = new System.Drawing.Point(16, 16);
            this.OptionsLayout.Name = "OptionsLayout";
            this.OptionsLayout.Size = new System.Drawing.Size(591, 19);
            this.OptionsLayout.TabIndex = 2;
            // 
            // OptionsTable
            // 
            this.OptionsTable.ColumnCount = 2;
            this.OptionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OptionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionsTable.Controls.Add(this.GamePathName, 0, 0);
            this.OptionsTable.Controls.Add(this.GamePathContainer, 1, 0);
            this.OptionsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionsTable.Location = new System.Drawing.Point(0, 0);
            this.OptionsTable.Name = "OptionsTable";
            this.OptionsTable.RowCount = 2;
            this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OptionsTable.Size = new System.Drawing.Size(591, 19);
            this.OptionsTable.TabIndex = 0;
            // 
            // GamePathName
            // 
            this.GamePathName.AutoSize = true;
            this.GamePathName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePathName.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.GamePathName.ForeColor = System.Drawing.Color.White;
            this.GamePathName.Location = new System.Drawing.Point(3, 0);
            this.GamePathName.Name = "GamePathName";
            this.GamePathName.Size = new System.Drawing.Size(136, 19);
            this.GamePathName.TabIndex = 0;
            this.GamePathName.Text = "Game directory :";
            this.GamePathName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GamePathContainer
            // 
            this.GamePathContainer.AutoSize = true;
            this.GamePathContainer.Controls.Add(this.GameDirBox);
            this.GamePathContainer.Controls.Add(this.GamePathBtn);
            this.GamePathContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePathContainer.Location = new System.Drawing.Point(142, 0);
            this.GamePathContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GamePathContainer.Name = "GamePathContainer";
            this.GamePathContainer.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.GamePathContainer.Size = new System.Drawing.Size(449, 19);
            this.GamePathContainer.TabIndex = 1;
            // 
            // GameDirBox
            // 
            this.GameDirBox.BackColor = System.Drawing.Color.White;
            this.GameDirBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GameDirBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameDirBox.Font = new System.Drawing.Font("Arial Black", 10F);
            this.GameDirBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.GameDirBox.Location = new System.Drawing.Point(8, 0);
            this.GameDirBox.Name = "GameDirBox";
            this.GameDirBox.ReadOnly = true;
            this.GameDirBox.Size = new System.Drawing.Size(399, 19);
            this.GameDirBox.TabIndex = 1;
            this.GameDirBox.Text = "Not set.";
            this.GameDirBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GamePathBtn
            // 
            this.GamePathBtn.AutoSize = true;
            this.GamePathBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.GamePathBtn.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.GamePathBtn.Location = new System.Drawing.Point(407, 0);
            this.GamePathBtn.Name = "GamePathBtn";
            this.GamePathBtn.Size = new System.Drawing.Size(34, 19);
            this.GamePathBtn.TabIndex = 1;
            this.GamePathBtn.Text = "...";
            this.GamePathBtn.UseVisualStyleBackColor = true;
            this.GamePathBtn.Click += new System.EventHandler(this.GamePathBtn_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BottomPanel.Controls.Add(this.ActionButtonsFlow);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 416);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Padding = new System.Windows.Forms.Padding(16);
            this.BottomPanel.Size = new System.Drawing.Size(623, 64);
            this.BottomPanel.TabIndex = 3;
            // 
            // ActionButtonsFlow
            // 
            this.ActionButtonsFlow.Controls.Add(this.Cancel);
            this.ActionButtonsFlow.Controls.Add(this.Ok);
            this.ActionButtonsFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionButtonsFlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ActionButtonsFlow.Location = new System.Drawing.Point(16, 16);
            this.ActionButtonsFlow.Name = "ActionButtonsFlow";
            this.ActionButtonsFlow.Size = new System.Drawing.Size(591, 32);
            this.ActionButtonsFlow.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = true;
            this.Cancel.Font = new System.Drawing.Font("Arial Black", 10F);
            this.Cancel.Location = new System.Drawing.Point(459, 0);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(128, 32);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Ok
            // 
            this.Ok.AutoSize = true;
            this.Ok.Font = new System.Drawing.Font("Arial Black", 10F);
            this.Ok.Location = new System.Drawing.Point(323, 0);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(128, 32);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // BottomSeparator
            // 
            this.BottomSeparator.BackColor = System.Drawing.Color.Silver;
            this.BottomSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomSeparator.Location = new System.Drawing.Point(0, 415);
            this.BottomSeparator.MaximumSize = new System.Drawing.Size(0, 1);
            this.BottomSeparator.MinimumSize = new System.Drawing.Size(0, 1);
            this.BottomSeparator.Name = "BottomSeparator";
            this.BottomSeparator.Size = new System.Drawing.Size(623, 1);
            this.BottomSeparator.TabIndex = 4;
            // 
            // SettingsPage
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BottomSeparator);
            this.Controls.Add(this.BottomPanel);
            this.Name = "SettingsPage";
            this.PageName = "pages:settings";
            this.PageTitle = "Settings";
            this.Size = new System.Drawing.Size(623, 480);
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.OptionsLayout.ResumeLayout(false);
            this.OptionsTable.ResumeLayout(false);
            this.OptionsTable.PerformLayout();
            this.GamePathContainer.ResumeLayout(false);
            this.GamePathContainer.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.ActionButtonsFlow.ResumeLayout(false);
            this.ActionButtonsFlow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private GUI.PhotonPanel OptionsLayout;
        private System.Windows.Forms.TableLayoutPanel OptionsTable;
        private System.Windows.Forms.Panel BottomPanel;
        private GUI.PhotonTrayButton Cancel;
        private System.Windows.Forms.Panel BottomSeparator;
        private GUI.PhotonLabel GamePathName;
        private System.Windows.Forms.Panel GamePathContainer;
        private GUI.PhotonButtonSimple GamePathBtn;
        private GUI.PhotonTextBox GameDirBox;
        private GUI.PhotonTrayButton Ok;
        private System.Windows.Forms.FlowLayoutPanel ActionButtonsFlow;
    }
}
