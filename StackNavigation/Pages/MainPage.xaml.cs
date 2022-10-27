namespace MauiApp1.StackNavigation.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		firstButton.Clicked += async (s, e) => await Shell.Current.GoToAsync("numberpage?number=first");
		secondButton.Clicked += async (s, e) => await Shell.Current.GoToAsync("numberpage?number=second");

	}
}