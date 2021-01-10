using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib.Interfaces;
using WebScrapperLib.Models;

namespace WebScrapperLib.ScrapperController
{
    public class CharacterSpecificInfoScrapper : BaseScrapperEntity, IWebScrapper
    {
        public CharacterSpecificInformationEntity Entity { get; private set; }
        private readonly List<string> ScrapListBasicInfo = new List<string>
        {
            "//div[@class='InnerTableContainer']",
            "//div[@class='TableShadowContainerRightTop']",
            "//div[@class='TableContentAndRightShadow']",
            "//div[@class='TableContentContainer']",
            "//table[@class='TableContent']"
        };
        
        private readonly List<string> ScrapListInfoPart1Value = new List<string>
        {
            "//div"
        };
        private readonly List<string> ScrapListInfoPart2ValueInteger = new List<string>
        {
            "//td[@class='LevelColumn']"
        };
        private readonly List<string> ScrapListInfoPart2ValuePercentage = new List<string>
        {
            "//span[@class='PercentageString']"
        };
        private readonly List<string> ScrapListInfoOutfitValue = new List<string>
        {
            "//img[@class='AuctionOutfitImage']"
        };

        public void BuildDictionaryData(List<string> listParameter, dynamic extraParams = null)
        {
        }

        private void BuildPart1(string parameter)
        {
            List<string> listInfoValue = RecoverInnerHtmlFromTagList(parameter, ScrapListInfoPart1Value);
            Entity.General.HitPoints = listInfoValue[0];
            Entity.General.Mana = listInfoValue[1];
            Entity.General.Capacity = listInfoValue[2];
            Entity.General.Speed = listInfoValue[3];
            Entity.General.Blessings = listInfoValue[4];
            Entity.General.Mounts = listInfoValue[5];
            Entity.General.Outfits = listInfoValue[6];
            Entity.General.Titles = listInfoValue[7];
        }
        private void BuildPart2(string parameter)
        {
            List<string> listInfoValueValue = RecoverInnerHtmlFromTagList(parameter, ScrapListInfoPart2ValueInteger);
            List<string> listInfoValuePercentage = RecoverInnerHtmlFromTagList(parameter, ScrapListInfoPart2ValuePercentage);

            Entity.General.SKillsValuePercentage.Add("AxeFighting", $"{listInfoValueValue[0]};{listInfoValuePercentage[0]}");
            Entity.General.SKillsValuePercentage.Add("ClubFighting", $"{listInfoValueValue[1]};{listInfoValuePercentage[1]}");
            Entity.General.SKillsValuePercentage.Add("DistanceFighting", $"{listInfoValueValue[2]};{listInfoValuePercentage[2]}");
            Entity.General.SKillsValuePercentage.Add("Fishing", $"{listInfoValueValue[3]};{listInfoValuePercentage[3]}");
            Entity.General.SKillsValuePercentage.Add("FistFighting", $"{listInfoValueValue[4]};{listInfoValuePercentage[4]}");
            Entity.General.SKillsValuePercentage.Add("MagicLevel", $"{listInfoValueValue[5]};{listInfoValuePercentage[5]}");
            Entity.General.SKillsValuePercentage.Add("Shielding", $"{listInfoValueValue[6]};{listInfoValuePercentage[6]}");
            Entity.General.SKillsValuePercentage.Add("SwordFighting", $"{listInfoValueValue[7]};{listInfoValuePercentage[7]}");
        }
        private void BuildPart3(string parameter)
        {
            List<string> listInfoValue = RecoverInnerHtmlFromTagList(parameter, ScrapListInfoPart1Value);
            Entity.General.CreationDate = listInfoValue[0];
            Entity.General.Experience = listInfoValue[1];
            Entity.General.Gold = listInfoValue[2];
            Entity.General.AchievementPoints = listInfoValue[3];
        }
        private void BuildPart4(string parameter)
        {
            Entity.General.RegularWorldTransfer = RecoverDocumentNodeInnerTextValue(
                RecoverInnerHtmlFromTagFirst(parameter, ScrapListInfoPart1Value));
        }
        private void BuildPart5(string parameter)
        {
            List<string> listInfoValue = RecoverInnerHtmlFromTagList(parameter, ScrapListInfoPart1Value);
            Entity.General.CharmExpansion = listInfoValue[0].Contains("yes") ? "yes" : "no";
            Entity.General.AvailableCharmPoints = listInfoValue[1];
            Entity.General.SpentCharmPoints = listInfoValue[2];
        }
        private void BuildPart6(string parameter)
        {
            List<string> listInfoValue = RecoverInnerHtmlFromTagList(parameter, ScrapListInfoPart1Value);
            Entity.General.DailyRewardStreak = listInfoValue[0];
        }
        private void BuildPart7(string parameter)
        {
            List<string> listInfoValue = RecoverInnerHtmlFromTagList(parameter, ScrapListInfoPart1Value);
            Entity.General.HuntingTaskPoints = listInfoValue[0];
            Entity.General.PermanentHuntingTaskSlots = listInfoValue[1];
            Entity.General.PermanentPreySlots = listInfoValue[2];
        }
        private void BuildPart8(string parameter)
        {
            List<string> listInfoValue = RecoverInnerHtmlFromTagList(parameter, ScrapListInfoPart1Value);
            Entity.General.Hirelings = listInfoValue[0];
            Entity.General.HirelingJobs = listInfoValue[1];
            Entity.General.HirelingOutfits = listInfoValue[2];
        }

