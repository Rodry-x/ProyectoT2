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
        private async void addTask()
        {
            if (input_taskName.Text.Length > 0 && input_taskDescription.Text.Length > 0)
            {
                try
                {
                    using (FetchHelper fetchHelper = new FetchHelper())
                    {
                        var body = new CreateTaskBodyRequest
                        {
                            name = input_taskName.Text,
                            description = input_taskDescription.Text,
                            deadline = input_taskDateTime.Value

                        };
                        fetchHelper.SetAuthorizationToken(DataStore.Token);
                        var response = await fetchHelper.PostAsync<CreateTaskBodyRequest, CreateTaskBodyResponse>("tasks", body);
                        TaskItem task = new TaskItem
                        {
                            Id = response.id,
                            Name = response.name,
                            Description = response.description,
                            Deadline = response.deadline
                        };
                        DataStore.Tasks.Add(task);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    //
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else 
            {
                msg_required1.Text = "Es Obligatorio";
                msg_required2.Text = "Es Obligatorio";
            }
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            msg_addTask.Text = $"Que quieres añadir hoy {DataStore.User.Name}?";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            addTask();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
