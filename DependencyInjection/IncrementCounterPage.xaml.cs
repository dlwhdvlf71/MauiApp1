namespace MauiApp1.DependencyInjection;

public partial class IncrementCounterPage : ContentPage
{
	public IncrementCounterPage(IncrementCOunterViewModel incrementCOunterViewModel)
	{
		InitializeComponent();
		BindingContext= incrementCOunterViewModel;
	}
}