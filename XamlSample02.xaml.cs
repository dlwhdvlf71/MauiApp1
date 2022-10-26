namespace MauiApp1;

public partial class XamlSample02 : ContentPage
{
    public XamlSample02()
    {
        InitializeComponent();
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Label label = (Label)sender;
        Color[] colors = { Color.FromRgb(240, 248, 255), Color.FromRgb(255, 160, 122), Color.FromRgb(32, 178, 170), Color.FromRgb(255, 0, 255) };

        Random random = new Random();

        label.TextColor = colors[random.Next(colors.Count() - 1)];
    }


    private void OnDark_Clicked(object sender, EventArgs e)
    {
        Resources["fgColor"] = Colors.Navy;
        Resources["bgColor"] = Colors.Silver;
    }

    private void OnLight_Clicked(object sender, EventArgs e)
    {
        Resources["fgColor"] = Colors.Silver;
        Resources["bgColor"] = Colors.Navy;
    }
}