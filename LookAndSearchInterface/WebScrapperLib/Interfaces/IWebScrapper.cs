using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapperLib.Interfaces
{
    public interface IWebScrapper
    {
        void RecoverScrapperData();
        void LastUpdateEntityTime();
        void BuildDictionaryData(List<string> listParameter, dynamic extraParams);
    }
}
