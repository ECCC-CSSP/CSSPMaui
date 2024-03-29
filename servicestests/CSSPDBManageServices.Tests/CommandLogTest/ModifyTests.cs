namespace ManageServices.Tests;

public partial class CommandLogServicesTests
{
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task ModifyAsync_Good_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        commandLogAdd.AppName = "NewAppName";

        CommandLog commandLogModify = await ModifyTestAsync(commandLogAdd);
        Assert.Equal(commandLogAdd.AppName, commandLogModify.AppName);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Modify_commandLog_null_Error_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog? commandLogAdd = await AddTestAsync(commandLog);

        commandLogAdd = null;

        Assert.NotNull(CommandLogService);

        var actionCommandLog = await CommandLogService.ModifyAsync(commandLogAdd);
        var modRes = actionCommandLog.Result;
        
        Assert.NotNull(modRes);

        Assert.Equal(400, ((ObjectResult)modRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)modRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)modRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._IsNullOrEmpty, "commandLog"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Modify_CommandLogID_equal_0_Error_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog? commandLogAdd = await AddTestAsync(commandLog);

        commandLogAdd.CommandLogID = 0;

        Assert.NotNull(CommandLogService);

        var actionCommandLog = await CommandLogService.ModifyAsync(commandLogAdd);
        var modRes = actionCommandLog.Result;
        
        Assert.NotNull(modRes);
        
        Assert.Equal(400, ((ObjectResult)modRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)modRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)modRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._IsRequired, "CommandLogID"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Modify_AppName_empty_Error_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        commandLogAdd.AppName = "";

        Assert.NotNull(CommandLogService);

        var actionCommandLog = await CommandLogService.ModifyAsync(commandLogAdd);
        var modRes = actionCommandLog.Result;
        
        Assert.NotNull(modRes);
        
        Assert.Equal(400, ((ObjectResult)modRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)modRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)modRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._IsRequired, "AppName"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Modify_AppName_length_200_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        commandLogAdd.AppName = "a".PadRight(201);

        Assert.NotNull(CommandLogService);

        var actionCommandLog = await CommandLogService.ModifyAsync(commandLogAdd);
        var modRes = actionCommandLog.Result;
        
        Assert.NotNull(modRes);
        
        Assert.Equal(400, ((ObjectResult)modRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)modRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)modRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._MaxLengthIs_, "AppName", "200"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Modify_CommandName_empty_Error_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        commandLogAdd.CommandName = "";

        Assert.NotNull(CommandLogService);

        var actionCommandLog = await CommandLogService.ModifyAsync(commandLogAdd);
        var modRes = actionCommandLog.Result;
        
        Assert.NotNull(modRes);

        
        Assert.Equal(400, ((ObjectResult)modRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)modRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)modRes).Value;
        
        Assert.NotNull(errRes);

        Assert.Equal(string.Format(CSSPCultureServicesRes._IsRequired, "CommandName"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Modify_CommandName_length_200_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        commandLogAdd.CommandName = "a".PadRight(201);

        Assert.NotNull(CommandLogService);

        var actionCommandLog = await CommandLogService.ModifyAsync(commandLogAdd);
        var modRes = actionCommandLog.Result;
        
        Assert.NotNull(modRes);

        Assert.Equal(400, ((ObjectResult)modRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)modRes).Value);

        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)modRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._MaxLengthIs_, "CommandName", "200"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Modify_Error_length_10000000_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        commandLogAdd.Error = "a".PadRight(10000001);

        Assert.NotNull(CommandLogService);

        var actionCommandLog = await CommandLogService.ModifyAsync(commandLogAdd);
        var modRes = actionCommandLog.Result;
        
        Assert.NotNull(modRes);
        
        Assert.Equal(400, ((ObjectResult)modRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)modRes).Value);

        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)modRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._MaxLengthIs_, "Error", "10000000"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Modify_Log_length_10000000_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        commandLogAdd.Log = "a".PadRight(10000001);

        Assert.NotNull(CommandLogService);

        var actionCommandLog = await CommandLogService.ModifyAsync(commandLogAdd);
        var modRes = actionCommandLog.Result;
        
        Assert.NotNull(modRes);
        
        Assert.Equal(400, ((ObjectResult)modRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)modRes).Value);

        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)modRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._MaxLengthIs_, "Log", "10000000"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Modify_DateTimeUTC_Year_before_1980_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        commandLogAdd.DateTimeUTC = new DateTime(1979, 1, 1);

        Assert.NotNull(CommandLogService);

        var actionCommandLog = await CommandLogService.ModifyAsync(commandLogAdd);
        var modRes = actionCommandLog.Result;
        
        Assert.NotNull(modRes);
        
        Assert.Equal(400, ((ObjectResult)modRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)modRes).Value);

        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)modRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._YearShouldBeBiggerThan_, "DateTimeUTC", "1980"), errRes.ErrList[0]);
    }
}

