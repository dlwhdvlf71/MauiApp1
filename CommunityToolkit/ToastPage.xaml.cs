using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace MauiApp1.CommunityToolkit;

public partial class ToastPage : ContentPage
{
	public ToastPage()
	{
		InitializeComponent();
	}

    private async void Toast_Clicked(object sender, EventArgs e)
    {
		await Toast.Make($"Toast 출력 - {DateTime.Now}").Show();
    }

    private async void ToastCustom_Clicked(object sender, EventArgs e)
    {
        await Toast.Make($"Taost Custom 출력 - {DateTime.Now}", ToastDuration.Long, 14).Show();
    }
}