namespace ListaConPanel
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
            this.boxUser = new System.Windows.Forms.TextBox();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.textCancel = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.Label();
            this.txtGmail = new System.Windows.Forms.Label();
            this.boxGmail = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxUser
            // 
            this.boxUser.Location = new System.Drawing.Point(167, 357);
            this.boxUser.Name = "boxUser";
            this.boxUser.Size = new System.Drawing.Size(245, 22);
            this.boxUser.TabIndex = 1;
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(167, 445);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(245, 22);
            this.boxPassword.TabIndex = 2;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(219, 480);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(133, 31);
            this.btRegister.TabIndex = 3;
            this.btRegister.Text = "Registrarse";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // textCancel
            // 
            this.textCancel.AutoSize = true;
            this.textCancel.LinkColor = System.Drawing.Color.Black;
            this.textCancel.Location = new System.Drawing.Point(253, 526);
            this.textCancel.Name = "textCancel";
            this.textCancel.Size = new System.Drawing.Size(61, 16);
            this.textCancel.TabIndex = 4;
            this.textCancel.TabStop = true;
            this.textCancel.Text = "Cancelar";
            this.textCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.textCancel_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(164, 426);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(76, 16);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "Contraseña";
            // 
            // txtGmail
            // 
            this.txtGmail.AutoSize = true;
            this.txtGmail.Location = new System.Drawing.Point(164, 382);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(48, 16);
            this.txtGmail.TabIndex = 7;
            this.txtGmail.Text = "Correo";
            // 
            // boxGmail
            // 
            this.boxGmail.Location = new System.Drawing.Point(167, 401);
            this.boxGmail.Name = "boxGmail";
            this.boxGmail.Size = new System.Drawing.Size(245, 22);
            this.boxGmail.TabIndex = 8;
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Location = new System.Drawing.Point(164, 338);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(54, 16);
            this.txtUser.TabIndex = 9;
            this.txtUser.Text = "Usuario";
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(579, 825);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.boxGmail);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.textCancel);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.boxUser);
            this.Name = "registerForm";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxUser;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.LinkLabel textCancel;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.Label txtGmail;
        private System.Windows.Forms.TextBox boxGmail;
        private System.Windows.Forms.Label txtUser;
    }
}