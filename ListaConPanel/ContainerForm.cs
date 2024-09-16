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
    public partial class ContainerForm : Form
    {
        public void ShowForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(form);
            form.Show();
        }
        public ContainerForm()

        {
            InitializeComponent();
            ShowForm(new LoginForm());
        }
    }
}
