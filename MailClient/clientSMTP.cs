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
        private int StreamPositionStart = 0;
        private string server;
        private int port;
        private string login;
        private string password;
        MimeMessage msg;

        public clientSMTP() 
        {
            msg = new MimeMessage();
            initLoggerAndClient();
        }

        public clientSMTP(string server, int port, string login, string password)
        {
            initLoggerAndClient();
            msg = new MimeMessage();

            msg.From.Add(new MailboxAddress("", login));
            msg.To.Add(new MailboxAddress("", login));
            msg.Subject = "проверка";
            msg.Body = new TextPart(MimeKit.Text.TextFormat.Html)

            //emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            {
                Text = "ffffffffffffffff"
            };

            
            try { smtp.Connect(server, port, MailKit.Security.SecureSocketOptions.Auto); } catch (Exception e) { throw new Exception(e.Message); }
            try { smtp.Authenticate(login, password); } catch (Exception e) { throw new Exception(""); }

            smtp.Send(msg);
            string log = getLogAll();
            this.Disconnect();
            
        }

        public void ConnectToServerAndAuthenticate()
        {
            try
            {
                smtp.Connect(server, port, MailKit.Security.SecureSocketOptions.Auto);
                smtp.Authenticate(login, password);
            }
            catch (Exception err) {throw new Exception(err.Message); }
        }

        private void initLoggerAndClient()
        {
            streamLogger = new MemoryStream();
            logger = new MailKit.ProtocolLogger(streamLogger, true);
            logger.Stream.Position = 0;
            this.smtp = new SmtpClient(logger);
        }

        public string getLogAll()
        {
            int offset = 0; // смещение от начального положения
            logger.Stream.Position = 0;
            byte[] bytes = new byte[streamLogger.Length];
            streamLogger.Read(bytes, offset, int.Parse(streamLogger.Length.ToString()) - offset);
            string strLog = Encoding.UTF8.GetString(bytes);
            return strLog;
        }

        public bool checkConnectedAndAuthenticated()
        {
            return smtp.IsConnected && smtp.IsAuthenticated;
        }

        public void Disconnect()
        {
            try {smtp.Disconnect(true); } catch (Exception error) { throw new Exception(error.Message); }
        }
    }
}
