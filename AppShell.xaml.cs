using MauiApp1.StackNavigation.Pages;

namespace MauiApp1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("numberpage", typeof(NumberPage));
    }
}
