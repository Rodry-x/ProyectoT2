using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaConPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //adicionar elementos a la lista
            //listBoxView.Items.Add("Elemento 1");
            //listBoxView.Items.Add("Elemento 2");
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            listBoxView.Items.Add(textNotas.Text);
            textNotas.Text = string.Empty;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
