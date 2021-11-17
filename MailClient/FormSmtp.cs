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
    public partial class FormSmtp : Form
    {
        public FormSmtp()
        {
            InitializeComponent();
        }

        private clientSMTP smtp;

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
                    smtp = new clientSMTP(txtServer.Text, port, txtLogin.Text, txtPassword.Text);
                    smtp.ConnectToServerAndAuthenticate();
                    if (smtp.checkConnectedAndAuthenticated())
                    {
                        txtFrom.Text = txtLogin.Text;
                        OnEditParameteresConnection(false);
                    }
                    else throw new Exception("Не удалось установить соединение!");
                    txtLog.Text = smtp.getLogAll();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
                MessageBox.Show("Заполните все поля для установление соединения!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        // кнопка Отправить
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtTo.TextLength > 0 && txtSubject.TextLength > 0 && txtBody.TextLength > 0/* && txtFrom.TextLength > 0*/)
            {
                if (smtp.checkConnectedAndAuthenticated())
                {
                    try
                    {
                        smtp.SendMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtBody.Text);
                        txtLog.Text = smtp.getLogAll();
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
            txtFrom.Enabled = flag;
        }

        // кнопка Закрыть соединение
        private void btnConnectionClose_Click(object sender, EventArgs e)
        {
            if (smtp != null)
            {
                try
                {
                    smtp.Disconnect();
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
    }
}

