namespace ToDoListT2
{
    partial class FormMain
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
            this.tituloList = new System.Windows.Forms.Label();
            this.textNotas = new System.Windows.Forms.TextBox();
            this.subTitelList = new System.Windows.Forms.Label();
            this.listBoxView = new System.Windows.Forms.ListBox();
            this.btLogOut = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonVaciar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloList
            // 
            this.tituloList.AutoSize = true;
            this.tituloList.BackColor = System.Drawing.Color.DarkCyan;
            this.tituloList.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.tituloList.ForeColor = System.Drawing.SystemColors.Control;
            this.tituloList.Location = new System.Drawing.Point(11, 74);
            this.tituloList.Name = "tituloList";
            this.tituloList.Size = new System.Drawing.Size(294, 58);
            this.tituloList.TabIndex = 0;
            this.tituloList.Text = "Lista Basica";
            // 
            // textNotas
            // 
            this.textNotas.Location = new System.Drawing.Point(20, 180);
            this.textNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNotas.Name = "textNotas";
            this.textNotas.Size = new System.Drawing.Size(540, 22);
            this.textNotas.TabIndex = 1;
            this.textNotas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textNotas_KeyDown);
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
            this.listBoxView.Size = new System.Drawing.Size(540, 516);
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
            // botonGuardar
            // 
            this.botonGuardar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.botonGuardar.Location = new System.Drawing.Point(32, 751);
            this.botonGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(227, 38);
            this.botonGuardar.TabIndex = 5;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = false;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.botonEliminar.Location = new System.Drawing.Point(304, 751);
            this.botonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(229, 37);
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
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(225, 143);
            this.botonEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(64, 31);
            this.botonEditar.TabIndex = 9;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(579, 825);
            this.Controls.Add(this.botonVaciar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.btLogOut);
            this.Controls.Add(this.listBoxView);
            this.Controls.Add(this.subTitelList);
            this.Controls.Add(this.textNotas);
            this.Controls.Add(this.tituloList);
            this.Controls.Add(this.botonEditar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloList;
        private System.Windows.Forms.TextBox textNotas;
        private System.Windows.Forms.Label subTitelList;
        private System.Windows.Forms.ListBox listBoxView;
        private System.Windows.Forms.Button btLogOut;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonVaciar;
        private System.Windows.Forms.Button botonEditar;
    }
}

