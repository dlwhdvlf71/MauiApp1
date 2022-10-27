namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		//MainPage = new StudentPage();
		//MainPage = new SecondPage();
		//MainPage = new XamlSample01();
		//MainPage = new MainPage();
		//MainPage = new TestPage();

		//MainPage = new NavigationPage(new MainPage());
	}
}
