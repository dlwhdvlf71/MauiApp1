namespace MauiApp1;

public partial class TimerPage : ContentPage
{
    private bool isRunning = false;
    private TimeOnly timeOnly = new TimeOnly();

	public TimerPage()
	{
		InitializeComponent();
	}

    private async void startAndStopButton_Clicked(object sender, EventArgs e)
    {
        isRunning = !isRunning;

        startAndStopButton.Text = isRunning ? "Stop" : "Start";

        while (isRunning)
        {
            timeOnly = timeOnly.Add(TimeSpan.FromSeconds(1));

            mainTimerLabel.Text = $"{timeOnly.Hour.ToString("00")}:{timeOnly.Minute.ToString("00")}:{timeOnly.Second.ToString("00")}";
            //mainTimerLabel.Text = timeOnly.ToString("hh:mm");


            await Task.Delay(TimeSpan.FromSeconds(1));
        }

    }

    private async void resetButton_Clicked(object sender, EventArgs e)
    {
        isRunning = false;
        timeOnly = new TimeOnly();

        mainTimerLabel.Text = "00:00:00";

        await Task.Delay(TimeSpan.FromSeconds(1));
    }

    
}