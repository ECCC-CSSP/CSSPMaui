namespace CSSPCreateGzFileServices;

public partial class CSSPCreateGzFileService : ControllerBase, ICSSPCreateGzFileService
{
    private async Task<bool> CreateWebAllContactsGzFileAsync()
    {
        string FunctionName = $"async Task<bool> CreateWebAllContactsGzFileAsync()";
        CSSPLogService.FunctionLog(FunctionName);

        WebAllContacts webAllContacts = new WebAllContacts();

        try
        {
            if (!await FillAllContactModelListAsync(webAllContacts.ContactModelList)) return await Task.FromResult(false);

            if (Local)
            {
                if (!await StoreLocalAsync<WebAllContacts>(webAllContacts, $"{ WebTypeEnum.WebAllContacts }.gz")) return await Task.FromResult(false);
            }
            else
            {
                if (!await StoreAsync<WebAllContacts>(webAllContacts, $"{ WebTypeEnum.WebAllContacts }.gz")) return await Task.FromResult(false);
            }
        }
        catch (Exception ex)
        {
            string inner = ex.InnerException != null ? $"Inner: { ex.InnerException.Message }" : "";
            CSSPLogService.AppendError($"{ ex.Message } { inner }");
            CSSPLogService.EndFunctionLog(FunctionName);
            return await Task.FromResult(false);
        }

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }
}

