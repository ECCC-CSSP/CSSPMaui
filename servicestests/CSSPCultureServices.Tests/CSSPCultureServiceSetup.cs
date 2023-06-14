namespace CSSPCultureServices.Tests;

public partial class CultureServicesTests
{
    private ICSSPCultureService? CSSPCultureService { get; set; }


    private async Task<bool> CSSPCultureServiceSetup(string culture)
    {
        ServiceCollection Services = new ServiceCollection();

        Services.AddSingleton<ICSSPCultureService, CSSPCultureService>();

        IServiceProvider Provider = Services.BuildServiceProvider();
        Assert.NotNull(Provider);

        CSSPCultureService = Provider.GetService<ICSSPCultureService>();
        Assert.NotNull(CSSPCultureService);

        return await Task.FromResult(true);
    }
}

