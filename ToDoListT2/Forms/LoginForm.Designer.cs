namespace Forms
{
    partial class LoginForm
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
            this.email_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.textRegister = new System.Windows.Forms.LinkLabel();
            this.txtGmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(167, 309);
            this.email_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(245, 22);
            this.email_input.TabIndex = 0;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(167, 354);
            this.password_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(245, 22);
            this.password_input.TabIndex = 1;
            // 
            // textRegister
            // 
            this.textRegister.AutoSize = true;
            this.textRegister.LinkColor = System.Drawing.Color.Black;
            this.textRegister.Location = new System.Drawing.Point(243, 500);
            this.textRegister.Name = "textRegister";
            this.textRegister.Size = new System.Drawing.Size(77, 16);
            this.textRegister.TabIndex = 3;
            this.textRegister.TabStop = true;
            this.textRegister.Text = "Registrarse";
            this.textRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.textRegister_LinkClicked);
            // 
            // txtGmail
            // 
            this.txtGmail.AutoSize = true;
            this.txtGmail.Location = new System.Drawing.Point(164, 290);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(48, 16);
            this.txtGmail.TabIndex = 4;
            this.txtGmail.Text = "Correo";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(164, 335);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(76, 16);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "O";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(217, 432);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(133, 31);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Acceder";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(579, 825);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.textRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.email_input);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.LinkLabel textRegister;
        private System.Windows.Forms.Label txtGmail;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
    }
}