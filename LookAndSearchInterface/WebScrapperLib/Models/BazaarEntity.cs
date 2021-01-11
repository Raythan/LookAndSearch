using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapperLib.Models
{
    public class BazaarEntity
    {
        public string CharacterName { get; set; }
        public int Level { get; set; }
        public string Vocation { get; set; }
        public string Sex { get; set; }
        public string World { get; set; }
        public string AuctionStarted { get; set; }
        public string AuctionEnd { get; set; }
        public string MinimumCurrentBid { get; set; }
        public bool IsBidded { get; set; }
        public string UrlEntityInfo { get; set; }
        public CharacterSpecificInformationEntity SpecifcInformationEntity = new CharacterSpecificInformationEntity();
    }
}
