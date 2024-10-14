using System.Windows.Forms;
using System;
using Helpers;
using Stores;

namespace Forms
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            var success = await TasksStore.addTask(
                txtTitle.Text,
                txtDescription.Text,
                dtpDeadline.Value
            );
            if (success)
            {
                MessageBox.Show("Tarea agregada");
                NavigationHelper.CloseFloating();
            }
            else
            {
                MessageBox.Show("Error al agregar la tarea");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigationHelper.CloseFloating();
        }
    }
}
