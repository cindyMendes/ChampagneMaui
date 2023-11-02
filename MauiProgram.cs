using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ChampagneMaui.Services;
using Microsoft.AspNetCore.Components.Authorization;

namespace ChampagneMaui;

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
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<IAppService, AppService>();
		builder.Services.AddSingleton<IChampagneService, ChampagneService>();
		builder.Services.AddSingleton<IGrapeVarietyService, GrapeVarietyService>();
		builder.Services.AddSingleton<ISizeService, SizeService>();
		builder.Services.AddSingleton<IPriceService, PriceService>();
		builder.Services.AddSingleton<ICompositionService, CompositionService>();



        return builder.Build();
	}
}
