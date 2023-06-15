namespace ManageServices.Tests;

public partial class ManageFileServicesTests
{
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Add_Good_Test(string culture)
    {
        Assert.True(await ManageFileServiceSetup(culture));

        ManageFile manageFile = await FillManageFileAsync();

        ManageFile manageFileAdd = await AddTestAsync(manageFile);
        Assert.NotNull(manageFileAdd);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Add_manageFile_null_Error_Test(string culture)
    {
        Assert.True(await ManageFileServiceSetup(culture));

        ManageFile? manageFile = await FillManageFileAsync();

        manageFile = null;

        Assert.NotNull(ManageFileService);

        var actionCommandLog = await ManageFileService.AddAsync(manageFile);
        var addRes = actionCommandLog.Result;
        
        Assert.NotNull(addRes);
        
        Assert.Equal(400, ((ObjectResult)addRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)addRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)addRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._IsNullOrEmpty, "manageFile"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Add_ManageFileID_Not_0_Error_Test(string culture)
    {
        Assert.True(await ManageFileServiceSetup(culture));

        ManageFile manageFile = await FillManageFileAsync();

        manageFile.ManageFileID = 1;

        Assert.NotNull(ManageFileService);

        var actionCommandLog = await ManageFileService.AddAsync(manageFile);
        var addRes = actionCommandLog.Result;
        
        Assert.NotNull(addRes);
        
        Assert.Equal(400, ((ObjectResult)addRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)addRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)addRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._ShouldBeEqualTo_, "ManageFileID", "0"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Add_AzureStorage_empty_Error_Test(string culture)
    {
        Assert.True(await ManageFileServiceSetup(culture));

        ManageFile manageFile = await FillManageFileAsync();

        manageFile.AzureStorage = "";

        Assert.NotNull(ManageFileService);

        var actionCommandLog = await ManageFileService.AddAsync(manageFile);
        var addRes = actionCommandLog.Result;
        
        Assert.NotNull(addRes);
        
        Assert.Equal(400, ((ObjectResult)addRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)addRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)addRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._IsRequired, "AzureStorage"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Add_AzureStorage_length_bigger_100_Error_Test(string culture)
    {
        Assert.True(await ManageFileServiceSetup(culture));

        ManageFile manageFile = await FillManageFileAsync();

        manageFile.AzureStorage = "a".PadRight(101);

        Assert.NotNull(ManageFileService);

        var actionCommandLog = await ManageFileService.AddAsync(manageFile);
        var addRes = actionCommandLog.Result;
        
        Assert.NotNull(addRes);
        
        Assert.Equal(400, ((ObjectResult)addRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)addRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)addRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._MaxLengthIs_, "AzureStorage", "100"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Add_AzureFileName_empty_Error_Test(string culture)
    {
        Assert.True(await ManageFileServiceSetup(culture));

        ManageFile manageFile = await FillManageFileAsync();

        manageFile.AzureFileName = "";

        Assert.NotNull(ManageFileService);

        var actionCommandLog = await ManageFileService.AddAsync(manageFile);
        var addRes = actionCommandLog.Result;
        
        Assert.NotNull(addRes);
        
        Assert.Equal(400, ((ObjectResult)addRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)addRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)addRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._IsRequired, "AzureFileName"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Add_AzureFileName_length_bigger_200_Error_Test(string culture)
    {
        Assert.True(await ManageFileServiceSetup(culture));

        ManageFile manageFile = await FillManageFileAsync();

        manageFile.AzureFileName = "a".PadRight(201);
          
        Assert.NotNull(ManageFileService);

        var actionCommandLog = await ManageFileService.AddAsync(manageFile);
        var addRes = actionCommandLog.Result;
        
        Assert.NotNull(addRes);

        Assert.Equal(400, ((ObjectResult)addRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)addRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)addRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._MaxLengthIs_, "AzureFileName", "200"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Add_AzureETag_empty_Error_Test(string culture)
    {
        Assert.True(await ManageFileServiceSetup(culture));

        ManageFile manageFile = await FillManageFileAsync();

        manageFile.AzureETag = "";

        Assert.NotNull(ManageFileService);

        var actionCommandLog = await ManageFileService.AddAsync(manageFile);
        var addRes = actionCommandLog.Result;
        
        Assert.NotNull(addRes);
        
        Assert.Equal(400, ((ObjectResult)addRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)addRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)addRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._IsRequired, "AzureETag"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Add_AzureETag_length_bigger_100_Error_Test(string culture)
    {
        Assert.True(await ManageFileServiceSetup(culture));

        ManageFile manageFile = await FillManageFileAsync();

        manageFile.AzureETag = "a".PadRight(101);

        Assert.NotNull(ManageFileService);

        var actionCommandLog = await ManageFileService.AddAsync(manageFile);
        var addRes = actionCommandLog.Result;
        
        Assert.NotNull(addRes);
        
        Assert.Equal(400, ((ObjectResult)addRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)addRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)addRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._MaxLengthIs_, "AzureETag", "100"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Add_AzureCreationTimeUTC_Year_smaller_1980_Error_Test(string culture)
    {
        Assert.True(await ManageFileServiceSetup(culture));

        ManageFile manageFile = await FillManageFileAsync();

        manageFile.AzureCreationTimeUTC = new DateTime(1979, 1, 1);

        Assert.NotNull(ManageFileService);

        var actionCommandLog = await ManageFileService.AddAsync(manageFile);
        var addRes = actionCommandLog.Result;
        
        Assert.NotNull(addRes);
        
        Assert.Equal(400, ((ObjectResult)addRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)addRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)addRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._YearShouldBeBiggerThan_, "AzureCreationTimeUTC", "1980"), errRes.ErrList[0]);
    }
}

