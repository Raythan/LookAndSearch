using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib;
using WebScrapperLib.Models;
using WebScrapperLib.ScrapperController;

namespace LookAndSearchInterface
{
    public partial class BazaarForm : Form
    {
        List<string> listVocationFilter = new List<string>
        {
            "Selecione",
            "Druid",
            "Knight",
            "Paladin",
            "Sorcerer"
        };
        
        BazaarScrapper ScrapperService = new BazaarScrapper();
        
        public BazaarForm()
        {
            InitializeComponent();
            cboBoxVocationFilter.DataSource = listVocationFilter;
            FillUpdateComboWorldNames();
        }

        public void FillUpdateTxtBoxCharacterNames()
        {
            if (ScrapperService.DictionaryEntity == null || ScrapperService.DictionaryEntity.Count() == 0)
                return;

            Dictionary<string, dynamic> dicAux = ScrapperService.DictionaryEntity;

            if (!string.IsNullOrEmpty(cboBoxVocationFilter.Text) && !cboBoxVocationFilter.Text.Contains("Selecione"))
                dicAux = dicAux.Where(w => ((BazaarEntity)w.Value).Vocation.Contains(cboBoxVocationFilter.Text))
                    .ToDictionary(p => p.Key, p => p.Value);

            if (!string.IsNullOrEmpty(cboBoxWorldFilter.Text) && !cboBoxWorldFilter.Text.Contains("Selecione"))
                dicAux = dicAux.Where(w => ((BazaarEntity)w.Value).World.Equals(cboBoxWorldFilter.Text))
                    .ToDictionary(p => p.Key, p => p.Value);

            if (numUpDownBidMaxFilter.Value > 0)
                dicAux = dicAux.Where(w => Convert.ToInt64(((BazaarEntity)w.Value).MinimumCurrentBid.Replace(",", "")) <= numUpDownBidMaxFilter.Value)
                    .ToDictionary(p => p.Key, p => p.Value);
            
            if(chkBoxIsBiddedFilter.Checked)
                dicAux = dicAux.Where(w => !((BazaarEntity)w.Value).IsBidded)
                    .ToDictionary(p => p.Key, p => p.Value);

            if(numUpDownLevelFilter.Value > 0)
                dicAux = dicAux.Where(w => Convert.ToInt64(((BazaarEntity)w.Value).Level) >= numUpDownLevelFilter.Value)
                    .ToDictionary(p => p.Key, p => p.Value);

            lstBoxCharacterNamesValues.DataSource = dicAux.Keys.ToList();
        }

        public void FillUpdateComboWorldNames()
        {
            WorldScrapper WorldScrapperService = new WorldScrapper();
            WorldScrapperService.RecoverScrapperData();
            //WorldScrapperService.DictionaryEntity.Add("Selecione", new WorldEntity());
            Dictionary<string, dynamic> worldsSource = new Dictionary<string, dynamic>();
            worldsSource.Add("Selecione", new WorldEntity());
            foreach (var item in WorldScrapperService.DictionaryEntity)
                worldsSource.Add(item.Key, item.Value);

            cboBoxWorldFilter.DataSource = worldsSource.Keys.ToList();
            //cboBoxWorldFilter.DataSource = WorldScrapperService.DictionaryEntity.Keys.ToList();
            //cboBoxWorldFilter.SelectedIndex = cboBoxWorldFilter.Items.Count - 1;
            cboBoxWorldFilter.SelectedIndex = 0;
        }

        private void cboBoxWorldFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillUpdateTxtBoxCharacterNames();
        }

        private void cboBoxVocationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillUpdateTxtBoxCharacterNames();
        }

        private void numUpDownBidMaxFilter_ValueChanged(object sender, EventArgs e)
        {
            FillUpdateTxtBoxCharacterNames();
        }

        private void chkBoxIsBiddedFilter_CheckedChanged(object sender, EventArgs e)
        {
            FillUpdateTxtBoxCharacterNames();
        }

        private void numUpDownLevelFilter_ValueChanged(object sender, EventArgs e)
        {
            FillUpdateTxtBoxCharacterNames();
        }

        private void btnUpdateBazaar_Click(object sender, EventArgs e)
        {
            Task.Run(() => FillUpdateBazaarData());
        }

        private async Task FillUpdateBazaarData()
        {
            lblDtaAtualizacaoBazaar.Invoke((MethodInvoker)delegate
            {
                lblDtaAtualizacaoBazaar.Text = $"Data da última atualização: || Atualizando... ||";
            });

            btnUpdateBazaar.Invoke((MethodInvoker)delegate
            {
                btnUpdateBazaar.Enabled = false;
            });

            ScrapperService.RecoverScrapperData();
            FillUpdateTxtBoxCharacterNamesAsync().GetAwaiter().GetResult();

            lblDtaAtualizacaoBazaar.Invoke((MethodInvoker)delegate
            {
                lblDtaAtualizacaoBazaar.Text = $"Data da última atualização: {ScrapperService.LastUpdateEntity.ToString(Extender.DateTimeFormatBrazil)}";
            });

            btnUpdateBazaar.Invoke((MethodInvoker)delegate
            {
                btnUpdateBazaar.Enabled = true;
            });
        }

        private async Task FillUpdateTxtBoxCharacterNamesAsync()
        {
            if (ScrapperService.DictionaryEntity == null || ScrapperService.DictionaryEntity.Count() == 0)
                return;

            lstBoxCharacterNamesValues.Invoke((MethodInvoker)delegate
            {
                lstBoxCharacterNamesValues.DataSource = ScrapperService.DictionaryEntity.Keys.ToList();
            });
        }
    }
}
