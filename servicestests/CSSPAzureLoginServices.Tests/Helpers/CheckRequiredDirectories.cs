namespace CSSPAzureLoginServices.Tests;

public partial class CSSPAzureLoginServiceTests
{
    private void CheckRequiredDirectories()
    {
        Assert.NotNull(Configuration);

        string? CSSPDBManageText = Configuration["CSSPDBManage"];

        Assert.NotNull(CSSPDBManageText);

        List<string> dirList = new List<string>() { CSSPDBManageText };

        // create all directories
        foreach (string FileName in dirList)
        {
            FileInfo fi = new FileInfo(FileName);

            Assert.NotNull(fi);
            Assert.True(fi.Exists);
            Assert.NotNull(fi.DirectoryName);

            DirectoryInfo di = new DirectoryInfo(fi.DirectoryName);
            if (!di.Exists)
            {
                try
                {
                    di.Create();
                }
                catch (Exception ex)
                {
                    Assert.True(false, ex.Message);
                }
            }
        }

        foreach (string FileName in dirList)
        {
            FileInfo fi = new FileInfo(FileName);

            Assert.NotNull(fi);
            Assert.True(fi.Exists);
            Assert.NotNull(fi.DirectoryName);

            DirectoryInfo di = new DirectoryInfo(fi.DirectoryName);
            Assert.True(di.Exists);

        }
    }
}

