using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapperLib.Models
{
    public abstract class BaseScrapperEntity
    {
        public readonly string BaseUrl;
        public readonly int TimeStampRequest = 3000;
        public Dictionary<string, dynamic> DictionaryEntity { get; set; }
        public DateTime LastUpdateEntity { get; set; }

        public static HttpClient Client = new HttpClient();

        public static void AddClientHeaders()
        {
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Add("accept", "text/html");
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

        public static string RecoverAttributeFromTagFirst(string htmlString, List<string> tagList, string attribute, string defaultAttributeValue)
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
            return RecoverAttributeFromTagFirst(document.Text, tagListForward, attribute, defaultAttributeValue);
        }

        public static string RecoverAttributeFromTagLast(string htmlString, List<string> tagList, string attribute, string defaultAttributeValue)
        {
            HtmlDocument document = new HtmlDocument();
            List<string> tagListForward = new List<string>();
            tagListForward.AddRange(tagList);
            document.LoadHtml(htmlString);

            if (tagList.Count == 1)
            {
                var nodes = document.DocumentNode.SelectNodes(tagList[0]);
                return nodes != null && nodes.Count() > 0 ?
                    nodes.Select(s => s.GetAttributeValue(attribute, defaultAttributeValue)).LastOrDefault() :
                    defaultAttributeValue;
            }

            tagListForward.RemoveAt(0);
            return RecoverAttributeFromTagLast(document.Text, tagListForward, attribute, defaultAttributeValue);
        }

        public static List<string> RecoverAttributeFromTagList(string htmlString, List<string> tagList, string attribute, string defaultAttributeValue)
        {
            HtmlDocument document = new HtmlDocument();
            List<string> tagListForward = new List<string>();
            tagListForward.AddRange(tagList);
            document.LoadHtml(htmlString);

            if (tagList.Count == 1)
            {
                var nodes = document.DocumentNode.SelectNodes(tagList[0]);
                return nodes != null && nodes.Count() > 0 ?
                    nodes.Select(s => s.GetAttributeValue(attribute, defaultAttributeValue)).ToList() : null;
            }

            tagListForward.RemoveAt(0);
            return RecoverAttributeFromTagList(document.Text, tagListForward, attribute, defaultAttributeValue);
        }
        
        public static string RecoverInnerHtmlFromTagFirst(string htmlString, List<string> tagList)
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
            return RecoverInnerHtmlFromTagFirst(document.Text, tagListForward);
        }

        public static string RecoverInnerHtmlFromTagLast(string htmlString, List<string> tagList)
        {
            HtmlDocument document = new HtmlDocument();
            List<string> tagListForward = new List<string>();
            tagListForward.AddRange(tagList);
            document.LoadHtml(htmlString);

            if (tagList.Count == 1)
            {
                var nodes = document.DocumentNode.SelectNodes(tagList[0]);
                string retorno = "";
                retorno = nodes.Select(s => s.InnerHtml).LastOrDefault();

                return retorno;
            }

            tagListForward.RemoveAt(0);
            return RecoverInnerHtmlFromTagLast(document.Text, tagListForward);
        }

        public static List<string> RecoverInnerHtmlFromTagList(string htmlString, List<string> tagList)
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

        public static string RecoverOuterHtmlFromTagFirst(string htmlString, List<string> tagList)
        {
            HtmlDocument document = new HtmlDocument();
            List<string> tagListForward = new List<string>();
            tagListForward.AddRange(tagList);
            document.LoadHtml(htmlString);

            if (tagList.Count == 1)
            {
                var nodes = document.DocumentNode.SelectNodes(tagList[0]);
                string retorno = "";
                retorno = nodes.Select(s => s.OuterHtml).FirstOrDefault();

                return retorno;
            }

            tagListForward.RemoveAt(0);
            return RecoverOuterHtmlFromTagFirst(document.Text, tagListForward);
        }

        public static string RecoverOuterHtmlFromTagLast(string htmlString, List<string> tagList)
        {
            HtmlDocument document = new HtmlDocument();
            List<string> tagListForward = new List<string>();
            tagListForward.AddRange(tagList);
            document.LoadHtml(htmlString);

            if (tagList.Count == 1)
            {
                var nodes = document.DocumentNode.SelectNodes(tagList[0]);
                string retorno = "";
                retorno = nodes.Select(s => s.OuterHtml).LastOrDefault();

                return retorno;
            }

            tagListForward.RemoveAt(0);
            return RecoverOuterHtmlFromTagLast(document.Text, tagListForward);
        }

        public static List<string> RecoverOuterHtmlFromTagList(string htmlString, List<string> tagList)
        {
            HtmlDocument document = new HtmlDocument();
            List<string> tagListForward = new List<string>();
            tagListForward.AddRange(tagList);
            document.LoadHtml(htmlString);

            if (tagList.Count == 1)
            {
                var nodes = document.DocumentNode.SelectNodes(tagList[0]);
                List<string> retorno = new List<string>();
                retorno = nodes.Select(s => s.OuterHtml).ToList();

                return retorno;
            }
            tagListForward.RemoveAt(0);
            return RecoverOuterHtmlFromTagList(document.Text, tagListForward);
        }

        public static string RecoverDocumentNodeInnerTextValue(string htmlString)
        {
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(htmlString);
            return document.DocumentNode.InnerText;
        }

        public virtual void UpdateEntityLastTime() => this.LastUpdateEntity = DateTime.Now;

        public BaseScrapperEntity(string paramUrl)
        {
            this.BaseUrl = paramUrl;
        }
    }
}
