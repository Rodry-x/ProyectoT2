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
            bool success = await UserStore.login(email_input.Text, password_input.Text);
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
    }
}
