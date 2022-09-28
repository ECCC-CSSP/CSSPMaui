namespace FirstPageLib.Tests;

public partial class FirstPageLibTests
{
    [Theory]
    [InlineData("en-CA")]
    [InlineData("fr-CA")]
    public async Task FirstPageLib_Constructor_Good_Test(string culture)
    {
        Assert.True(await FirstPageLibSetup(culture));
        Assert.NotNull(FirstPageViewModel);
        if (FirstPageViewModel != null)
        {
            // constructor defaults to "en-CA"
            Assert.False(FirstPageViewModel.IsFrench);
            Assert.True(FirstPageViewModel.IsEnglish);
            CultureInfo currentCulture = new CultureInfo("en-CA");
            Assert.Equal(currentCulture, Thread.CurrentThread.CurrentCulture);
            Assert.Equal(currentCulture, Thread.CurrentThread.CurrentUICulture);
            Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentCulture);
            Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentUICulture);
            Assert.NotEmpty(FirstPageViewModel.Title);
            Assert.True(FirstPageViewModel.IsEnglish);
            Assert.False(FirstPageViewModel.IsFrench);
            Assert.Equal(3, FirstPageViewModel.Items.Count);
        }
    }
    [Theory]
    [InlineData("en-CA")]
    [InlineData("fr-CA")]
    [InlineData("es-ES")]
    public async Task FirstPageLib_SetCulture_Good_Test(string culture)
    {
        Assert.True(await FirstPageLibSetup(culture));
        Assert.NotNull(FirstPageViewModel);

        if (FirstPageViewModel != null)
        {
            await FirstPageViewModel.SetCulture(culture);

            if (culture == "fr-CA")
            {
                Assert.True(FirstPageViewModel.IsFrench);
                Assert.False(FirstPageViewModel.IsEnglish);
                CultureInfo currentCulture = new CultureInfo("fr-CA");
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentCulture);
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentUICulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentCulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentUICulture);
                Assert.NotEmpty(FirstPageViewModel.Title);
                Assert.False(FirstPageViewModel.IsEnglish);
                Assert.True(FirstPageViewModel.IsFrench);
                Assert.Equal(3, FirstPageViewModel.Items.Count);
            }
            else
            {
                Assert.False(FirstPageViewModel.IsFrench);
                Assert.True(FirstPageViewModel.IsEnglish);
                CultureInfo currentCulture = new CultureInfo("en-CA");
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentCulture);
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentUICulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentCulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentUICulture);
                Assert.Contains(FirstPageRes.Title, FirstPageViewModel.Title);
                Assert.True(FirstPageViewModel.IsEnglish);
                Assert.False(FirstPageViewModel.IsFrench);
                Assert.Equal(3, FirstPageViewModel.Items.Count);
            }
        }
    }
}

