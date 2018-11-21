using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Photon.GUI.ToolPage;
using Photon.Pages.Error;
using Photon.Pages.Home;
using Photon.Pages.Settings;

namespace Photon.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            
            Pages = new List<ToolPage>();
            InitializeComponent();
            Globals.Colors.OnColorsUpdated += new Action(delegate () {
                this.Invalidate();
                UpdateGUIColors();
            });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateGUIColors();
            AddPageSafe(new HomePage());
            SetPage("pages:home");
            AddPageSafe(new SettingsPage());

            if (Program.Arguments.Source != "pages:home")
            {
                ToolPage redirect = Tools.PageFromType(Program.Arguments.Source);
                AddPageSafe(redirect);
                SetPage(redirect.PageName);
            }
        }
        
        private void UpdateGUIColors()
        {
            this.BackColor = Globals.Colors.CONTROL_Light;
            MenuBar.BackColor = Globals.Colors.CONTROL_Dark;
            MenuBarSeparator.BackColor = Globals.Colors.PRIMARY_Main;
            PageNameBackground.BackColor = Globals.Colors.PRIMARY_Main;
            PageNameBackground.ForeColor = Globals.Colors.CONTROL_Light;

            foreach (ToolPage page in Pages)
            {
                page.Reload();
            }
        }
        
        private void BugReportBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/REHERC/Distance-Toolbox/issues");
        }









        public List<ToolPage> Pages;

        public void AddPageForce(ToolPage page)
        {
            if (!HasPage(page.PageName))
            {
                RemovePage(page.PageName);
            }
            AddPage(page);
        }

        public void AddPageSafe(ToolPage page)
        {
            if (!HasPage(page.PageName))
            {
                AddPage(page);
            }  
        }

        public void AddPage(ToolPage page)
        {
            Pages.Add(page);
            MainPanel.Controls.Add(Pages.Last());
            page.Dock = DockStyle.Fill;
        }

        public void RemovePage(string name)
        {
            ToolPage currentpage = GetPage(name);
            MainPanel.Controls.Remove(currentpage);
            Pages.Remove(currentpage);
            currentpage.Dispose();
        }

        public void SetPage(string name)
        {
            ToolPage currentpage = GetPage(name);
            foreach (ToolPage page in Pages)
            {
                page.Visible = false;
            }
            currentpage.Visible = true;
            PageNameBackground.Visible = (bool)(currentpage.PageTitle != "");
            PageName.Text = currentpage.PageTitle;
            currentpage.Reload();
        }

        public bool HasPage(string name)
        {
            foreach (ToolPage page in Pages)
            {
                if (page.PageName == name) return true;
            }
            return false;
        }

        public ToolPage GetPage(string name)
        {
            if (Pages != null && Pages.Count > 0)
            {
                try
                {
                    return new List<ToolPage>(from page in Pages where page.PageName == name select page).Last();
                }
                catch (Exception Greg)
                {
                    return new ErrorPage("Internal Error", "The page you requested for couldn't be loaded.", "If you see this message, please report it using the \"Bug report\" button on the top-right corner.");
                }
            }
            return new GUI.ToolPage.ToolPage();
        }
    }
}
