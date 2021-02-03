using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WebScrapperLib.Models;

namespace WebScrapperLib.Utils
{
    public static class EmailSender
    {
        public static void SendEmail(EmailEntity emailEntity)
        {
            try
            {
                SmtpClient mySmtpClient = new SmtpClient(emailEntity.SmtpServer);
                mySmtpClient.Port = 587;
                mySmtpClient.EnableSsl = true;

                // set smtp-client with basicAuthentication
                mySmtpClient.UseDefaultCredentials = false;
                NetworkCredential basicAuthenticationInfo = new NetworkCredential(emailEntity.Username, emailEntity.Password);
                mySmtpClient.Credentials = basicAuthenticationInfo;

                // add from,to mailaddresses
                MailAddress from = new MailAddress(emailEntity.EmailFrom, emailEntity.EmailFromDisplayName);
                MailAddress to = new MailAddress(emailEntity.EmailTo, emailEntity.EmailToDisplayName);
                MailMessage myMail = new MailMessage(from, to);

                //// add ReplyTo
                //MailAddress replyTo = new MailAddress("reply@example.com");
                //myMail.ReplyToList.Add(replyTo);

                // set subject and encoding
                myMail.Subject = emailEntity.SubjectTitle;
                myMail.SubjectEncoding = Encoding.UTF8;

                // set body-message and encoding
                myMail.Body = emailEntity.BodyMessage;
                myMail.BodyEncoding = Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = true;

                mySmtpClient.Send(myMail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
