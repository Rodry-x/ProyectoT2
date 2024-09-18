using System.Windows.Forms;
using ToDoListT2.Helpers;

namespace ToDoListT2
{
    public partial class ContainerForm : Form
    {
        public ContainerForm()
        {
            InitializeComponent();
            NavigationHelper.MainForm = this;
            NavigationHelper.NavigateTo(new LoginForm());
        }
        public void ShowForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(form);
            form.Show();
        }
    }
}
