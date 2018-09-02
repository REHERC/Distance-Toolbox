using System;
using Photon.Pages.Settings;

namespace Photon.Pages.Home
{
    internal partial class HomePage : Photon.GUI.ToolPage.ToolPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Globals.Variables.MainForm.AddPageSafe(new SettingsPage());
            Globals.Variables.MainForm.SetPage("pages:settings");
        }
    }
}
