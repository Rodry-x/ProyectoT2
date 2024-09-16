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
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            ContainerForm mainForm = (ContainerForm)this.ParentForm;
            mainForm.ShowForm(new FormMain());
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ContainerForm mainForm = (ContainerForm)this.ParentForm;
            mainForm.ShowForm(new FormMain());
        }
    }
}
