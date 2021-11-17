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
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        // загрузка формы
        private void FormAuth_Load(object sender, EventArgs e)
        {
            
        }

        // войти
        private void btnEntry_Click(object sender, EventArgs e)
        {
            /*
            if (txtServer.Text.Length > 0 && txtLogin.Text.Length > 0 && txtPassword.Text.Length > 0 && txtPortPop3.Text.Length > 0)
                if (comboBoxProtocol.SelectedIndex == 0) // SMTP
                {
                    try
                    {
                        clientSMTP client = new clientSMTP(txtServer.Text, txtPortPop3.Text, txtLogin.Text, txtPassword.Text);
                    }
                    catch(Exception error)
                    {
                        MessageBox.Show(error.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
                else if (comboBoxProtocol.SelectedIndex == 1) // POP3
                { 
                }
                else
                    MessageBox.Show("Выберите протокол!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Заполните все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        
        */
        }

    }
}