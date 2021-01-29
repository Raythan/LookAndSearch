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
    public class CharacterScrapper : BaseScrapperEntity, IWebScrapper
    {
        public string CharacterName;
        public CharacterInfoEntity CharacterEntity;
        private readonly List<string> ScrapListBasicInfo = new List<string>
        {
            "//div[@class='Border_2']",
            "//div[@class='Border_3']",
            "//div[@class='BoxContent']",
            "//table"
        };

        private readonly List<string> ScrapListAllTdInformation = new List<string>
        {
            "//td"
        };
        private readonly List<string> ScrapListAllImgInformation = new List<string>
        {
            "//img"
        };
        private readonly List<string> ScrapListAllAnchorInformation = new List<string>
        {
            "//a"
        };
        private readonly List<string> ScrapListIsCharacterInformation = new List<string>
        {
            "//b"
        };
        private readonly List<string> ScrapListAllNobrInformation = new List<string>
        {
            "//nobr"
        };
        private readonly List<string> ScrapListIsAccountAchievement = new List<string>
        {
            "//b"
        };
        private readonly List<string> ScrapListIsCharacterDeaths = new List<string>
        {
            "//b"
        };
        private readonly List<string> ScrapListIsAccountInformation = new List<string>
        {
            "//b"
        };
        private readonly List<string> ScrapListIsCharacters = new List<string>
        {
            "//b"
        };
        private readonly List<string> ScrapListIsSearchCharacter = new List<string>
        {
            "//b"
        };
        private readonly List<string> ScrapListIsSubmitButton = new List<string>
        {
            "//input"
        };
        private readonly List<string> ScrapListIsCharacterForm = new List<string>
        {
            "//form"
        };
        public void RecoverScrapperData()
        {
            string responseString = "";
            base.DictionaryEntity = new Dictionary<string, dynamic>();
            Client = new HttpClient();
            Client.BaseAddress = new Uri(base.BaseUrl);
            AddClientHeaders();
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("name", this.CharacterName),
                new KeyValuePair<string, string>("Submit.x", "29"),
                new KeyValuePair<string, string>("Submit.y", "11")
            });

            HttpResponseMessage response = Client.PostAsync(base.BaseUrl, content)
                .GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
                responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            List<string> listInfo = RecoverInnerHtmlFromTagList(responseString, ScrapListBasicInfo);
            listInfo = Extender.CleanListName(listInfo);

            if(IsRelationedFieldInnerHtml(listInfo[0], ScrapListIsCharacterInformation, "Character Information"))
                BuildDictionaryData(listInfo, true);
            
            UpdateEntityLastTime();
        }

        public void BuildDictionaryData(List<string> listParameter, dynamic extraParams = null)
        {
            string teste = "";
            CharacterEntity = new CharacterInfoEntity();
            foreach (string item in listParameter)
            {
                if(IsRelationedFieldInnerHtml(item, ScrapListIsCharacterInformation, "Character Information"))
                {
                    var tdsFromHtml = RecoverInnerHtmlFromTagList(item, ScrapListAllTdInformation);

                    foreach(var item2 in tdsFromHtml)
                    {
                        int indexOfItemPlusOne = tdsFromHtml.IndexOf(item2) + 1;
                        if (item2.Contains("Name:"))
                            CharacterEntity.Name = RemoveAllTagsFromString(tdsFromHtml[indexOfItemPlusOne]);
                        else if (item2.Contains("Title:"))
                            CharacterEntity.Title = tdsFromHtml[indexOfItemPlusOne];
                        else if (item2.Contains("Sex:"))
                            CharacterEntity.Sex = tdsFromHtml[indexOfItemPlusOne];
                        else if (item2.Contains("Vocation:"))
                            CharacterEntity.Vocation = tdsFromHtml[indexOfItemPlusOne];
                        else if (item2.Contains("Level:"))
                            CharacterEntity.Level = tdsFromHtml[indexOfItemPlusOne];
                        else if (item2.Contains("Achievement Points:"))
                            CharacterEntity.AchievementPoints = tdsFromHtml[indexOfItemPlusOne];
                        else if (item2.Contains("World:"))
                            CharacterEntity.World = tdsFromHtml[indexOfItemPlusOne];
                        else if (item2.Contains("Residence:"))
                            CharacterEntity.Residence = tdsFromHtml[indexOfItemPlusOne];
                        else if (item2.Contains("Last Login:"))
                            CharacterEntity.LastLogin = Extender.FormatAuctionDateFromEntity(tdsFromHtml[indexOfItemPlusOne], 0);
                        else if (item2.Contains("Account Status:"))
                            CharacterEntity.AccountStatus = RemoveAllTagsFromString(tdsFromHtml[indexOfItemPlusOne]);
                        else if (item2.Contains("Married To:"))
                            CharacterEntity.MarriedTo = RemoveAllTagsFromString(tdsFromHtml[indexOfItemPlusOne]);
                        else if (item2.Contains("Guild&#160;Membership:"))
                            CharacterEntity.GuildMembership = Extender.CleanHtmlWhiteSpace(RemoveAllTagsFromString(tdsFromHtml[indexOfItemPlusOne]));
                        else if (item2.Contains("Comment:"))
                            CharacterEntity.Comment = RemoveAllTagsFromString(tdsFromHtml[indexOfItemPlusOne]);
                    }

                    continue;
                }
                else if (IsRelationedFieldInnerHtml(item, ScrapListIsAccountAchievement, "Account Achievements"))
                {
                    var tdsFromHtml = RecoverInnerHtmlFromTagList(item, ScrapListAllTdInformation);
                    CharacterEntity.AccountAchievement = new List<AchievementType>();
                    int counter = 0;
                    foreach (var tdFromHtml in tdsFromHtml)
                    {
                        if (counter == 0)
                        {
                            counter++;
                            continue;
                        }
                        
                        if(counter % 2 == 0)
                        {
                            var achievementToAdd = new AchievementType();
                            achievementToAdd.AchievementName = tdFromHtml.Contains("<img") ? tdFromHtml.Substring(0, tdFromHtml.IndexOf("<img")) : tdFromHtml;
                            achievementToAdd.Secret = tdFromHtml.Contains("achievement-secret") ? "Secret" : "";
                            achievementToAdd.AchievementLevel = RecoverInnerHtmlFromTagList(tdsFromHtml[tdsFromHtml.IndexOf(tdFromHtml) - 1], ScrapListAllImgInformation).Count;
                            CharacterEntity.AccountAchievement.Add(achievementToAdd);
                        }
                        counter++;
                    }
                }
                else if (IsRelationedFieldInnerHtml(item, ScrapListIsCharacterDeaths, "Character Deaths"))
                {
                    var tdsFromHtml = RecoverInnerHtmlFromTagList(item, ScrapListAllTdInformation);
                    CharacterEntity.CharacterDeaths = new List<CharacterDeath>();
                    int counter = 0;
                    foreach (var tdFromHtml in tdsFromHtml)
                    {
                        if (counter == 0)
                        {
                            counter++;
                            continue;
                        }

                        if (counter % 2 == 0)
                        {
                            var deathToAdd = new CharacterDeath()
                            {
                                DeathTime = Extender.FormatAuctionDateFromEntity(tdsFromHtml[tdsFromHtml.IndexOf(tdFromHtml) - 1], 0),
                                DeathCause = tdFromHtml
                            };
                            CharacterEntity.CharacterDeaths.Add(deathToAdd);
                        }
                        counter++;
                    }
                }
                else if (IsRelationedFieldInnerHtml(item, ScrapListIsAccountInformation, "Account Information"))
                {
                    var tdsFromHtml = RecoverInnerHtmlFromTagList(item, ScrapListAllTdInformation);
                    CharacterEntity.LoyaltyTitle = tdsFromHtml[2];
                    CharacterEntity.Created = Extender.FormatAuctionDateFromEntity(tdsFromHtml[4], 0);
                }
                else if (IsRelationedFieldInnerHtml(item, ScrapListIsCharacters, "Characters"))
                {
                    var tdsFromHtml = RecoverInnerHtmlFromTagList(item, ScrapListAllTdInformation);
                    tdsFromHtml.RemoveRange(0, 5);
                    CharacterEntity.Characters = new List<CharacterGrid>();
                    int counter = 0;
                    var characterToAdd = new CharacterGrid();
                    foreach (var tdFromHtml in tdsFromHtml)
                    {
                        switch (counter)
                        {
                            case 0:
                                characterToAdd.Name = Extender.CleanHtmlWhiteSpace(RecoverInnerHtmlFromTagFirst(tdFromHtml, ScrapListAllNobrInformation)
                                    .Split('.').LastOrDefault());
                                characterToAdd.MainCharacter = tdFromHtml.Contains("maincharacter") ? "Main" : "";
                                break;
                            case 1:
                                characterToAdd.World = RecoverInnerHtmlFromTagFirst(tdFromHtml, ScrapListAllNobrInformation);
                                break;
                            case 2:
                                characterToAdd.Status = tdFromHtml.Contains("blank.gif") ? "Offline" : "Online";
                                break;
                            //case 3:
                            //    break;
                            case 4:
                                CharacterEntity.Characters.Add(characterToAdd);
                                counter = 0;
                                characterToAdd = new CharacterGrid();
                                continue;
                            default:
                                break;
                        }
                        
                        counter++;
                    }
                    teste = "";
                }
                else if (IsRelationedFieldInnerHtml(item, ScrapListIsSearchCharacter, "Search Character"))
                    break;
            }
            teste = "";
        }

        private bool IsRelationedFieldInnerCount(string param, List<string> scrapListParameter)
        {
            try
            {
                return RecoverInnerHtmlFromTagList(param, scrapListParameter).Count > 0;
            }
            catch
            {
                return false;
            }
        }

        private bool IsRelationedFieldAttributeFromTag(string param, List<string> scrapListParameter, string attributeParam, string defaultAttributeParam)
        {
            try
            {
                return RecoverAttributeFromTagFirst(param, scrapListParameter, attributeParam, defaultAttributeParam).Equals(this.CharacterName);
            }
            catch
            {
                return false;
            }
        }

        private bool IsRelationedFieldInnerHtml(string param, List<string> scrapListParameter, string parameterField)
        {
            try
            {
                return RecoverInnerHtmlFromTagFirst(param, scrapListParameter).Contains(parameterField);
            }
            catch
            {
                return false;
            }
        }
        
        public CharacterScrapper(string nameParam) : base("https://www.tibia.com/community/?subtopic=characters")
        {
            this.CharacterName = nameParam;
        }
    }
}
