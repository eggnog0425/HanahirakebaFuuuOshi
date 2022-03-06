using Microsoft.AspNetCore.Components.WebView.Maui;
using HanahirakebaFuuuOshi.Data;
using HanahirakebaFuuuOshi.OAuth;
using HanahirakebaFuuuOshi.Config;

namespace HanahirakebaFuuuOshi;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddBlazorWebView();
		builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddScoped<OAuth2Twitter>();
		builder.Services.AddSingleton<ConfigStatefulService>();

		return builder.Build();
	}
}
