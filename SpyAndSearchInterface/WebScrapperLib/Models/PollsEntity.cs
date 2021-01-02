using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapperLib.Models
{
    public class PollsEntity
    {
        public string Topic { get; set; }
        public string Anchor { get; set; }
        public string EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
