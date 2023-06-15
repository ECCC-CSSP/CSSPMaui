namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebAllAddressesAsync(WebAllAddresses? webAllAddresses, WebAllAddresses? webAllAddressesLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebAllAddressesAsync(WebAllAddresses? webAllAddresses, WebAllAddresses? webAllAddressesLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebAllAddressesAddressModelList(webAllAddresses, webAllAddressesLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }

    private void MergeJsonWebAllAddressesAddressModelList(WebAllAddresses? webAllAddresses, WebAllAddresses? webAllAddressesLocal)
    {
        if (webAllAddressesLocal != null)
        {
            List<Address> addressLocalList = (from c in webAllAddressesLocal.AddressList
                                              where c.DBCommand != DBCommandEnum.Original
                                              select c).ToList();

            foreach (Address addressLocal in addressLocalList)
            {
                if (webAllAddresses != null)
                {
                    Address? addressOriginal = webAllAddresses.AddressList.Where(c => c.AddressID == addressLocal.AddressID).FirstOrDefault();
                    if (addressOriginal == null)
                    {
                        webAllAddresses.AddressList.Add(addressLocal);
                    }
                    else
                    {
                        addressOriginal = addressLocal;
                    }
                }
            }
        }
    }
}

