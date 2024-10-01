using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Data;
using Helpers;
using Models;

namespace Forms
{
    public partial class HomeForm: Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            msg_welcome.Text = $"Bienvenido, {DataStore.User.Name}";
            tasksList.DataSource = DataStore.Tasks;
            tasksList.DisplayMember = "Name";
            tasksList.ValueMember = "Id";
            try
            {
                var response = await FetchHelper.GetAsync<List<GetTasksItem>>("tasks");
                response.ForEach(task => {
                    var taskItem = new TaskItem
                    {
                        Id = task.id,
                        Name = task.name,
                        Description = task.description,
                        Deadline = task.Deadline
                    };
                    DataStore.Tasks.Add(taskItem);
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void List_DoubleClick(object sender, EventArgs e)
        {
            AddTaskForm addTask = new AddTaskForm();
            addTask.Visible = true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            TaskItem selectedTask = (TaskItem)tasksList.SelectedItem;
            EditTaskForm editTask = new EditTaskForm(selectedTask);
            editTask.Visible = true;
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            DataStore.Clear();
            FetchHelper.ClearAuthenticationHeader();
            NavigationHelper.NavigateTo(new LoginForm());
        }
    }
}
