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

namespace SpyAndSearchInterface
{
    public partial class frmHighScore : Form
    {
        public frmHighScore()
        {
            InitializeComponent();
            WebScrapper.RecoverHighScoreNames();
            BuildGridViewData();
        }

        private void BuildGridViewData()
        {
            this.dtGridViewHighScores.DataSource = null;

            List<HighScoreEntity> entities = new List<HighScoreEntity>();

            foreach (var item in WebScrapper.DictionaryHighScoreEntity)
                entities.Add(item.Value);

            this.dtGridViewHighScores.DataSource = new BindingList<HighScoreEntity>(entities);
        }
    }
}
