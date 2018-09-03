using Photon.GUI.ToolPage;

namespace Photon.Pages.Error
{
    public partial class ErrorPage : Photon.GUI.ToolPage.ToolPage  
    {
        public PageRedirect Redirect = null;

        public ErrorPage()
        {
            InitializeComponent();
            FinalizeComponent();
        }

        public ErrorPage(string PageTitle_,string Title_,string Message_,PageRedirect Redirect_ = null)
        {
            InitializeComponent();

            this.PageTitle = PageTitle_;
            this.ErrorHeader.Text = Title_;
            this.ErrorMessage.Text = Message_;
            this.ErrorMessageContainer.Visible = (bool)(Message_.Length > 0);

            Redirect = Redirect_;

            FinalizeComponent();
        }

        public ErrorPage(string Title_, string Message_, PageRedirect Redirect_ = null)
        {
            InitializeComponent();
            
            this.ErrorHeader.Text = Title_;
            this.ErrorMessageContainer.Visible = (bool)(Message_.Length > 0);
            this.ErrorMessage.Text = Message_;

            Redirect = Redirect_;

            FinalizeComponent();
        }

        public void FinalizeComponent()
        {
            if (Redirect != null)
            {
                Ok.Text = Redirect.Message;
            }
            else
            {
                Ok.Visible = false;
            }
        }

        private void ErrorPage_Load(object sender, System.EventArgs e)
        {
            BottomPanel.BackColor = Globals.Colors.CONTROL_Dark;
            BottomSeparator.BackColor = Globals.Colors.PRIMARY_Main;
        }

        private void Ok_Click(object sender, System.EventArgs e)
        {
            Globals.Variables.MainForm.AddPageForce(Redirect.GetPage());
            if (Redirect != null)
            {
                Globals.Variables.MainForm.SetPage(Redirect.GetPage().PageName);
                Globals.Variables.MainForm.RemovePage(this.PageName);
            }
        }

        private void Cancel_Click(object sender, System.EventArgs e)
        {
            Globals.Variables.MainForm.SetPage("pages:home");
            Globals.Variables.MainForm.RemovePage(this.PageName);
        }
    }
}
