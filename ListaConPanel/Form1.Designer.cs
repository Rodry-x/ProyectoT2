namespace ListaConPanel
{
    partial class Form1
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
            this.botonHome = new System.Windows.Forms.Button();
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
            this.tituloList.Location = new System.Drawing.Point(8, 60);
            this.tituloList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloList.Name = "tituloList";
            this.tituloList.Size = new System.Drawing.Size(236, 46);
            this.tituloList.TabIndex = 0;
            this.tituloList.Text = "Lista Basica";
            this.tituloList.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNotas
            // 
            this.textNotas.Location = new System.Drawing.Point(15, 146);
            this.textNotas.Margin = new System.Windows.Forms.Padding(2);
            this.textNotas.Name = "textNotas";
            this.textNotas.Size = new System.Drawing.Size(406, 20);
            this.textNotas.TabIndex = 1;
            this.textNotas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textNotas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textNotas_KeyDown);
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
            // botonHome
            // 
            this.botonHome.Location = new System.Drawing.Point(17, 20);
            this.botonHome.Margin = new System.Windows.Forms.Padding(2);
            this.botonHome.Name = "botonHome";
            this.botonHome.Size = new System.Drawing.Size(69, 29);
            this.botonHome.TabIndex = 4;
            this.botonHome.Text = "Retoceder";
            this.botonHome.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(434, 670);
            this.Controls.Add(this.botonVaciar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonHome);
            this.Controls.Add(this.listBoxView);
            this.Controls.Add(this.subTitelList);
            this.Controls.Add(this.textNotas);
            this.Controls.Add(this.tituloList);
            this.Controls.Add(this.botonEditar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label tituloList;
        private System.Windows.Forms.TextBox textNotas;
        private System.Windows.Forms.Label subTitelList;
        private System.Windows.Forms.ListBox listBoxView;
        private System.Windows.Forms.Button botonHome;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonVaciar;
        private System.Windows.Forms.Button botonEditar;
    }
}

