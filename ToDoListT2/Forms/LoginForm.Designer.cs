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
            this.email_input.Location = new System.Drawing.Point(125, 251);
            this.email_input.Margin = new System.Windows.Forms.Padding(2);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(185, 20);
            this.email_input.TabIndex = 0;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(125, 288);
            this.password_input.Margin = new System.Windows.Forms.Padding(2);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(185, 20);
            this.password_input.TabIndex = 1;
            // 
            // textRegister
            // 
            this.textRegister.AutoSize = true;
            this.textRegister.LinkColor = System.Drawing.Color.Black;
            this.textRegister.Location = new System.Drawing.Point(181, 388);
            this.textRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textRegister.Name = "textRegister";
            this.textRegister.Size = new System.Drawing.Size(60, 13);
            this.textRegister.TabIndex = 3;
            this.textRegister.TabStop = true;
            this.textRegister.Text = "Registrarse";
            this.textRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.textRegister_LinkClicked);
            // 
            // txtGmail
            // 
            this.txtGmail.AutoSize = true;
            this.txtGmail.Location = new System.Drawing.Point(123, 236);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(38, 13);
            this.txtGmail.TabIndex = 4;
            this.txtGmail.Text = "Correo";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(123, 272);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(61, 13);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 367);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "O";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(164, 330);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 25);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Acceder";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(434, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.textRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.email_input);
            this.Margin = new System.Windows.Forms.Padding(2);
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