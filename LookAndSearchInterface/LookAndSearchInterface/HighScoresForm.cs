using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using WebScrapperLib.Models;
using WebScrapperLib.Utils;
using WebScrapperLib.ScrapperController;

namespace LookAndSearchInterface
{
    public partial class HighScoreForm : Form
    {
        HighScoreScrapper Scrapper = new HighScoreScrapper();
        
        private void BuildGridViewData()
        {
            Scrapper.RecoverScrapperData();
            this.dtGridViewHighScores.DataSource = null;

            List<HighScoreEntity> entities = new List<HighScoreEntity>();

            foreach (var item in Scrapper.DictionaryEntity)
                entities.Add(item.Value);

            this.dtGridViewHighScores.DataSource = new BindingList<HighScoreEntity>(entities);
            lblHighScoreLastTimeUpdate.Text = $"Last time updated: {Scrapper.LastUpdateEntity.ToString(Extender.GetDateFormatFromKey(0))}";
        }

        private void btnHighScoreRefresh_Click(object sender, EventArgs e) => BuildGridViewData();

        public HighScoreForm() => InitializeComponent();
    }
}
