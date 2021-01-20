using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapperLib.Models
{
    public class EmailEntity
    {
        public string SmtpServer { get; }
        public string Username { get; }
        public string Password { get; }
        public string EmailTo { get; set; }
        public string EmailToDisplayName { get; set; }
        public string EmailFrom { get; }
        public string EmailFromDisplayName { get; }
        public string SubjectTitle { get; }
        public string BodyMessage { get; set; }
        public EmailEntity(string bodyMessageParam)
        {
            this.SmtpServer = "smtp.gmail.com";
            this.Username = "usuariofantasmausogeral@gmail.com";
            this.Password = "Ray1234.";
            this.EmailFrom = "usuariofantasmausogeral@gmail.com";
            this.EmailFromDisplayName = "Bazaar Monitor Application";
            this.SubjectTitle = "Character names from monitor";
            this.BodyMessage = bodyMessageParam;
        }
    }
}
