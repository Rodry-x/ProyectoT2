using System;
using System.Windows.Forms;
using ToDoListT2.Helpers;

namespace ToDoListT2
{
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(new FormMain());
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(new FormMain());
        }
    }
}
