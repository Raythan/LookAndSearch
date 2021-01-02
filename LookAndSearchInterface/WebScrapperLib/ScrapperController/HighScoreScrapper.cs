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
    public class HighScoreScrapper : BaseScrapperEntity, IWebScrapper
    {
        private readonly List<string> ListHighScoreInfo = new List<string>()
        {
            "//div",
            "//div[@class='TableContentAndRightShadow']",
            "//div[@class='TableContentContainer']//tr//td"
        };

        private readonly List<string> ListHighScoreNameInfo = new List<string>()
        {
            "//a"
        };

        public void RecoverScrapperData()
        {
            string responseString = "";
            DictionaryEntity = new Dictionary<string, dynamic>();
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://www.tibia.com/community/?subtopic=highscores");
            AddClientHeaders();
            HttpResponseMessage response = Client.GetAsync("https://www.tibia.com/community/?subtopic=highscores")
                .GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
                responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            List<string> listHighScore = RecoverInnerHtmlFromTagList(responseString, ListHighScoreInfo);
            listHighScore.RemoveRange(0, 6);
            listHighScore.RemoveAt(listHighScore.Count() - 1);
            DictionaryEntity.Clear();
            BuildDictionaryData(listHighScore);
            LastUpdateEntityTime();
        }

        public void LastUpdateEntityTime()
        {
            base.LastUpdateEntity = DateTime.Now;
        }

        public void BuildDictionaryData(List<string> listParameter, dynamic extraParams = null)
        {
            int counter = 0;
            HighScoreEntity HighScoreEntity = new HighScoreEntity();

            foreach (var parameter in listParameter)
            {
                if (counter == 0)
                {
                    HighScoreEntity = new HighScoreEntity()
                    {
                        Rank = Convert.ToInt32(parameter)
                    };
                }
                else if (counter == 1)
                {
                    string innerFromTag = RecoverInnerHtmlFromTag(parameter, ListHighScoreNameInfo);
                    HighScoreEntity.Name = innerFromTag;
                    DictionaryEntity.Add(innerFromTag, HighScoreEntity);
                }
                else if (counter == 2)
                    HighScoreEntity.Vocation = parameter;
                else if (counter == 3)
                    HighScoreEntity.World = parameter;
                else if (counter == 4)
                    HighScoreEntity.Level = Convert.ToInt32(parameter);
                else if (counter == 5)
                {
                    HighScoreEntity.Points = Convert.ToInt64(parameter.Replace(",", "").Replace(".", ""));
                    counter = 0;
                    continue;
                }

                counter++;
            }
        }
    }
}
