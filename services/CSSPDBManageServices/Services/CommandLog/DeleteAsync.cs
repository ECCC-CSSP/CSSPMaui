namespace ManageServices;

public partial class CommandLogService : ControllerBase, ICommandLogService
{
    public async Task<ActionResult<CommandLog>> DeleteAsync(int CommandLogID)
    {
        if (CommandLogID == 0)
        {
            errRes.ErrList.Add(string.Format(CSSPCultureServicesRes._IsRequired, "CommandLogID"));

            return await Task.FromResult(BadRequest(errRes));
        }

        CommandLog? commandLog = null;
        if (dbManage != null)
        {
            commandLog = (from c in dbManage.CommandLogs
                          where c.CommandLogID == CommandLogID
                          select c).FirstOrDefault();

            if (commandLog == null)
            {
                errRes.ErrList.Add(string.Format(CSSPCultureServicesRes.CouldNotFind_With_Equal_, "CommandLog", "CommandLogID", CommandLogID.ToString()));

                return await Task.FromResult(BadRequest(errRes));
            }
            else
            {
                try
                {
                    dbManage.CommandLogs.Remove(commandLog);
                    dbManage.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    errRes.ErrList.Add(ex.Message + (ex.InnerException != null ? " Inner: " + ex.InnerException.Message : ""));
                }

                if (errRes.ErrList.Count > 0) return await Task.FromResult(BadRequest(errRes));

                return await Task.FromResult(Ok(commandLog));

            }
        }

        return await Task.FromResult(Ok(commandLog));
    }
}

