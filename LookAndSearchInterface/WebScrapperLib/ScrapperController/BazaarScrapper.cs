using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapperLib.Interfaces;
using WebScrapperLib.Models;

namespace WebScrapperLib.ScrapperController
{
    public class BazaarScrapper : BaseScrapperEntity, IWebScrapper
    {
        private static int LastPage = 0, CurrentPage = 1;
        private readonly string UrlToGetAsync = $"https://www.tibia.com/charactertrade/?subtopic=currentcharactertrades";
        public readonly string QueryParameters;
        private CharacterSpecificInfoScrapper SpecificInfoScrapper;
        private readonly List<string> ScrapListBasicInfo = new List<string>
        {
            "//div[@class='TableContainer']",
            "//table[@class='Table3']",
            "//div[@class='InnerTableContainer']",
            "//tr"
        };

        private readonly List<string> ScrapListContainerInfo = new List<string>
        {
            "//div[@class='AuctionHeader']",
            "//node()",
        };

        private readonly List<string> ScrapListHeaderInfo = new List<string>
        {
            "//div[@class='AuctionHeader']",
        };

        private readonly List<string> ScrapListBodyInfo = new List<string>
        {
             "//div[@class='AuctionBody']",
        };

        private readonly List<string> ScrapListAuctionStartEndInfo = new List<string>
        {
             "//div[@class='AuctionBodyBlock ShortAuctionData']//node()",
        };

        private readonly List<string> ScrapListNodeRule = new List<string>
        {
            "//node()",
            //"//node()[preceding-sibling::div or self::div][following-sibling::div or self::div]",
            //"//node()[preceding-sibling::div][following-sibling::div]",
        };

        private readonly List<string> ScrapListGetLastPage = new List<string>
        {
            "//div[@class='TableContainer']",
            "//div[@class='InnerTableContainer']",
            "//td[@class='PageNavigation']",
            //"//span[@class='PageLink']"
        };

        private readonly List<string> ScrapListGetLastPageAttribute = new List<string>
        {
            "//a"
        };

        private readonly List<string> ScrapListGetUrlStatusInfoAttribute = new List<string>
        {
            "//a"
        };

        private readonly List<string> ScrapListNameWorldInfo = new List<string>
        {
            "//div[@class='AuctionHeader']//a",
        };

        public void RecoverScrapperData()
        {
            string responseString = "";
            base.DictionaryEntity = new Dictionary<string, dynamic>();
            Client = new HttpClient
            {
                BaseAddress = new Uri(base.BaseUrl)
            };
            AddClientHeaders();
            HttpResponseMessage response = Client.GetAsync(base.BaseUrl)
                .GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
                responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            List<string> pageListInfo = RecoverInnerHtmlFromTagList(responseString, ScrapListGetLastPage);
            string pageListInfoLastAttributes = RecoverAttributeFromTagLast(pageListInfo[0], ScrapListGetLastPageAttribute, "href", "nothing");
            LastPage = Convert.ToInt32(pageListInfoLastAttributes.Split('=').LastOrDefault());

            base.DictionaryEntity = new Dictionary<string, dynamic>();

            for (; CurrentPage <= 3 && CurrentPage <= LastPage; CurrentPage++)
                RecoverScrapperDataOnLoop();

            UpdateEntityLastTime();
            CurrentPage = 1;
        }

        public async Task RecoverScrapperDataAsyncPercentage(dynamic formParameter)
        {
            Extender.UpdateComponentValue(Extender.GetControlByName(formParameter.Controls, "prgBarBazaarLoadingInfo"), 10);

            string responseString = "";
            base.DictionaryEntity = new Dictionary<string, dynamic>();
            Client = new HttpClient
            {
                BaseAddress = new Uri(base.BaseUrl)
            };
            AddClientHeaders();

            Extender.UpdateComponentValue(Extender.GetControlByName(formParameter.Controls, "prgBarBazaarLoadingInfo"), 20);

            HttpResponseMessage response = Client.GetAsync(base.BaseUrl)
                .GetAwaiter().GetResult();

            Extender.UpdateComponentValue(Extender.GetControlByName(formParameter.Controls, "prgBarBazaarLoadingInfo"), 30);

            if (response.IsSuccessStatusCode)
                responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            List<string> pageListInfo = RecoverInnerHtmlFromTagList(responseString, ScrapListGetLastPage);
            string pageListInfoLastAttributes = RecoverAttributeFromTagLast(pageListInfo[0], ScrapListGetLastPageAttribute, "href", "nothing");
            LastPage = Convert.ToInt32(pageListInfoLastAttributes.Split('=').LastOrDefault());

            Extender.UpdateComponentValue(Extender.GetControlByName(formParameter.Controls, "prgBarBazaarLoadingInfo"), 40);

            base.DictionaryEntity = new Dictionary<string, dynamic>();

            int progressPercentage = 50;
            for (; CurrentPage <= 1 && CurrentPage <= LastPage; CurrentPage++)
            {
                RecoverScrapperDataOnLoop(formParameter);
                Extender.UpdateComponentValue(Extender.GetControlByName(formParameter.Controls, "prgBarBazaarLoadingInfo"), progressPercentage);

                if (progressPercentage < 85)
                    progressPercentage += 15;
            }
            
            UpdateEntityLastTime();
            CurrentPage = 1;
        }

