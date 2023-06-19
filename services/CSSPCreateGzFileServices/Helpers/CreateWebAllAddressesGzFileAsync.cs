namespace CSSPCreateGzFileServices;

public partial class CSSPCreateGzFileService : ControllerBase, ICSSPCreateGzFileService
{
    private async Task<bool> CreateWebAllAddressesGzFileAsync()
    {
        string FunctionName = $"async Task<bool> CreateWebAllAddressesGzFileAsync()";
        CSSPLogService.FunctionLog(FunctionName);

        WebAllAddresses webAllAddresses = new WebAllAddresses();

        try
        {
            webAllAddresses.AddressList = await GetAllAddressAsync();

            if (Local)
            {
                if (!await StoreLocalAsync<WebAllAddresses>(webAllAddresses, $"{ WebTypeEnum.WebAllAddresses }.gz")) return await Task.FromResult(false);
            }
            else
            {
                if (!await StoreAsync<WebAllAddresses>(webAllAddresses, $"{ WebTypeEnum.WebAllAddresses }.gz")) return await Task.FromResult(false);
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

