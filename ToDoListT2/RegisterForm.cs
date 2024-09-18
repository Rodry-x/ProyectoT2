using System;
using System.Windows.Forms;
using ToDoListT2.Helpers;

namespace ToDoListT2
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
            NavigationHelper.NavigateTo(new FormMain());
        }
    }
}
