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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContainerForm mainForm = (ContainerForm)this.ParentForm;
            mainForm.ShowForm(new LoginForm());
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            ContainerForm mainForm = (ContainerForm)this.ParentForm;
            mainForm.ShowForm(new FormMain());
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
