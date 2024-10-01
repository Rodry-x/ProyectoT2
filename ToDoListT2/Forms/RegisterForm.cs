using System;
using System.Diagnostics;
using System.Windows.Forms;
using Helpers;
using Models;

namespace Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationHelper.NavigateTo(new LoginForm());
        }

        private async void btRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var body = new RegisterBodyRequest
                {
                    name = name_input.Text,
                    email = email_input.Text,
                    password = password_input.Text
                };
                await FetchHelper.PostAsync<RegisterBodyRequest, RegisterBodyResponse>("users", body);
                NavigationHelper.NavigateTo(new LoginForm());
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void boxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
