namespace BasePageLib.Tests;

public partial class BasePageLibTests
{
    [Theory]
    [InlineData("en-CA")]
    [InlineData("fr-CA")]
    public async Task BasePageLib_Constructor_Good_Test(string culture)
    {
        Assert.True(await BasePageLibSetup(culture));
        Assert.NotNull(basePageViewModel);
        if (basePageViewModel != null)
        {
            // constructor defaults to "en-CA"
            Assert.False(basePageViewModel.IsFrench);
            Assert.True(basePageViewModel.IsEnglish);
            CultureInfo currentCulture = new CultureInfo("en-CA");
            Assert.Equal(currentCulture, basePageViewModel.appCulture);
            Assert.Equal(currentCulture, Thread.CurrentThread.CurrentCulture);
            Assert.Equal(currentCulture, Thread.CurrentThread.CurrentUICulture);
            Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentCulture);
            Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentUICulture);
        }
    }
    [Theory]
    [InlineData("en-CA")]
    [InlineData("fr-CA")]
    [InlineData("es-ES")]
    public async Task BasePageLib_SetBaseCulture_Good_Test(string culture)
    {
        Assert.True(await BasePageLibSetup(culture));
        Assert.NotNull(basePageViewModel);

        if (basePageViewModel != null)
        {
            basePageViewModel.SetBaseCulture(culture);

            if (culture == "fr-CA")
            {
                Assert.True(basePageViewModel.IsFrench);
                Assert.False(basePageViewModel.IsEnglish);
                CultureInfo currentCulture = new CultureInfo("fr-CA");
                Assert.Equal(currentCulture, basePageViewModel.appCulture);
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentCulture);
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentUICulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentCulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentUICulture);
            }
            else
            {
                Assert.False(basePageViewModel.IsFrench);
                Assert.True(basePageViewModel.IsEnglish);
                CultureInfo currentCulture = new CultureInfo("en-CA");
                Assert.Equal(currentCulture, basePageViewModel.appCulture);
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentCulture);
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentUICulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentCulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentUICulture);
            }
        }
    }
}

