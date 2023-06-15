namespace CSSPSQLiteServices.Tests;

public partial class CSSPSQLiteServiceTests
{
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task CreateSQLiteCSSPDBLocal_Good_Test(string culture)
    {
        Assert.True(await CSSPSQLiteServiceSetup(culture));

        string? CSSPDBLocalText = Configuration["CSSPDBLocal"];
        if (CSSPDBLocalText != null)
        {
            FileInfo fi = new FileInfo(CSSPDBLocalText);
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

            bool retBool = await CSSPSQLiteService.CreateSQLiteCSSPDBLocalAsync();
            Assert.True(retBool);

            fi = new FileInfo(CSSPDBLocalText);
            Assert.True(fi.Exists);
        }
    }
}

