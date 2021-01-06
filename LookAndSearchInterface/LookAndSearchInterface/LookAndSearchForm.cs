﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib;

namespace LookAndSearchInterface
{
    public partial class MainForm : Form
    {
        List<string> comboMenuItems = new List<string>()
        {
            "Selecione..",
            "Bazaar",
            "HighScores",
            "Mundos",
            "Polls"
        };

        Dictionary<string, Form> panelForms = new Dictionary<string, Form>();

        public MainForm()
        {
            InitializeComponent();
            LoadPanelForms();
            LoadComboMenuItems();
            FillUpdateAssemblyVersion();
        }

        private void FillUpdateAssemblyVersion()
        {
            string InterfaceVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            string LibVersion = Extender.GetLibVersionFromAssembly();
            this.Text = $"Look and search! v{InterfaceVersion} lib{LibVersion}";
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
                { "Error", new ErrorContextForm() },
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
