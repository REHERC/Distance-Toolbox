using System.Collections.Generic;
using System.Linq;

namespace Photon.Pages.Settings
{
    public partial class SettingsPage : Photon.GUI.ToolPage.ToolPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SettingsPage_Load(object sender, System.EventArgs e)
        {
            BottomPanel.BackColor = Globals.Colors.BACKGROUND_Dark;
            BottomSeparator.BackColor = Globals.Colors.PRIMARY_Main;
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            Globals.Variables.MainForm.SetPage("pages:home");
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
            }
        }
    }
}
