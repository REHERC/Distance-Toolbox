using System.Collections.Generic;
using System.Linq;
using Photon.Serialization.Data;

namespace Photon.Pages.Settings
{
    public partial class SettingsPage : Photon.GUI.ToolPage.ToolPage
    {
        private AppSettings GeneralSettings;
        
        public SettingsPage()
        {
            InitializeComponent();
            GeneralSettings = Globals.Settings.General.Data;
            GameDirBox.Text = GeneralSettings.GameDir;
        }

        private void SettingsPage_Load(object sender, System.EventArgs e)
        {
            BottomPanel.BackColor = Globals.Colors.CONTROL_Dark;
            BottomSeparator.BackColor = Globals.Colors.PRIMARY_Main;
        }
        
        private void GamePathBtn_Click(object sender, System.EventArgs e)
        {
            Microsoft.Win32.OpenFileDialog Dialog = new Microsoft.Win32.OpenFileDialog();
            Dialog.FileName = "Distance.exe"; // Default file name
            Dialog.DefaultExt = ".exe"; // Default file extension
            Dialog.Filter = "Distance.exe|Distance.exe"; // Filter files by extension
            if (Dialog.ShowDialog() == true)
            {
                string file = Dialog.FileName;
                string path = file.Substring(0, file.Length - new List<string>(file.Split('\\')).Last().Length);
                
                GameDirBox.Text = path;
                GeneralSettings.GameDir = path;
            }
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Ok_Click(object sender, System.EventArgs e)
        {
            Globals.Settings.General.Data = GeneralSettings;
            Globals.Settings.General.Save();
            Close();
        }

        private void Close() {
            Globals.Settings.General.Load();
            Globals.Variables.MainForm.SetPage("pages:home");
        }
    }
}
