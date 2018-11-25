using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Photon.Pages.Torcht
{
    public partial class GalleryPage : Photon.GUI.ToolPage.ToolPage
    {
        public GalleryPage()
        {
            InitializeComponent();
        }

        public override void Reload()
        {
            base.Reload();
            BottomPanel.BackColor = Globals.Colors.CONTROL_Dark;
            BottomSeparator.BackColor = Globals.Colors.PRIMARY_Main;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Globals.Variables.MainForm.SetPage("pages:home");
            Globals.Variables.MainForm.RemovePage(this.PageName);
        }

        private void GalleryPage_Load(object sender, EventArgs e)
        {
            this.Reload();
        }
    }
}
