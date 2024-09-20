using System;
using System.Windows.Forms;
using Data;
using Helpers;
using Models;

namespace AppForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                using (FetchHelper fetchHelper = new FetchHelper())
                {
                    var body = new LoginBodyRequest
                    {
                        email = email_input.Text,
                        password = password_input.Text
                    };
                    var response = await fetchHelper.PostAsync<LoginBodyRequest, LoginBodyResponse>("auth/login", body);
                    User user = new User
                    {
                        Id = response.user.id,
                        Name = response.user.name,
                        Email = response.user.email
                    };
                    DataStore.User = user;
                    DataStore.Token = response.token;

                    NavigationHelper.NavigateTo(new HomeForm());
                }
            }
            catch (Exception ex)
            {
                //
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void textRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationHelper.NavigateTo(new RegisterForm());
        }
    }
}
