using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WebScrapperLib;
using WebScrapperLib.Models;

namespace SpyAndSearchInterface
{
    public partial class PollsForm : Form
    {
        public PollsForm()
        {
            InitializeComponent();
            WebScrapper.RecoverPollsData();
            FillUpdateComboTopicNames();
            lblPollsLastTimeUpdate.Text = $"Data da última atualização: {WebScrapper.LastUpdatePollsEntity.ToString(Extender.DateTimeFormatBrazil)}";
        }

        private void FillUpdateComboTopicNames()
        {
            SortedDictionary<string, string> source = new SortedDictionary<string, string>();

            foreach (var item in WebScrapper.DictionaryPollsEntity)
                source.Add(item.Key, item.Value.Topic);

            cboBoxPollsTopicsData.DataSource = new BindingSource(source, null);
            cboBoxPollsTopicsData.DisplayMember = "Value";
            cboBoxPollsTopicsData.ValueMember = "Key";
            cboBoxPollsTopicsData.SelectedItem = 0;
        }

        private void cboBoxPollsTopicsData_SelectedIndexChanged(object sender, EventArgs e)
        {
            PollsEntity source = new PollsEntity();
            WebScrapper.DictionaryPollsEntity.TryGetValue(cboBoxPollsTopicsData.SelectedIndex.ToString(), out source);
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
