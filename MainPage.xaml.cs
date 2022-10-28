namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        //InitBinding();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private async void OnTimerClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new XamlSample02());
    }

    public void InitBinding()
    {
        dotnetBotImage.SetBinding(Image.RotationProperty, new Binding("Value", source:sliderImage));


        //dotnetBotImage.BindingContext = sliderImage;
        //dotnetBotImage.SetBinding(Image.RotationProperty, "Value");   
    }
}

