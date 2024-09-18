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
            this.input_taskName = new System.Windows.Forms.TextBox();
            this.subTitelList = new System.Windows.Forms.Label();
            this.listBoxView = new System.Windows.Forms.ListBox();
            this.btLogOut = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonVaciar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msg_welcome
            // 
            this.msg_welcome.AutoSize = true;
            this.msg_welcome.BackColor = System.Drawing.Color.DarkCyan;
            this.msg_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.msg_welcome.ForeColor = System.Drawing.SystemColors.Control;
            this.msg_welcome.Location = new System.Drawing.Point(8, 60);
            this.msg_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msg_welcome.Name = "msg_welcome";
            this.msg_welcome.Size = new System.Drawing.Size(276, 46);
            this.msg_welcome.TabIndex = 0;
            this.msg_welcome.Text = "msg_welcome";
            // 
            // input_taskName
            // 
            this.input_taskName.Location = new System.Drawing.Point(15, 146);
            this.input_taskName.Margin = new System.Windows.Forms.Padding(2);
            this.input_taskName.Name = "input_taskName";
            this.input_taskName.Size = new System.Drawing.Size(406, 20);
            this.input_taskName.TabIndex = 1;
            this.input_taskName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textNotas_KeyDown);
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
            this.listBoxView.Size = new System.Drawing.Size(406, 420);
            this.listBoxView.TabIndex = 3;
            this.listBoxView.SelectedIndexChanged += new System.EventHandler(this.listBoxView_SelectedIndexChanged);
            this.listBoxView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxView_KeyDown);
            // 
            // btLogOut
            // 
            this.btLogOut.Location = new System.Drawing.Point(15, 22);
            this.btLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(81, 29);
            this.btLogOut.TabIndex = 4;
            this.btLogOut.Text = "Cerrar Sesión";
            this.btLogOut.UseVisualStyleBackColor = true;
            this.btLogOut.Click += new System.EventHandler(this.botonHome_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.botonGuardar.Location = new System.Drawing.Point(24, 610);
            this.botonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(170, 31);
            this.botonGuardar.TabIndex = 5;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = false;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.botonEliminar.Location = new System.Drawing.Point(228, 610);
            this.botonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(172, 30);
            this.botonEliminar.TabIndex = 6;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonVaciar
            // 
            this.botonVaciar.Location = new System.Drawing.Point(402, 178);
            this.botonVaciar.Margin = new System.Windows.Forms.Padding(2);
            this.botonVaciar.Name = "botonVaciar";
            this.botonVaciar.Size = new System.Drawing.Size(18, 19);
            this.botonVaciar.TabIndex = 7;
            this.botonVaciar.Text = "X";
            this.botonVaciar.UseVisualStyleBackColor = true;
            this.botonVaciar.Click += new System.EventHandler(this.botonVaciar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(169, 116);
            this.botonEditar.Margin = new System.Windows.Forms.Padding(2);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(48, 25);
            this.botonEditar.TabIndex = 9;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(434, 670);
            this.Controls.Add(this.botonVaciar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.btLogOut);
            this.Controls.Add(this.listBoxView);
            this.Controls.Add(this.subTitelList);
            this.Controls.Add(this.input_taskName);
            this.Controls.Add(this.msg_welcome);
            this.Controls.Add(this.botonEditar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeForm";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label msg_welcome;
        private System.Windows.Forms.TextBox input_taskName;
        private System.Windows.Forms.Label subTitelList;
        private System.Windows.Forms.ListBox listBoxView;
        private System.Windows.Forms.Button btLogOut;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonVaciar;
        private System.Windows.Forms.Button botonEditar;
    }
}

