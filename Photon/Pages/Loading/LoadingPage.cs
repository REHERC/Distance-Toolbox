namespace Photon.Pages.Loading
{
    public partial class LoadingPage : Photon.GUI.ToolPage.ToolPage
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        public override void Reload()
        {
            base.Reload();
            EmptyContainer.BackColor = Globals.Colors.GRAYSCALE_Light;
        }

        private void ManagerSettingsCreatePage_Load(object sender, System.EventArgs e)
        {
            Reload();
        }
    }
}
