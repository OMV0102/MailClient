using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Pop3;
using System.IO;

namespace MailClient
{
    public class clientPOP3
    {
        public Pop3Client client;

        private MemoryStream streamLogger;
        private MailKit.ProtocolLogger logger;
        
        private string server;
        private int port;
        private string login;
        private string password;

        public List<MimeMessage> listMessage;

        public clientPOP3()
        {
            initLoggerAndClient();
        }

        public clientPOP3(string server, int port, string login, string password)
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
            this.client = new Pop3Client(logger); // создали объект клиента с логированием
        }

        public List<MimeMessage> GetMessages(int countRequested = 10)
        {
            if (client.GetMessageCount() < countRequested) countRequested = client.GetMessageCount();
            listMessage = new List<MimeMessage>();
            MimeMessage msg;
            try
            {
                for (int i = client.GetMessageCount() - 1, j = 0; i > 0 && j < countRequested; i--, j++)
                {
                    msg = client.GetMessage(i);
                    listMessage.Add(msg);
                }
            }
            catch (Exception err) { throw new Exception(err.Message); }

            return listMessage;
        }

        public void DeleteMessage(int index)
        {
            client.DeleteMessage((client.GetMessageCount()-1) - index);
        }

        public void ConnectToServerAndAuthenticate()
        {
            try
            {
                client.Connect(server, port, MailKit.Security.SecureSocketOptions.Auto);
                client.Authenticate(login, password);
            }
            catch (Exception err) { throw new Exception(err.Message); }
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
            if (path == "") path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Log_POP3.txt";
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
            try { client.Disconnect(true); } catch (Exception error) { throw new Exception(error.Message); }
        }
    }
}
