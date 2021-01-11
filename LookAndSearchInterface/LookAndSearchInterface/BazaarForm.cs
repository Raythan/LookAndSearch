using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib;
using WebScrapperLib.Models;
using WebScrapperLib.ScrapperController;

namespace LookAndSearchInterface
{
    public partial class BazaarForm : Form
    {
        private readonly string FilterIconUrl = "https://raw.githubusercontent.com/Raythan/LookAndSearch/main/LookAndSearchInterface/WebScrapperLib/Images/funnel.png",
            RefreshIconUrl = "https://raw.githubusercontent.com/Raythan/LookAndSearch/main/LookAndSearchInterface/WebScrapperLib/Images/reset.png",
            EraserIconUrl = "https://raw.githubusercontent.com/Raythan/LookAndSearch/main/LookAndSearchInterface/WebScrapperLib/Images/eraser.png";
        List<string> listVocationFilter = new List<string>
        {
            "None",
            "Druid",
            "Knight",
            "Paladin",
            "Sorcerer"
        };

        Dictionary<string, int?> DictionarySkillId = new Dictionary<string, int?>
        {
            {"Select..", null},
            {"Axe Fighting", 10},
            {"Club Fighting", 9},
            {"Distance Fighting", 7},
            {"Fishing", 13},
            {"Fist Fighting", 11},
            {"Magic Level", 1},
            {"Shielding", 6},
            {"Sword Fighting", 8}
        };

        BazaarScrapper ScrapperService;
        WorldScrapper WorldScrapperService = new WorldScrapper();
        private string QueryParameters = null;

        public void FillUpdateTxtBoxCharacterNames()
        {
            if (ScrapperService == null ||
                ScrapperService.DictionaryEntity == null ||
                ScrapperService.DictionaryEntity.Count() == 0)
                return;

            Dictionary<string, dynamic> dicFromScrapper = ScrapperService.DictionaryEntity;

            if (chkLstBoxPvpTypeFilter.CheckedItems.Count > 0)
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

            if (chkLstBoxWorldFilter.CheckedItems.Count > 0)
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

            if (numMinLevelFilter.Value > 0)
                dicFromScrapper = dicFromScrapper.Where(w => Convert.ToInt64(((BazaarEntity)w.Value).Level) >= numMinLevelFilter.Value)
                    .ToDictionary(p => p.Key, p => p.Value);

            if (numMaxLevelFilter.Value > 0)
                dicFromScrapper = dicFromScrapper.Where(w => Convert.ToInt64(((BazaarEntity)w.Value).Level) <= numMaxLevelFilter.Value)
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
            Extender.UpdateComponentText(lblDteUpdatedBazaar, $"Last time updated: || Requesting data... ||");
            Extender.UpdateComponentEnable(btnBazaarApplyFilter, false);
            Extender.UpdateComponentEnable(btnUpdateBazaar, false);

            BuildQueryParametersPath();
            ScrapperService = new BazaarScrapper(QueryParameters);

            Task.Run(() => ScrapperService.RecoverScrapperDataAsyncPercentage(this))
                .GetAwaiter().GetResult();

            FillUpdateTxtBoxCharacterNamesAsync().GetAwaiter().GetResult();

            Extender.UpdateComponentText(lblDteUpdatedBazaar, $"Last time updated: {ScrapperService.LastUpdateEntity.ToString(Extender.DateTimeFormatBrazil)}");
            Extender.UpdateComponentValue(prgBarBazaarLoadingInfo, 99);
            Extender.UpdateComponentEnable(btnBazaarApplyFilter, true);
            Extender.UpdateComponentEnable(chkBoxIsBiddedFilter, true);
            Extender.UpdateComponentEnable(chkLstBoxPvpTypeFilter, true);
            Extender.UpdateComponentEnable(chkLstBoxVocationFilter, true);
            Extender.UpdateComponentEnable(chkLstBoxWorldFilter, true);
            Extender.UpdateComponentEnable(numUpDownBidMaxFilter, true);
            Extender.UpdateComponentEnable(cboBoxSkillsFilter, false);
            Extender.UpdateComponentEnable(numMaxSkillFilter, false);
            Extender.UpdateComponentEnable(numMinSkillFilter, false);
            Extender.UpdateComponentValue(prgBarBazaarLoadingInfo, 0);
        }

