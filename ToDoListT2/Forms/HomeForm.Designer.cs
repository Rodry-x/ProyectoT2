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
            this.listBoxView = new System.Windows.Forms.ListBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.button_add_task = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msg_welcome
            // 
            this.msg_welcome.AutoSize = true;
            this.msg_welcome.BackColor = System.Drawing.Color.Transparent;
            this.msg_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.msg_welcome.ForeColor = System.Drawing.SystemColors.Control;
            this.msg_welcome.Location = new System.Drawing.Point(8, 60);
            this.msg_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msg_welcome.Name = "msg_welcome";
            this.msg_welcome.Size = new System.Drawing.Size(276, 46);
            this.msg_welcome.TabIndex = 0;
            this.msg_welcome.Text = "msg_welcome";
            //
            // subTitelList
            //
            this.subTitelList.AutoSize = true;
            this.subTitelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subTitelList.ForeColor = System.Drawing.SystemColors.Control;
            this.subTitelList.Location = new System.Drawing.Point(11, 116);
            this.subTitelList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subTitelList.Name = "subTitelList";
            this.subTitelList.Size = new System.Drawing.Size(157, 20);
            this.subTitelList.TabIndex = 2;
            this.subTitelList.Text = "Quieres anotar algo?";
            //
            // listBoxView
            //
            this.listBoxView.FormattingEnabled = true;
            this.listBoxView.Location = new System.Drawing.Point(15, 178);
            this.listBoxView.Margin = new System.Windows.Forms.Padding(2, 13, 2, 13);
            this.listBoxView.Name = "listBoxView";
            this.listBoxView.Size = new System.Drawing.Size(406, 472);
            this.listBoxView.TabIndex = 3;
            this.listBoxView.DoubleClick += new System.EventHandler(this.OnListDoubleClick);
            //
            // logout_btn
            //
            this.logout_btn.Location = new System.Drawing.Point(15, 22);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(81, 29);
            this.logout_btn.TabIndex = 4;
            this.logout_btn.Text = "Cerrar Sesión";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            //
            // button_add_task
            //
            this.button_add_task.Location = new System.Drawing.Point(16, 148);
            this.button_add_task.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_task.Name = "button_add_task";
            this.button_add_task.Size = new System.Drawing.Size(90, 22);
            this.button_add_task.TabIndex = 10;
            this.button_add_task.Text = "Añadir";
            this.button_add_task.UseVisualStyleBackColor = true;
            this.button_add_task.Click += new System.EventHandler(this.button_add_task_Click);
            //
            // HomeForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(434, 670);
            this.Controls.Add(this.button_add_task);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.listBoxView);
            this.Controls.Add(this.subTitelList);
            this.Controls.Add(this.msg_welcome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeForm";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label msg_welcome;
        private System.Windows.Forms.Label subTitelList;
        private System.Windows.Forms.ListBox listBoxView;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button button_add_task;
    }
}

