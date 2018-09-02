using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Photon.GUI.ToolPage;
using Photon.Pages.Home;

namespace Photon.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Pages = new List<ToolPage>();
            InitializeComponent();
            AddPageSafe(new HomePage());
            SetPage("pages:home");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateGUIColors();
        }
        
        private void UpdateGUIColors()
        {
            this.BackColor = Globals.Colors.BACKGROUND_Light;
            MenuBar.BackColor = Globals.Colors.BACKGROUND_Dark;
            MenuBarSeparator.BackColor = Globals.Colors.PRIMARY_Main;
            PageNameBackground.BackColor = Globals.Colors.PRIMARY_Main;
            PageNameBackground.ForeColor = Globals.Colors.BACKGROUND_Light;
        }



















        public List<ToolPage> Pages;

        public void AddPageSafe(ToolPage page)
        {
            if (!HasPage(page.PageName)) AddPage(page);
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
            PageName.Text = currentpage.PageTitle;
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
                catch (Exception NullRef)
                { 

                }
            }
            return new GUI.ToolPage.ToolPage();
        }
    }
}
