using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapperLib.Models
{
    public class HighScoreEntity
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public string Vocation { get; set; }
        public string World { get; set; }
        public int Level { get; set; }
        public long Points { get; set; }
    }
}