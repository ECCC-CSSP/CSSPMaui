namespace CSSPApp;

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

        //try
        //{
        //builder.Services.AddSingleton<IAppService, AppService>();
        builder.Services.AddSingleton<ICSSPAppService, CSSPAppService>();
        builder.Services.AddSingleton<ICSSPScrambleService, CSSPScrambleService>();

        //builder.Services.AddTransient<AppViewModel>();
        //builder.Services.AddTransient<IFirstPageViewModel, FirstPageViewModel>();
        //builder.Services.AddTransient<IMainPageViewModel, MainPageViewModel>();

        builder.Services.AddTransient<FirstPage>();
        builder.Services.AddSingleton<FirstPageViewModel>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();
        //}
        //catch (Exception ex)
        //{
        //    var sejf = ex.Message;
        //}

        //builder.Services.AddLocalization();
        //builder.Services.AddSingleton<IStringLocalizer<StringRes>, StringRes>();

        return builder.Build();

    }
}
