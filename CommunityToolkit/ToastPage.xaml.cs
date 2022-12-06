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
		await Toast.Make($"Toast ��� - {DateTime.Now}").Show();
    }

    private async void ToastCustom_Clicked(object sender, EventArgs e)
    {
        await Toast.Make($"Taost Custom ��� - {DateTime.Now}", ToastDuration.Long, 14).Show();
    }
}