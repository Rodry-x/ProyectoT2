using System;
using System.Windows.Forms;
using Helpers;
using Stores;

namespace Forms
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            bool success = await UserStore.login(txtEmail.Text, txtPassword.Text);
            if (success)
            {
                await TasksStore.getTasks();
                NavigationHelper.NavigateTo(new HomeForm());
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            };
        }

        private void textRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationHelper.NavigateTo(new RegisterForm());
        }

        private void panelPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void panelEmail_Click(object sender, EventArgs e)
        {

            txtEmail.Focus();
        }
    }
}
