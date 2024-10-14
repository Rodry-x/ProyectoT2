using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;
using Stores;

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

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            lblTaskName.DataBindings.Add("Text", TasksStore.Tasks[taskIndex], "Name");
            lblTaskDescription.DataBindings.Add("Text", TasksStore.Tasks[taskIndex], "Description");
            lblTaskDeadline.DataBindings.Add("Text", TasksStore.Tasks[taskIndex], "Deadline");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var success = await TasksStore.deleteTask(taskIndex);
            if (success)
            {
                MessageBox.Show("Tarea eliminada");
                NavigationHelper.NavigateTo(new HomeForm());
            }
            else
            {
                MessageBox.Show("Error al eliminar la tarea");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(new HomeForm());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToFloating(new EditTaskForm(taskIndex));
        }
    }
}