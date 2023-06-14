namespace ManageServices;

public partial class ManageFileService : ControllerBase, IManageFileService
{
    public async Task<ActionResult<ManageFile>> GetWithManageFileIDAsync(int ManageFileID)
    {
        ManageFile? manageFile = null;
        if (DbManage != null)
        {
            manageFile = (from c in DbManage.ManageFiles.AsNoTracking()
                          where c.ManageFileID == ManageFileID
                          select c).FirstOrDefault();

        }

        return await Task.FromResult(Ok(manageFile));
    }
}

