using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Helpers;
using System.Drawing;

namespace Forms
{
    public partial class ContainerForm : Form
    {

        public ContainerForm()
        {
            InitializeComponent();
            AppHelper._containerForm = this;
            NavigationHelper._containerForm = this;
            NavigationHelper.NavigateTo(new LoginForm());
        }
        public void ShowForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(form);
            form.Show();
        }

        public void SetLoading()
        {
            panelLoading.Visible = true;
        }

        public void RemoveLoading()
        {
            panelLoading.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam );

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012,0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
