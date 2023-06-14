namespace ManageServices.Tests;

public partial class CommandLogServicesTests
{
    private async Task<CommandLog> DeleteTestAsync(CommandLog commandLogAdd)
    {
        Assert.NotNull(CommandLogService);

        var actionDelete = await CommandLogService.DeleteAsync(commandLogAdd.CommandLogID);
        var delRes = actionDelete.Result;

        Assert.NotNull(delRes);

        Assert.Equal(200, ((ObjectResult)delRes).StatusCode);
        Assert.NotNull(((OkObjectResult)delRes).Value);

        CommandLog? commandLogDelete = (CommandLog?)((OkObjectResult)delRes).Value;

        Assert.NotNull(commandLogDelete);
        Assert.Equal(commandLogAdd.CommandLogID, commandLogDelete.CommandLogID);

        Assert.NotNull(dbManage);

        CommandLog? commandLogDeleteDB = (from c in dbManage.CommandLogs
                                          where c.CommandLogID == commandLogAdd.CommandLogID
                                          select c).FirstOrDefault();

        Assert.Null(commandLogDeleteDB);

        return commandLogDelete;
    }
}