        private void BuildQueryParametersPath()
        {
            QueryParameters = "";
            QueryParameters += numMinLevelFilter.Value > 0 ? $"&filter_levelrangefrom={numMinLevelFilter.Value}" : "";
            QueryParameters += numMaxLevelFilter.Value > 0 ? $"&filter_levelrangeto={numMaxLevelFilter.Value}" : "";

            cboBoxSkillsFilter.Invoke((MethodInvoker)delegate
            {
                if (!string.IsNullOrEmpty(cboBoxSkillsFilter.SelectedItem.ToString()))
                {
                    int? parameterSkillId = DictionarySkillId
                    .Where(w => w.Key.Equals(cboBoxSkillsFilter.SelectedItem.ToString()))
                    .Select(s => s.Value)
                    .FirstOrDefault();
                    QueryParameters += $"&filter_skillid={parameterSkillId}";
                }
            });

            QueryParameters += numMinSkillFilter.Value > 0 ? $"&filter_skillrangefrom={numMinSkillFilter.Value}" : "";
            QueryParameters += numMaxSkillFilter.Value > 0 ? $"&filter_skillrangeto={numMaxSkillFilter.Value}" : "";
        }

        private async Task FillUpdateTxtBoxCharacterNamesAsync()
        {
            if (ScrapperService.DictionaryEntity == null || ScrapperService.DictionaryEntity.Count() == 0)
                return;

            Extender.UpdateComponentDataSource(lstBoxCharacterNamesValues, ScrapperService.DictionaryEntity.Keys.ToList());
            Extender.UpdateComponentValue(prgBarBazaarLoadingInfo, 70);
        }

