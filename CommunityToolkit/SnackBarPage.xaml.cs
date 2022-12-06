using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Microsoft.Maui;

namespace MauiApp1.CommunityToolkit;

public partial class SnackBarPage : ContentPage
{
	public SnackBarPage()
	{
		InitializeComponent();
	}

    CancellationToken ct = new CancellationToken();

    private async void SnackBar_Clicked(object sender, EventArgs e)
    {
		await this.DisplaySnackbar($"Click SnackBar - {DateTime.Now}", null, "�ݱ�", TimeSpan.FromSeconds(10), null, ct);
    }

    private async void SnackBarCustom_Clicked(object sender, EventArgs e)
    {
        var snackbar = Snackbar.Make(
            "������ �Դϴ�.",
            async () => await DisplayAlert("SnackBar > Alert", "SnackBar > Alert ���� �Դϴ�.", "Ȯ��", "���"),
            "�ݱ�",
            TimeSpan.FromSeconds(5),
            new SnackbarOptions
            {
                BackgroundColor = Colors.White,
                TextColor = Colors.Coral,
                ActionButtonTextColor = Colors.Red,
                CornerRadius = 10,
                Font = Microsoft.Maui.Font.SystemFontOfSize(10),
            }
            );

        await snackbar.Show();
    }
}