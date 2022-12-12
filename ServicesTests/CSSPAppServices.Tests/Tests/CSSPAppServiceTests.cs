namespace CSSPAppServices.Tests;

public partial class CSSPAppServicesTests
{
    [Theory]
    [InlineData("en-CA")]
    [InlineData("fr-CA")]
    public async Task CSSPAppService_Constructor_Good_Test(string culture)
    {
        Assert.True(await CSSPAppServiceSetup(culture));
        Assert.NotNull(CSSPAppService);
        if (CSSPAppService != null)
        {
            Assert.NotNull(CSSPAppService.AppCulture);

            if (CSSPAppService.AppCulture != null)
            {
                Assert.Equal("en-CA", CSSPAppService.AppCulture.Name);
                //Assert.False(CSSPAppService.IsFrench);
                //Assert.True(CSSPAppService.IsEnglish);
            }
        }
    }
    [Theory]
    [InlineData("en-CA")]
    [InlineData("fr-CA")]
    public async Task CSSPAppService_SetCulture_Good_Test(string culture)
    {
        Assert.True(await CSSPAppServiceSetup(culture));
        if (CSSPAppService != null)
        {
            Assert.NotNull(CSSPAppService.AppCulture);

            if (CSSPAppService.AppCulture != null)
            {
                Assert.Equal("en-CA", CSSPAppService.AppCulture.Name);
                //Assert.False(CSSPAppService.IsFrench);
                //Assert.True(CSSPAppService.IsEnglish);
            }

            CSSPAppService.SetCulture(culture);

            if (culture == "fr-CA")
            {
                //Assert.True(CSSPAppService.IsFrench);
                //Assert.False(CSSPAppService.IsEnglish);
                CultureInfo currentCulture = new CultureInfo("fr-CA");
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentCulture);
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentUICulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentCulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentUICulture);
                if (CSSPAppService.AppCulture != null)
                {
                    Assert.Equal(culture, CSSPAppService.AppCulture.Name);
                }
            }
            else
            {
                //Assert.False(CSSPAppService.IsFrench);
                //Assert.True(CSSPAppService.IsEnglish);
                CultureInfo currentCulture = new CultureInfo("en-CA");
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentCulture);
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentUICulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentCulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentUICulture);
                if (CSSPAppService.AppCulture != null)
                {
                    Assert.Equal(culture, CSSPAppService.AppCulture.Name);
                }
            }
        }
    }
}

