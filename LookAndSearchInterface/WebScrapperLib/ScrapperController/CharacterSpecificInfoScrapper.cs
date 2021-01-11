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
            //listInfo = Extender.CleanListName(listInfo);
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

        public void RecoverScrapperSkillsAndName(string characterName, dynamic FormParameter)
        {
            string responseString = "";
            base.DictionaryEntity = new Dictionary<string, dynamic>();
            Client = new HttpClient();
            Client.BaseAddress = new Uri(base.BaseUrl);

            UpdateComponentProgressBar(GetControlByName(FormParameter.Controls, "prgBarBazaarLoadingInfo"), 45);

            AddClientHeaders();
            HttpResponseMessage response = Client.GetAsync(base.BaseUrl)
                .GetAwaiter().GetResult();

            UpdateComponentProgressBar(GetControlByName(FormParameter.Controls, "prgBarBazaarLoadingInfo"), 55);

            if (response.IsSuccessStatusCode)
                responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            UpdateComponentProgressBar(GetControlByName(FormParameter.Controls, "prgBarBazaarLoadingInfo"), 60);

            List<string> listInfo = RecoverInnerHtmlFromTagList(responseString, ScrapListBasicInfo);
            //listInfo = Extender.CleanListName(listInfo);
            listInfo.RemoveAt(0);
            BuildPart2(listInfo[1]);

            UpdateComponentProgressBar(GetControlByName(FormParameter.Controls, "prgBarBazaarLoadingInfo"), 70);

            Entity.CharacterName = characterName;
            UpdateEntityLastTime();

            UpdateComponentProgressBar(GetControlByName(FormParameter.Controls, "prgBarBazaarLoadingInfo"), 80);

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
            //listInfo = Extender.CleanListName(listInfo);
            listInfo.RemoveAt(0);

            List<string> listOutfitsUrls = RecoverAttributeFromTagList(responseString, ScrapListInfoOutfitValue, "src", "nothing");
            BuildMainOutfit(listOutfitsUrls);
            
            BuildPart1(listInfo[0]);
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 25);

            BuildPart2(listInfo[1]);
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 35);

            BuildPart3(listInfo[2]);
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 45);

            BuildPart4(listInfo[3]);
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 55);

            BuildPart5(listInfo[4]);
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 65);

            BuildPart6(listInfo[5]);
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 75);

            BuildPart7(listInfo[6]);
            await UpdateComponentProgressBar(GetControlByName(FormToFillAsync.Controls, "prgBarSpecificInfo"), 85);

            BuildPart8(listInfo[7]);
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
