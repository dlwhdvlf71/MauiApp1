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
		await this.DisplaySnackbar($"Click SnackBar - {DateTime.Now}", null, "닫기", TimeSpan.FromSeconds(10), null, ct);
    }

    private async void SnackBarCustom_Clicked(object sender, EventArgs e)
    {
        var snackbar = Snackbar.Make(
            "스낵바 입니다.",
            async () => await DisplayAlert("SnackBar > Alert", "SnackBar > Alert 상태 입니다.", "확인", "취소"),
            "닫기",
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