namespace CSSPSQLiteServices.Tests;

public partial class CSSPSQLiteServiceTests
{
    private void CheckCSSPDBLocalContext()
    {
        Assert.NotNull(Services);
        Assert.NotNull(Configuration);

        Services.AddDbContext<CSSPDBLocalContext>(options =>
        {
            options.UseSqlite($"Data Source={ Configuration["CSSPDBLocal"] }");
        });
    }
}

