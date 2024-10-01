using System;
using System.Diagnostics;
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
        private async void login()
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
                NavigationHelper.NavigateTo(new HomeForm());
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void textRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationHelper.NavigateTo(new RegisterForm());
        }

        private void onPressEnter(object sender, KeyEventArgs e)
        {
            login();
        }
    }
}
