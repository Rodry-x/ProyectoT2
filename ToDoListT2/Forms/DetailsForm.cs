using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;
using Data;
using Models;

namespace Forms
{
    public partial class DetailsForm : Form
    {
        private readonly int taskIndex;
        public DetailsForm(int selectedTaskIndex)
        {
            InitializeComponent();
            taskIndex = selectedTaskIndex;
        }

        private async Task DeleteTask()
        {
            try
            {
                var success = await FetchHelper.DeleteAsync($"tasks/{DataStore.Tasks[taskIndex].Id}");
                if (success)
                {
                    DataStore.Tasks.RemoveAt(taskIndex);
                    MessageBox.Show("Tarea eliminada");
                    NavigationHelper.NavigateTo(new HomeForm());
                }
                else
                {
                    MessageBox.Show("Error al eliminar la tarea");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            lblTaskName.DataBindings.Add("Text", DataStore.Tasks[taskIndex], "Name");
            lblTaskDescription.DataBindings.Add("Text", DataStore.Tasks[taskIndex], "Description");
            lblTaskDeadline.DataBindings.Add("Text", DataStore.Tasks[taskIndex], "Deadline");
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            var editTaskForm = new EditTaskForm(taskIndex);
            editTaskForm.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(new HomeForm());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteTask();
        }
    }
}