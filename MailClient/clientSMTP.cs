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
        private SmtpClient client;

        private MemoryStream streamLogger;
        private MailKit.ProtocolLogger logger;
        private long StreamPositionStart = 0;

        private string server;
        private int port;
        private string login;
        private string password;
        

        public clientSMTP() 
        {
            initLoggerAndClient();
        }

        public clientSMTP(string server, int port, string login, string password)
        {
            initLoggerAndClient();
            this.server = server;
            this.port = port;
            this.login = login;
            this.password = password;
        }

        private void initLoggerAndClient()
        {
            streamLogger = new MemoryStream(); // Поток для записи в него лога
            logger = new MailKit.ProtocolLogger(streamLogger, true); // Создали логгер и связали с потоком
            logger.Stream.Position = 0;
            this.client = new SmtpClient(logger); // создали объект клиента с логированием
        }

        public void SendMessage(string userFrom, string userTo, string subject, string body, bool TextFormatHtml = true)
        {
            try
            {
                MimeMessage msg = new MimeMessage();
                msg.From.Add(new MailboxAddress("", userFrom));
                msg.To.Add(new MailboxAddress("", userTo));
                msg.Subject = subject;
                if (TextFormatHtml)
                    msg.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };
                else
                    msg.Body = new TextPart(MimeKit.Text.TextFormat.Plain) { Text = body };
                client.Send(msg);
            }
            catch (Exception err) { throw new Exception(err.Message); }
        }

        public void ConnectToServerAndAuthenticate()
        {
            try
            {
                client.Connect(server, port, MailKit.Security.SecureSocketOptions.Auto);
                client.Authenticate(login, password);
            }
            catch (Exception err) {throw new Exception(err.Message); }
        }

        public string getLogAll()
        {
            int offset = 0; // смещение от начального положения
            long StreamPositionCurrent = logger.Stream.Position;
            logger.Stream.Position = 0;
            byte[] bytes = new byte[streamLogger.Length];
            streamLogger.Read(bytes, offset, int.Parse(streamLogger.Length.ToString()) - offset);
            logger.Stream.Position = StreamPositionCurrent;
            string strLog = Encoding.UTF8.GetString(bytes);
            return strLog;
        }

        public string getLogAllAndReadInFile(string path = "")
        {
            if (path == "") path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Log_SMTP.txt";
            string log = getLogAll();
            File.WriteAllText(path, log, Encoding.UTF8);
            return log;
        }

        public bool checkConnectedAndAuthenticated()
        {
            return client.IsConnected && client.IsAuthenticated;
        }

        public void Disconnect()
        {
            try {client.Disconnect(true); } catch (Exception error) { throw new Exception(error.Message); }
        }
    }
}
