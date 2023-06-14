namespace ManageServices.Tests;

public partial class CommandLogServicesTests
{
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task GetTodayListAsync_Good_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        Assert.NotNull(CommandLogService);

        var actionGet = await CommandLogService.GetTodayListAsync();
        var getRes = actionGet.Result;

        Assert.NotNull(getRes);

        Assert.Equal(200, ((ObjectResult)getRes).StatusCode);
        Assert.NotNull(((OkObjectResult)getRes).Value);

        List<CommandLog>? commandLogList = (List<CommandLog>?)((OkObjectResult)getRes).Value;

        Assert.NotNull(commandLogList);
        Assert.NotEmpty(commandLogList);
        Assert.Single(commandLogList);

        Assert.NotNull(dbManage);

        List<CommandLog> commandLogListDB = await (from c in dbManage.CommandLogs
                                                   select c).ToListAsync();

        Assert.NotNull(commandLogListDB);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task GetLastWeekListAsync_Good_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        Assert.NotNull(CommandLogService);

        var actionGet = await CommandLogService.GetLastWeekListAsync();
        var getRes = actionGet.Result;

        Assert.NotNull(getRes);

        Assert.Equal(200, ((ObjectResult)getRes).StatusCode);
        Assert.NotNull(((OkObjectResult)getRes).Value);

        List<CommandLog>? commandLogList = (List<CommandLog>?)((OkObjectResult)actionGet.Result).Value;

        Assert.NotNull(commandLogList);
        Assert.NotEmpty(commandLogList);
        Assert.Single(commandLogList);

        Assert.NotNull(dbManage);

        List<CommandLog> commandLogListDB = await (from c in dbManage.CommandLogs
                                                   select c).ToListAsync();

        Assert.NotNull(commandLogListDB);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task GetLastMonthListAsync_Good_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        Assert.NotNull(CommandLogService);

        var actionGet = await CommandLogService.GetLastMonthListAsync();
        var getRes = actionGet.Result;

        Assert.NotNull(getRes);

        Assert.Equal(200, ((ObjectResult)getRes).StatusCode);
        Assert.NotNull(((OkObjectResult)getRes).Value);

        List<CommandLog>? commandLogList = (List<CommandLog>?)((OkObjectResult)actionGet.Result).Value;

        Assert.NotNull(commandLogList);
        Assert.NotEmpty(commandLogList);
        Assert.Single(commandLogList);

        Assert.NotNull(dbManage);

        List<CommandLog> commandLogListDB = await (from c in dbManage.CommandLogs
                                                   select c).ToListAsync();

        Assert.NotNull(commandLogListDB);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task GetBetweenDatesListAsync_Good_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        Assert.NotNull(CommandLogService);

        var actionGet = await CommandLogService.GetBetweenDatesListAsync(DateTime.UtcNow.AddDays(-1), DateTime.UtcNow.AddDays(1));
        var getRes = actionGet.Result;

        Assert.NotNull(getRes);

        Assert.Equal(200, ((ObjectResult)getRes).StatusCode);
        Assert.NotNull(((OkObjectResult)getRes).Value);

        List<CommandLog>? commandLogList = (List<CommandLog>?)((OkObjectResult)getRes).Value;

        Assert.NotNull(commandLogList);
        Assert.NotEmpty(commandLogList);
        Assert.Single(commandLogList);

        Assert.NotNull(dbManage);

        List<CommandLog> commandLogListDB = await (from c in dbManage.CommandLogs
                                                   select c).ToListAsync();

        Assert.NotNull(commandLogListDB);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task GetBetweenDatesListAsync_StartDate_Year_lessThan_1980_Error_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        DateTime StartDate = new DateTime(1979, 1, 1);
        DateTime EndDate = new DateTime(2020, 1, 1);

        Assert.NotNull(CommandLogService);

        var actionGet = await CommandLogService.GetBetweenDatesListAsync(StartDate, EndDate);
        var getRes = actionGet.Result;

        Assert.NotNull(getRes);

        Assert.Equal(400, ((ObjectResult)getRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)getRes).Value);

        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)getRes).Value;

        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._YearShouldBeBiggerThan_, "StartDate", "1980"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task GetBetweenDatesListAsync_EndDate_Year_lessThan_1980_Error_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        DateTime StartDate = new DateTime(2020, 1, 1);
        DateTime EndDate = new DateTime(1979, 1, 1);

        Assert.NotNull(CommandLogService);

        var actionGet = await CommandLogService.GetBetweenDatesListAsync(StartDate, EndDate);
        var getRes = actionGet.Result;

        Assert.NotNull(getRes);

        Assert.Equal(400, ((ObjectResult)getRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)getRes).Value);

        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)getRes).Value;

        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._YearShouldBeBiggerThan_, "EndDate", "1980"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task GetBetweenDatesListAsync_StartDate_biggerThan_EndDate_Error_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        DateTime StartDate = new DateTime(2020, 1, 1);
        DateTime EndDate = new DateTime(2019, 1, 1);

        Assert.NotNull(CommandLogService);

        var actionGet = await CommandLogService.GetBetweenDatesListAsync(StartDate, EndDate);
        var getRes = actionGet.Result;

        Assert.NotNull(getRes);

        Assert.Equal(400, ((ObjectResult)getRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)getRes).Value);

        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)getRes).Value;

        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._YearShouldBeBiggerThan_, "StartDate", "EndDate"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task GetWithCommandLogIDAsync_Good_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        Assert.NotNull(CommandLogService);

        var actionGet = await CommandLogService.GetWithCommandLogIDAsync(commandLogAdd.CommandLogID);
        var getRes = actionGet.Result;

        Assert.NotNull(getRes);

        Assert.Equal(200, ((ObjectResult)getRes).StatusCode);
        Assert.NotNull(((OkObjectResult)getRes).Value);

        CommandLog? commandLogGet = (CommandLog?)((OkObjectResult)getRes).Value;

        Assert.NotNull(commandLogGet);

        Assert.NotNull(dbManage);

        CommandLog? commandLogDB = await (from c in dbManage.CommandLogs
                                          select c).FirstOrDefaultAsync();

        Assert.NotNull(commandLogDB);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task GetWithCommandLogIDAsync_CommandLogID_Error_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        commandLogAdd.CommandLogID = 0;

        Assert.NotNull(CommandLogService);

        var actionGet = await CommandLogService.GetWithCommandLogIDAsync(commandLogAdd.CommandLogID);
        var getRes = actionGet.Result;
        
        Assert.NotNull(getRes);

        Assert.Equal(400, ((ObjectResult)getRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)getRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)getRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._IsRequired, "CommandLogID"), errRes.ErrList[0]);
    }
}

