using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Helpers;
using Models;
using Stores;

namespace Forms
{
    public partial class EditTaskForm: Form
    {
        private readonly int taskIndex;
        public EditTaskForm(int selecTaskItem)
        {
            taskIndex = selecTaskItem;
            InitializeComponent();
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {
            txtTitle.Text = TasksStore.Tasks[taskIndex].Name;
            txtDescription.Text = TasksStore.Tasks[taskIndex].Description;
            dtpDeadline.Value = TasksStore.Tasks[taskIndex].Deadline;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigationHelper.CloseFloating();
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            var success = await TasksStore.editTask(
                taskIndex,
                txtTitle.Text,
                txtDescription.Text,
                dtpDeadline.Value
            );
            if (success)
            {
                MessageBox.Show("Tarea actualizada");
                NavigationHelper.CloseFloating();
            }
            else
            {
                MessageBox.Show("Error al actualizar la tarea");
            }
        }

        private void panelTitle_Click(object sender, EventArgs e)
        {
            txtTitle.Focus();
        }

        private void panelDescription_Click(object sender, EventArgs e)
        {
            txtDescription.Focus();
        }
    }
}