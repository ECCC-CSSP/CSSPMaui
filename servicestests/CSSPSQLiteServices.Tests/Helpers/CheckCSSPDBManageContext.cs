namespace CSSPSQLiteServices.Tests;

public partial class CSSPSQLiteServiceTests
{
    private void CheckCSSPDBManageContext()
    {
        Assert.NotNull(Services);
        Assert.NotNull(Configuration);

        Services.AddDbContext<CSSPDBManageContext>(options =>
        {
            options.UseSqlite($"Data Source={ Configuration["CSSPDBManage"] }");
        });

    }
}

