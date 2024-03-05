using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record.SMTP
{
    internal class EmailSender
    {
        public static void SendEmail(string recipient, string subject, string body)
        {
            using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
            {
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("adriel.dev.123@gmail.com", "llwlvuksnrvfzeuo");
                client.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage("adriel.dev.123@gmail.com", recipient))
                {
                    mailMessage.Subject = subject;
                    mailMessage.Body = body;

                    client.Send(mailMessage);
                }
            }
        }
    }
}
