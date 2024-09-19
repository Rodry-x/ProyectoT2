using System;
using System.Windows.Forms;
using AppForms;
using Data;
using Helpers;
using Models;

namespace ToDoListT2
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }
        private void addTask()
        {
            if (input_taskName.Text.Length > 0 && input_taskDescription.Text.Length > 0)
            {
                var task = new Task
                {
                    Id = 1,
                    Name = input_taskName.Text,
                    Description = input_taskDescription.Text,
                    Deadline = input_taskDateTime.Value
                };
                DataStore.Tasks.Add(task);
                input_taskName.Text = string.Empty;
                input_taskDescription.Text = string.Empty;
            }
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            msg_addTask.Text = $"Que quieres añadir hoy {DataStore.User.Name}?";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            addTask();
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
