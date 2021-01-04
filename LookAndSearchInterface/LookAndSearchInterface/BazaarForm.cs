using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib.ScrapperController;

namespace LookAndSearchInterface
{
    public partial class BazaarForm : Form
    {
        BazaarScrapper ScrapperService = new BazaarScrapper();
        public BazaarForm()
        {
            InitializeComponent();
            ScrapperService.RecoverScrapperData();
            //FillUpdateComboTopicNames();
            //lblPollsLastTimeUpdate.Text = $"Data da última atualização: {ScrapperService.LastUpdateEntity.ToString(Extender.DateTimeFormatBrazil)}";
        }
    }
}
