namespace ManageServices;

public partial class ManageFileService : ControllerBase, IManageFileService
{
    public async Task<ActionResult<ManageFile>> GetWithAzureStorageAndAzureFileNameAsync(string AzureStorage, string AzureFileName)
    {
        ManageFile? manageFile = null;
        if (DbManage != null)
        {
            manageFile = (from c in DbManage.ManageFiles.AsNoTracking()
                          where c.AzureStorage == AzureStorage
                          && c.AzureFileName == AzureFileName
                          select c).FirstOrDefault();
        }

        return await Task.FromResult(Ok(manageFile));
    }
}

