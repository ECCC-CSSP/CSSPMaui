namespace FirstPageLib.Tests;

[Collection("Sequential")]
public partial class FirstPageLibTests
{
    private IConfiguration? Configuration { get; set; }
    private IServiceCollection? Services { get; set; }
    private IServiceProvider? Provider { get; set; }
    private IFirstPageViewModel? FirstPageViewModel { get; set; }

    private async Task<bool> FirstPageLibSetup(string culture)
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.FullName)
            .AddJsonFile("appsettings_firstpagelibtests.json")
            .Build();

        Services = new ServiceCollection();

        Services.AddSingleton(Configuration);
        Services.AddSingleton<ICSSPAppService, CSSPAppService>();
        Services.AddSingleton<IFirstPageViewModel, FirstPageViewModel>();


        Provider = Services.BuildServiceProvider();
        Assert.NotNull(Provider);

        //try
        //{
            FirstPageViewModel = Provider.GetService<IFirstPageViewModel>();
            Assert.NotNull(FirstPageViewModel);
        //}
        //catch (Exception ex)
        //{
        //    var exc = ex.Message;
        //}

        return await Task.FromResult(true);
    }
}

