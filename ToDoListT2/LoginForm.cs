using System;
using System.Windows.Forms;
using ToDoListT2.Data;
using ToDoListT2.Helpers;

namespace ToDoListT2
{
    public class LoginBodyRequest
    {
        public string email { get; set; }
        public string password { get; set; }
    }
    public abstract class LoginBodyResponse
    {
        public string token { get; }
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
                    var data = await fetchHelper.PostAsync<LoginBodyRequest, LoginBodyResponse>("auth/login", body);
                    DataStore.User.Token = data.token;
                    NavigationHelper.NavigateTo(new FormMain());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }
        }

        private void textRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationHelper.NavigateTo(new RegisterForm());
        }
    }
}
