using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib;
using WebScrapperLib.Models;
using WebScrapperLib.ScrapperController;

namespace LookAndSearchInterface
{
    public partial class HighScoreForm : Form
    {
        HighScoreScrapper Scrapper = new HighScoreScrapper();
        public HighScoreForm()
        {
            InitializeComponent();
            Scrapper.RecoverScrapperData();
            BuildGridViewData();
        }

        private void BuildGridViewData()
        {
            this.dtGridViewHighScores.DataSource = null;

            List<HighScoreEntity> entities = new List<HighScoreEntity>();

            foreach (var item in Scrapper.DictionaryEntity)
                entities.Add(item.Value);

            this.dtGridViewHighScores.DataSource = new BindingList<HighScoreEntity>(entities);
            lblHighScoreLastTimeUpdate.Text = $"Data da última atualização: {Scrapper.LastUpdateEntity.ToString(Extender.DateTimeFormatBrazil)}";
        }

        private void btnHighScoreRefresh_Click(object sender, EventArgs e)
        {
            Scrapper.RecoverScrapperData();
            BuildGridViewData();
        }
    }
}
