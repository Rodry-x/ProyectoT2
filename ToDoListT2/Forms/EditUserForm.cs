using System;
using System.Windows.Forms;
using Helpers;
using Models;
using Stores;

namespace Forms
{
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }

        private async void EditUser()
        {
            try
            {
                var body = new PutUserBodyRequest
                {
                    name = input_userName.Text,
                    email = input_userEmail.Text,
                    password = input_userPassword.Text
                };
                var success = await FetchHelper.PutAsync($"users/{UserStore.User.Id}", body);
                if (success)
                {
                    UserStore.User.Name = input_userName.Text;
                    UserStore.User.Email = input_userEmail.Text;
                    UserStore.User.Password = input_userPassword.Text;
                    MessageBox.Show("Usuario actualizado");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el usuario");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            EditUser();
            NavigationHelper.NavigateTo(new DetailsUserForm());
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(new DetailsUserForm());
        }
    }
}
