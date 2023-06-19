namespace CSSPCreateGzFileServices;

public partial class CSSPCreateGzFileService : ControllerBase, ICSSPCreateGzFileService
{
    private async Task<bool> CreateWebAllSearchGzFileAsync()
    {
        string FunctionName = $"async Task<bool> CreateWebAllSearchGzFileAsync()";
        CSSPLogService.FunctionLog(FunctionName);

        WebAllSearch WebAllSearch = new WebAllSearch();

        try
        {
            if (!await FillAllSearchTVItemModelListAsync(WebAllSearch.TVItemModelList)) return await Task.FromResult(false);

            if (Local)
            {
                if (!await StoreLocalAsync<WebAllSearch>(WebAllSearch, $"{ WebTypeEnum.WebAllSearch }.gz")) return await Task.FromResult(false);
            }
            else
            {
                if (!await StoreAsync<WebAllSearch>(WebAllSearch, $"{ WebTypeEnum.WebAllSearch }.gz")) return await Task.FromResult(false);
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
