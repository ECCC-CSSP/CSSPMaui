namespace ManageServices.Tests;

public partial class CommandLogServicesTests
{
    private async Task GetProviderServices(string culture)
    {
        Assert.NotNull(Provider);
        Assert.NotNull(Configuration);

        CSSPCultureService = Provider.GetService<ICSSPCultureService>();
        Assert.NotNull(CSSPCultureService);

        CSSPCultureService.SetCulture(culture);

        CommandLogService = Provider.GetService<ICommandLogService>();
        Assert.NotNull(CommandLogService);

        CSSPSQLiteService = Provider.GetService<ICSSPSQLiteService>();
        Assert.NotNull(CSSPSQLiteService);

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

