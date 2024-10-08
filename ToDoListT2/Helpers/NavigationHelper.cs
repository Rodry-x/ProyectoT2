using System.Windows.Forms;
using Forms;

namespace Helpers
{
    public static class NavigationHelper
    {
        public static ContainerForm _containerForm;
        public static FloatingContainerForm _floatingContainerForm;

        public static void NavigateTo(Form form)
        {
            _containerForm.ShowForm(form);
        }

        public static void NavigateToFloating(Form form)
        {
            _floatingContainerForm = new FloatingContainerForm(form);
            _floatingContainerForm.Show();
        }

        public static void CloseFloating()
        {
            _floatingContainerForm.Close();
        }
    }
}