using System.Windows.Forms;
using Helpers;
using Stores;

namespace Forms
{
    public partial class DetailsUserForm : Form
    {
        public DetailsUserForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, System.EventArgs e)
        {
            NavigationHelper.NavigateTo(new HomeForm());
        }

        private void buttonEdit_Click(object sender, System.EventArgs e)
        {
            NavigationHelper.NavigateTo(new EditUserForm());
        }

        private void DetailsUserForm_Load(object sender, System.EventArgs e)
        {
            lblEmail.Text = UserStore.User.Email;
            lblUser.Text = UserStore.User.Name;
        }
    }
}
