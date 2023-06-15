namespace ManageServices.Tests;

public partial class ManageFileServicesTests
{
    private async Task GetProviderServices(string culture)
    {
        Assert.NotNull(Configuration);
        Assert.NotNull(Provider);

        CSSPCultureService = Provider.GetService<ICSSPCultureService>();
        Assert.NotNull(CSSPCultureService);

        CSSPCultureService.SetCulture(culture);

        CSSPSQLiteService = Provider.GetService<ICSSPSQLiteService>();
        Assert.NotNull(CSSPSQLiteService);

        ManageFileService = Provider.GetService<IManageFileService>();
        Assert.NotNull(ManageFileService);

        string? CSSPDBLocalText = Configuration["CSSPDBLocal"];

        Assert.NotNull(CSSPDBLocalText);

        FileInfo fiCSSPDBLocal = new FileInfo(CSSPDBLocalText);
        if (!fiCSSPDBLocal.Exists)
        {
            await CSSPSQLiteService.CreateSQLiteCSSPDBLocalAsync();
        }

        fiCSSPDBLocal = new FileInfo(CSSPDBLocalText);
        Assert.True(fiCSSPDBLocal.Exists);

        string? CSSPDBManageText = Configuration["CSSPDBManage"];
        
        Assert.NotNull(CSSPDBManageText);
        
        FileInfo fiCSSPDBManage = new FileInfo(CSSPDBManageText);
        if (!fiCSSPDBManage.Exists)
        {
            await CSSPSQLiteService.CreateSQLiteCSSPDBManageAsync();
        }

        fiCSSPDBManage = new FileInfo(CSSPDBManageText);
        Assert.True(fiCSSPDBManage.Exists);

        dbManage = Provider.GetService<CSSPDBManageContext>();
        Assert.NotNull(dbManage);

        dbLocal = Provider.GetService<CSSPDBLocalContext>();
        Assert.NotNull(dbLocal);
    }
}

