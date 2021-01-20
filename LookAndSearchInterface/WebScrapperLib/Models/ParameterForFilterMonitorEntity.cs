using System.Collections.Generic;

namespace WebScrapperLib.Models
{
    public class ParameterForFilterMonitorEntity
    {
        public List<string> WorldsFilter { get; set; }
        public List<string> VocationsFilter { get; set; }
        public long MaxBidFilter { get; set; }
        public bool IsBiddedFilter { get; set; }
        public int MinLevelFilter { get; set; }
        public int MaxLevelFilter { get; set; }
        public string PropSkillFilter { get; set; }
        public int MinSkillFilter { get; set; }
        public int MaxSkillFilter { get; set; }

        public ParameterForFilterMonitorEntity()
        {
            this.WorldsFilter = new List<string>();
            this.VocationsFilter = new List<string>();
            this.MaxBidFilter = 0;
            this.IsBiddedFilter = false;
            this.MinLevelFilter = 0;
            this.MaxLevelFilter = 10000;
            this.PropSkillFilter = null;
            this.MinSkillFilter = 0;
            this.MaxSkillFilter = 500;
        }
    }
}
