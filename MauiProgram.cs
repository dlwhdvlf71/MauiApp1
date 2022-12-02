using MauiApp1.DependencyInjection;
using MauiApp1.InjectableServices;

namespace MauiApp1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//builder.Services.AddTransient<IHelloWorldClass, HelloWorldlClass>();
		//builder.Services.AddTransient<IncrementCOunterViewModel>();
		//builder.Services.AddTransient<IncrementCounterPage>();

		builder.Services.Scan(scan => scan
		.FromAssemblyOf<ITransientService>()
		.AddClasses(classes => classes.AssignableTo<ITransientService>())
		.AsSelfWithInterfaces()
		.WithTransientLifetime()
        .AddClasses(classes => classes.AssignableTo<IScopedService>())
        .AsSelfWithInterfaces()
        .WithScopedLifetime()
        .AddClasses(classes => classes.AssignableTo<ISingletonService>())
        .AsSelfWithInterfaces()
        .WithSingletonLifetime()
        );

        return builder.Build();
	}
}
