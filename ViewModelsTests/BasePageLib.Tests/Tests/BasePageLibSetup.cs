namespace BasePageLib.Tests;

[Collection("Sequential")]
public partial class BasePageLibTests
{
    private IConfiguration? Configuration { get; set; }
    private IServiceCollection? Services { get; set; }
    private IServiceProvider? Provider { get; set; }
    private BasePageViewModel? basePageViewModel { get; set; }

    private async Task<bool> BasePageLibSetup(string culture)
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.FullName)
            .AddJsonFile("appsettings_basepagelibtests.json")
            .Build();

        Services = new ServiceCollection();

        Services.AddSingleton(Configuration);
        Services.AddSingleton<BasePageViewModel>();


        Provider = Services.BuildServiceProvider();
        Assert.NotNull(Provider);

        basePageViewModel = Provider.GetService<BasePageViewModel>();
        Assert.NotNull(basePageViewModel);

        return await Task.FromResult(true);
    }
}

