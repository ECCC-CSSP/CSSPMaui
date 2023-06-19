namespace CSSPCreateGzFileServices;

public partial class CSSPCreateGzFileService : ControllerBase, ICSSPCreateGzFileService
{
    private async Task<bool> CreateWebAllUseOfSitesGzFileAsync()
    {
        string FunctionName = $"async Task<bool> CreateWebAllUseOfSitesGzFileAsync()";
        CSSPLogService.FunctionLog(FunctionName);

        WebAllUseOfSites webAllUseOfSites = new WebAllUseOfSites();

        try
        {
            webAllUseOfSites.UseOfSiteList = await GetAllUseOfSiteListAsync();

            if (Local)
            {
                if (!await StoreLocalAsync<WebAllUseOfSites>(webAllUseOfSites, $"{ WebTypeEnum.WebAllUseOfSites  }.gz")) return await Task.FromResult(false);
            }
            else
            {
                if (!await StoreAsync<WebAllUseOfSites>(webAllUseOfSites, $"{ WebTypeEnum.WebAllUseOfSites  }.gz")) return await Task.FromResult(false);
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

