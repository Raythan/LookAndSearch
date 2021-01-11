using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib;

namespace LookAndSearchInterface
{
    public partial class MainForm : Form
    {
        private readonly string IconUrl = "https://raw.githubusercontent.com/Raythan/LookAndSearch/main/LookAndSearchInterface/WebScrapperLib/Images/robot.ico";
        List<string> comboMenuItems = new List<string>()
        {
            "Selecione..",
            "Bazaar",
            "HighScores",
            "Mundos",
            "Polls",
            "About"
        };

        Dictionary<string, Form> panelForms = new Dictionary<string, Form>();

        public MainForm()
        {
            InitializeComponent();
            this.Icon = Extender.RecoverIconFromUrl(IconUrl, "IconSize18x18", "GitHubHeaders");
            LoadPanelForms();
            LoadComboMenuItems();
            FillUpdateAssemblyVersion();
        }

        private void FillUpdateAssemblyVersion()
        {
            string InterfaceVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            string LibVersion = Extender.GetLibVersionFromAssembly();
            this.Text = $"Watch Info! v{InterfaceVersion} lib{LibVersion}";
        }

        private void LoadComboMenuItems() => cboBoxMenuSelector.DataSource = comboMenuItems;

        private void LoadPanelForms()
        {
            panelForms = new Dictionary<string, Form>
            {
                { "Selecione..", new SelectionForm() },
                { "Bazaar", new BazaarForm() },
                { "HighScores", new HighScoreForm() },
                { "Mundos", new WorldsForm() },
                { "Polls", new PollsForm() },
                { "About", new AboutForm() },
            };
        }

        private void cboBoxMenuSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.panelLookAndSearch.Controls.Count > 0)
                this.panelLookAndSearch.Controls.RemoveAt(0);

            try
            {
                if (panelForms.ContainsKey(cboBoxMenuSelector.Text))
                {
                    Form inputFormPanel;
                    panelForms.TryGetValue(cboBoxMenuSelector.Text, out inputFormPanel);
                    inputFormPanel.TopLevel = false;
                    inputFormPanel.AutoScroll = true;
                    this.panelLookAndSearch.Controls.Add(inputFormPanel);
                    inputFormPanel.Show();
                }
            }
            catch (Exception ex)
            {
                Form inputFormPanel;
                panelForms.TryGetValue("Error", out inputFormPanel);
                inputFormPanel.TopLevel = false;
                inputFormPanel.AutoScroll = true;
                this.panelLookAndSearch.Controls.Add(inputFormPanel);
                inputFormPanel.Show();
            }
        }
    }
}
