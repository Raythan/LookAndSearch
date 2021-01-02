using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapperLib.Models
{
    public class WorldEntity
    {
        public string World { get; set; }
        public int Online { get; set; }
        public string Location { get; set; }
        public string PvpType { get; set; }
        public string BattleEye { get; set; }
        public string AdditionalInformation { get; set; }
        public WorldEntity() { }
        public WorldEntity(string worldParam) => this.World = worldParam;
    }
}
