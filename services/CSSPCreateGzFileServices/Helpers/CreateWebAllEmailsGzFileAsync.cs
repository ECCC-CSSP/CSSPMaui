namespace CSSPCreateGzFileServices;

public partial class CSSPCreateGzFileService : ControllerBase, ICSSPCreateGzFileService
{
    private async Task<bool> CreateWebAllEmailsGzFileAsync()
    {
        string FunctionName = $"async Task<bool> CreateWebAllEmailsGzFileAsync()";
        CSSPLogService.FunctionLog(FunctionName);

        WebAllEmails webAllEmails = new WebAllEmails();

        try
        {
            webAllEmails.EmailList = await GetAllEmailAsync();

            if (Local)
            {
                if (!await StoreLocalAsync<WebAllEmails>(webAllEmails, $"{ WebTypeEnum.WebAllEmails }.gz")) return await Task.FromResult(false);
            }
            else
            {
                if (!await StoreAsync<WebAllEmails>(webAllEmails, $"{ WebTypeEnum.WebAllEmails }.gz")) return await Task.FromResult(false);
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

