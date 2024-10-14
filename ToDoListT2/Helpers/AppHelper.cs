using Forms;

public static class AppHelper
{
    public static ContainerForm _containerForm;
    public static FloatingContainerForm _floatingContainerForm;

    public static void SetLoading()
    {
        _containerForm.SetLoading();
    }

    public static void RemoveLoading()
    {
        _containerForm.RemoveLoading();
    }

    public static void SetFloatingLoading()
    {
        _floatingContainerForm.SetLoading();
    }

    public static void RemoveFloatingLoading()
    {
        _floatingContainerForm.RemoveLoading();
    }
}
