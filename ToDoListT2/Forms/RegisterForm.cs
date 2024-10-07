using System;
using System.Diagnostics;
using System.Windows.Forms;
using Helpers;
using Models;
using Stores;

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
            await UserStore.register(
                name_input.Text,
                email_input.Text,
                // txtPassword.Text
                "asd"
            );
            NavigationHelper.NavigateTo(new HomeForm());
        }

        private void boxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelName_Paint(object sender, PaintEventArgs e)
        {
            txtUser.Focus();
        }

        private void panelEmail_Paint(object sender, PaintEventArgs e)
        {
            txtGmail.Focus();
        }

        private void panelPassword_Paint(object sender, PaintEventArgs e)
        {
            // txtPassword.Focus();
        }
    }
}
