using System.Diagnostics;
using System.Globalization;


namespace Delme2;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        if (CultureInfo.CurrentCulture.IetfLanguageTag != CultureInfo.CurrentUICulture.IetfLanguageTag)
        {
			//Debugger.Break();
        }

        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
