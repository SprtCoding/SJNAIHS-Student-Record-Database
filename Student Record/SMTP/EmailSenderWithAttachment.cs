using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record.SMTP
{
    internal class EmailSenderWithAttachment
    {
        public static void SendEmail(string recipient, string subject, string body, List<string> attachments)
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

                    // Attach files
                    foreach (string attachmentPath in attachments)
                    {
                        if (File.Exists(attachmentPath))
                        {
                            Attachment attachment = new Attachment(attachmentPath);
                            mailMessage.Attachments.Add(attachment);
                        }
                        else
                        {
                            throw new FileNotFoundException($"Attachment file not found: {attachmentPath}");
                        }
                    }

                    client.Send(mailMessage);
                }
            }
        }
    }
}
