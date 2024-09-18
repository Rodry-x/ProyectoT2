using System;
using System.Windows.Forms;
using Helpers;

namespace AppForms
{
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(new HomeForm());
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(new HomeForm());
        }
    }
}
