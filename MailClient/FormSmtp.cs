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

        private clientSMTP client;

        // при загрузке формы
        private void FormSmtp_Load(object sender, EventArgs e)
        {
            client
        }

        // кнопка СОЕДИНЕНИЕ
        private void btnEntry_Click(object sender, EventArgs e)
        {
            client
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtTo.TextLength > 0 && txtSubject.TextLength > 0 && txtBody.TextLength > 0/* && txtFrom.TextLength > 0*/)
            {
                if (client.checkConnectedAndAuthenticated())
                {
                    try
                    {

                    }
                    catch(Exception err)
                    {
                        MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("Соединение не было установлено.\nУстановите соединение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля письма!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
