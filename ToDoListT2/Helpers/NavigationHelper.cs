using System.Windows.Forms;

namespace ToDoListT2.Helpers
{
    public static class NavigationHelper
    {
        public static ContainerForm MainForm { get; set; }

        public static void NavigateTo(Form form)
        {
            MainForm.ShowForm(form);
        }
    }

}