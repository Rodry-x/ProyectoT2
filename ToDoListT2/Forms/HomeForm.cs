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

            listBoxView.DataSource = DataStore.Tasks;
            listBoxView.DisplayMember = "Name";
            listBoxView.ValueMember = "Id";
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
        private void logout_btn_Click(object sender, EventArgs e)
        {
            DataStore.Clear();
            FetchHelper.ClearAuthenticationHeader();
            NavigationHelper.NavigateTo(new LoginForm());
        }
        private void button_add_task_Click(object sender, EventArgs e)
        {
            AddTaskForm addTask = new AddTaskForm();
            addTask.Visible = true;
        }
        private void OnListDoubleClick(object sender, EventArgs e)
        {
            TaskItem selectedTask = (TaskItem)listBoxView.SelectedItem;
            EditTaskForm editTask = new EditTaskForm(selectedTask);
            editTask.Visible = true;
        }
    }
}
