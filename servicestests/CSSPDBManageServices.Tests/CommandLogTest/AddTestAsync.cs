namespace ManageServices.Tests;

public partial class CommandLogServicesTests
{
    private async Task<CommandLog> AddTestAsync(CommandLog commandLog)
    {
        Assert.NotNull(CommandLogService);

        var actionAdd = await CommandLogService.AddAsync(commandLog);
        var addRes = actionAdd.Result;
        
        Assert.NotNull(addRes);

        Assert.Equal(200, ((ObjectResult)addRes).StatusCode);
        Assert.NotNull(((OkObjectResult)addRes).Value);

        CommandLog? commandLogAdd = (CommandLog?)((OkObjectResult)addRes).Value;
        
        Assert.NotNull(commandLogAdd);
        Assert.Equal(1, commandLogAdd.CommandLogID);
        Assert.True(DateTime.UtcNow.AddMinutes(-1) < commandLogAdd.DateTimeUTC);
        Assert.True(DateTime.UtcNow.AddMinutes(1) > commandLogAdd.DateTimeUTC);

        Assert.NotNull(dbManage);

        CommandLog? commandLogAddDB = (from c in dbManage.CommandLogs
                                      where c.CommandLogID == commandLogAdd.CommandLogID
                                      select c).FirstOrDefault();

        Assert.Equal(JsonSerializer.Serialize(commandLogAdd), JsonSerializer.Serialize(commandLogAddDB));

        return commandLogAdd;
    }
}

