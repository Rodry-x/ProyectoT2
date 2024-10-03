using Data;
using Forms;
using Helpers;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListT2.Forms
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
                var success = await FetchHelper.PutAsync($"users/{DataStore.User.Id}", body);
                if (success)
                {
                    DataStore.User.Name = input_userName.Text;
                    DataStore.User.Email = input_userEmail.Text;
                    DataStore.User.Password = input_userPassword.Text;
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
