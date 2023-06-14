namespace CSSPSQLiteServices;

public partial class CSSPSQLiteService : ICSSPSQLiteService
{
    private async Task<bool> FillExistingTableListAsync(List<string> ExistingTableList)
    {
        if (dbLocal != null)
        {
            using (var command = dbLocal.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT name FROM sqlite_master WHERE type = 'table' AND name NOT LIKE 'sqlite_%'";
                dbLocal.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        ExistingTableList.Add(result.GetString(0));
                    }
                }
                dbLocal.Database.CloseConnection();
            }

        }

        return await Task.FromResult(true);
    }
}

