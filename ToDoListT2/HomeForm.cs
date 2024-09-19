using System;
using System.Windows.Forms;
using Data;
using Helpers;
using Models;
using ToDoListT2;

namespace AppForms
{
    public partial class HomeForm: Form
    {
        AddTaskForm ventana = new AddTaskForm();
        public HomeForm()
        {
            InitializeComponent();
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            msg_welcome.Text = $"Bienvenido, {DataStore.User.Name}";

            listBoxView.DataSource = DataStore.Tasks;
            listBoxView.DisplayMember = "Name";
            listBoxView.ValueMember = "Id";
        }

        private void listBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBoxView.SelectedIndex!=-1)
                 //textEliminar.Text = listBoxView.Items[listBoxView.SelectedIndex].ToString;
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            int indice = listBoxView.SelectedIndex;

            if (indice!=-1)
            {
                listBoxView.Items.RemoveAt(indice);
            }
        }

        private void botonVaciar_Click(object sender, EventArgs e)
        {
            listBoxView.Items.Clear();
        }
        private void listBoxView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int indice = listBoxView.SelectedIndex;

                if (indice != -1)
                {
                    listBoxView.Items.RemoveAt(indice);
                }
            }
        }

        private void botonHome_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(new LoginForm());
        }

        private void button_add_task_Click(object sender, EventArgs e)
        {
            AddTaskForm addTask = new AddTaskForm();
            addTask.Visible = true;
        }
    }
}
