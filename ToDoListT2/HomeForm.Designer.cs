namespace AppForms
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
            this.btLogOut = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonVaciar = new System.Windows.Forms.Button();
            this.button_add_task = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msg_welcome
            // 
            this.msg_welcome.AutoSize = true;
            this.msg_welcome.BackColor = System.Drawing.Color.DarkCyan;
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
            // listBoxView
            // 
            this.listBoxView.FormattingEnabled = true;
            this.listBoxView.ItemHeight = 16;
            this.listBoxView.Location = new System.Drawing.Point(20, 219);
            this.listBoxView.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.listBoxView.Name = "listBoxView";
            this.listBoxView.Size = new System.Drawing.Size(540, 532);
            this.listBoxView.TabIndex = 3;
            this.listBoxView.SelectedIndexChanged += new System.EventHandler(this.listBoxView_SelectedIndexChanged);
            this.listBoxView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxView_KeyDown);
            // 
            // btLogOut
            // 
            this.btLogOut.Location = new System.Drawing.Point(20, 27);
            this.btLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(108, 36);
            this.btLogOut.TabIndex = 4;
            this.btLogOut.Text = "Cerrar Sesión";
            this.btLogOut.UseVisualStyleBackColor = true;
            this.btLogOut.Click += new System.EventHandler(this.botonHome_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.botonEliminar.Location = new System.Drawing.Point(379, 759);
            this.botonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(181, 46);
            this.botonEliminar.TabIndex = 6;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonVaciar
            // 
            this.botonVaciar.Location = new System.Drawing.Point(536, 219);
            this.botonVaciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonVaciar.Name = "botonVaciar";
            this.botonVaciar.Size = new System.Drawing.Size(24, 23);
            this.botonVaciar.TabIndex = 7;
            this.botonVaciar.Text = "X";
            this.botonVaciar.UseVisualStyleBackColor = true;
            this.botonVaciar.Click += new System.EventHandler(this.botonVaciar_Click);
            // 
            // button_add_task
            // 
            this.button_add_task.Location = new System.Drawing.Point(21, 182);
            this.button_add_task.Name = "button_add_task";
            this.button_add_task.Size = new System.Drawing.Size(120, 27);
            this.button_add_task.TabIndex = 10;
            this.button_add_task.Text = "Añadir";
            this.button_add_task.UseVisualStyleBackColor = true;
            this.button_add_task.Click += new System.EventHandler(this.button_add_task_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(579, 825);
            this.Controls.Add(this.button_add_task);
            this.Controls.Add(this.botonVaciar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.btLogOut);
            this.Controls.Add(this.listBoxView);
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
        private System.Windows.Forms.ListBox listBoxView;
        private System.Windows.Forms.Button btLogOut;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonVaciar;
        private System.Windows.Forms.Button button_add_task;
    }
}

