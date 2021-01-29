using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebScrapperLib.Interfaces;
using WebScrapperLib.Models;

namespace WebScrapperLib.ScrapperController
{
    public class WorldScrapper : BaseScrapperEntity, IWebScrapper
    {
        private readonly List<string> ListWorldsEven = new List<string>()
        {
            "//div",
            "//div[@class='TableContentContainer']",
            "//tr[@class='Even']//td"
        };
        private readonly List<string> ListWorldsOdd = new List<string>()
        {
            "//div",
            "//div[@class='TableContentContainer']",
            "//tr[@class='Odd']//td"
        };
        private readonly List<string> ListWorldsAncorName = new List<string>()
        {
            "//a",
        };
        private readonly List<string> ListTagsBattleEyeIcon = new List<string>()
        {
            "//span",
            "//img",
        };

        public void RecoverScrapperData()
        {
            string product = "";
            base.DictionaryEntity = new Dictionary<string, dynamic>();
            Client = new HttpClient();
            Client.BaseAddress = new Uri(base.BaseUrl);
            AddClientHeaders();
            HttpResponseMessage response = Client.GetAsync(base.BaseUrl)
                .GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
                product = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            List<string> listEvenWorld = RecoverInnerHtmlFromTagList(product, ListWorldsEven);
            List<string> listOddWorld = RecoverInnerHtmlFromTagList(product, ListWorldsOdd);
            
            BuildDictionaryData(listEvenWorld);
            BuildDictionaryData(listOddWorld);
            OrderDictionaryWorld();
            UpdateEntityLastTime();
        }
        
        private void OrderDictionaryWorld()
        {
            base.DictionaryEntity = base.DictionaryEntity
                .OrderBy(o => o.Key)
                .ToDictionary((key) => key.Key, (value) => value.Value);
        }

        public void BuildDictionaryData(List<string> listWorldParameter, dynamic extraParams = null)
        {
            int counter = 0;
            WorldEntity WorldEntity = new WorldEntity();

            foreach (var worldParameter in listWorldParameter)
            {
                if (counter == 0)
                {
                    string innerFromTag = RecoverInnerHtmlFromTagFirst(worldParameter, ListWorldsAncorName);
                    WorldEntity = new WorldEntity(innerFromTag);
                    base.DictionaryEntity.Add(innerFromTag, WorldEntity);
                }
                else if (counter == 1)
                {
                    int intParameter = 0;
                    int.TryParse(worldParameter.Replace(",", "").Replace(".", ""), out intParameter);
                    WorldEntity.Online = intParameter;
                }
                else if (counter == 2)
                    WorldEntity.Location = worldParameter;
                else if (counter == 3)
                    WorldEntity.PvpType = worldParameter;
                else if (counter == 4)
                {
                    string attributeFromTag = RecoverAttributeFromTagFirst(worldParameter, ListTagsBattleEyeIcon, "src", "nothing");
                    WorldEntity.BattleEye = attributeFromTag;
                }
                else if (counter == 5)
                {
                    WorldEntity.AdditionalInformation = worldParameter;
                    counter = 0;
                    continue;
                }

                counter++;
            }
        }

        public WorldScrapper() : base("https://www.tibia.com/community/?subtopic=worlds")
        {
        }
    }
}
