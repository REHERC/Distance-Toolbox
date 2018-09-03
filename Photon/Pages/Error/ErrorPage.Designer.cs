using System.ComponentModel;

namespace Photon.Pages.Error
{
    [ToolboxItem(false)]
    partial class ErrorPage
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
                Globals.Variables.MainForm?.RemovePage("pages:error");
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
            this.ErrorHeader = new Photon.GUI.PhotonHeaderLabel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ErrorMessageMargin = new System.Windows.Forms.Panel();
            this.ErrorMessageContainer = new Photon.GUI.PhotonPanel();
            this.ErrorMessage = new Photon.GUI.PhotonLabel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ActionButtonsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel = new Photon.GUI.PhotonTrayButton();
            this.Ok = new Photon.GUI.PhotonTrayButton();
            this.BottomSeparator = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.ErrorMessageMargin.SuspendLayout();
            this.ErrorMessageContainer.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.ActionButtonsFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorHeader
            // 
            this.ErrorHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ErrorHeader.Font = new System.Drawing.Font("Arial Black", 16F);
            this.ErrorHeader.Location = new System.Drawing.Point(16, 16);
            this.ErrorHeader.Name = "ErrorHeader";
            this.ErrorHeader.Size = new System.Drawing.Size(608, 32);
            this.ErrorHeader.TabIndex = 0;
            this.ErrorHeader.Text = "Error title";
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Controls.Add(this.ErrorMessageMargin);
            this.MainPanel.Controls.Add(this.ErrorHeader);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(16);
            this.MainPanel.Size = new System.Drawing.Size(640, 415);
            this.MainPanel.TabIndex = 1;
            // 
            // ErrorMessageMargin
            // 
            this.ErrorMessageMargin.AutoSize = true;
            this.ErrorMessageMargin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ErrorMessageMargin.Controls.Add(this.ErrorMessageContainer);
            this.ErrorMessageMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.ErrorMessageMargin.Location = new System.Drawing.Point(16, 48);
            this.ErrorMessageMargin.Name = "ErrorMessageMargin";
            this.ErrorMessageMargin.Padding = new System.Windows.Forms.Padding(16);
            this.ErrorMessageMargin.Size = new System.Drawing.Size(608, 66);
            this.ErrorMessageMargin.TabIndex = 2;
            // 
            // ErrorMessageContainer
            // 
            this.ErrorMessageContainer.AutoSize = true;
            this.ErrorMessageContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ErrorMessageContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.ErrorMessageContainer.Controls.Add(this.ErrorMessage);
            this.ErrorMessageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorMessageContainer.Location = new System.Drawing.Point(16, 16);
            this.ErrorMessageContainer.Name = "ErrorMessageContainer";
            this.ErrorMessageContainer.Padding = new System.Windows.Forms.Padding(8);
            this.ErrorMessageContainer.Size = new System.Drawing.Size(576, 34);
            this.ErrorMessageContainer.TabIndex = 0;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorMessage.Font = new System.Drawing.Font("Arial", 12F);
            this.ErrorMessage.ForeColor = System.Drawing.Color.White;
            this.ErrorMessage.Location = new System.Drawing.Point(8, 8);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(112, 18);
            this.ErrorMessage.TabIndex = 0;
            this.ErrorMessage.Text = "Error message";
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
            this.Cancel.Text = "Back to menu";
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
            this.Ok.Text = "Open settings";
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
            // ErrorPage
            // 
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BottomSeparator);
            this.Controls.Add(this.BottomPanel);
            this.Name = "ErrorPage";
            this.PageName = "pages:error";
            this.PageTitle = "";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.ErrorPage_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ErrorMessageMargin.ResumeLayout(false);
            this.ErrorMessageMargin.PerformLayout();
            this.ErrorMessageContainer.ResumeLayout(false);
            this.ErrorMessageContainer.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.ActionButtonsFlow.ResumeLayout(false);
            this.ActionButtonsFlow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GUI.PhotonHeaderLabel ErrorHeader;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ErrorMessageMargin;
        private GUI.PhotonPanel ErrorMessageContainer;
        private GUI.PhotonLabel ErrorMessage;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.FlowLayoutPanel ActionButtonsFlow;
        private GUI.PhotonTrayButton Cancel;
        private GUI.PhotonTrayButton Ok;
        private System.Windows.Forms.Panel BottomSeparator;
    }
}
