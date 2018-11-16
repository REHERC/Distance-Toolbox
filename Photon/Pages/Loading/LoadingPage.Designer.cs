using System.ComponentModel;

namespace Photon.Pages.Loading
{
    [ToolboxItem(false)]
    partial class LoadingPage
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
            this.EmptyContainer = new System.Windows.Forms.Panel();
            this.BackgroundContainer = new Photon.GUI.PhotonPanel();
            this.MessageLabel = new Photon.GUI.PhotonLabel();
            this.MessageContainer = new Photon.GUI.PhotonPanel();
            this.RightLine = new Photon.GUI.PhotonPanel();
            this.LeftLine = new Photon.GUI.PhotonPanel();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeftContainer = new System.Windows.Forms.Panel();
            this.RightContainer = new System.Windows.Forms.Panel();
            this.EmptyContainer.SuspendLayout();
            this.BackgroundContainer.SuspendLayout();
            this.MessageContainer.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.LeftContainer.SuspendLayout();
            this.RightContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmptyContainer
            // 
            this.EmptyContainer.AutoSize = true;
            this.EmptyContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmptyContainer.BackColor = System.Drawing.Color.White;
            this.EmptyContainer.Controls.Add(this.BackgroundContainer);
            this.EmptyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmptyContainer.Location = new System.Drawing.Point(12, 12);
            this.EmptyContainer.Name = "EmptyContainer";
            this.EmptyContainer.Padding = new System.Windows.Forms.Padding(12);
            this.EmptyContainer.Size = new System.Drawing.Size(241, 74);
            this.EmptyContainer.TabIndex = 3;
            // 
            // BackgroundContainer
            // 
            this.BackgroundContainer.AutoSize = true;
            this.BackgroundContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.BackgroundContainer.Controls.Add(this.MessageLabel);
            this.BackgroundContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundContainer.Location = new System.Drawing.Point(12, 12);
            this.BackgroundContainer.Name = "BackgroundContainer";
            this.BackgroundContainer.Padding = new System.Windows.Forms.Padding(32, 12, 32, 12);
            this.BackgroundContainer.Size = new System.Drawing.Size(217, 50);
            this.BackgroundContainer.TabIndex = 0;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.MessageLabel.ForeColor = System.Drawing.Color.White;
            this.MessageLabel.Location = new System.Drawing.Point(32, 12);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(153, 26);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Please wait ...";
            // 
            // MessageContainer
            // 
            this.MessageContainer.AutoSize = true;
            this.MessageContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MessageContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.MessageContainer.Controls.Add(this.EmptyContainer);
            this.MessageContainer.Location = new System.Drawing.Point(187, 190);
            this.MessageContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MessageContainer.Name = "MessageContainer";
            this.MessageContainer.Padding = new System.Windows.Forms.Padding(12);
            this.MessageContainer.Size = new System.Drawing.Size(265, 98);
            this.MessageContainer.TabIndex = 4;
            // 
            // RightLine
            // 
            this.RightLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RightLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.RightLine.Location = new System.Drawing.Point(28, 46);
            this.RightLine.Margin = new System.Windows.Forms.Padding(16);
            this.RightLine.MaximumSize = new System.Drawing.Size(0, 8);
            this.RightLine.MinimumSize = new System.Drawing.Size(0, 8);
            this.RightLine.Name = "RightLine";
            this.RightLine.Size = new System.Drawing.Size(132, 8);
            this.RightLine.TabIndex = 5;
            // 
            // LeftLine
            // 
            this.LeftLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.LeftLine.Location = new System.Drawing.Point(28, 46);
            this.LeftLine.Margin = new System.Windows.Forms.Padding(16);
            this.LeftLine.MaximumSize = new System.Drawing.Size(0, 8);
            this.LeftLine.MinimumSize = new System.Drawing.Size(0, 8);
            this.LeftLine.Name = "LeftLine";
            this.LeftLine.Size = new System.Drawing.Size(131, 8);
            this.LeftLine.TabIndex = 6;
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 3;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.Controls.Add(this.MessageContainer, 1, 1);
            this.MainPanel.Controls.Add(this.LeftContainer, 0, 1);
            this.MainPanel.Controls.Add(this.RightContainer, 2, 1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 3;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.Size = new System.Drawing.Size(640, 480);
            this.MainPanel.TabIndex = 7;
            // 
            // LeftContainer
            // 
            this.LeftContainer.Controls.Add(this.LeftLine);
            this.LeftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftContainer.Location = new System.Drawing.Point(0, 190);
            this.LeftContainer.Margin = new System.Windows.Forms.Padding(0);
            this.LeftContainer.Name = "LeftContainer";
            this.LeftContainer.Padding = new System.Windows.Forms.Padding(12);
            this.LeftContainer.Size = new System.Drawing.Size(187, 100);
            this.LeftContainer.TabIndex = 5;
            // 
            // RightContainer
            // 
            this.RightContainer.Controls.Add(this.RightLine);
            this.RightContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightContainer.Location = new System.Drawing.Point(452, 190);
            this.RightContainer.Margin = new System.Windows.Forms.Padding(0);
            this.RightContainer.Name = "RightContainer";
            this.RightContainer.Padding = new System.Windows.Forms.Padding(12);
            this.RightContainer.Size = new System.Drawing.Size(188, 100);
            this.RightContainer.TabIndex = 6;
            // 
            // LoadingPage
            // 
            this.Controls.Add(this.MainPanel);
            this.Name = "LoadingPage";
            this.PageName = "pages:manageplugins.createsettings";
            this.PageTitle = "";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.ManagerSettingsCreatePage_Load);
            this.EmptyContainer.ResumeLayout(false);
            this.EmptyContainer.PerformLayout();
            this.BackgroundContainer.ResumeLayout(false);
            this.BackgroundContainer.PerformLayout();
            this.MessageContainer.ResumeLayout(false);
            this.MessageContainer.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.LeftContainer.ResumeLayout(false);
            this.RightContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EmptyContainer;
        private GUI.PhotonPanel BackgroundContainer;
        private GUI.PhotonPanel MessageContainer;
        private GUI.PhotonPanel RightLine;
        private GUI.PhotonPanel LeftLine;
        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.Panel LeftContainer;
        private System.Windows.Forms.Panel RightContainer;
        public GUI.PhotonLabel MessageLabel;
    }
}
