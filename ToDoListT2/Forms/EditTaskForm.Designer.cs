namespace Forms
{
    partial class EditTaskForm
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
            this.input_taskName = new System.Windows.Forms.TextBox();
            this.txtEdit = new System.Windows.Forms.Label();
            this.btAccept = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.msg_Edit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_taskDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_detele = new System.Windows.Forms.Button();
            this.input_taskDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // input_taskName
            // 
            this.input_taskName.Location = new System.Drawing.Point(44, 94);
            this.input_taskName.Margin = new System.Windows.Forms.Padding(2);
            this.input_taskName.Name = "input_taskName";
            this.input_taskName.Size = new System.Drawing.Size(312, 20);
            this.input_taskName.TabIndex = 0;
            // 
            // txtEdit
            // 
            this.txtEdit.AutoSize = true;
            this.txtEdit.Location = new System.Drawing.Point(41, 79);
            this.txtEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(33, 13);
            this.txtEdit.TabIndex = 1;
            this.txtEdit.Text = "Titulo";
            // 
            // btAccept
            // 
            this.btAccept.Location = new System.Drawing.Point(334, 318);
            this.btAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(67, 32);
            this.btAccept.TabIndex = 2;
            this.btAccept.Text = "Aceptar";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(424, 318);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(68, 32);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // msg_Edit
            // 
            this.msg_Edit.AutoSize = true;
            this.msg_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.msg_Edit.ForeColor = System.Drawing.SystemColors.Control;
            this.msg_Edit.Location = new System.Drawing.Point(38, 24);
            this.msg_Edit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msg_Edit.Name = "msg_Edit";
            this.msg_Edit.Size = new System.Drawing.Size(351, 39);
            this.msg_Edit.TabIndex = 4;
            this.msg_Edit.Text = "Que quieres cambiar?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descripción";
            // 
            // input_taskDescription
            // 
            this.input_taskDescription.Location = new System.Drawing.Point(44, 145);
            this.input_taskDescription.Margin = new System.Windows.Forms.Padding(2);
            this.input_taskDescription.Name = "input_taskDescription";
            this.input_taskDescription.Size = new System.Drawing.Size(308, 20);
            this.input_taskDescription.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha";
            // 
            // button_detele
            // 
            this.button_detele.Location = new System.Drawing.Point(44, 318);
            this.button_detele.Margin = new System.Windows.Forms.Padding(2);
            this.button_detele.Name = "button_detele";
            this.button_detele.Size = new System.Drawing.Size(84, 32);
            this.button_detele.TabIndex = 9;
            this.button_detele.Text = "Eliminar Tarea";
            this.button_detele.UseVisualStyleBackColor = true;
            // 
            // input_taskDateTime
            // 
            this.input_taskDateTime.Location = new System.Drawing.Point(44, 200);
            this.input_taskDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.input_taskDateTime.Name = "input_taskDateTime";
            this.input_taskDateTime.Size = new System.Drawing.Size(151, 20);
            this.input_taskDateTime.TabIndex = 7;
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(509, 371);
            this.Controls.Add(this.button_detele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_taskDateTime);
            this.Controls.Add(this.input_taskDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msg_Edit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAccept);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.input_taskName);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker input_taskDateTime;

        #endregion

        private System.Windows.Forms.TextBox input_taskName;
        private System.Windows.Forms.Label txtEdit;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label msg_Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_taskDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_detele;
    }
}