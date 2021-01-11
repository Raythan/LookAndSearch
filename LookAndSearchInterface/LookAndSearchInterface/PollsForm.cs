using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WebScrapperLib;
using WebScrapperLib.Models;
using WebScrapperLib.ScrapperController;

namespace LookAndSearchInterface
{
    public partial class PollsForm : Form
    {
        PollsScrapper ScrapperService = new PollsScrapper();
        private readonly string AlertMessageEmptyFields = "Before click you need refresh informations.";

        private void FillUpdateComboTopicNames()
        {
            SortedDictionary<string, string> source = new SortedDictionary<string, string>();

            foreach (var item in ScrapperService.DictionaryEntity)
                source.Add(item.Key, item.Value.Topic);

            cboBoxPollsTopicsData.DataSource = new BindingSource(source, null);
            cboBoxPollsTopicsData.DisplayMember = "Value";
            cboBoxPollsTopicsData.ValueMember = "Key";
            cboBoxPollsTopicsData.SelectedItem = 0;
        }

        private void cboBoxPollsTopicsData_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic entity = new PollsEntity();
            ScrapperService.DictionaryEntity.TryGetValue(cboBoxPollsTopicsData.SelectedIndex.ToString(), out entity);
            lblPollsStatusValue.Text = entity.IsActive ? "Active" : "Closed";
            string[] endDateSplited = entity.EndDate.Split(';');
            lblPollsEndDateValue.Text = Extender.FormatAuctionDateFromEntity(entity.EndDate, Extender.DateFormatBrazil);
            lnkLblPollsTopicAnchorDisabled.Text = entity.Anchor;
        }

        private void lnkLabelPollsToRedirectClick_DoubleClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lnkLblPollsTopicAnchorDisabled.Text) &&
                !lnkLblPollsTopicAnchorDisabled.Text.Contains("Disabled"))
                System.Diagnostics.Process.Start(lnkLblPollsTopicAnchorDisabled.Text);
            else
                MessageBox.Show(AlertMessageEmptyFields, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnRefreshPollsInfo_Click(object sender, EventArgs e)
        {
            lblPollsLastTimeUpdate.Text = $"Last time updated: || Refreshing... ||";
            ScrapperService.RecoverScrapperData();
            FillUpdateComboTopicNames();
            lblPollsLastTimeUpdate.Text = $"Last time updated: {ScrapperService.LastUpdateEntity.ToString(Extender.DateTimeFormatBrazil)}";
        }

        public PollsForm() => InitializeComponent();
    }
}
