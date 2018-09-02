using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Photon.GUI.ToolPage
{
    [ToolboxItem(false)]
    public class ToolPage : UserControl
    {
        public string PageName{ get; set; }
        public string PageTitle { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.BackColor = Globals.Colors.BACKGROUND_Light;
        }
    }
}
