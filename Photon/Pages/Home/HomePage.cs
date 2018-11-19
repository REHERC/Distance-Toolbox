using System;
using System.Security.Permissions;
using System.Windows.Forms;
using Photon.GUI.ToolPage;
using Photon.Pages.Backups;
using Photon.Pages.Error;
using Photon.Pages.Settings;
using Photon.Pages.Spectrum;

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
            Globals.Variables.MainForm.AddPageForce(new SettingsPage());
            Globals.Variables.MainForm.SetPage("pages:settings");
        }

        public void SpectrumPluginsBtn_Click(object sender, EventArgs e)
        {
            Globals.Settings.General.Load();

            if (!Utils.IsDistanceDirValid())
            {
                Globals.Variables.MainForm.AddPageForce(new ErrorPage("", "Game directory error.", "The distance game directory couldn't be located.\n\nThe value might not have been set, you can go to the settings to change it.", new PageRedirect(typeof(SettingsPage), "Go to settings")));
                Globals.Variables.MainForm.SetPage("pages:error");
                return;
            }

            if (!Utils.IsSpectrumInstalled())
            {
                Globals.Variables.MainForm.AddPageForce(new ErrorPage("", "Spectrum installation not found.", "A spectrum installation couldn't be found.\n\nIf you have installed spectrum:\n    - Check all the files are present\n    - Check that spectrum is up to date.", null));
                Globals.Variables.MainForm.SetPage("pages:error");
                return;
            }

            if (!Utils.SpectrumManagerSettingsExists())
            {
                Globals.Variables.MainForm.AddPageForce(new ErrorPage("", "Spectrum manager settings not found.", "The spectrum manager settings file \n\"Spectrum\\Settings\\ManagerSettings.json\" couldn't be found.", new PageRedirect(typeof(ManagerSettingsCreatePage), "Create the settings file")));
                Globals.Variables.MainForm.SetPage("pages:error");
                return;
            }

            Globals.Variables.MainForm.AddPageForce(new ManagePluginsMainPage());
            Globals.Variables.MainForm.SetPage("pages:manageplugins.main");
        }

        private void RunGameBtn_Click(object sender, EventArgs e)
        {
            if (Utils.IsDistanceDirValid())
            {
                System.Diagnostics.Process.Start($@"{Globals.Settings.General.Data.GameDir}\Distance.exe");
            }
            else
            {
                Globals.Variables.MainForm.AddPageForce(new ErrorPage("", "Game directory error.", "The distance game directory couldn't be located.\n\nThe value might not have been set, you can go to the settings to change it.", new PageRedirect(typeof(SettingsPage), "Go to settings")));
                Globals.Variables.MainForm.SetPage("pages:error");
            }
        }

        public override void Reload()
        {
            base.Reload();
            Separator_1.BackColor = Globals.Colors.GRAYSCALE_Darker;
            GameCategoryContainer.BackColor = Globals.Colors.GRAYSCALE_Dark;
            SpectrumCategoryContainer.BackColor = Globals.Colors.GRAYSCALE_Dark;
            UtilitiesCategoryContainer.BackColor = Globals.Colors.GRAYSCALE_Dark;
            OnlineCategoryContainer.BackColor = Globals.Colors.GRAYSCALE_Dark;

            SettingsCategoryContainer.BackColor = Globals.Colors.GRAYSCALE_Dark;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Reload();
            FocusForScroll();
        }

        private void BackupBtn_Click(object sender, EventArgs e)
        {
            if (!Tools.IsRunAsAdmin())
            {
                if (Tools.Elevate("--source pages:backups.main --nosplash " + Tools.GetWindowPositionArgs()))
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
            else
            {
                Globals.Variables.MainForm.AddPageSafe(new BackupsMainPage());
                Globals.Variables.MainForm.SetPage("pages:backups.main");
            }
        }

        private void HomePage_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                FocusForScroll();
            }
        }

        void FocusForScroll()
        {
            ToolsPanel.Select();
            ToolsPanel.Focus();
        }

        private void GameCategory_Click(object sender, EventArgs e)
        {
            GameHeader.Select();
        }

        private void SpectrumCategory_Click(object sender, EventArgs e)
        {
            SpectrumHeader.Select();
        }

        private void UtilitiesCategory_Click(object sender, EventArgs e)
        {
            UtilitiesHeader.Select();
        }

        private void OnlineCategory_Click(object sender, EventArgs e)
        {
            OnlineHeader.Select();
        }
    }
}
