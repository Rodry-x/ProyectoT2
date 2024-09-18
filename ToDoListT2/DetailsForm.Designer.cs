namespace AppForms
{
    partial class DetailsForm
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
            this.boxEdit = new System.Windows.Forms.TextBox();
            this.txtEdit = new System.Windows.Forms.Label();
            this.btAccept = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxEdit
            // 
            this.boxEdit.Location = new System.Drawing.Point(73, 100);
            this.boxEdit.Name = "boxEdit";
            this.boxEdit.Size = new System.Drawing.Size(415, 22);
            this.boxEdit.TabIndex = 0;
            // 
            // txtEdit
            // 
            this.txtEdit.AutoSize = true;
            this.txtEdit.Location = new System.Drawing.Point(70, 66);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(42, 16);
            this.txtEdit.TabIndex = 1;
            this.txtEdit.Text = "Editar";
            // 
            // btAccept
            // 
            this.btAccept.Location = new System.Drawing.Point(306, 143);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(69, 30);
            this.btAccept.TabIndex = 2;
            this.btAccept.Text = "Aceptar";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(408, 144);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(79, 28);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(579, 825);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAccept);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.boxEdit);
            this.Name = "DetailsForm";
            this.Text = "editorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxEdit;
        private System.Windows.Forms.Label txtEdit;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.Button btCancel;
    }
}