using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Helpers;
using Models;

namespace Forms
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private async Task getTasks()
        {
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

        private async Task login()
        {
            try
            {
                var body = new LoginBodyRequest
                {
                    email = email_input.Text,
                    password = password_input.Text
                };
                var response = await FetchHelper.PostAsync<LoginBodyRequest, LoginBodyResponse>("auth/login", body);
                User user = new User
                {
                    Id = response.user.id,
                    Name = response.user.name,
                    Email = response.user.email
                };
                DataStore.User = user;
                FetchHelper.SetAuthenticationHeader(response.token);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            await login();
            await getTasks();
            NavigationHelper.NavigateTo(new HomeForm());
        }

        private void textRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationHelper.NavigateTo(new RegisterForm());
        }
    }
}
