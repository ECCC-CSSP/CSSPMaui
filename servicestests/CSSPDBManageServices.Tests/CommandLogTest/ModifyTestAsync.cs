namespace ManageServices.Tests;

public partial class CommandLogServicesTests
{
    private async Task<CommandLog> ModifyTestAsync(CommandLog commandLog)
    {
        Assert.NotNull(CommandLogService);

        var actionCommandLogModify = await CommandLogService.ModifyAsync(commandLog);
        var modRes = actionCommandLogModify.Result;
        
        Assert.NotNull(modRes);

        Assert.Equal(200, ((ObjectResult)modRes).StatusCode);
        Assert.NotNull(((OkObjectResult)modRes).Value);

        CommandLog? commandLogModify = (CommandLog?)((OkObjectResult)modRes).Value;
        
        Assert.NotNull(commandLogModify);
        Assert.Equal(1, commandLogModify.CommandLogID);
        Assert.True(DateTime.UtcNow.AddMinutes(-1) < commandLogModify.DateTimeUTC);
        Assert.True(DateTime.UtcNow.AddMinutes(1) > commandLogModify.DateTimeUTC);

        Assert.NotNull(dbManage);

        CommandLog? commandLogModifyDB = (from c in dbManage.CommandLogs
                                         where c.CommandLogID == commandLogModify.CommandLogID
                                         select c).FirstOrDefault();

        Assert.Equal(JsonSerializer.Serialize(commandLogModify), JsonSerializer.Serialize(commandLogModifyDB));

        return commandLogModify;
    }
}

