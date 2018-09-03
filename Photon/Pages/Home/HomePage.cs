﻿using System;
using Photon.GUI.ToolPage;
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

        private void SpectrumPluginsBtn_Click(object sender, EventArgs e)
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

            Globals.Variables.MainForm.AddPageForce(new ManagePluginsMainPage());
            Globals.Variables.MainForm.SetPage("pages:manageplugins.main");
        }
    }
}