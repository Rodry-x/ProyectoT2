using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Data;
using Helpers;
using Models;

namespace Forms
{
    public partial class HomeForm: Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            msg_welcome.Text = $"Bienvenido, {DataStore.User.Name}";
            tasksList.DataSource = DataStore.Tasks;
            tasksList.DisplayMember = "Name";
            tasksList.ValueMember = "Id";
        }

        private void List_DoubleClick(object sender, EventArgs e)
        {
            var selectedTaskIndex = tasksList.SelectedIndex;
            NavigationHelper.NavigateTo(new DetailsForm(selectedTaskIndex));
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();
            addTaskForm.Visible = true;
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            DataStore.Clear();
            FetchHelper.ClearAuthenticationHeader();
            NavigationHelper.NavigateTo(new LoginForm());
        }
    }
}
