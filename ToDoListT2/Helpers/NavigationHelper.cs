using System.Windows.Forms;
using Forms;

namespace Helpers
{
    public static class NavigationHelper
    {
        public static ContainerForm _containerForm;

        public static void NavigateTo(Form form)
        {
            _containerForm.ShowForm(form);
        }

        public static void NavigateToFloating(Form form)
        {
            new FloatingContainerForm(form).Show();
        }
    }
}