namespace ToDoListT2
{
    partial class AddTaskForm
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
            this.msg_addTask = new System.Windows.Forms.Label();
            this.title_addTask = new System.Windows.Forms.Label();
            this.input_taskName = new System.Windows.Forms.TextBox();
            this.description_addTask = new System.Windows.Forms.Label();
            this.input_taskDescription = new System.Windows.Forms.TextBox();
            this.input_taskDateTime = new System.Windows.Forms.DateTimePicker();
            this.date_addTask = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msg_addTask
            // 
            this.msg_addTask.AutoSize = true;
            this.msg_addTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.msg_addTask.ForeColor = System.Drawing.SystemColors.Control;
            this.msg_addTask.Location = new System.Drawing.Point(12, 9);
            this.msg_addTask.Name = "msg_addTask";
            this.msg_addTask.Size = new System.Drawing.Size(282, 48);
            this.msg_addTask.TabIndex = 0;
            this.msg_addTask.Text = "msg_addTask";
            // 
            // title_addTask
            // 
            this.title_addTask.AutoSize = true;
            this.title_addTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.title_addTask.ForeColor = System.Drawing.SystemColors.Control;
            this.title_addTask.Location = new System.Drawing.Point(38, 80);
            this.title_addTask.Name = "title_addTask";
            this.title_addTask.Size = new System.Drawing.Size(44, 18);
            this.title_addTask.TabIndex = 1;
            this.title_addTask.Text = "Titulo";
            // 
            // input_taskName
            // 
            this.input_taskName.Location = new System.Drawing.Point(41, 101);
            this.input_taskName.Name = "input_taskName";
            this.input_taskName.Size = new System.Drawing.Size(471, 22);
            this.input_taskName.TabIndex = 2;
            // 
            // description_addTask
            // 
            this.description_addTask.AutoSize = true;
            this.description_addTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.description_addTask.ForeColor = System.Drawing.SystemColors.Control;
            this.description_addTask.Location = new System.Drawing.Point(38, 138);
            this.description_addTask.Name = "description_addTask";
            this.description_addTask.Size = new System.Drawing.Size(87, 18);
            this.description_addTask.TabIndex = 3;
            this.description_addTask.Text = "Descripción";
            // 
            // input_taskDescription
            // 
            this.input_taskDescription.Location = new System.Drawing.Point(42, 162);
            this.input_taskDescription.Name = "input_taskDescription";
            this.input_taskDescription.Size = new System.Drawing.Size(469, 22);
            this.input_taskDescription.TabIndex = 4;
            // 
            // input_taskDateTime
            // 
            this.input_taskDateTime.Location = new System.Drawing.Point(42, 231);
            this.input_taskDateTime.Name = "input_taskDateTime";
            this.input_taskDateTime.Size = new System.Drawing.Size(175, 22);
            this.input_taskDateTime.TabIndex = 5;
            // 
            // date_addTask
            // 
            this.date_addTask.AutoSize = true;
            this.date_addTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.date_addTask.ForeColor = System.Drawing.SystemColors.Control;
            this.date_addTask.Location = new System.Drawing.Point(45, 213);
            this.date_addTask.Name = "date_addTask";
            this.date_addTask.Size = new System.Drawing.Size(49, 18);
            this.date_addTask.TabIndex = 6;
            this.date_addTask.Text = "Fecha";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(46, 435);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(147, 50);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Guardar";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(433, 435);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(157, 49);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Cancelar";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(634, 509);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.date_addTask);
            this.Controls.Add(this.input_taskDateTime);
            this.Controls.Add(this.input_taskDescription);
            this.Controls.Add(this.description_addTask);
            this.Controls.Add(this.input_taskName);
            this.Controls.Add(this.title_addTask);
            this.Controls.Add(this.msg_addTask);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msg_addTask;
        private System.Windows.Forms.Label title_addTask;
        private System.Windows.Forms.TextBox input_taskName;
        private System.Windows.Forms.Label description_addTask;
        private System.Windows.Forms.TextBox input_taskDescription;
        private System.Windows.Forms.DateTimePicker input_taskDateTime;
        private System.Windows.Forms.Label date_addTask;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
    }
}