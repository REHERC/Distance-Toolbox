using System;
using System.Windows.Forms;

namespace Photon.GUI
{
    class PhotonPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = Globals.Colors.PRIMARY_Main;
            base.OnPaint(e);
            
        }
    }
}
