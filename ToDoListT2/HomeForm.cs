using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Data;
using Helpers;
using Models;
using ToDoListT2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AppForms
{
    public partial class HomeForm: Form
    {
        AddTaskForm ventana = new AddTaskForm();
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
                using (FetchHelper fetchHelper = new FetchHelper())
                {
                    fetchHelper.SetAuthorizationToken(DataStore.Token);
                    var response = await fetchHelper.GetAsync<List<GetTasksItem>>("tasks");
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
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void listBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DataStore.Clear();
            NavigationHelper.NavigateTo(new LoginForm());
        }

        private void button_add_task_Click(object sender, EventArgs e)
        {
            AddTaskForm addTask = new AddTaskForm();
            addTask.Visible = true;
        }

        private void edit_TaskForm(object sender, EventArgs e)
        {
            TaskItem selectedTask = (TaskItem)listBoxView.SelectedItem;
            DetailsForm editTask = new DetailsForm(selectedTask);
            editTask.Visible = true;
        }
    }
}
