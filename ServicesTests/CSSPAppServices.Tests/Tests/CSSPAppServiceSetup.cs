using Microsoft.Extensions.DependencyInjection;

namespace CSSPAppServices.Tests;

[Collection("Sequential")]
public partial class CSSPAppServicesTests
{
    private IConfiguration? Configuration { get; set; } = null;
    private IServiceCollection? Services { get; set; } = null;
    private IServiceProvider? Provider { get; set; } = null;
    private ICSSPAppService? CSSPAppService { get; set; } = null;

    private async Task<bool> CSSPAppServiceSetup(string culture)
    {
        DirectoryInfo? di = Directory.GetParent(AppContext.BaseDirectory);

        if (di.Exists)
        {
            if (string.IsNullOrEmpty(di.FullName))
            {
                Assert.False(true, "FullName is empty");
            }

            Configuration = new ConfigurationBuilder()
                .SetBasePath(di.FullName)
                .AddJsonFile("appsettings_csspappservicestests.json")
                .Build();

            Services = new ServiceCollection();

            Services.AddSingleton<IConfiguration>(Configuration);
            Services.AddSingleton<ICSSPAppService, CSSPAppService>();


            Provider = Services.BuildServiceProvider();
            Assert.NotNull(Provider);

            CSSPAppService = Provider.GetService<ICSSPAppService>();
            Assert.NotNull(CSSPAppService);

        }

        return await Task.FromResult(true);
    }
}

