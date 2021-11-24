using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailClient
{
    public partial class FormPop3 : Form
    {
        public FormPop3()
        {
            InitializeComponent();
        }

        private clientPOP3 pop3;
        DataTable table;

        // при загрузке формы
        private void FormPop3_Load(object sender, EventArgs e)
        {
            OnEditParameteresConnection(true);
        }

        // кнопка Соединиться
        private void btnEntry_Click(object sender, EventArgs e)
        {
            int port = 0;
            if (txtServer.Text.Length > 0 && int.TryParse(txtPortSmtp.Text, out port) && txtLogin.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                try
                {
                    pop3 = new clientPOP3(txtServer.Text, port, txtLogin.Text, txtPassword.Text);
                    this.Cursor = Cursors.WaitCursor;
                    pop3.ConnectToServerAndAuthenticate();
                    if (pop3.checkConnectedAndAuthenticated())
                    {
                        OnEditParameteresConnection(false);
                        initDataTable();
                    }
                    else throw new Exception("Не удалось установить соединение!");
                    txtLog.Text = pop3.getLogAll();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }
            else
                MessageBox.Show("Заполните все поля для установление соединения!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            if (pop3.listMessage != null && pop3.listMessage.Count > 0)
            {



                table.Rows.Clear();

                for (int j = 0; j < 10; j++) // ЗАПОЛНЕНИЕ СООБЩЕНИЯМИ
                {
                    DataRow dr = table.NewRow();
                    dr[0] = pop3.listMessage[j].MessageId;
                    dr[1] = pop3.listMessage[j].From[0];
                    dr[3] = pop3.listMessage[j].Subject;
                    dr[4] = pop3.listMessage[j].TextBody;
                    table.Rows.Add(dr);
                }

                setCongigOfRowTable(0);
                setCongigOfRowTable(1);
                setCongigOfRowTable(2);
                setCongigOfRowTable(3);
            }
        }
        
        // инициализация таблицы сообщений
        private void initDataTable()
        {
            table = new DataTable("Messages");
            table.Clear();
            table.Columns.Clear();

            table.Columns.Add(new DataColumn("№"));
            table.Columns.Add(new DataColumn("From"));
            table.Columns.Add(new DataColumn("Subject"));
            table.Columns.Add(new DataColumn("Body"));

            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[3].Width = 230;
        }

        private void OnEditParameteresConnection(bool flag)
        {
            txtServer.Enabled = flag;
            txtPortSmtp.Enabled = flag;
            txtLogin.Enabled = flag;
            txtPassword.Enabled = flag;
            btnConnectionOpen.Visible = flag;
            btnConnectionClose.Visible = !flag;
            groupBoxGetMessage.Enabled = !flag;
        }

        // кнопка Закрыть соединение
        private void btnConnectionClose_Click(object sender, EventArgs e)
        {
            if (pop3 != null)
            {
                try
                {
                    pop3.Disconnect();
                }
                catch (Exception err) { MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); }
                finally
                {
                    OnEditParameteresConnection(true);
                }
            }
        }

        // перед закрытием формы
        private void FormPop3_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnConnectionClose_Click(null, null);
        }

        // вывод html в webBrowser
        private void SetHtmlDocumentInWebBrowser(string textHtml)
        {
            webBrowser1.Navigate("about:blank");
            if (webBrowser1.Document != null)
            {
                webBrowser1.Document.Write(string.Empty);
            }
            webBrowser1.DocumentText = textHtml;
        }

        private void setCongigOfRowTable(int i)
        {
            table.Columns[i].ReadOnly = true;
            dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

    }
}

