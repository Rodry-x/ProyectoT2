using System;
using System.Diagnostics;
using System.Windows.Forms;
using Helpers;
using Models;
using Stores;

namespace Forms
{
    public partial class EditTaskForm: Form
    {
        private readonly int taskIndex;
        public EditTaskForm(int selecTaskItem)
        {
            taskIndex = selecTaskItem;
            InitializeComponent();
        }
        private async void EditTask()
        {
            try
            {
                var body = new PutTaskBodyRequest
                {
                    name = input_taskName.Text,
                    description = input_taskDescription.Text,
                    deadline = input_taskDateTime.Value
                };
                var success = await FetchHelper.PutAsync($"tasks/{TasksStore.Tasks[taskIndex].Id}", body);
                if (success)
                {
                    Debug.WriteLine(taskIndex);
                    TasksStore.Tasks[taskIndex].Name = input_taskName.Text;
                    TasksStore.Tasks[taskIndex].Description = input_taskDescription.Text;
                    TasksStore.Tasks[taskIndex].Deadline = input_taskDateTime.Value;
                    MessageBox.Show("Tarea actualizada");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la tarea");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            EditTask();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}