namespace Photon.User_Controls
{
    partial class SpectrumPluginListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.Plugin = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.EnabledBox = new Photon.GUI.PhotonCheckButton();
            this.photonButtonSimple1 = new Photon.GUI.PhotonButtonSimple();
            this.BottomPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottomPanel.Controls.Add(this.photonButtonSimple1);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(8, 58);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Padding = new System.Windows.Forms.Padding(16, 4, 16, 4);
            this.BottomPanel.Size = new System.Drawing.Size(454, 32);
            this.BottomPanel.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.Controls.Add(this.MainContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(8, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(16, 16, 16, 8);
            this.MainPanel.Size = new System.Drawing.Size(454, 58);
            this.MainPanel.TabIndex = 2;
            // 
            // MainContainer
            // 
            this.MainContainer.AutoSize = true;
            this.MainContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainContainer.ColumnCount = 3;
            this.MainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainContainer.Controls.Add(this.Author, 2, 0);
            this.MainContainer.Controls.Add(this.EnabledBox, 0, 0);
            this.MainContainer.Controls.Add(this.Plugin, 1, 0);
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(16, 16);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.RowCount = 1;
            this.MainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainContainer.Size = new System.Drawing.Size(422, 34);
            this.MainContainer.TabIndex = 0;
            // 
            // Plugin
            // 
            this.Plugin.AutoSize = true;
            this.Plugin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plugin.Font = new System.Drawing.Font("Arial Black", 16F);
            this.Plugin.Location = new System.Drawing.Point(88, 0);
            this.Plugin.Margin = new System.Windows.Forms.Padding(8, 0, 0, 2);
            this.Plugin.Name = "Plugin";
            this.Plugin.Size = new System.Drawing.Size(163, 32);
            this.Plugin.TabIndex = 0;
            this.Plugin.Text = "Plugin name";
            this.Plugin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Author.Font = new System.Drawing.Font("Arial Black", 12F);
            this.Author.Location = new System.Drawing.Point(259, 0);
            this.Author.Margin = new System.Windows.Forms.Padding(8, 0, 0, 2);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(163, 32);
            this.Author.TabIndex = 1;
            this.Author.Text = "by Author";
            this.Author.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnabledBox
            // 
            this.EnabledBox.Checked = false;
            this.EnabledBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnabledBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnabledBox.Location = new System.Drawing.Point(0, 2);
            this.EnabledBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.EnabledBox.Name = "EnabledBox";
            this.EnabledBox.Size = new System.Drawing.Size(80, 32);
            this.EnabledBox.TabIndex = 0;
            this.EnabledBox.Text = "Off";
            // 
            // photonButtonSimple1
            // 
            this.photonButtonSimple1.AutoSize = true;
            this.photonButtonSimple1.Dock = System.Windows.Forms.DockStyle.Right;
            this.photonButtonSimple1.Font = new System.Drawing.Font("Arial Black", 10F);
            this.photonButtonSimple1.Location = new System.Drawing.Point(347, 4);
            this.photonButtonSimple1.Name = "photonButtonSimple1";
            this.photonButtonSimple1.Size = new System.Drawing.Size(91, 24);
            this.photonButtonSimple1.TabIndex = 0;
            this.photonButtonSimple1.Text = "Configure";
            this.photonButtonSimple1.UseVisualStyleBackColor = true;
            // 
            // SpectrumPluginListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BottomPanel);
            this.Name = "SpectrumPluginListItem";
            this.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.Size = new System.Drawing.Size(470, 98);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.MainContainer.ResumeLayout(false);
            this.MainContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label Plugin;
        private System.Windows.Forms.TableLayoutPanel MainContainer;
        private GUI.PhotonCheckButton EnabledBox;
        private System.Windows.Forms.Label Author;
        private GUI.PhotonButtonSimple photonButtonSimple1;
    }
}
