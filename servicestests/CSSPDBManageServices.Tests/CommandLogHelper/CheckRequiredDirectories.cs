namespace ManageServices.Tests;

public partial class CommandLogServicesTests
{
    private void CheckRequiredDirectories()
    {
        Assert.NotNull(Configuration);

        string? CSSPDBLocalText = Configuration["CSSPDBLocal"];
        string? CSSPDBManageText = Configuration["CSSPDBManage"];

        if (CSSPDBLocalText != null)
        {
            Assert.True(false, "CSSPDBLocal is null");
        }

        if (CSSPDBManageText != null)
        {
            Assert.True(false, "CSSPDBManage is null");
        }

        List<string> FileList = new List<string>();

        if (CSSPDBLocalText != null && CSSPDBManageText != null)
        {
            FileList = new List<string>() { CSSPDBLocalText, CSSPDBManageText };
        }

        // create all directories
        foreach (string FileName in FileList)
        {
            FileInfo fi = new FileInfo(FileName);

            if (fi.DirectoryName != null)
            {
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
        }

        foreach (string FileName in FileList)
        {
            FileInfo fi = new FileInfo(FileName);

            if (fi.DirectoryName != null)
            {
                DirectoryInfo di = new DirectoryInfo(fi.DirectoryName);
                Assert.True(di.Exists);
            }

        }
    }
}

