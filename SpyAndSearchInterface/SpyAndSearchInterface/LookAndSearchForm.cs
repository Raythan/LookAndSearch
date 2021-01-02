using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SpyAndSearchInterface
{
    public partial class MainForm : Form
    {
        List<string> comboMenuItems = new List<string>()
        {
            "Selecione..",
            "Mundos",
            "HighScores",
            "Polls"
        };

        Dictionary<string, Form> panelForms = new Dictionary<string, Form>();

        public MainForm()
        {
            InitializeComponent();
            LoadPanelForms();
            LoadComboMenuItems();
        }

        private void LoadComboMenuItems()
        {
            cboBoxMenuSelector.DataSource = comboMenuItems;
        }

        private void LoadPanelForms()
        {
            panelForms = new Dictionary<string, Form>
            {
                { "Selecione..", new SelectionForm() },
                { "Mundos", new WorldsForm() },
                { "HighScores", new HighScoreForm() },
                { "Polls", new PollsForm() },
                { "Error", new ErrorContextForm() },
            };
        }

        private void cboBoxMenuSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.panelSpyAndSearch.Controls.Count > 0)
                this.panelSpyAndSearch.Controls.RemoveAt(0);

            try
            {
                if (panelForms.ContainsKey(cboBoxMenuSelector.Text))
                {
                    Form inputFormPanel;
                    panelForms.TryGetValue(cboBoxMenuSelector.Text, out inputFormPanel);
                    inputFormPanel.TopLevel = false;
                    inputFormPanel.AutoScroll = true;
                    this.panelSpyAndSearch.Controls.Add(inputFormPanel);
                    inputFormPanel.Show();
                }
            }
            catch (Exception ex)
            {
                Form inputFormPanel;
                panelForms.TryGetValue("Error", out inputFormPanel);
                inputFormPanel.TopLevel = false;
                inputFormPanel.AutoScroll = true;
                this.panelSpyAndSearch.Controls.Add(inputFormPanel);
                inputFormPanel.Show();
            }
        }
    }
}
