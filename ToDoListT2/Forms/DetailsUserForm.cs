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

        private void DetailsUserForm_Load(object sender, System.EventArgs e)
        {
            lblEmail.Text = UserStore.User.Email;
            lblName.Text = UserStore.User.Name;
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            NavigationHelper.NavigateTo(new HomeForm());
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            NavigationHelper.NavigateToFloating(new EditUserForm());
        }
    }
}
