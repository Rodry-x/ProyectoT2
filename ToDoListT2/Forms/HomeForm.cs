using System;
using System.Windows.Forms;
using Helpers;
using Stores;

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
            msg_welcome.Text = $"Bienvenido, {UserStore.User.Name}";
            tasksList.DataSource = TasksStore.Tasks;
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
            TasksStore.Clear();
            UserStore.Clear();
            FetchHelper.ClearAuthenticationHeader();
            NavigationHelper.NavigateTo(new LoginForm());
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(new DetailsUserForm());
        }
    }
}
