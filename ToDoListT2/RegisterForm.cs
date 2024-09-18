using System;
using System.Windows.Forms;
using Helpers;

namespace AppForms
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

        private void btRegister_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(new HomeForm());
        }
    }
}
