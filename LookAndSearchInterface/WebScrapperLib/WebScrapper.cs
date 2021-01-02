using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using WebScrapperLib.Models;

namespace WebScrapperLib
{
    public static class WebScrapper
    {
        #region Shared attributes
        private static HttpClient Client = new HttpClient();
        #endregion

        #region Polls atributes
        public static Dictionary<string, PollsEntity> DictionaryPollsEntity { get; private set; }
        public static DateTime LastUpdatePollsEntity { get; private set; }
        public static int DictionaryPollsKey { get; private set; } = 0;
        #endregion

        #region Polls scrap list

        private static readonly List<string> ListPollsInfo = new List<string>()
        {
            "//div[@class='polls']",
            "//div[@class='Border_2']",
            "//div[@class='Border_3']",
            "//div[@class='BoxContent']",
            "//table//tr//td//table//tr//td"
        };

        private static readonly List<string> ListPollsTopicInfo = new List<string>()
        {
            "//a"
        };

        #endregion

        #region Polls methods

        public static void RecoverPollsData()
        {
            string responseString = "";
            DictionaryPollsEntity = new Dictionary<string, PollsEntity>();
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://www.tibia.com/community/?subtopic=polls");
            AddClientHeaders();
            HttpResponseMessage response = Client.GetAsync("https://www.tibia.com/community/?subtopic=polls")
                .GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
                responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            List<string> listInfo = RecoverInnerHtmlFromTagList(responseString, ListPollsInfo);
            listInfo.RemoveRange(0, 3);
            DictionaryPollsEntity.Clear();
            BuildDictionaryPolls(listInfo, true);
            UpdateLastPollsTime();
        }

        private static void UpdateLastPollsTime()
        {
            LastUpdatePollsEntity = DateTime.Now;
        }

