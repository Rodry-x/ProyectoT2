using System;
using System.Windows.Forms;
using ToDoListT2.Data;
using ToDoListT2.Helpers;
using ToDoListT2.Models;

namespace ToDoListT2
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();

            // Configurar el ListBox
            listBoxView.DataSource = DataStore.Tasks;
            listBoxView.DisplayMember = "Name"; // Mostrar solo la propiedad 'Name' de cada tarea
            listBoxView.ValueMember = "Id"; // Identificador
        }

        private void addTask()
        {
            if (textNotas.Text.Length > 0)
            {
                DataStore.Tasks.Add(new Task {
                    Id = 1,
                    Name = textNotas.Text,
                    Description = "",
                    Deadline = DateTime.Now.AddDays(1)
                });
                textNotas.Text = string.Empty;
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            addTask();
        }

        private void textNotas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addTask();
            }
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

        private void botonEditar_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(new DetailsForm());
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
    }
}
