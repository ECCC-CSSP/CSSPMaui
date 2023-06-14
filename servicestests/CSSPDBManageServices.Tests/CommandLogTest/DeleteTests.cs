namespace ManageServices.Tests;

public partial class CommandLogServicesTests
{
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task DeleteAsync_Good_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        await DeleteTestAsync(commandLogAdd);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Delete_CommandLogID_0_Error_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        commandLogAdd.CommandLogID = 0;

        Assert.NotNull(CommandLogService);

        var actionCommandLog = await CommandLogService.DeleteAsync(commandLogAdd.CommandLogID);
        var delRes = actionCommandLog.Result;

        Assert.NotNull(delRes);

        Assert.Equal(400, ((ObjectResult)delRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)delRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)delRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes._IsRequired, "CommandLogID"), errRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Delete_CommandLogID_cant_find_Error_Test(string culture)
    {
        Assert.True(await CommandLogServiceSetup(culture));

        CommandLog commandLog = await FillCommandLogAsync();

        CommandLog commandLogAdd = await AddTestAsync(commandLog);

        commandLogAdd.CommandLogID = 10000;

        Assert.NotNull(CommandLogService);

        var actionCommandLog = await CommandLogService.DeleteAsync(commandLogAdd.CommandLogID);
        var delRes = actionCommandLog.Result;
        
        Assert.NotNull(delRes);
        Assert.Equal(400, ((ObjectResult)delRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)delRes).Value);

        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)delRes).Value;
        
        Assert.NotNull(errRes);
        Assert.Equal(string.Format(CSSPCultureServicesRes.CouldNotFind_With_Equal_, "CommandLog", "CommandLogID", commandLogAdd.CommandLogID.ToString()), errRes.ErrList[0]);
    }
}

