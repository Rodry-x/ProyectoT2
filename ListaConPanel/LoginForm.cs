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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btAccess_Click(object sender, EventArgs e)
        {
            ContainerForm mainForm = (ContainerForm)this.ParentForm;
            mainForm.ShowForm(new FormMain());
        }

        private void textRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContainerForm mainForm = (ContainerForm)this.ParentForm;
            mainForm.ShowForm(new RegisterForm());
        }
    }
}
