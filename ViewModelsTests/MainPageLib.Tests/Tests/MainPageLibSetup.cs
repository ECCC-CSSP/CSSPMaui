namespace MainPageLib.Tests;

[Collection("Sequential")]
public partial class MainPageLibTests
{
    private IConfiguration? Configuration { get; set; }
    private IServiceCollection? Services { get; set; }
    private IServiceProvider? Provider { get; set; }
    private IMainPageViewModel? MainPageViewModel { get; set; }

    private async Task<bool> MainPageLibSetup(string culture)
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.FullName)
            .AddJsonFile("appsettings_mainpagelibtests.json")
            .Build();

        Services = new ServiceCollection();

        Services.AddSingleton(Configuration);
        Services.AddSingleton<ICSSPScrambleService, CSSPScrambleService>();
        Services.AddSingleton<ICSSPAppService, CSSPAppService>();
        Services.AddSingleton<IMainPageViewModel, MainPageViewModel>();

        Provider = Services.BuildServiceProvider();
        Assert.NotNull(Provider);

        //try
        //{
            MainPageViewModel = Provider.GetService<IMainPageViewModel>();
            Assert.NotNull(MainPageViewModel);

        //}
        //catch (Exception ex)
        //{
        //    var exc = ex.Message;
        //}

        return await Task.FromResult(true);
    }
}

