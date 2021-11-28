
namespace MailClient
{
    partial class FormPop3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.btnConnectionClose = new System.Windows.Forms.Button();
            this.txtPortSmtp = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnectionOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxGetMessage = new System.Windows.Forms.GroupBox();
            this.btnDeleteMessage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.groupBoxConnect.SuspendLayout();
            this.groupBoxGetMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.btnConnectionClose);
            this.groupBoxConnect.Controls.Add(this.txtPortSmtp);
            this.groupBoxConnect.Controls.Add(this.labelPass);
            this.groupBoxConnect.Controls.Add(this.txtLogin);
            this.groupBoxConnect.Controls.Add(this.label2);
            this.groupBoxConnect.Controls.Add(this.label1);
            this.groupBoxConnect.Controls.Add(this.txtServer);
            this.groupBoxConnect.Controls.Add(this.txtPassword);
            this.groupBoxConnect.Controls.Add(this.btnConnectionOpen);
            this.groupBoxConnect.Controls.Add(this.label3);
            this.groupBoxConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxConnect.ForeColor = System.Drawing.Color.Black;
            this.groupBoxConnect.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Size = new System.Drawing.Size(445, 224);
            this.groupBoxConnect.TabIndex = 0;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Соединение по протоколу POP3";
            // 
            // btnConnectionClose
            // 
            this.btnConnectionClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnectionClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnectionClose.Location = new System.Drawing.Point(16, 186);
            this.btnConnectionClose.Name = "btnConnectionClose";
            this.btnConnectionClose.Size = new System.Drawing.Size(180, 29);
            this.btnConnectionClose.TabIndex = 22;
            this.btnConnectionClose.TabStop = false;
            this.btnConnectionClose.Text = "Закрыть соединение";
            this.btnConnectionClose.UseVisualStyleBackColor = true;
            this.btnConnectionClose.Click += new System.EventHandler(this.btnConnectionClose_Click);
            // 
            // txtPortSmtp
            // 
            this.txtPortSmtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPortSmtp.Location = new System.Drawing.Point(330, 25);
            this.txtPortSmtp.Name = "txtPortSmtp";
            this.txtPortSmtp.Size = new System.Drawing.Size(70, 29);
            this.txtPortSmtp.TabIndex = 20;
            this.txtPortSmtp.TabStop = false;
            this.txtPortSmtp.Text = "995";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(41, 123);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(67, 20);
            this.labelPass.TabIndex = 19;
            this.labelPass.Text = "Пароль";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(45, 80);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(355, 29);
            this.txtLogin.TabIndex = 18;
            this.txtLogin.TabStop = false;
            this.txtLogin.Text = "mishkansk98@mail.ru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Сервер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Логин";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServer.Location = new System.Drawing.Point(105, 25);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(213, 29);
            this.txtServer.TabIndex = 15;
            this.txtServer.TabStop = false;
            this.txtServer.Text = "pop.mail.ru";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(45, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(355, 31);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "zauce7EhBnd5YgSK4d9b";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnConnectionOpen
            // 
            this.btnConnectionOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnectionOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnectionOpen.Location = new System.Drawing.Point(207, 186);
            this.btnConnectionOpen.Name = "btnConnectionOpen";
            this.btnConnectionOpen.Size = new System.Drawing.Size(219, 29);
            this.btnConnectionOpen.TabIndex = 13;
            this.btnConnectionOpen.TabStop = false;
            this.btnConnectionOpen.Text = "Установить соединение";
            this.btnConnectionOpen.UseVisualStyleBackColor = true;
            this.btnConnectionOpen.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(316, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = ":";
            // 
            // groupBoxGetMessage
            // 
            this.groupBoxGetMessage.Controls.Add(this.btnDeleteMessage);
            this.groupBoxGetMessage.Controls.Add(this.label4);
            this.groupBoxGetMessage.Controls.Add(this.dataGridView1);
            this.groupBoxGetMessage.Controls.Add(this.btnRefreshList);
            this.groupBoxGetMessage.Controls.Add(this.webBrowser1);
            this.groupBoxGetMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxGetMessage.ForeColor = System.Drawing.Color.Black;
            this.groupBoxGetMessage.Location = new System.Drawing.Point(522, 12);
            this.groupBoxGetMessage.Name = "groupBoxGetMessage";
            this.groupBoxGetMessage.Size = new System.Drawing.Size(722, 559);
            this.groupBoxGetMessage.TabIndex = 22;
            this.groupBoxGetMessage.TabStop = false;
            this.groupBoxGetMessage.Text = "Входящие письма";
            // 
            // btnDeleteMessage
            // 
            this.btnDeleteMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteMessage.Location = new System.Drawing.Point(410, 154);
            this.btnDeleteMessage.Name = "btnDeleteMessage";
            this.btnDeleteMessage.Size = new System.Drawing.Size(145, 29);
            this.btnDeleteMessage.TabIndex = 25;
            this.btnDeleteMessage.TabStop = false;
            this.btnDeleteMessage.Text = "Удалить письмо";
            this.btnDeleteMessage.UseVisualStyleBackColor = true;
            this.btnDeleteMessage.Click += new System.EventHandler(this.btnDeleteMessage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Просмотр содержимого письма:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(710, 123);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefreshList.Location = new System.Drawing.Point(561, 154);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(155, 29);
            this.btnRefreshList.TabIndex = 22;
            this.btnRefreshList.TabStop = false;
            this.btnRefreshList.Text = "Обновить список";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(6, 189);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(710, 362);
            this.webBrowser1.TabIndex = 23;
            this.webBrowser1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLog);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 329);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отображение лога";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 22);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(498, 304);
            this.txtLog.TabIndex = 28;
            this.txtLog.TabStop = false;
            this.txtLog.Text = "";
            // 
            // FormPop3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1256, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxGetMessage);
            this.Controls.Add(this.groupBoxConnect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormPop3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Получение писем по протоколу POP3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPop3_FormClosing);
            this.Load += new System.EventHandler(this.FormPop3_Load);
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxConnect.PerformLayout();
            this.groupBoxGetMessage.ResumeLayout(false);
            this.groupBoxGetMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConnect;
        private System.Windows.Forms.TextBox txtPortSmtp;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnectionOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxGetMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnConnectionClose;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteMessage;
    }
}