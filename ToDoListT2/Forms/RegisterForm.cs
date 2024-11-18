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
                txtUser.Text,
                txtEmail.Text,
                txtPassword.Text
            );
            NavigationHelper.NavigateTo(new HomeForm());
        }
        private void panelName_Click(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void panelEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }
        private void panelPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }
    }
}
