using System;
using System.Windows.Forms;

namespace Photon.GUI
{
    class PhotonTextBox : TextBox
    {
        public PhotonTextBox()
        {
            Globals.Colors.OnColorsUpdated += new Action(delegate () {
                this.Invalidate();
            });

            BorderStyle = BorderStyle.None;
            BackColor = Globals.Colors.CONTROL_Lighter;
            ForeColor = Globals.Colors.PRIMARY_Main;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            ForeColor = Globals.Colors.PRIMARY_Main;
        }
    }
}
