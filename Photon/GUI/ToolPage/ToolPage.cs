using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Photon.GUI.ToolPage
{
    [ToolboxItem(false)]
    public class ToolPage : UserControl
    {
        public ToolPage()
        {
            Globals.Colors.OnColorsUpdated += new Action(delegate () {
                this.Invalidate();
            });
        }

        public string PageName{ get; set; }
        public string PageTitle { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Reload();
        }

        public virtual void Reload()
        {
            this.BackColor = Globals.Colors.CONTROL_Light;
        }
    }

    public class PageRedirect
    {
        private Type PageType;
        public string Message;

        public PageRedirect(Type Page, string Message_) 
        {

            PageType = Page;
            this.Message = Message_;
        }

        public ToolPage GetPage()
        {
            return PageType.Assembly.CreateInstance(PageType.FullName) as ToolPage;
        }
    }
}
