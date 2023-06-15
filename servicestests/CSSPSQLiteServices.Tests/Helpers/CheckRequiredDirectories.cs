namespace CSSPSQLiteServices.Tests;

public partial class CSSPSQLiteServiceTests
{
    private void CheckRequiredDirectories()
    {
        string? CSSPDBLocalText = Configuration["CSSPDBLocal"];
        string? CSSPDBManageText = Configuration["CSSPDBManage"];

        if (CSSPDBLocalText != null && CSSPDBManageText != null)
        {
            List<string> dirList = new List<string>() { CSSPDBLocalText, CSSPDBManageText, };

            // create all directories
            foreach (string FileName in dirList)
            {
                FileInfo fi = new FileInfo(FileName);
                if (fi != null && fi.DirectoryName != null)
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

            foreach (string FileName in dirList)
            {
                FileInfo fi = new FileInfo(FileName);
                if (fi != null && fi.DirectoryName != null)
                {
                    DirectoryInfo di = new DirectoryInfo(fi.DirectoryName);
                    Assert.True(di.Exists);
                }
            }
        }
    }
}

