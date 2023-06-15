namespace ManageServices.Tests;

public partial class ManageFileServicesTests
{
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Delete_Good_Test(string culture)
    {
        Assert.True(await ManageFileServiceSetup(culture));

        ManageFile manageFile = await FillManageFileAsync();

        ManageFile manageFileAdd = await AddTestAsync(manageFile);

        ManageFile manageFileDelete = await DeleteTestAsync(manageFileAdd);
        Assert.NotNull(manageFileDelete);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Delete_ManageFileID_not_0_Error_Test(string culture)
    {
        Assert.True(await ManageFileServiceSetup(culture));

        ManageFile manageFile = await FillManageFileAsync();

        ManageFile manageFileAdd = await AddTestAsync(manageFile);

        manageFileAdd.ManageFileID = 0;

        Assert.NotNull(ManageFileService);

        var actionCommandLog = await ManageFileService.DeleteAsync(manageFileAdd.ManageFileID);
        var delRes = actionCommandLog.Result;
        
        Assert.NotNull(delRes);
        
        Assert.Equal(400, ((ObjectResult)delRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)delRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)delRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._IsRequired, "ManageFileID"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Delete_Manage_not_found_Error_Test(string culture)
    {
        Assert.True(await ManageFileServiceSetup(culture));

        ManageFile manageFile = await FillManageFileAsync();

        ManageFile manageFileAdd = await AddTestAsync(manageFile);

        manageFileAdd.ManageFileID = 10000;

        Assert.NotNull(ManageFileService);

        var actionCommandLog = await ManageFileService.DeleteAsync(manageFileAdd.ManageFileID);
        var delRes = actionCommandLog.Result;
        
        Assert.NotNull(delRes);
        
        Assert.Equal(400, ((ObjectResult)delRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)delRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)delRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes.CouldNotFind_With_Equal_, "ManageFile", "ManageFileID", manageFileAdd.ManageFileID.ToString()), errRes.ErrList[0]);
    }
}

