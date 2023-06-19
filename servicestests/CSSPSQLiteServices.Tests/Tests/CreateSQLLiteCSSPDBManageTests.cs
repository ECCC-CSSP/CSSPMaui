namespace CSSPSQLiteServices.Tests;

public partial class CSSPSQLiteServiceTests
{
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task CreateSQLiteCSSPDBManage_Good_Test(string culture)
    {
        Assert.True(await CSSPSQLiteServiceSetup(culture));

        Assert.NotNull(Configuration);

        string? CSSPDBManageText = Configuration["CSSPDBManage"];

        if (CSSPDBManageText != null)
        {
            FileInfo fi = new FileInfo(CSSPDBManageText);
            if (fi.Exists)
            {
                try
                {
                    fi.Delete();
                }
                catch (Exception ex)
                {
                    Assert.True(false, ex.Message);
                }
            }

            Assert.NotNull(CSSPSQLiteService);

            bool retBool = await CSSPSQLiteService.CreateSQLiteCSSPDBManageAsync();
            Assert.True(retBool);

            fi = new FileInfo(CSSPDBManageText);
            Assert.True(fi.Exists);
        }
    }
}