        public void RecoverScrapperDataOnLoop(dynamic formParameter = null)
        {
            string responseString = "";
            Client = new HttpClient();
            Client.BaseAddress = new Uri($"{base.BaseUrl}{QueryParameters}&currentpage={CurrentPage}");
            AddClientHeaders();
            
            HttpResponseMessage response = Client.PostAsync($"{base.BaseUrl}{QueryParameters}&currentpage={CurrentPage}", new StringContent(""))
                .GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
                responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            List<string> pageListInfo = RecoverInnerHtmlFromTagList(responseString, ScrapListGetLastPage);
            string pageListInfoLastAttributes = RecoverAttributeFromTagLast(pageListInfo[0], ScrapListGetLastPageAttribute, "href", "nothing");
            LastPage = Convert.ToInt32(pageListInfoLastAttributes.Split('=').LastOrDefault());
            List<string> listInfo = RecoverInnerHtmlFromTagList(responseString, ScrapListBasicInfo);
            listInfo.RemoveRange(0, 8);
            listInfo.RemoveAt(listInfo.Count() - 1);
            
            if (formParameter == null)
                BuildDictionaryData(listInfo);
            else
                BuildDictionaryData(listInfo, formParameter);

            Thread.Sleep(TimeStampRequest);
        }

        public void BuildDictionaryData(List<string> listParameter, dynamic extraParams = null)
        {
            int counter = 0;
            BazaarEntity entity = new BazaarEntity();
            foreach (var item in listParameter)
            {
                if (counter == 0)
                {
                    List<string> HeaderInfo = RecoverInnerHtmlFromTagList(item, ScrapListHeaderInfo);
                    List<string> HeaderDetailsInfo = RecoverInnerHtmlFromTagList(HeaderInfo[0], ScrapListNodeRule);
                    string[] LevelSexVocationInfo = HeaderDetailsInfo[6].Split('|');
                    entity = new BazaarEntity()
                    {
                        CharacterName = HeaderDetailsInfo[4],
                        World = HeaderDetailsInfo[7],
                        UrlEntityInfo = RecoverAttributeFromTagFirst(HeaderDetailsInfo[3], ScrapListGetUrlStatusInfoAttribute,
                        "href", "nothing")
                    };

                    entity.Level = Convert.ToInt32(LevelSexVocationInfo[0].Split(':').LastOrDefault().Trim());
                    entity.Vocation = LevelSexVocationInfo[1].Split(':').LastOrDefault().Trim();
                    entity.Sex = LevelSexVocationInfo[2].Trim();

                    List<string> BodyInfo = RecoverInnerHtmlFromTagList(item, ScrapListBodyInfo);
                    List<string> AuctionInfo = RecoverInnerHtmlFromTagList(BodyInfo[0], ScrapListAuctionStartEndInfo);

                    entity.AuctionStarted = AuctionInfo[3];
                    entity.AuctionEnd = AuctionInfo[7];
                    entity.IsBidded = AuctionInfo[10].Contains("Current") ? true : false;
                    entity.MinimumCurrentBid = AuctionInfo[13];
                    
                    if(extraParams != null)
                    {
                        SpecificInfoScrapper = new CharacterSpecificInfoScrapper(entity.UrlEntityInfo);
                        SpecificInfoScrapper.RecoverScrapperSkillsAndName(HeaderDetailsInfo[4], extraParams);
                        entity.SpecifcInformationEntity = SpecificInfoScrapper.Entity;
                    }
                    
                    base.DictionaryEntity.Add(entity.CharacterName, entity);
                }
                else if (counter == 1)
                {
                    counter = 0;
                    continue;
                }

                counter++;
            }
        }

        public BazaarScrapper(string queryParameters) : base($"https://www.tibia.com/charactertrade/?subtopic=currentcharactertrades")
        {
            QueryParameters = queryParameters;
        }
    }
}
