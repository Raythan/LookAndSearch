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

namespace LookAndSearchInterface
{
    public partial class HighScoreForm : Form
    {
        public HighScoreForm()
        {
            InitializeComponent();
            WebScrapper.RecoverHighScoreData();
            BuildGridViewData();
        }

        private void BuildGridViewData()
        {
            this.dtGridViewHighScores.DataSource = null;

            List<HighScoreEntity> entities = new List<HighScoreEntity>();

            foreach (var item in WebScrapper.DictionaryHighScoreEntity)
                entities.Add(item.Value);

            this.dtGridViewHighScores.DataSource = new BindingList<HighScoreEntity>(entities);
            lblHighScoreLastTimeUpdate.Text = $"Data da última atualização: {WebScrapper.LastUpdateHighScoreEntity.ToString(Extender.DateTimeFormatBrazil)}";
        }

        private void btnHighScoreRefresh_Click(object sender, EventArgs e)
        {
            WebScrapper.RecoverHighScoreData();
            BuildGridViewData();
        }
    }
}
