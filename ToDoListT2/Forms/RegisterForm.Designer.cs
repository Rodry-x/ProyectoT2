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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.textCancel = new System.Windows.Forms.LinkLabel();
            this.panelName = new System.Windows.Forms.Panel();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelName.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(10, 7);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(280, 16);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.boxUser_TextChanged);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(162, 401);
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
            this.textCancel.Location = new System.Drawing.Point(189, 443);
            this.textCancel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textCancel.Name = "textCancel";
            this.textCancel.Size = new System.Drawing.Size(49, 13);
            this.textCancel.TabIndex = 4;
            this.textCancel.TabStop = true;
            this.textCancel.Text = "Cancelar";
            this.textCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.textCancel_LinkClicked);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.White;
            this.panelName.Controls.Add(this.txtUser);
            this.panelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelName.Location = new System.Drawing.Point(69, 174);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(300, 30);
            this.panelName.TabIndex = 10;
            this.panelName.Paint += new System.Windows.Forms.PaintEventHandler(this.panelName_Paint);
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.Color.White;
            this.panelEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelEmail.Location = new System.Drawing.Point(69, 251);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(300, 30);
            this.panelEmail.TabIndex = 11;
            this.panelEmail.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEmail_Paint);
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.White;
            this.panelPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelPassword.Location = new System.Drawing.Point(69, 328);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(300, 30);
            this.panelPassword.TabIndex = 11;
            this.panelPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPassword_Paint);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(66, 308);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 17);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Contraseña";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(66, 231);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 17);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Correo";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(66, 154);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 17);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Nombre";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(450, 650);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.textCancel);
            this.Controls.Add(this.btRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.Text = "Registro";
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Panel panelPassword;

        #endregion

        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.LinkLabel textCancel;
        private System.Windows.Forms.Label txtGmail;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
    }
}