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

        private clientSMTP pop3;
        DataTable table;

        // при загрузке формы
        private void FormSmtp_Load(object sender, EventArgs e)
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
                    pop3 = new clientSMTP(txtServer.Text, port, txtLogin.Text, txtPassword.Text);
                    pop3.ConnectToServerAndAuthenticate();
                    if (pop3.checkConnectedAndAuthenticated())
                    {
                        txtFrom.Text = txtLogin.Text;
                        OnEditParameteresConnection(false);
                    }
                    else throw new Exception("Не удалось установить соединение!");
                    txtLog.Text = pop3.getLogAll();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
                MessageBox.Show("Заполните все поля для установление соединения!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        // обновить список сообщений
        private void RefreshListMessage()
        {
            table = new DataTable("Messages");
            table.Clear();
            table.Columns.Clear();
            table.Rows.Clear();

            table.Columns.Add(new DataColumn("№"));
            table.Columns.Add(new DataColumn("From"));
            table.Columns.Add(new DataColumn("Subject"));
            table.Columns.Add(new DataColumn("Body"));

            for (int j = 0; j < 10; j++) // ЗАПОЛНЕНИЕ СООБЩЕНИЯМИ
            {
                DataRow dr = table.NewRow();
                dr[0] = null;
                dr[1] = null;
                dr[3] = null;
                dr[4] = null;
                table.Rows.Add(dr);
            }

            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[3].Width = 230;
            setCongigOfRowTable(0);
            setCongigOfRowTable(1);
            setCongigOfRowTable(2);
            setCongigOfRowTable(3);

            dataGridView1.DataSource = table;
        }

        // кнопка Отправить
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtTo.TextLength > 0 && txtSubject.TextLength > 0 && txtBody.TextLength > 0/* && txtFrom.TextLength > 0*/)
            {
                if (pop3.checkConnectedAndAuthenticated())
                {
                    try
                    {
                        pop3.SendMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtBody.Text);
                        txtLog.Text = pop3.getLogAll();
                        MessageBox.Show("Письмо успешно отправлено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    catch (Exception err) { MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); }
                }
                else
                    MessageBox.Show("Соединение не было установлено.\nУстановите соединение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
                MessageBox.Show("Заполните все поля письма!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        private void OnEditParameteresConnection(bool flag)
        {
            txtServer.Enabled = flag;
            txtPortSmtp.Enabled = flag;
            txtLogin.Enabled = flag;
            txtPassword.Enabled = flag;
            btnConnectionOpen.Visible = flag;
            btnConnectionClose.Visible = !flag;
            groupBoxGetMessage.Enabled = flag;
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
        private void FormSmtp_FormClosing(object sender, FormClosingEventArgs e)
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

