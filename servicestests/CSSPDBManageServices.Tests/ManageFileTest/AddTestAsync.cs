namespace ManageServices.Tests;

public partial class ManageFileServicesTests
{
    private async Task<ManageFile> AddTestAsync(ManageFile manageFile)
    {
        Assert.NotNull(ManageFileService);

        var actionAdd = await ManageFileService.AddAsync(manageFile);
        var addRes = actionAdd.Result;
        
        Assert.NotNull(addRes);
        
        Assert.Equal(200, ((ObjectResult)addRes).StatusCode);
        Assert.NotNull(((OkObjectResult)addRes).Value);
        
        ManageFile? manageFileAdd = (ManageFile?)((OkObjectResult)addRes).Value;
        
        Assert.NotNull(manageFileAdd);

        Assert.NotNull(dbManage);

        ManageFile? manageFileAddDB = (from c in dbManage.ManageFiles
                                      where c.ManageFileID == manageFileAdd.ManageFileID
                                      select c).FirstOrDefault();

        Assert.Equal(JsonSerializer.Serialize(manageFileAdd), JsonSerializer.Serialize(manageFileAddDB));

        return manageFileAdd;
    }
}

