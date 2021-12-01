using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            OnOffEditParameteresConnection(true);
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
                        OnOffEditParameteresConnection(false);
                        initDataTable();
                        //btnRefreshList_Click(null, null); // как подсоединились, сразу же загрузить список писем
                    }
                    else throw new Exception("Не удалось установить соединение!");
                    txtLog.Text = pop3.getLogAllAndReadInFile();
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
        
        // кнопка обновить список
        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            try
            {
                pop3.GetMessages(10);
                if (pop3.listMessage != null && pop3.listMessage.Count > 0)
                {
                    int N = pop3.listMessage.Count;
                    table.Rows.Clear();

                    for (int j = 0; j < N; j++) // ЗАПОЛНЕНИЕ СООБЩЕНИЯМИ
                    {
                        DataRow dr = table.NewRow();
                        //dr[0] = pop3.listMessage[j].MessageId;
                        dr[0] = j;
                        dr[1] = pop3.listMessage[j].Date.ToString("d");
                        dr[2] = pop3.listMessage[j].From.ToString();
                        dr[3] = pop3.listMessage[j].Subject;
                        //dr[3] = pop3.listMessage[j].HtmlBody;
                        table.Rows.Add(dr);
                    }
                }
                else
                {
                    MessageBox.Show("Входящих писем нет!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                txtLog.Text = pop3.getLogAllAndReadInFile();
            }
            catch (Exception err) { MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); }
        }
        
        // инициализация таблицы сообщений
        private void initDataTable()
        {
            table = new DataTable("Messages");
            table.Clear();
            table.Columns.Clear();
            table.Rows.Clear();
            dataGridView1.ClearSelection();
            //dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();


            table.Columns.Add(new DataColumn("№"));
            table.Columns.Add(new DataColumn("Date"));
            table.Columns.Add(new DataColumn("From"));
            table.Columns.Add(new DataColumn("Subject"));
            //table.Columns.Add(new DataColumn("Body"));
            dataGridView1.DataSource = table;
            setSizeForDataGrid(0);
            setSizeForDataGrid(1);
            setSizeForDataGrid(2);
            setSizeForDataGrid(3);
        }

        private void setSizeForDataGrid(int i)
        {
            dataGridView1.Columns[i].ReadOnly = true;
            dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 300;
        }

        private void OnOffEditParameteresConnection(bool flag)
        {
            groupBoxConnect.Enabled = flag;
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
                    table.Clear();
                    table.Columns.Clear();
                    table.Rows.Clear();
                    dataGridView1.ClearSelection();
                    dataGridView1.Columns.Clear();
                    //dataGridView1.Rows.Clear();
                    SetHtmlDocumentInWebBrowser("<!doctype html><HTML></HTML>");
                    pop3.Disconnect();
                    txtLog.Text = pop3.getLogAllAndReadInFile();
                }
                catch (Exception err) { MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); }
                finally
                {
                    OnOffEditParameteresConnection(true);
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
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\temp.html";
            File.WriteAllText(path, textHtml, Encoding.UTF8);
            String uriString = String.Format("file:///{0}", path)/*.Replace("\\", "/")*/;
            webBrowser1.Navigate(new Uri(uriString));
            webBrowser1.Refresh();
        }


        // выбор письма из списка
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string htmlText = pop3.listMessage[dataGridView1.CurrentRow != null ? dataGridView1.CurrentRow.Index : 0].HtmlBody;
            SetHtmlDocumentInWebBrowser(htmlText);
        }

        // удалить письмо
        private void btnDeleteMessage_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow != null ? dataGridView1.CurrentRow.Index : -1;
            if(index != -1)
            {
                pop3.DeleteMessage(index);
                btnRefreshList_Click(null, null);
                //txtLog.Text = pop3.getLogAllAndReadInFile();
            }
        }

        // Переход на форму SMTP
        private void btnGoToFormSMTP_Click(object sender, EventArgs e)
        {
            FormSmtp form = new FormSmtp();
            this.Enabled = false;
            form.ShowDialog(this);
            this.Enabled = true;
        }
    }
}

