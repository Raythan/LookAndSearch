using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapperLib.Models
{
    public class CharacterSpecificInformationEntity
    {
        public GeneralInfo General { get; set; }
        public class GeneralInfo
        {
            public string UrlMainOutfit { get; set; }
            #region Part1
            public string HitPoints { get; set; }
            public string Mana { get; set; }
            public string Capacity { get; set; }
            public string Speed { get; set; }
            public string Blessings { get; set; }
            public string Mounts { get; set; }
            public string Outfits { get; set; }
            public string Titles { get; set; }
            #endregion
            #region Part2
            public Dictionary<string, string> SKillsValuePercentage { get; set; }
            #endregion
            #region Part3
            public string CreationDate { get; set; }
            public string Experience { get; set; }
            public string Gold { get; set; }
            public string AchievementPoints { get; set; }
            #endregion
            #region Part4
            public string RegularWorldTransfer { get; set; }
            #endregion
            #region Part5
            public string CharmExpansion { get; set; }
            public string AvailableCharmPoints { get; set; }
            public string SpentCharmPoints { get; set; }
            #endregion
            #region Part6
            public string DailyRewardStreak { get; set; }
            #endregion
            #region Part7
            public string HuntingTaskPoints { get; set; }
            public string PermanentHuntingTaskSlots { get; set; }
            public string PermanentPreySlots { get; set; }
            #endregion
            #region Part8
            public string Hirelings { get; set; }
            public string HirelingJobs { get; set; }
            public string HirelingOutfits { get; set; }
            #endregion
        }

        public CharacterSpecificInformationEntity()
        {
            General = new GeneralInfo();
            General.SKillsValuePercentage = new Dictionary<string, string>();
        }
    }
}
