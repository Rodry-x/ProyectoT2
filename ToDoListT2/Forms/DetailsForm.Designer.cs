﻿using System.ComponentModel;

namespace Forms
{
    partial class DetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.backButton = new System.Windows.Forms.Button();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.lblTaskDeadline = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(16, 42);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 28);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Retroceder";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTaskName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTaskName.Location = new System.Drawing.Point(38, 107);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(129, 48);
            this.lblTaskName.TabIndex = 5;
            this.lblTaskName.Text = "Tarea";
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.ForeColor = System.Drawing.Color.White;
            this.lblTaskDescription.Location = new System.Drawing.Point(43, 202);
            this.lblTaskDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(516, 245);
            this.lblTaskDescription.TabIndex = 6;
            this.lblTaskDescription.Text = "Descripción";
            // 
            // lblTaskDeadline
            // 
            this.lblTaskDeadline.ForeColor = System.Drawing.Color.White;
            this.lblTaskDeadline.Location = new System.Drawing.Point(410, 546);
            this.lblTaskDeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskDeadline.Name = "lblTaskDeadline";
            this.lblTaskDeadline.Size = new System.Drawing.Size(116, 42);
            this.lblTaskDeadline.TabIndex = 7;
            this.lblTaskDeadline.Text = "01/10/2024";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(46, 683);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(221, 683);
            this.btnEditTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(100, 28);
            this.btnEditTask.TabIndex = 9;
            this.btnEditTask.Text = "Editar";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTaskDeadline);
            this.Controls.Add(this.lblTaskDescription);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditTask;

        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblTaskDeadline;

        private System.Windows.Forms.Label titleTask;

        private System.Windows.Forms.Button backButton;

        #endregion
    }
}