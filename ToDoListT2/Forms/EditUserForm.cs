using System;
using System.Windows.Forms;
using Helpers;
using Stores;

namespace Forms
{
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            txtUser.Text = UserStore.User.Name;
            txtEmail.Text = UserStore.User.Email;
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            var success = await UserStore.editUser(txtUser.Text, txtEmail.Text);
            if (success)
            {
                NavigationHelper.NavigateTo(new DetailsUserForm());
                MessageBox.Show("Usuario actualizado");
                NavigationHelper.CloseFloating();
            }
            else
            {
                MessageBox.Show("Error al actualizar el usuario");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigationHelper.CloseFloating();
        }

        private void panelUser_Click(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void panelEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }
    }
}
