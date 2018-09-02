using System;
using System.Windows.Forms;

namespace Photon.GUI
{
    class PhotonLabel : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            ForeColor = Globals.Colors.TEXT_Light;
            base.OnPaint(e);
        }
    }
}