        public async Task FillGridViewGeneralPart1(DataGridView dtaGrdView)
        {
            dtaGrdView.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Rows.Add("Hit Points", Entity.General.HitPoints);
                dt.Rows.Add("Mana", Entity.General.Mana);
                dt.Rows.Add("Capacity", Entity.General.Capacity);
                dt.Rows.Add("Speed", Entity.General.Speed);
                dt.Rows.Add("Blessings", Entity.General.Blessings);
                dt.Rows.Add("Mounts", Entity.General.Mounts);
                dt.Rows.Add("Outfits", Entity.General.Outfits);
                dt.Rows.Add("Titles", Entity.General.Titles);

                dtaGrdView.DataSource = dt;
                dtaGrdView.BackgroundColor = Color.PapayaWhip;
                ResizeDtaGrdView(dt, dtaGrdView);
            });
        }
        public async Task FillGridViewGeneralPart2(DataGridView dtaGrdView)
        {
            dtaGrdView.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));

                foreach (var item in Entity.General.SKillsValuePercentage)
                    dt.Rows.Add(item.Key, item.Value.Replace(";", " // "));

                dtaGrdView.DataSource = dt;
                dtaGrdView.BackgroundColor = Color.PapayaWhip;
                ResizeDtaGrdView(dt, dtaGrdView);
            });
        }
        public async Task FillGridViewGeneralPart3(DataGridView dtaGrdView)
        {
            dtaGrdView.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                
                dt.Rows.Add("Creation Date", Extender.FormatAuctionDateFromEntity(Entity.General.CreationDate, Extender.DateTimeFormatBrazil));
                dt.Rows.Add("Experience", Entity.General.Experience);
                dt.Rows.Add("Gold", Entity.General.Gold);
                dt.Rows.Add("Achievement Points", Entity.General.AchievementPoints);

                dtaGrdView.DataSource = dt;
                dtaGrdView.BackgroundColor = Color.PapayaWhip;
                ResizeDtaGrdView(dt, dtaGrdView);
            });
        }
        public async Task FillGridViewGeneralPart4(DataGridView dtaGrdView)
        {
            dtaGrdView.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Rows.Add("Regular World Transfer", Entity.General.RegularWorldTransfer);

                dtaGrdView.DataSource = dt;
                dtaGrdView.BackgroundColor = Color.PapayaWhip;
                ResizeDtaGrdView(dt, dtaGrdView);
            });
        }
        public async Task FillGridViewGeneralPart5(DataGridView dtaGrdView)
        {
            dtaGrdView.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Rows.Add("Charm Expansion", Entity.General.CharmExpansion);
                dt.Rows.Add("Available Charm Points", Entity.General.AvailableCharmPoints);
                dt.Rows.Add("Spent Charm Points", Entity.General.SpentCharmPoints);

                dtaGrdView.DataSource = dt;
                dtaGrdView.BackgroundColor = Color.PapayaWhip;
                ResizeDtaGrdView(dt, dtaGrdView);
            });
        }
        public async Task FillGridViewGeneralPart6(DataGridView dtaGrdView)
        {
            dtaGrdView.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Rows.Add("Daily Reward Streak", Entity.General.DailyRewardStreak);

                dtaGrdView.DataSource = dt;
                dtaGrdView.BackgroundColor = Color.PapayaWhip;
                ResizeDtaGrdView(dt, dtaGrdView);
            });
        }
        public async Task FillGridViewGeneralPart7(DataGridView dtaGrdView)
        {
            dtaGrdView.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Rows.Add("Hunting Task Points", Entity.General.HuntingTaskPoints);
                dt.Rows.Add("Permanent Hunting Task Slots", Entity.General.PermanentHuntingTaskSlots);
                dt.Rows.Add("Permanent Prey Slots", Entity.General.PermanentPreySlots);

                dtaGrdView.DataSource = dt;
                dtaGrdView.BackgroundColor = Color.PapayaWhip;
                ResizeDtaGrdView(dt, dtaGrdView);
            });
        }
        public async Task FillGridViewGeneralPart8(DataGridView dtaGrdView)
        {
            dtaGrdView.Invoke((MethodInvoker)delegate
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Rows.Add("Hirelings", Entity.General.Hirelings);
                dt.Rows.Add("Hireling Jobs", Entity.General.HirelingJobs);
                dt.Rows.Add("Hireling Outfits", Entity.General.HirelingOutfits);

                dtaGrdView.DataSource = dt;
                dtaGrdView.BackgroundColor = Color.PapayaWhip;
                ResizeDtaGrdView(dt, dtaGrdView);
            });
        }
        private void ResizeDtaGrdView(DataTable dtParam, DataGridView dtaGrdViewParam)
        {
            dtaGrdViewParam.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtaGrdViewParam.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            for (int i = 0; i <= dtaGrdViewParam.Columns.Count - 1; i++)
            {
                int colw = dtaGrdViewParam.Columns[i].Width;
                dtaGrdViewParam.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dtaGrdViewParam.Columns[i].Width = colw;
            }
        }

        public void RecoverScrapperData()
        {
            string responseString = "";
            base.DictionaryEntity = new Dictionary<string, dynamic>();
            Client = new HttpClient();
            Client.BaseAddress = new Uri(base.BaseUrl);
            AddClientHeaders();
            HttpResponseMessage response = Client.GetAsync(base.BaseUrl)
                .GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
                responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            List<string> listInfo = RecoverInnerHtmlFromTagList(responseString, ScrapListBasicInfo);
            listInfo = Extender.CleanListName(listInfo);
            listInfo.RemoveAt(0);
            BuildPart1(listInfo[0]);
            BuildPart2(listInfo[1]);
            BuildPart3(listInfo[2]);
            BuildPart4(listInfo[3]);
            BuildPart5(listInfo[4]);
            BuildPart6(listInfo[5]);
            BuildPart7(listInfo[6]);
            BuildPart8(listInfo[7]);
            UpdateEntityLastTime();
            Thread.Sleep(TimeStampRequest);
        }

        public async Task RecoverScrapperDataAsync(dynamic FormToFillAsync)
        {
            string responseString = "";
            base.DictionaryEntity = new Dictionary<string, dynamic>();
            Client = new HttpClient();
            Client.BaseAddress = new Uri(base.BaseUrl);
            AddClientHeaders();


            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 5);

            HttpResponseMessage response = Client.GetAsync(base.BaseUrl)
                .GetAwaiter().GetResult();

            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 10);

            if (response.IsSuccessStatusCode)
                responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 15);

            List<string> listInfo = RecoverInnerHtmlFromTagList(responseString, ScrapListBasicInfo);
            listInfo = Extender.CleanListName(listInfo);
            listInfo.RemoveAt(0);

            List<string> listOutfitsUrls = RecoverAttributeFromTagList(responseString, ScrapListInfoOutfitValue, "src", "nothing");
            BuildMainOutfit(listOutfitsUrls);

            UpdateFillComponentPicBoxIcon(GetControlByName(FormToFillAsync.Controls, "picBoxMainIconStatus"));

            BuildPart1(listInfo[0]);
            await FillGridViewGeneralPart1(GetControlByName(FormToFillAsync.Controls, "dtaGridGeneralPart1Info"));
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 25);

            BuildPart2(listInfo[1]);
            await FillGridViewGeneralPart2(GetControlByName(FormToFillAsync.Controls, "dtaGridGeneralPart2Info"));
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 35);

            BuildPart3(listInfo[2]);
            await FillGridViewGeneralPart3(GetControlByName(FormToFillAsync.Controls, "dtaGridGeneralPart3Info"));
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 45);

            BuildPart4(listInfo[3]);
            await FillGridViewGeneralPart4(GetControlByName(FormToFillAsync.Controls, "dtaGridGeneralPart4Info"));
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 55);

            BuildPart5(listInfo[4]);
            await FillGridViewGeneralPart5(GetControlByName(FormToFillAsync.Controls, "dtaGridGeneralPart5Info"));
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 65);

            BuildPart6(listInfo[5]);
            await FillGridViewGeneralPart6(GetControlByName(FormToFillAsync.Controls, "dtaGridGeneralPart6Info"));
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 75);

            BuildPart7(listInfo[6]);
            await FillGridViewGeneralPart7(GetControlByName(FormToFillAsync.Controls, "dtaGridGeneralPart7Info"));
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 85);

            BuildPart8(listInfo[7]);
            await FillGridViewGeneralPart8(GetControlByName(FormToFillAsync.Controls, "dtaGridGeneralPart8Info"));
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 95);

            UpdateEntityLastTime();
            Thread.Sleep(TimeStampRequest);
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 0);
        }

        private dynamic GetControlByName(dynamic controls, string controlName)
        {
            foreach (var item in controls)
                if (item.Name.Equals(controlName))
                    return item;

            return null;
        }

        private void BuildMainOutfit(List<string> listOutfitsUrls)
        {
            Entity.General.UrlMainOutfit = listOutfitsUrls[0];
        }

        public async Task UpdateFillComponentPicBoxIcon(PictureBox prgBarParam)
        {
            prgBarParam.Invoke((MethodInvoker)delegate
            {
                prgBarParam.Image = Extender.RecoverImageFromUrl(Entity.General.UrlMainOutfit, "IconSize64x64", "CipSoftHeaders");
            });
        }

        public async Task UpdateComponentProgressBar(ProgressBar prgBarParam, int percentage)
        {
            prgBarParam.Invoke((MethodInvoker)delegate
            {
                prgBarParam.Value = percentage;
            });
        }
        
        public CharacterSpecificInfoScrapper(string UrlForScrapper) : base(UrlForScrapper)
        {
            Entity = new CharacterSpecificInformationEntity();
        }
    }
}
