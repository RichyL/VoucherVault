using VoucherVault.ViewModels;
using VoucherVault.Views;

namespace VoucherVault;

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

        builder.Services.AddSingleton<VouchersViewModel>();
        builder.Services.AddSingleton<VouchersView>();

        builder.Services.AddTransient<VoucherViewModel>();
        builder.Services.AddTransient<VoucherView>();


        return builder.Build();
	}
}
