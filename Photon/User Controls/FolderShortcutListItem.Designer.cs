namespace Photon.User_Controls
{
    partial class FolderShortcutListItem
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.Panel();
            this.Extend = new System.Windows.Forms.Panel();
            this.MainPanel = new Photon.GUI.PhotonPanel();
            this.InnerBorder = new System.Windows.Forms.Panel();
            this.Content = new Photon.GUI.PhotonPanel();
            this.DescriptionBox = new Photon.GUI.PhotonLabel();
            this.BottomLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OpenBtn = new Photon.GUI.PhotonButtonSimple();
            this.RightLine = new System.Windows.Forms.Panel();
            this.LeftLine = new System.Windows.Forms.Panel();
            this.ExtendBar = new Photon.GUI.PhotonPanel();
            this.TitleBackground = new Photon.GUI.PhotonPanel();
            this.TitleBox = new Photon.GUI.PhotonLabel();
            this.Header.SuspendLayout();
            this.Extend.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.InnerBorder.SuspendLayout();
            this.Content.SuspendLayout();
            this.BottomLayout.SuspendLayout();
            this.TitleBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.Extend);
            this.Header.Controls.Add(this.TitleBackground);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.Header.Size = new System.Drawing.Size(256, 32);
            this.Header.TabIndex = 1;
            // 
            // Extend
            // 
            this.Extend.Controls.Add(this.ExtendBar);
            this.Extend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Extend.Location = new System.Drawing.Point(68, 4);
            this.Extend.Name = "Extend";
            this.Extend.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.Extend.Size = new System.Drawing.Size(188, 28);
            this.Extend.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(109)))), ((int)(((byte)(145)))));
            this.MainPanel.Controls.Add(this.InnerBorder);
            this.MainPanel.Controls.Add(this.BottomLayout);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 32);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(4);
            this.MainPanel.Size = new System.Drawing.Size(256, 128);
            this.MainPanel.TabIndex = 0;
            // 
            // InnerBorder
            // 
            this.InnerBorder.BackColor = System.Drawing.Color.White;
            this.InnerBorder.Controls.Add(this.Content);
            this.InnerBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerBorder.Location = new System.Drawing.Point(4, 4);
            this.InnerBorder.Name = "InnerBorder";
            this.InnerBorder.Padding = new System.Windows.Forms.Padding(4);
            this.InnerBorder.Size = new System.Drawing.Size(248, 80);
            this.InnerBorder.TabIndex = 4;
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(109)))), ((int)(((byte)(145)))));
            this.Content.Controls.Add(this.DescriptionBox);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(4, 4);
            this.Content.Name = "Content";
            this.Content.Padding = new System.Windows.Forms.Padding(8);
            this.Content.Size = new System.Drawing.Size(240, 72);
            this.Content.TabIndex = 0;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.DescriptionBox.ForeColor = System.Drawing.Color.White;
            this.DescriptionBox.Location = new System.Drawing.Point(8, 8);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(224, 56);
            this.DescriptionBox.TabIndex = 1;
            this.DescriptionBox.Text = "Description";
            // 
            // BottomLayout
            // 
            this.BottomLayout.ColumnCount = 3;
            this.BottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.BottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BottomLayout.Controls.Add(this.OpenBtn, 1, 1);
            this.BottomLayout.Controls.Add(this.RightLine, 2, 1);
            this.BottomLayout.Controls.Add(this.LeftLine, 0, 1);
            this.BottomLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomLayout.Location = new System.Drawing.Point(4, 84);
            this.BottomLayout.Name = "BottomLayout";
            this.BottomLayout.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.BottomLayout.RowCount = 2;
            this.BottomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.BottomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.BottomLayout.Size = new System.Drawing.Size(248, 40);
            this.BottomLayout.TabIndex = 2;
            // 
            // OpenBtn
            // 
            this.OpenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.OpenBtn.Location = new System.Drawing.Point(58, 12);
            this.OpenBtn.Margin = new System.Windows.Forms.Padding(4);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(131, 24);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            this.OpenBtn.MouseEnter += new System.EventHandler(this.OpenBtn_MouseEnter);
            this.OpenBtn.MouseLeave += new System.EventHandler(this.OpenBtn_MouseLeave);
            // 
            // RightLine
            // 
            this.RightLine.BackColor = System.Drawing.Color.White;
            this.RightLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightLine.Location = new System.Drawing.Point(205, 22);
            this.RightLine.Margin = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.RightLine.Name = "RightLine";
            this.RightLine.Size = new System.Drawing.Size(23, 4);
            this.RightLine.TabIndex = 1;
            // 
            // LeftLine
            // 
            this.LeftLine.BackColor = System.Drawing.Color.White;
            this.LeftLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftLine.Location = new System.Drawing.Point(20, 22);
            this.LeftLine.Margin = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.LeftLine.Name = "LeftLine";
            this.LeftLine.Size = new System.Drawing.Size(22, 4);
            this.LeftLine.TabIndex = 2;
            // 
            // ExtendBar
            // 
            this.ExtendBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(109)))), ((int)(((byte)(145)))));
            this.ExtendBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExtendBar.Location = new System.Drawing.Point(4, 0);
            this.ExtendBar.Name = "ExtendBar";
            this.ExtendBar.Size = new System.Drawing.Size(184, 24);
            this.ExtendBar.TabIndex = 0;
            // 
            // TitleBackground
            // 
            this.TitleBackground.AutoSize = true;
            this.TitleBackground.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TitleBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(109)))), ((int)(((byte)(145)))));
            this.TitleBackground.Controls.Add(this.TitleBox);
            this.TitleBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleBackground.Location = new System.Drawing.Point(0, 4);
            this.TitleBackground.Name = "TitleBackground";
            this.TitleBackground.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.TitleBackground.Size = new System.Drawing.Size(68, 28);
            this.TitleBackground.TabIndex = 0;
            // 
            // TitleBox
            // 
            this.TitleBox.AutoSize = true;
            this.TitleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleBox.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.TitleBox.ForeColor = System.Drawing.Color.White;
            this.TitleBox.Location = new System.Drawing.Point(12, 4);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(44, 19);
            this.TitleBox.TabIndex = 0;
            this.TitleBox.Text = "Title";
            // 
            // FolderShortcutListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Header);
            this.Name = "FolderShortcutListItem";
            this.Size = new System.Drawing.Size(256, 160);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Extend.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.InnerBorder.ResumeLayout(false);
            this.Content.ResumeLayout(false);
            this.BottomLayout.ResumeLayout(false);
            this.TitleBackground.ResumeLayout(false);
            this.TitleBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GUI.PhotonPanel MainPanel;
        private GUI.PhotonButtonSimple OpenBtn;
        private System.Windows.Forms.Panel RightLine;
        private System.Windows.Forms.TableLayoutPanel BottomLayout;
        private System.Windows.Forms.Panel LeftLine;
        private System.Windows.Forms.Panel Header;
        private GUI.PhotonPanel TitleBackground;
        private GUI.PhotonLabel TitleBox;
        private System.Windows.Forms.Panel InnerBorder;
        private GUI.PhotonPanel Content;
        private GUI.PhotonLabel DescriptionBox;
        private System.Windows.Forms.Panel Extend;
        private GUI.PhotonPanel ExtendBar;
    }
}
