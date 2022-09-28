using MainPageLib.Resources;

namespace MainPageLib.Tests;

public partial class MainPageLibTests
{
    [Theory]
    [InlineData("en-CA")]
    [InlineData("fr-CA")]
    public async Task MainPageLib_Constructor_Good_Test(string culture)
    {
        Assert.True(await MainPageLibSetup(culture));
        Assert.NotNull(MainPageViewModel);
        if (MainPageViewModel != null)
        {
            // constructor defaults to "en-CA"
            Assert.False(MainPageViewModel.IsFrench);
            Assert.True(MainPageViewModel.IsEnglish);
            CultureInfo currentCulture = new CultureInfo("en-CA");
            Assert.Equal(currentCulture, Thread.CurrentThread.CurrentCulture);
            Assert.Equal(currentCulture, Thread.CurrentThread.CurrentUICulture);
            Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentCulture);
            Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentUICulture);
            Assert.NotEmpty(MainPageViewModel.CSSPDesktop);
            Assert.NotEmpty(MainPageViewModel.StartText);
            Assert.NotEmpty(MainPageViewModel.CSSPFullText);
            Assert.NotEmpty(MainPageViewModel.CSSPDesktopApplicationWillLetYou);
            Assert.NotEmpty(MainPageViewModel.ViewAndUpdateWWTPInfo);
            Assert.NotEmpty(MainPageViewModel.MakeCalculationUsingBoxModelAndVP);
            Assert.NotEmpty(MainPageViewModel.SetupAndRunMIKEScenariosAndStoreInputsAndResults);
            Assert.NotEmpty(MainPageViewModel.VisualizeAndManageMarineWQInfo);
            Assert.NotEmpty(MainPageViewModel.PleaseContactASiteAdministratorListedBelowForAccess);
            Assert.Empty(MainPageViewModel.ScrambleResult);
        }
    }
    [Theory]
    [InlineData("en-CA")]
    [InlineData("fr-CA")]
    [InlineData("es-ES")]
    public async Task MainPageLib_SetCulture_Good_Test(string culture)
    {
        Assert.True(await MainPageLibSetup(culture));
        Assert.NotNull(MainPageViewModel);

        if (MainPageViewModel != null)
        {
            await MainPageViewModel.SetCulture(culture);

            if (culture == "fr-CA")
            {
                Assert.True(MainPageViewModel.IsFrench);
                Assert.False(MainPageViewModel.IsEnglish);
                CultureInfo currentCulture = new CultureInfo("fr-CA");
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentCulture);
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentUICulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentCulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentUICulture);
                Assert.Contains(MainPageRes.CSSPDesktop, MainPageViewModel.CSSPDesktop);
                Assert.Contains(MainPageRes.StartText, MainPageViewModel.StartText);
                Assert.Contains(MainPageRes.CSSPFullText, MainPageViewModel.CSSPFullText);
                Assert.Contains(MainPageRes.CSSPDesktopApplicationWillLetYou, MainPageViewModel.CSSPDesktopApplicationWillLetYou);
                Assert.Contains(MainPageRes.ViewAndUpdateWWTPInfo, MainPageViewModel.ViewAndUpdateWWTPInfo);
                Assert.Contains(MainPageRes.MakeCalculationUsingBoxModelAndVP, MainPageViewModel.MakeCalculationUsingBoxModelAndVP);
                Assert.Contains(MainPageRes.SetupAndRunMIKEScenariosAndStoreInputsAndResults, MainPageViewModel.SetupAndRunMIKEScenariosAndStoreInputsAndResults);
                Assert.Contains(MainPageRes.VisualizeAndManageMarineWQInfo, MainPageViewModel.VisualizeAndManageMarineWQInfo);
                Assert.Contains(MainPageRes.PleaseContactASiteAdministratorListedBelowForAccess, MainPageViewModel.PleaseContactASiteAdministratorListedBelowForAccess);
                Assert.Empty(MainPageViewModel.ScrambleResult);
            }
            else
            {
                Assert.False(MainPageViewModel.IsFrench);
                Assert.True(MainPageViewModel.IsEnglish);
                CultureInfo currentCulture = new CultureInfo("en-CA");
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentCulture);
                Assert.Equal(currentCulture, Thread.CurrentThread.CurrentUICulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentCulture);
                Assert.Equal(currentCulture, CultureInfo.DefaultThreadCurrentUICulture);
                Assert.Contains(MainPageRes.CSSPDesktop, MainPageViewModel.CSSPDesktop);
                Assert.Contains(MainPageRes.StartText, MainPageViewModel.StartText);
                Assert.Contains(MainPageRes.CSSPFullText, MainPageViewModel.CSSPFullText);
                Assert.Contains(MainPageRes.CSSPDesktopApplicationWillLetYou, MainPageViewModel.CSSPDesktopApplicationWillLetYou);
                Assert.Contains(MainPageRes.ViewAndUpdateWWTPInfo, MainPageViewModel.ViewAndUpdateWWTPInfo);
                Assert.Contains(MainPageRes.MakeCalculationUsingBoxModelAndVP, MainPageViewModel.MakeCalculationUsingBoxModelAndVP);
                Assert.Contains(MainPageRes.SetupAndRunMIKEScenariosAndStoreInputsAndResults, MainPageViewModel.SetupAndRunMIKEScenariosAndStoreInputsAndResults);
                Assert.Contains(MainPageRes.VisualizeAndManageMarineWQInfo, MainPageViewModel.VisualizeAndManageMarineWQInfo);
                Assert.Contains(MainPageRes.PleaseContactASiteAdministratorListedBelowForAccess, MainPageViewModel.PleaseContactASiteAdministratorListedBelowForAccess);
                Assert.Empty(MainPageViewModel.ScrambleResult);
            }
        }
    }

    [Theory]
    [InlineData("en-CA")]
    [InlineData("fr-CA")]
    public async Task MainPageLib_Scramble_Good_Test(string culture)
    {
        Assert.True(await MainPageLibSetup(culture));
        Assert.NotNull(MainPageViewModel);
        if (MainPageViewModel != null)
        {
            await MainPageViewModel.Scramble("test");

            Assert.NotNull(MainPageViewModel.ScrambleResult);
        }
    }
}