        private static void BuildDictionaryPolls(List<string> listParameter, bool? isActiveParam = null)
        {
            int counter = 0, listNumericIndex = 0;
            bool isActive = isActiveParam.HasValue ? true : false;
            PollsEntity PollsEntity = new PollsEntity();

            foreach (var parameter in listParameter)
            {
                if (isActive && parameter.Contains("Closed Polls"))
                    break;

                if (counter == 0)
                {
                    string topicName = RecoverInnerHtmlFromTag(parameter, ListPollsTopicInfo);
                    PollsEntity = new PollsEntity()
                    {
                        Topic = topicName,
                        IsActive = isActive,
                        Anchor = RecoverAttributeFromTag(parameter, ListPollsTopicInfo, "href", "nothing")
                    };
                    DictionaryPollsEntity.Add(DictionaryPollsKey.ToString(), PollsEntity);
                    DictionaryPollsKey++;
                }
                else if (counter == 1)
                {
                    PollsEntity.EndDate = parameter.Replace("&#160", "");
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
                BuildDictionaryPolls(listParameter);
            }
        }

        #endregion

        #region HighScore atributes
        public static Dictionary<string, HighScoreEntity> DictionaryHighScoreEntity { get; private set; }
        public static DateTime LastUpdateHighScoreEntity { get; private set; }
        #endregion

        #region HighScore scrap list

        private static List<string> ListHighScoreInfo = new List<string>()
        {
            "//div",
            "//div[@class='TableContentAndRightShadow']",
            "//div[@class='TableContentContainer']//tr//td"
        };

        private static List<string> ListHighScoreNameInfo = new List<string>()
        {
            "//a"
        };

        #endregion

        #region HighScore methods

        public static void RecoverHighScoreData()
        {
            string responseString = "";
            DictionaryHighScoreEntity = new Dictionary<string, HighScoreEntity>();
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
            DictionaryHighScoreEntity.Clear();
            BuildDictionaryHighScore(listHighScore);
            UpdateLastHighScoreTime();
        }

        private static void UpdateLastHighScoreTime()
        {
            LastUpdateHighScoreEntity = DateTime.Now;
        }

        private static void BuildDictionaryHighScore(List<string> listParameter)
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
                    DictionaryHighScoreEntity.Add(innerFromTag, HighScoreEntity);
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

        #endregion

        #region World attributes
        public static Dictionary<string, WorldEntity> DictionaryWorldEntity { get; private set; }
        public static DateTime LastUpdateWorldEntity { get; private set; }
        #endregion

        #region World scrap list

        private static List<string> ListWorldsEven = new List<string>()
        {
            "//div",
            "//div[@class='TableContentContainer']",
            "//tr[@class='Even']//td"
        };
        private static List<string> ListWorldsOdd = new List<string>()
        {
            "//div",
            "//div[@class='TableContentContainer']",
            "//tr[@class='Odd']//td"
        };
        private static List<string> ListWorldsAncorName = new List<string>()
        {
            "//a",
        };
        private static List<string> ListTagsBattleEyeIcon = new List<string>()
        {
            "//span",
            "//img",
        };

        #endregion

        #region World methods

        public static void RecoverWorldsData()
        {
            string product = "";
            DictionaryWorldEntity = new Dictionary<string, WorldEntity>();
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://www.tibia.com/community/?subtopic=worlds");
            AddClientHeaders();
            HttpResponseMessage response = Client.GetAsync("https://www.tibia.com/community/?subtopic=worlds").GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
                product = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            List<string> listEvenWorld = RecoverInnerHtmlFromTagList(product, ListWorldsEven);
            List<string> listOddWorld = RecoverInnerHtmlFromTagList(product, ListWorldsOdd);

            DictionaryWorldEntity.Clear();
            BuildDictionaryWorld(listEvenWorld);
            BuildDictionaryWorld(listOddWorld);
            OrderDictionaryWorld();
            UpdateLastWorldTime();
        }

        private static void UpdateLastWorldTime()
        {
            LastUpdateWorldEntity = DateTime.Now;
        }

        private static void OrderDictionaryWorld()
        {
            DictionaryWorldEntity = DictionaryWorldEntity
                .OrderBy(o => o.Key)
                .ToDictionary((key) => key.Key, (value) => value.Value);
        }

        private static void BuildDictionaryWorld(List<string> listWorldParameter)
        {
            int counter = 0;
            WorldEntity WorldEntity = new WorldEntity();

            foreach (var worldParameter in listWorldParameter)
            {
                if (counter == 0)
                {
                    string innerFromTag = RecoverInnerHtmlFromTag(worldParameter, ListWorldsAncorName);
                    WorldEntity = new WorldEntity(innerFromTag);
                    DictionaryWorldEntity.Add(innerFromTag, WorldEntity);
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
                    string attributeFromTag = RecoverAttributeFromTag(worldParameter, ListTagsBattleEyeIcon, "src", "nothing");
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

        #endregion

        #region Shared methods

        private static string RecoverAttributeFromTag(string htmlString, List<string> tagList, string attribute, string defaultAttributeValue)
        {
            HtmlDocument document = new HtmlDocument();
            List<string> tagListForward = new List<string>();
            tagListForward.AddRange(tagList);
            document.LoadHtml(htmlString);

            if (tagList.Count == 1)
            {
                var nodes = document.DocumentNode.SelectNodes(tagList[0]);
                return nodes != null && nodes.Count() > 0 ?
                    nodes.Select(s => s.GetAttributeValue(attribute, defaultAttributeValue)).FirstOrDefault() :
                    defaultAttributeValue;
            }

            tagListForward.RemoveAt(0);
            return RecoverAttributeFromTag(document.Text, tagListForward, attribute, defaultAttributeValue);
        }

        private static string RecoverInnerHtmlFromTag(string htmlString, List<string> tagList)
        {
            HtmlDocument document = new HtmlDocument();
            List<string> tagListForward = new List<string>();
            tagListForward.AddRange(tagList);
            document.LoadHtml(htmlString);

            if (tagList.Count == 1)
            {
                var nodes = document.DocumentNode.SelectNodes(tagList[0]);
                string retorno = "";
                retorno = nodes.Select(s => s.InnerHtml).FirstOrDefault();

                return retorno;
            }

            tagListForward.RemoveAt(0);
            return RecoverInnerHtmlFromTag(document.Text, tagListForward);
        }

        private static List<string> RecoverInnerHtmlFromTagList(string htmlString, List<string> tagList)
        {
            HtmlDocument document = new HtmlDocument();
            List<string> tagListForward = new List<string>();
            tagListForward.AddRange(tagList);
            document.LoadHtml(htmlString);

            if (tagList.Count == 1)
            {
                var nodes = document.DocumentNode.SelectNodes(tagList[0]);
                List<string> retorno = new List<string>();
                retorno = nodes.Select(s => s.InnerHtml).ToList();

                return retorno;
            }
            tagListForward.RemoveAt(0);
            return RecoverInnerHtmlFromTagList(document.Text, tagListForward);
        }

        private static void AddClientHeaders()
        {
            Client.DefaultRequestHeaders.Clear();
            //Client.DefaultRequestHeaders.Add("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            Client.DefaultRequestHeaders.Add("accept", "text/html");
            //Client.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
            Client.DefaultRequestHeaders.Add("accept-encoding", "UTF-8");
            Client.DefaultRequestHeaders.Add("accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            Client.DefaultRequestHeaders.Add("cache-control", "no-cache");
            Client.DefaultRequestHeaders.Add("cookie", "__cfduid=df4aba1030b9ada4d3ad6ac0addfeb06a1607818705; cf_clearance=0a6991fa94f7d778b0dcfc435281fca9995c516e-1608659141-0-150; SessionLastVisit=1608659186; DM_LandingPage=visited; DM_SessionID=ebf66963c897d3fdcf73c7ed5c915dab1609171284");
            Client.DefaultRequestHeaders.Add("pragma", "no-cache");
            Client.DefaultRequestHeaders.Add("sec-fetch-dest", "document");
            Client.DefaultRequestHeaders.Add("sec-fetch-mode", "navigate");
            Client.DefaultRequestHeaders.Add("sec-fetch-site", "none");
            Client.DefaultRequestHeaders.Add("sec-fetch-user", "?1");
            Client.DefaultRequestHeaders.Add("upgrade-insecure-requests", "1");
            Client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36");
        }

        #endregion
    }
}
