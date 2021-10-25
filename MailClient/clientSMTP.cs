using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MimeKit;
using MailKit.Net.Smtp;
using System.IO;

namespace MailClient
{
    public class clientSMTP
    {
        public SmtpClient smtp;
        public MemoryStream streamLogger;
        private MailKit.ProtocolLogger logger;

        public clientSMTP(string server, string port, string login, string password)
        {
            MimeMessage emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("", login));
            emailMessage.To.Add(new MailboxAddress("", login));
            emailMessage.Subject = "проверка";
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            //emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            {
                Text = "ffffffffffffffffaaaaaaaaaaaaaaa"
            };

            initLoggerAndClient();
            try { smtp.Connect(server, int.Parse(port), MailKit.Security.SecureSocketOptions.Auto); } catch (Exception e){throw new Exception(e.Message);}
            try { smtp.Authenticate(login, password); } catch(Exception e) { throw new Exception("");}
            smtp.Send(emailMessage);
            string log = getLog();
            this.Disconnect();
        }

        private void initLoggerAndClient()
        {
            streamLogger = new MemoryStream();
            logger = new MailKit.ProtocolLogger(streamLogger, true);
            logger.Stream.Position = 0;
            this.smtp = new SmtpClient(logger);
        }

        private string getLog()
        {
            logger.Stream.Position = 0;
            byte[] bytes = new byte[streamLogger.Length];
            streamLogger.Read(bytes, 0, int.Parse(streamLogger.Length.ToString()));
            string strLog = Encoding.UTF8.GetString(bytes);
            return strLog;
        }

        public void Disconnect()
        {
            try { this.smtp.Disconnect(true); } catch (Exception error) { throw new Exception(error.Message); }
        }
    }
}
