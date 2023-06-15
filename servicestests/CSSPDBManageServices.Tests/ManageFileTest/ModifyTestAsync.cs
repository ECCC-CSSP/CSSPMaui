namespace ManageServices.Tests;

public partial class ManageFileServicesTests
{
    private async Task<ManageFile> ModifyTestAsync(ManageFile manageFile)
    {
        Assert.NotNull(ManageFileService);

        var actionCommandLogModify = await ManageFileService.ModifyAsync(manageFile);
        var modRes = actionCommandLogModify.Result;
        
        Assert.NotNull(modRes);
        
        Assert.Equal(200, ((ObjectResult)modRes).StatusCode);
        Assert.NotNull(((OkObjectResult)modRes).Value);
        
        ManageFile? manageFileModify = (ManageFile?)((OkObjectResult)modRes).Value;
        
        Assert.NotNull(manageFileModify);
        Assert.Equal(1, manageFileModify.ManageFileID);

        Assert.NotNull(dbManage);
        
        ManageFile? manageFileModifyDB = (from c in dbManage.ManageFiles
                                         where c.ManageFileID == manageFileModify.ManageFileID
                                         select c).FirstOrDefault();

        Assert.Equal(JsonSerializer.Serialize(manageFileModify), JsonSerializer.Serialize(manageFileModifyDB));

        return manageFileModify;
    }
}

