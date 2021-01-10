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
            "None",
            "Druid",
            "Knight",
            "Paladin",
            "Sorcerer"
        };
        
        BazaarScrapper ScrapperService = new BazaarScrapper();
        WorldScrapper WorldScrapperService = new WorldScrapper();

        public BazaarForm() => InitializeComponent();

        public void FillUpdateTxtBoxCharacterNames()
        {
            if (ScrapperService.DictionaryEntity == null || ScrapperService.DictionaryEntity.Count() == 0)
                return;

            Dictionary<string, dynamic> dicFromScrapper = ScrapperService.DictionaryEntity;
            
            if(chkLstBoxPvpTypeFilter.CheckedItems.Count > 0)
            {
                Dictionary<string, dynamic> dicFilterPvpTypeFromScrapper = new Dictionary<string, dynamic>();
                foreach (var dicScrapItem in ScrapperService.DictionaryEntity)
                {
                    foreach (var chkItem in chkLstBoxWorldFilter.Items)
                    {
                        if (((BazaarEntity)dicScrapItem.Value).World.Contains(chkItem.ToString()))
                        {
                            dicFilterPvpTypeFromScrapper.Add(dicScrapItem.Key, dicScrapItem.Value);
                            break;
                        }
                    }
                }

                dicFromScrapper = dicFilterPvpTypeFromScrapper;
            }

            if(chkLstBoxWorldFilter.CheckedItems.Count > 0)
            {
                Dictionary<string, dynamic> dicFilterWorldsFromScrapper = new Dictionary<string, dynamic>();
                foreach (var dicScrapItem in ScrapperService.DictionaryEntity)
                {
                    foreach (var chkItem in chkLstBoxWorldFilter.CheckedItems)
                    {
                        if (((BazaarEntity)dicScrapItem.Value).World.Contains(chkItem.ToString()))
                        {
                            dicFilterWorldsFromScrapper.Add(dicScrapItem.Key, dicScrapItem.Value);
                            break;
                        }
                    }
                }

                dicFromScrapper = dicFilterWorldsFromScrapper;
            }

            if (chkLstBoxVocationFilter.CheckedItems.Count > 0)
            {
                Dictionary<string, dynamic> dicFilterVocationFromScrapper = new Dictionary<string, dynamic>();
                foreach (var dicScrapItem in dicFromScrapper)
                {
                    foreach (var chkItem in chkLstBoxVocationFilter.CheckedItems)
                    {
                        if (((BazaarEntity)dicScrapItem.Value).Vocation.Contains(chkItem.ToString()))
                        {
                            dicFilterVocationFromScrapper.Add(dicScrapItem.Key, dicScrapItem.Value);
                            break;
                        }
                    }
                }

                dicFromScrapper = dicFilterVocationFromScrapper;
            }

            if (numUpDownBidMaxFilter.Value > 0)
                dicFromScrapper = dicFromScrapper.Where(w => Convert.ToInt64(((BazaarEntity)w.Value).MinimumCurrentBid.Replace(",", "")) <= numUpDownBidMaxFilter.Value)
                    .ToDictionary(p => p.Key, p => p.Value);

            if (chkBoxIsBiddedFilter.Checked)
                dicFromScrapper = dicFromScrapper.Where(w => !((BazaarEntity)w.Value).IsBidded)
                    .ToDictionary(p => p.Key, p => p.Value);

            if (numUpDownLevelFilter.Value > 0)
                dicFromScrapper = dicFromScrapper.Where(w => Convert.ToInt64(((BazaarEntity)w.Value).Level) >= numUpDownLevelFilter.Value)
                    .ToDictionary(p => p.Key, p => p.Value);

            if (dicFromScrapper == null || dicFromScrapper.Count() == 0)
                grpBoxBazaarEntityStatus.Visible = false;

            lstBoxCharacterNamesValues.DataSource = dicFromScrapper.Keys.ToList();
        }

        public void FillUpdateChkListVocationNames()
        {
            foreach (var item in listVocationFilter)
                chkLstBoxVocationFilter.Items.Add(item);
        }

        public void FillUpdateComboWorldNames()
        {
            WorldScrapperService.RecoverScrapperData();
            foreach (var item in WorldScrapperService.DictionaryEntity)
                chkLstBoxWorldFilter.Items.Add(item.Key);
        }

        private async Task FillUpdateBazaarData()
        {
            lblDtaAtualizacaoBazaar.Invoke((MethodInvoker)delegate
            {
                lblDtaAtualizacaoBazaar.Text = $"Last time updated: || Refreshing... ||";
            });
            
            btnUpdateBazaar.Invoke((MethodInvoker)delegate
            {
                btnUpdateBazaar.Enabled = false;
            });

            //ScrapperService.RecoverScrapperData(prgBarBazaarLoadingInfo)
            Task.Run(() => ScrapperService.RecoverScrapperDataAsyncPercentage(prgBarBazaarLoadingInfo))
                .GetAwaiter().GetResult();
            
            FillUpdateTxtBoxCharacterNamesAsync().GetAwaiter().GetResult();

            lblDtaAtualizacaoBazaar.Invoke((MethodInvoker)delegate
            {
                lblDtaAtualizacaoBazaar.Text = $"Last time updated: {ScrapperService.LastUpdateEntity.ToString(Extender.DateTimeFormatBrazil)}";
            });
            
            prgBarBazaarLoadingInfo.Invoke((MethodInvoker)delegate
            {
                prgBarBazaarLoadingInfo.Value = 99;
            });

            btnUpdateBazaar.Invoke((MethodInvoker)delegate
            {
                btnUpdateBazaar.Enabled = true;
            });

            Thread.Sleep(200);
            prgBarBazaarLoadingInfo.Invoke((MethodInvoker)delegate
            {
                prgBarBazaarLoadingInfo.Value = 0;
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

            prgBarBazaarLoadingInfo.Invoke((MethodInvoker)delegate
            {
                prgBarBazaarLoadingInfo.Value = 70;
            });
        }

        private void BazaarForm_Load(object sender, EventArgs e)
        {
            FillUpdateChkListVocationNames();
            FillUpdateComboWorldNames();
            FillUpdateComboWorldPvpType();
        }

        private void FillUpdateComboWorldPvpType()
        {
            List<string> pvpTypeList = new List<string>();
            foreach (var item in WorldScrapperService.DictionaryEntity)
                if (!pvpTypeList.Contains(((WorldEntity)item.Value).PvpType))
                    pvpTypeList.Add(((WorldEntity)item.Value).PvpType);
            
            foreach(var item in pvpTypeList)
                chkLstBoxPvpTypeFilter.Items.Add(item);
        }

        private void lstBoxCharacterNamesValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ScrapperService.DictionaryEntity == null || ScrapperService.DictionaryEntity.Count() == 0)
            {
                lblBazaarEntityLevelValue.Text = "";
                lblBazaarEntityGenderValue.Text = "";
                lblBazaarEntityCurrMinBidValue.Text = "";
                lblStoreUrlAuctionValueDisabled.Text = "";
                lblBazaarEntityStartedAuctionValue.Text = "";
                lblBazaarEntityEndAuctionValue.Text = "";
                lblBazaarEntityWorldValue.Text = "";
                grpBoxBazaarEntityStatus.Visible = false;
                return;
            }

            if (!string.IsNullOrEmpty(lstBoxCharacterNamesValues.Text))
            {
                grpBoxBazaarEntityStatus.Visible = true;
                BazaarEntity entity = ScrapperService.DictionaryEntity
                .Where(w => w.Key.Equals(lstBoxCharacterNamesValues.Text))
                .Select(s => s.Value)
                .FirstOrDefault();

                lblBazaarEntityLevelValue.Text = entity.Level.ToString();
                lblBazaarEntityGenderValue.Text = entity.Sex;
                lblBazaarEntityCurrMinBidValue.Text = entity.MinimumCurrentBid;
                lblStoreUrlAuctionValueDisabled.Text = entity.UrlEntityInfo;
                lblBazaarEntityWorldValue.Text = entity.World;
                lblBazaarEntityStartedAuctionValue.Text = Extender.FormatAuctionDateFromEntity(entity.AuctionStarted, Extender.DateTimeFormatBrazil);
                lblBazaarEntityEndAuctionValue.Text = Extender.FormatAuctionDateFromEntity(entity.AuctionEnd, Extender.DateTimeFormatBrazil);
                return;
            }

            grpBoxBazaarEntityStatus.Visible = false;
        }

        private void cboBoxWorldFilter_SelectedIndexChanged(object sender, EventArgs e) => FillUpdateTxtBoxCharacterNames();

        private void cboBoxVocationFilter_SelectedIndexChanged(object sender, EventArgs e) => FillUpdateTxtBoxCharacterNames();

        private void numUpDownBidMaxFilter_ValueChanged(object sender, EventArgs e) => FillUpdateTxtBoxCharacterNames();

        private void chkBoxIsBiddedFilter_CheckedChanged(object sender, EventArgs e) => FillUpdateTxtBoxCharacterNames();

        private void numUpDownLevelFilter_ValueChanged(object sender, EventArgs e) => FillUpdateTxtBoxCharacterNames();

        private void btnUpdateBazaar_Click(object sender, EventArgs e) => Task.Run(() => FillUpdateBazaarData());

        private void lblBazaarEntityUrlAuctionTag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start(lblStoreUrlAuctionValueDisabled.Text);
        
        private void btnBazaarAppleFilter_Click(object sender, EventArgs e) => FillUpdateTxtBoxCharacterNames();

        private void chkLstBoxPvpTypeFilter_Leave(object sender, EventArgs e)
        {
            chkLstBoxWorldFilter.Items.Clear();
            
            if(chkLstBoxPvpTypeFilter.CheckedItems.Count > 0)
            {
                foreach (var item in chkLstBoxPvpTypeFilter.CheckedItems)
                    foreach (var item2 in WorldScrapperService.DictionaryEntity)
                        if (item.Equals(((WorldEntity)item2.Value).PvpType))
                            chkLstBoxWorldFilter.Items.Add(item2.Key);
            }   
            else
            {
                foreach (var item2 in WorldScrapperService.DictionaryEntity)
                    chkLstBoxWorldFilter.Items.Add(item2.Key);
            }
        }

        private void lblBazaarEntityUrlStatusTag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CharacterSpecificInfoForm dialogCharacterInformation = new CharacterSpecificInfoForm(lblStoreUrlAuctionValueDisabled.Text);
            //CharacterSpecificInfoForm dialogCharacterInformation = new CharacterSpecificInfoForm("https://www.tibia.com/charactertrade/?subtopic=currentcharactertrades&page=details&auctionid=282327&source=overview");
            dialogCharacterInformation.ShowDialog(this);
        }
    }
}
