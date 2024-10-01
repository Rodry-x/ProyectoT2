using System;
using System.Diagnostics;
using System.Windows.Forms;
using Helpers;
using Models;
using Data;

namespace Forms
{
    public partial class EditTaskForm: Form
    {
        TaskItem task;
        public EditTaskForm(TaskItem taskItem)
        {
            task = taskItem;
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
                var success = await FetchHelper.PutAsync($"tasks/{task.Id}", body);
                if (success)
                {
                    var taskIndex = DataStore.Tasks.IndexOf(task);
                    Debug.WriteLine(taskIndex);
                    DataStore.Tasks[taskIndex] = new TaskItem
                    {
                        Id = task.Id,
                        Name = input_taskName.Text,
                        Description = input_taskDescription.Text,
                        Deadline = input_taskDateTime.Value
                    };
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