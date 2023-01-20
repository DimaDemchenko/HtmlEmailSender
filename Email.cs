using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML_email_sender
{
    public class Email
    {
        public string smtp { get; set; }
        public int port { get; set; }
        public string login { get; set; }
        public string pass { get; set; }
        public string sendTo { get; set; }
        public string sendFrom { get; set; }
        public string emailSubject { get; set; }
        public string HTMLtext { get; set; }

        public void SendMail()
        {
            MimeMessage message = new MimeMessage();
            var bodyBuilderHTML = new BodyBuilder();
            message.From.Add(new MailboxAddress($"{this.sendFrom}", $"{this.login}"));
            message.To.Add(MailboxAddress.Parse(this.sendTo));
            message.Subject = $"{this.emailSubject}";
            bodyBuilderHTML.HtmlBody = $"{this.HTMLtext}";
            message.Body = bodyBuilderHTML.ToMessageBody();

            MailKit.Net.Smtp.SmtpClient smtp = new MailKit.Net.Smtp.SmtpClient();
            try
            {
                smtp.Connect(this.smtp, this.port, false);
                smtp.Authenticate(this.login, this.pass);
                smtp.Send(message);
                MessageBox.Show("Відправлено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            finally
            {
                smtp.Disconnect(true);
                smtp.Dispose();
            }

        }
    }
}
