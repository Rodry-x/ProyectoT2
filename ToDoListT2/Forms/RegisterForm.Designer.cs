namespace Forms
{
    partial class RegisterForm
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
            this.name_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.textCancel = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.Label();
            this.txtGmail = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(125, 290);
            this.name_input.Margin = new System.Windows.Forms.Padding(2);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(185, 20);
            this.name_input.TabIndex = 1;
            this.name_input.TextChanged += new System.EventHandler(this.boxUser_TextChanged);
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(125, 362);
            this.password_input.Margin = new System.Windows.Forms.Padding(2);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(185, 20);
            this.password_input.TabIndex = 2;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(164, 390);
            this.btRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(100, 25);
            this.btRegister.TabIndex = 3;
            this.btRegister.Text = "Registrarse";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // textCancel
            // 
            this.textCancel.AutoSize = true;
            this.textCancel.LinkColor = System.Drawing.Color.White;
            this.textCancel.Location = new System.Drawing.Point(190, 427);
            this.textCancel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textCancel.Name = "textCancel";
            this.textCancel.Size = new System.Drawing.Size(49, 13);
            this.textCancel.TabIndex = 4;
            this.textCancel.TabStop = true;
            this.textCancel.Text = "Cancelar";
            this.textCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.textCancel_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(123, 346);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(61, 13);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "Contraseña";
            // 
            // txtGmail
            // 
            this.txtGmail.AutoSize = true;
            this.txtGmail.ForeColor = System.Drawing.Color.White;
            this.txtGmail.Location = new System.Drawing.Point(123, 310);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(38, 13);
            this.txtGmail.TabIndex = 7;
            this.txtGmail.Text = "Correo";
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(125, 326);
            this.email_input.Margin = new System.Windows.Forms.Padding(2);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(185, 20);
            this.email_input.TabIndex = 8;
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(123, 275);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(43, 13);
            this.txtUser.TabIndex = 9;
            this.txtUser.Text = "Usuario";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(450, 610);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.textCancel);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.name_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.LinkLabel textCancel;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.Label txtGmail;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Label txtUser;
    }
}