using System;
using System.Windows.Forms;
using Data;
using Helpers;
using Models;

namespace AppForms
{
    public class LoginBodyRequest
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class ResponseUser
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
    public class LoginBodyResponse
    {
        public ResponseUser user { get; set; }
        public string token { get; set; }
    }
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
