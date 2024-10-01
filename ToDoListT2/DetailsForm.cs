using System;
using System.ComponentModel;
using System.Windows.Forms;
using Data;
using Helpers;
using Models;

namespace AppForms
{
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

       private async void EditTask()
        {
            //
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            EditTask();
            NavigationHelper.NavigateTo(new HomeForm());
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(new HomeForm());
        }
    }
}
