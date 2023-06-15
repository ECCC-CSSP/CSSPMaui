namespace CSSPAzureLoginServices.Tests;

public partial class CSSPAzureLoginServiceTests
{
    private async Task GetProviderServices()
    {
        Assert.NotNull(Configuration);
        Assert.NotNull(Provider);

        CSSPCultureService = Provider.GetService<ICSSPCultureService>();
        Assert.NotNull(CSSPCultureService);

        CSSPScrambleService = Provider.GetService<ICSSPScrambleService>();
        Assert.NotNull(CSSPScrambleService);

        CSSPLogService = Provider.GetService<ICSSPLogService>();
        Assert.NotNull(CSSPLogService);

        CSSPLocalLoggedInService = Provider.GetService<ICSSPLocalLoggedInService>();
        Assert.NotNull(CSSPLocalLoggedInService);

        CSSPSQLiteService = Provider.GetService<ICSSPSQLiteService>();
        Assert.NotNull(CSSPSQLiteService);

        string? CSSPDBManageText = Configuration["CSSPDBManage"];

        Assert.NotNull(CSSPDBManageText);

        FileInfo fiCSSPDBManage = new FileInfo(CSSPDBManageText);
        if (!fiCSSPDBManage.Exists)
        {
            await CSSPSQLiteService.CreateSQLiteCSSPDBManageAsync();
        }

        fiCSSPDBManage = new FileInfo(CSSPDBManageText);
        Assert.True(fiCSSPDBManage.Exists); 

        CSSPAzureLoginService = Provider.GetService<ICSSPAzureLoginService>();
        Assert.NotNull(CSSPAzureLoginService);

        dbManage = Provider.GetService<CSSPDBManageContext>();
        Assert.NotNull(dbManage);
    }
}

