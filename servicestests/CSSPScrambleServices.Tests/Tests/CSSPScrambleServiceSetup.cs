namespace CSSPScrambleServices.Tests;

[Collection("Sequential")]
public partial class CSSPScrambleServicesTests
{
    private IConfiguration? Configuration { get; set; }
    private IServiceCollection? Services { get; set; }
    private IServiceProvider? Provider { get; set; }
    private ICSSPScrambleService? CSSPScrambleService { get; set; }

    private async Task<bool> CSSPScrambleServiceSetup(string culture)
    {
        DirectoryInfo? di = Directory.GetParent(AppContext.BaseDirectory);

        if (di != null)
        {
            if (di.Exists)
            {
                Configuration = new ConfigurationBuilder()
                    .SetBasePath(di.FullName)
                    .AddJsonFile("appsettings_csspscrambleservicestests.json")
                    .Build();
            }
        }

        Assert.NotNull(Configuration);

        Services = new ServiceCollection();

        if (Configuration != null)
        {
            Services.AddSingleton<IConfiguration>(Configuration);
        }

        Services.AddSingleton<ICSSPScrambleService, CSSPScrambleService>();

        Provider = Services.BuildServiceProvider();
        Assert.NotNull(Provider);

        CSSPScrambleService = Provider.GetService<ICSSPScrambleService>();
        Assert.NotNull(CSSPScrambleService);

        return await Task.FromResult(true);
    }
}

