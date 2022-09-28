using Microsoft.Extensions.DependencyInjection;

namespace CSSPAppServices.Tests;

[Collection("Sequential")]
public partial class CSSPAppServicesTests
{
    private IConfiguration? Configuration { get; set; }
    private IServiceCollection? Services { get; set; }
    private IServiceProvider? Provider { get; set; }
    private ICSSPAppService? CSSPAppService { get; set; }

    private async Task<bool> CSSPAppServiceSetup(string culture)
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.FullName)
            .AddJsonFile("appsettings_csspappservicestests.json")
            .Build();

        Services = new ServiceCollection();

        Services.AddSingleton<IConfiguration>(Configuration);
        Services.AddSingleton<ICSSPAppService, CSSPAppService>();


        Provider = Services.BuildServiceProvider();
        Assert.NotNull(Provider);

        //try
        //{
            CSSPAppService = Provider.GetService<ICSSPAppService>();
            Assert.NotNull(CSSPAppService);
        //}
        //catch (Exception ex)
        //{
        //    var exc = ex.Message;
        //}

        return await Task.FromResult(true);
    }
}

