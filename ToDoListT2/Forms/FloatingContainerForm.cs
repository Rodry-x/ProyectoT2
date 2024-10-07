using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Helpers;
using System.Diagnostics;

namespace Forms
{
    public partial class FloatingContainerForm : Form
    {
        public FloatingContainerForm(Form form)
        {
            InitializeComponent();
            ShowForm(form);
        }
        private void ShowForm(Form form)
        {
            Debug.WriteLine(form);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            panelContent.Controls.Clear();
            panelContent.Controls.Add(form);
            form.Show();
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
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
