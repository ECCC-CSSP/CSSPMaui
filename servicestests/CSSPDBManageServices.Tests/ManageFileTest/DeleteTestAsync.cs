namespace ManageServices.Tests;

public partial class ManageFileServicesTests
{
    private async Task<ManageFile> DeleteTestAsync(ManageFile manageFile)
    {
        Assert.NotNull(ManageFileService);

        var actionDelete = await ManageFileService.DeleteAsync(manageFile.ManageFileID);
        var delRes = actionDelete.Result;
        
        Assert.NotNull(delRes);
        
        Assert.Equal(200, ((ObjectResult)delRes).StatusCode);
        Assert.NotNull(((OkObjectResult)delRes).Value);
        
        ManageFile? manageFileDelete = (ManageFile?)((OkObjectResult)delRes).Value;
        
        Assert.NotNull(manageFileDelete);
        Assert.Equal(manageFileDelete.ManageFileID, manageFileDelete.ManageFileID);

        Assert.NotNull(dbManage);

        ManageFile? manageFileDeleteDB = (from c in dbManage.ManageFiles
                                         where c.ManageFileID == manageFileDelete.ManageFileID
                                         select c).FirstOrDefault();

        Assert.Null(manageFileDeleteDB);

        return manageFileDelete;
    }
}

