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
    public class PollsScrapper : BaseScrapperEntity, IWebScrapper
    {
        public static int DictionaryPollsKey { get; private set; } = 0;

        private readonly List<string> ScrapListBasicInfo = new List<string>
        {
            "//div[@class='polls']",
            "//div[@class='Border_2']",
            "//div[@class='Border_3']",
            "//div[@class='BoxContent']",
            "//table//tr//td//table//tr//td"
        };

        private readonly List<string> ListPollsTopicInfo = new List<string>
        {
            "//a"
        };

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
            listInfo.RemoveRange(0, 3);
            BuildDictionaryData(listInfo, true);
            UpdateEntityLastTime();
        }

        public void BuildDictionaryData(List<string> listParameter, dynamic isActiveParam = null)
        {
            int counter = 0, listNumericIndex = 0;
            bool isActive = isActiveParam != null ? true : false;
            PollsEntity PollsEntity = new PollsEntity();

            foreach (var parameter in listParameter)
            {
                if (isActive && parameter.Contains("Closed Polls"))
                    break;

                if (counter == 0)
                {
                    string topicName = RecoverInnerHtmlFromTagFirst(parameter, ListPollsTopicInfo);
                    PollsEntity = new PollsEntity()
                    {
                        Topic = topicName,
                        IsActive = isActive,
                        Anchor = RecoverAttributeFromTagFirst(parameter, ListPollsTopicInfo, "href", "nothing")
                    };
                    DictionaryEntity.Add(DictionaryPollsKey.ToString(), PollsEntity);
                    DictionaryPollsKey++;
                }
                else if (counter == 1)
                {
                    PollsEntity.EndDate = parameter;
                    counter = 0;
                    listNumericIndex++;
                    continue;
                }

                listNumericIndex++;
                counter++;
            }

            if (isActive)
            {
                listParameter.RemoveRange(0, listNumericIndex + 3);
                BuildDictionaryData(listParameter);
            }
        }

        public PollsScrapper() : base("https://www.tibia.com/community/?subtopic=polls")
        {
        }
    }
}
