using Photon.Serialization.Data;
using Photon.User_Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Photon.Pages.GameFiles
{
    public partial class BrowseGameFilesPage : Photon.GUI.ToolPage.ToolPage
    {
        public BrowseGameFilesPage()
        {
            InitializeComponent();


            FolderLayout.Controls.Clear();

            AppSettings Settings = Globals.Settings.General.Data;
            string Userdocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            

            FolderLayout.Controls.Add(new FolderShortcutListItem(
                $@"{Settings.GameDir}",
                "Game",
                "Contains the game executable"
            ));

            FolderLayout.Controls.Add(new FolderShortcutListItem(
                $@"{Settings.GameDir}\Screenshots",
                "Editor screenshots",
                "Contains screenshots saved using the editor"
            ));

            FolderLayout.Controls.Add(new FolderShortcutListItem(
                $@"{Settings.GameDir}\Distance_Data\Spectrum",
                "Spectrum",
                "Contains the spectrum extension system's files (configuration and plugin files)"
            ));

            FolderLayout.Controls.Add(new FolderShortcutListItem(
                $@"{Userdocs}\my games\Distance\Settings",
                "Settings",
                "Contains the game settings files"
            ));

            FolderLayout.Controls.Add(new FolderShortcutListItem(
                $@"{Userdocs}\my games\Distance\Profiles",
                "Proffiles",
                "Contains the profiles created within the game"
            ));

            FolderLayout.Controls.Add(new FolderShortcutListItem(
                $@"{Userdocs}\my games\Distance\CustomObjects",
                "Custom objects",
                "Contains your custom objects made in the editor"
            ));

            FolderLayout.Controls.Add(new FolderShortcutListItem(
                $@"{Userdocs}\my games\Distance\Levels\MyLevels",
                "Editor levels",
                "Contains your editor levels"
            ));

            FolderLayout.Controls.Add(new FolderShortcutListItem(
                $@"{Userdocs}\my games\Distance\LevelPlaylists",
                "Level playlists",
                "Contains custom level playlists"
            ));

            FolderLayout.Controls.Add(new FolderShortcutListItem(
                $@"{Userdocs}\my games\Distance\ControlSchemes",
                "Control schemes",
                "Contains your custom control schemes"
            ));


            foreach (FolderShortcutListItem item in FolderLayout.Controls)
            {
                //item.Dock = DockStyle.Fill;
                item.Margin = new Padding(2, 0, 2, 0);
                item.Size = new Size(290, 160);
            }

            FolderLayout.Controls[FolderLayout.Controls.Count - 1].Margin = new Padding(2, 0, 2, 16);

            /*FolderLayout.Controls.Add(new Panel()
            {
                Dock = DockStyle.Bottom,
                Height = 16
            });*/
        }

        public override void Reload()
        {
            base.Reload();
            BottomPanel.BackColor = Globals.Colors.CONTROL_Dark;
            BottomSeparator.BackColor = Globals.Colors.PRIMARY_Main;
        }

        private void BrowseGameFilesPage_Load(object sender, System.EventArgs e)
        {
            Reload();
        }

        private void Cancel_Click(object sender, System.EventArgs e)
        {
            Globals.Variables.MainForm.SetPage("pages:home");
            Globals.Variables.MainForm.RemovePage(this.PageName);
        }
    }
}
