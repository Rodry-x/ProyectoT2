namespace Forms
{
    partial class HomeForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msg_welcome = new System.Windows.Forms.Label();
            this.subTitelList = new System.Windows.Forms.Label();
            this.tasksList = new System.Windows.Forms.ListBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msg_welcome
            // 
            this.msg_welcome.AutoSize = true;
            this.msg_welcome.BackColor = System.Drawing.Color.Transparent;
            this.msg_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.msg_welcome.ForeColor = System.Drawing.SystemColors.Control;
            this.msg_welcome.Location = new System.Drawing.Point(11, 74);
            this.msg_welcome.Name = "msg_welcome";
            this.msg_welcome.Size = new System.Drawing.Size(346, 58);
            this.msg_welcome.TabIndex = 0;
            this.msg_welcome.Text = "msg_welcome";
            // 
            // subTitelList
            // 
            this.subTitelList.AutoSize = true;
            this.subTitelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subTitelList.ForeColor = System.Drawing.SystemColors.Control;
            this.subTitelList.Location = new System.Drawing.Point(15, 143);
            this.subTitelList.Name = "subTitelList";
            this.subTitelList.Size = new System.Drawing.Size(194, 25);
            this.subTitelList.TabIndex = 2;
            this.subTitelList.Text = "Quieres anotar algo?";
            // 
            // tasksList
            // 
            this.tasksList.FormattingEnabled = true;
            this.tasksList.ItemHeight = 16;
            this.tasksList.Location = new System.Drawing.Point(20, 219);
            this.tasksList.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.tasksList.Name = "tasksList";
            this.tasksList.Size = new System.Drawing.Size(540, 580);
            this.tasksList.TabIndex = 3;
            this.tasksList.DoubleClick += new System.EventHandler(this.List_DoubleClick);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(20, 27);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(108, 36);
            this.logout_btn.TabIndex = 4;
            this.logout_btn.Text = "Cerrar Sesión";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(441, 188);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 27);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Añadir";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(441, 27);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(99, 36);
            this.buttonSettings.TabIndex = 11;
            this.buttonSettings.Text = "Configuración";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(579, 825);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.tasksList);
            this.Controls.Add(this.subTitelList);
            this.Controls.Add(this.msg_welcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeForm";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msg_welcome;
        private System.Windows.Forms.Label subTitelList;
        private System.Windows.Forms.ListBox tasksList;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSettings;
    }
}

