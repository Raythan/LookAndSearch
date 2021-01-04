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
        public PollsForm()
        {
            InitializeComponent();
            ScrapperService.RecoverScrapperData();
            FillUpdateComboTopicNames();
            lblPollsLastTimeUpdate.Text = $"Data da última atualização: {ScrapperService.LastUpdateEntity.ToString(Extender.DateTimeFormatBrazil)}";
        }

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
            dynamic source = new PollsEntity();
            ScrapperService.DictionaryEntity.TryGetValue(cboBoxPollsTopicsData.SelectedIndex.ToString(), out source);
            lblPollsStatusValue.Text = source.IsActive ? "Active" : "Closed";
            string[] endDateSplited = source.EndDate.Split(';');
            lblPollsEndDateValue.Text = new DateTime(Convert.ToInt32(endDateSplited[2]),
                Extender.GetMonthNumberFromAbreviate(endDateSplited[0]),
                Convert.ToInt32(endDateSplited[1])).ToString(Extender.DateFormatBrazil);
            lnkLblPollsTopicAnchorDisabled.Text = source.Anchor;
        }

        private void lnkLabelPollsToRedirectClick_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lnkLblPollsTopicAnchorDisabled.Text);
        }
    }
}