        public async Task FillGridViewGeneralPart2()
        {
            dtaGridSkillsPart2Info.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Columns.Add("Percentage", typeof(string));

                BazaarEntity entity = ScrapperService.DictionaryEntity
                .Where(w => w.Key.Equals(lstBoxCharacterNamesValues.SelectedItem))
                .Select(s => s.Value)
                .FirstOrDefault();
                
                foreach (var item in entity.SpecifcInformationEntity.General.SKillsValuePercentage)
                {
                    string[] valuePercentSplited = item.Value.Split(';');
                    dt.Rows.Add(item.Key, valuePercentSplited[0], valuePercentSplited[1]);

                    if (prgBarBazaarLoadingInfo.Value < 96)
                        Extender.UpdateComponentValue(prgBarBazaarLoadingInfo, prgBarBazaarLoadingInfo.Value += 5);
                }

                dtaGridSkillsPart2Info.DataSource = dt;
                Extender.ResizeDtaGrdView(dt, dtaGridSkillsPart2Info);
            });
        }

        private void FillUpdateComboSkillsFilterById() => cboBoxSkillsFilter.DataSource = DictionarySkillId.Keys.ToList();

        private void FillUpdateComboWorldPvpType()
        {
            List<string> pvpTypeList = new List<string>();
            foreach (var item in WorldScrapperService.DictionaryEntity)
                if (!pvpTypeList.Contains(((WorldEntity)item.Value).PvpType))
                    pvpTypeList.Add(((WorldEntity)item.Value).PvpType);

            foreach (var item in pvpTypeList)
                chkLstBoxPvpTypeFilter.Items.Add(item);
        }

        private void chkLstBoxPvpTypeFilter_Leave(object sender, EventArgs e)
        {
            chkLstBoxWorldFilter.Items.Clear();

            if (chkLstBoxPvpTypeFilter.CheckedItems.Count > 0)
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

        private void BazaarForm_Load(object sender, EventArgs e)
        {
            FillUpdateChkListVocationNames();
            FillUpdateComboWorldNames();
            FillUpdateComboWorldPvpType();
            FillUpdateComboSkillsFilterById();
            Task.Run(() => FillUpdateImagesButton());
        }

        private async Task FillUpdateImagesButton()
        {
            btnBazaarApplyFilter.Image = Extender.RecoverImageFromUrl(FilterIconUrl, "IconSize32x32", "GitHubHeaders");
            btnResetFields.Image = Extender.RecoverImageFromUrl(EraserIconUrl, "IconSize32x32", "GitHubHeaders");
            btnUpdateBazaar.Image = Extender.RecoverImageFromUrl(RefreshIconUrl, "IconSize32x32", "GitHubHeaders");
            //Extender.UpdateComponentImage(btnBazaarApplyFilter.Image, Extender.RecoverImageFromUrl(FilterIconUrl, "IconSize18x18", "GitHubHeaders"));
            //Extender.UpdateComponentImage(btnResetFields.Image, Extender.RecoverImageFromUrl(EraserIconUrl, "IconSize18x18", "GitHubHeaders"));
            //Extender.UpdateComponentImage(btnUpdateBazaar.Image, Extender.RecoverImageFromUrl(RefreshIconUrl, "IconSize18x18", "GitHubHeaders"));
        }

        private void lblBazaarEntityUrlStatusTag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var dialogCharacterInformation = new CharacterSpecificInfoForm(lblStoreUrlAuctionValueDisabled.Text))
                dialogCharacterInformation.ShowDialog(this);

            //using (var dialogCharacterInformation = new CharacterSpecificInfoForm("https://www.tibia.com/charactertrade/?subtopic=currentcharactertrades&page=details&auctionid=282327&source=overview"))
            //    dialogCharacterInformation.ShowDialog(this);
        }

        private void numMinSkillFilter_ValueChanged(object sender, EventArgs e)
        {
            if (numMinSkillFilter.Value > numMaxSkillFilter.Value && numMinSkillFilter.Value > 0)
                numMaxSkillFilter.Value = numMinSkillFilter.Value + 1;
        }

        private void numMaxSkillFilter_ValueChanged(object sender, EventArgs e)
        {
            if (numMaxSkillFilter.Value < numMinSkillFilter.Value && numMaxSkillFilter.Value > 0)
                numMinSkillFilter.Value = numMaxSkillFilter.Value - 1;
        }

        private void numMaxLevelFilter_ValueChanged(object sender, EventArgs e)
        {
            if (numMaxLevelFilter.Value < numMinLevelFilter.Value && numMaxLevelFilter.Value > 0)
                numMinLevelFilter.Value = numMaxLevelFilter.Value - 1;

            FillUpdateTxtBoxCharacterNames();
        }

        private void numMinLevelFilter_ValueChanged(object sender, EventArgs e)
        {
            if (numMinLevelFilter.Value > numMaxLevelFilter.Value && numMinLevelFilter.Value > 0)
                numMaxLevelFilter.Value = numMinLevelFilter.Value + 1;

            FillUpdateTxtBoxCharacterNames();
        }

        private void lstBoxCharacterNamesValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtaGridSkillsPart2Info.DataSource = null;

            if (ScrapperService.DictionaryEntity == null || ScrapperService.DictionaryEntity.Count() == 0)
            {
                lblBazaarEntityLevelValue.Text = "";
                lblBazaarEntityGenderValue.Text = "";
                lblBazaarEntityCurrMinBidValue.Text = "";
                lblStoreUrlAuctionValueDisabled.Text = "";
                lblBazaarEntityStartedAuctionValue.Text = "";
                lblBazaarEntityEndAuctionValue.Text = "";
                lblBazaarEntityWorldValue.Text = "";
                lblBazaarEntityVocationValue.Text = "";
                grpBoxBazaarEntityStatus.Visible = false;
                grpBoxBazaarEntitySkills.Visible = false;
                dtaGridSkillsPart2Info.DataSource = null;
                prgBarBazaarLoadingInfo.Value = 0;
                return;
            }

            if (!string.IsNullOrEmpty(lstBoxCharacterNamesValues.Text))
            {
                lblDteUpdatedBazaar.Text = $"Last time updated: || Refreshing general status... ||";
                prgBarBazaarLoadingInfo.Value = 10;

                grpBoxBazaarEntityStatus.Visible = true;
                grpBoxBazaarEntitySkills.Visible = true;
                BazaarEntity entity = ScrapperService.DictionaryEntity
                .Where(w => w.Key.Equals(lstBoxCharacterNamesValues.Text))
                .Select(s => s.Value)
                .FirstOrDefault();

                prgBarBazaarLoadingInfo.Value = 15;

                lblBazaarEntityLevelValue.Text = entity.Level.ToString();
                lblBazaarEntityGenderValue.Text = entity.Sex;
                lblBazaarEntityCurrMinBidValue.Text = entity.MinimumCurrentBid;
                lblStoreUrlAuctionValueDisabled.Text = entity.UrlEntityInfo;
                lblBazaarEntityWorldValue.Text = entity.World;
                lblBazaarEntityVocationValue.Text = entity.Vocation;
                lblBazaarEntityStartedAuctionValue.Text = Extender.FormatAuctionDateFromEntity(entity.AuctionStarted, Extender.DateTimeFormatBrazil);
                lblBazaarEntityEndAuctionValue.Text = Extender.FormatAuctionDateFromEntity(entity.AuctionEnd, Extender.DateTimeFormatBrazil);

                prgBarBazaarLoadingInfo.Value = 35;
                
                lblDteUpdatedBazaar.Text = $"Last time updated: || Refreshing skills... ||";

                if (dtaGridSkillsPart2Info.DataSource == null)
                    FillGridViewGeneralPart2();

                prgBarBazaarLoadingInfo.Value = 0;
                lblDteUpdatedBazaar.Text = $"Last time updated: {ScrapperService.LastUpdateEntity.ToString(Extender.DateTimeFormatBrazil)}";
                return;
            }

            grpBoxBazaarEntityStatus.Visible = false;
            grpBoxBazaarEntitySkills.Visible = false;
            prgBarBazaarLoadingInfo.Value = 0;
        }

        private void numUpDownBidMaxFilter_ValueChanged(object sender, EventArgs e) => FillUpdateTxtBoxCharacterNames();

        private void chkBoxIsBiddedFilter_CheckedChanged(object sender, EventArgs e) => FillUpdateTxtBoxCharacterNames();

        private void btnUpdateBazaar_Click(object sender, EventArgs e) => Task.Run(() => FillUpdateBazaarData());

        private void lblBazaarEntityUrlAuctionTag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start(lblStoreUrlAuctionValueDisabled.Text);

        private void btnResetFields_Click(object sender, EventArgs e)
        {
            lstBoxCharacterNamesValues.DataSource = null;
            lstBoxCharacterNamesValues.Items.Clear();
            grpBoxBazaarEntityStatus.Visible = false;
            grpBoxBazaarEntitySkills.Visible = false;
            chkBoxIsBiddedFilter.CheckState = CheckState.Unchecked;
            numUpDownBidMaxFilter.Value = 0;
            numMinLevelFilter.Value = 0;
            numMaxLevelFilter.Value = 10000;
            numMinSkillFilter.Value = 0;
            numMaxSkillFilter.Value = 500;
            btnBazaarApplyFilter.Enabled = false;
            btnUpdateBazaar.Enabled = true;
            numMinLevelFilter.Enabled = true;
            numMaxLevelFilter.Enabled = true;
            numMinSkillFilter.Enabled = true;
            numMaxSkillFilter.Enabled = true;
            cboBoxSkillsFilter.Enabled = true;
            cboBoxSkillsFilter.SelectedIndex = 0;
            chkLstBoxWorldFilter.Items.Clear();
            chkBoxIsBiddedFilter.Enabled = false;

            for (int i = 0; i < chkLstBoxPvpTypeFilter.Items.Count; i++)
                chkLstBoxPvpTypeFilter.SetItemCheckState(i, CheckState.Unchecked);

            for (int i = 0; i < chkLstBoxWorldFilter.Items.Count; i++)
                chkLstBoxWorldFilter.SetItemCheckState(i, CheckState.Unchecked);

            for (int i = 0; i < chkLstBoxVocationFilter.Items.Count; i++)
                chkLstBoxVocationFilter.SetItemCheckState(i, CheckState.Unchecked);
            
            foreach (var item in WorldScrapperService.DictionaryEntity)
                chkLstBoxWorldFilter.Items.Add(item.Key);
        }

        private void btnBazaarAppleFilter_Click(object sender, EventArgs e) => FillUpdateTxtBoxCharacterNames();

        public BazaarForm() => InitializeComponent();
    }
}
