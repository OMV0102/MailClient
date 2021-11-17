
namespace MailClient
{
    partial class FormAuth
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
            this.btnEntry = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtPortPop3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPortSmtp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEntry
            // 
            this.btnEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEntry.Location = new System.Drawing.Point(95, 208);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(118, 44);
            this.btnEntry.TabIndex = 0;
            this.btnEntry.TabStop = false;
            this.btnEntry.Text = "Войти";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(12, 171);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(339, 31);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "varM=9808";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServer.Location = new System.Drawing.Point(79, 11);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(272, 29);
            this.txtServer.TabIndex = 2;
            this.txtServer.TabStop = false;
            this.txtServer.Text = "mail2.nstu.ru";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сервер";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(12, 105);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(339, 29);
            this.txtLogin.TabIndex = 5;
            this.txtLogin.TabStop = false;
            this.txtLogin.Text = "m.orlov@corp.nstu.ru";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(8, 148);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(67, 20);
            this.labelPass.TabIndex = 6;
            this.labelPass.Text = "Пароль";
            // 
            // txtPortPop3
            // 
            this.txtPortPop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPortPop3.Location = new System.Drawing.Point(110, 46);
            this.txtPortPop3.Name = "txtPortPop3";
            this.txtPortPop3.Size = new System.Drawing.Size(70, 29);
            this.txtPortPop3.TabIndex = 9;
            this.txtPortPop3.TabStop = false;
            this.txtPortPop3.Text = "587";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Порт SMTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Порт POP3";
            // 
            // txtPortSmtp
            // 
            this.txtPortSmtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPortSmtp.Location = new System.Drawing.Point(281, 46);
            this.txtPortSmtp.Name = "txtPortSmtp";
            this.txtPortSmtp.Size = new System.Drawing.Size(70, 29);
            this.txtPortSmtp.TabIndex = 12;
            this.txtPortSmtp.TabStop = false;
            this.txtPortSmtp.Text = "587";
            // 
            // FormAuth
            // 
            this.AcceptButton = this.btnEntry;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 269);
            this.Controls.Add(this.txtPortSmtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPortPop3);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.FormAuth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtPortPop3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPortSmtp;
    }
}