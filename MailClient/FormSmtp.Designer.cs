
namespace MailClient
{
    partial class FormSmtp
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
            this.txtPortPop3 = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEntry = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.groupBoxSend = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.groupBoxConnect.SuspendLayout();
            this.groupBoxSend.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.txtPortPop3);
            this.groupBoxConnect.Controls.Add(this.labelPass);
            this.groupBoxConnect.Controls.Add(this.txtLogin);
            this.groupBoxConnect.Controls.Add(this.label2);
            this.groupBoxConnect.Controls.Add(this.label1);
            this.groupBoxConnect.Controls.Add(this.txtServer);
            this.groupBoxConnect.Controls.Add(this.txtPassword);
            this.groupBoxConnect.Controls.Add(this.btnEntry);
            this.groupBoxConnect.Controls.Add(this.label3);
            this.groupBoxConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxConnect.ForeColor = System.Drawing.Color.Black;
            this.groupBoxConnect.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Size = new System.Drawing.Size(384, 224);
            this.groupBoxConnect.TabIndex = 0;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Соединение";
            // 
            // txtPortPop3
            // 
            this.txtPortPop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPortPop3.Location = new System.Drawing.Point(303, 25);
            this.txtPortPop3.Name = "txtPortPop3";
            this.txtPortPop3.Size = new System.Drawing.Size(70, 29);
            this.txtPortPop3.TabIndex = 20;
            this.txtPortPop3.TabStop = false;
            this.txtPortPop3.Text = "587";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(14, 123);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(67, 20);
            this.labelPass.TabIndex = 19;
            this.labelPass.Text = "Пароль";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(18, 80);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(339, 29);
            this.txtLogin.TabIndex = 18;
            this.txtLogin.TabStop = false;
            this.txtLogin.Text = "m.orlov@corp.nstu.ru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Сервер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Логин";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServer.Location = new System.Drawing.Point(78, 25);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(213, 29);
            this.txtServer.TabIndex = 15;
            this.txtServer.TabStop = false;
            this.txtServer.Text = "mail2.nstu.ru";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(18, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(339, 31);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "varM=9808";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnEntry
            // 
            this.btnEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEntry.Location = new System.Drawing.Point(78, 183);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(219, 29);
            this.btnEntry.TabIndex = 13;
            this.btnEntry.TabStop = false;
            this.btnEntry.Text = "Установить соединение";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(289, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = ":";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(11, 157);
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtBody.Size = new System.Drawing.Size(426, 131);
            this.txtBody.TabIndex = 23;
            this.txtBody.TabStop = false;
            this.txtBody.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Кому";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "От";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Тема";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Текст письма (поддерживается HTML)";
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFrom.Location = new System.Drawing.Point(63, 25);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(339, 29);
            this.txtFrom.TabIndex = 22;
            this.txtFrom.TabStop = false;
            // 
            // groupBoxSend
            // 
            this.groupBoxSend.Controls.Add(this.btnSend);
            this.groupBoxSend.Controls.Add(this.txtSubject);
            this.groupBoxSend.Controls.Add(this.txtBody);
            this.groupBoxSend.Controls.Add(this.txtTo);
            this.groupBoxSend.Controls.Add(this.label7);
            this.groupBoxSend.Controls.Add(this.txtFrom);
            this.groupBoxSend.Controls.Add(this.label4);
            this.groupBoxSend.Controls.Add(this.label5);
            this.groupBoxSend.Controls.Add(this.label6);
            this.groupBoxSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSend.ForeColor = System.Drawing.Color.Black;
            this.groupBoxSend.Location = new System.Drawing.Point(12, 242);
            this.groupBoxSend.Name = "groupBoxSend";
            this.groupBoxSend.Size = new System.Drawing.Size(445, 331);
            this.groupBoxSend.TabIndex = 22;
            this.groupBoxSend.TabStop = false;
            this.groupBoxSend.Text = "Отправка письма";
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.Location = new System.Drawing.Point(218, 294);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(219, 29);
            this.btnSend.TabIndex = 22;
            this.btnSend.TabStop = false;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSubject.Location = new System.Drawing.Point(63, 96);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(339, 29);
            this.txtSubject.TabIndex = 27;
            this.txtSubject.TabStop = false;
            this.txtSubject.Text = "ТУТ ТЕМА";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTo.Location = new System.Drawing.Point(63, 61);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(339, 29);
            this.txtTo.TabIndex = 26;
            this.txtTo.TabStop = false;
            this.txtTo.Text = "m.orlov@corp.nstu.ru";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLog);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(463, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 561);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отображение лога";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(6, 22);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(492, 531);
            this.txtLog.TabIndex = 28;
            this.txtLog.TabStop = false;
            this.txtLog.Text = "";
            // 
            // FormSmtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(979, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSend);
            this.Controls.Add(this.groupBoxConnect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormSmtp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправка писем по протоколу POP3";
            this.Load += new System.EventHandler(this.FormSmtp_Load);
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxConnect.PerformLayout();
            this.groupBoxSend.ResumeLayout(false);
            this.groupBoxSend.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConnect;
        private System.Windows.Forms.TextBox txtPortPop3;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.GroupBox groupBoxSend;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}