using System.Collections.Generic;
using System.ComponentModel;

namespace WebScrapperLib.Models
{
    public class CharacterInfoEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Sex { get; set; }
        public string Vocation { get; set; }
        public string Level { get; set; }
        public string AchievementPoints { get; set; }
        public string World { get; set; }
        public string Residence { get; set; }
        public string MarriedTo { get; set; }
        public string GuildMembership { get; set; }
        public string LastLogin { get; set; }
        public string Comment { get; set; }
        public string AccountStatus { get; set; }
        public List<AchievementType> AccountAchievement { get; set; }
        public List<CharacterGrid> Characters { get; set; }
        public string LoyaltyTitle { get; set; }
        public string Created { get; set; }
        public List<CharacterDeath> CharacterDeaths { get; set; }
    }
    public class CharacterGrid
    {
        [Description("Character Name")]
        public string Name { get; set; }
        [Description("Character World")]
        public string World { get; set; }
        [Description("Character Status")]
        public string Status { get; set; }
        [Description("Character Main")]
        public string MainCharacter { get; set; }
    }
    public class CharacterDeath
    {
        [Description("Death Time")]
        public string DeathTime { get; set; }
        [Description("Death Cause")]
        public string DeathCause { get; set; }
    }
    public class AchievementType
    {
        [Description("Achievement Name")]
        public string AchievementName { get; set; }
        [Description("Secret?")]
        public string Secret { get; set; }
        [Description("Achievement Level")]
        public int AchievementLevel { get; set; }
    }
}
