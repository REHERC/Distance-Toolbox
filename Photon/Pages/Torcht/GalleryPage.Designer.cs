namespace Photon.Pages.Torcht
{
    partial class GalleryPage
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalleryPage));
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ActionButtonsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel = new Photon.GUI.PhotonTrayButton();
            this.BottomSeparator = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BottomPanel.SuspendLayout();
            this.ActionButtonsFlow.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.BottomPanel.TabIndex = 13;
            // 
            // ActionButtonsFlow
            // 
            this.ActionButtonsFlow.Controls.Add(this.Cancel);
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
            // BottomSeparator
            // 
            this.BottomSeparator.BackColor = System.Drawing.Color.Silver;
            this.BottomSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomSeparator.Location = new System.Drawing.Point(0, 415);
            this.BottomSeparator.MaximumSize = new System.Drawing.Size(0, 1);
            this.BottomSeparator.MinimumSize = new System.Drawing.Size(0, 1);
            this.BottomSeparator.Name = "BottomSeparator";
            this.BottomSeparator.Size = new System.Drawing.Size(640, 1);
            this.BottomSeparator.TabIndex = 14;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Controls.Add(this.tableLayoutPanel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(16);
            this.MainPanel.Size = new System.Drawing.Size(640, 416);
            this.MainPanel.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::Photon.Properties.Resources.frame;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(80, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 440);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Photon.Properties.Resources._06;
            this.pictureBox1.Location = new System.Drawing.Point(45, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 24, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "I LOVE ME A GOOD TOGGLE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GalleryPage
            // 
            this.Controls.Add(this.BottomSeparator);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BottomPanel);
            this.Name = "GalleryPage";
            this.PageName = "pages:gallery";
            this.PageTitle = "Torcht";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.GalleryPage_Load);
            this.BottomPanel.ResumeLayout(false);
            this.ActionButtonsFlow.ResumeLayout(false);
            this.ActionButtonsFlow.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.FlowLayoutPanel ActionButtonsFlow;
        private GUI.PhotonTrayButton Cancel;
        private System.Windows.Forms.Panel BottomSeparator;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
