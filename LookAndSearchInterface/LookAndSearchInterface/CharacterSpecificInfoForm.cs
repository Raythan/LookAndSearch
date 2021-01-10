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
    public partial class CharacterSpecificInfoForm : Form
    {
        private readonly string UrlForScrappingPage;
        private CharacterSpecificInfoScrapper ScrapperService;
        
        public CharacterSpecificInfoForm(string UrlForScrappingPageParam)
        {
            InitializeComponent();
            this.UrlForScrappingPage = UrlForScrappingPageParam;
            ScrapperService = new CharacterSpecificInfoScrapper(UrlForScrappingPageParam);
        }

        private void CharacterSpecificInfoForm_Load(object sender, EventArgs e)
        {
            Task.Run(() => ScrapperService.RecoverScrapperDataAsync(this));
        }
    }
}
