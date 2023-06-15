namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebAllMWQMLookupMPNsAsync(WebAllMWQMLookupMPNs? webAllMWQMLookupMPNs, WebAllMWQMLookupMPNs? webAllMWQMLookupMPNsLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebAllMWQMLookupMPNsAsync(WebAllMWQMLookupMPNs? webAllMWQMLookupMPNs, WebAllMWQMLookupMPNs? webAllMWQMLookupMPNsLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebAllMWQMLookupMPNsMWQMLookupMPNList(webAllMWQMLookupMPNs, webAllMWQMLookupMPNsLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }

    private void MergeJsonWebAllMWQMLookupMPNsMWQMLookupMPNList(WebAllMWQMLookupMPNs? webAllMWQMLookupMPNs, WebAllMWQMLookupMPNs? webAllMWQMLookupMPNsLocal)
    {
        if (webAllMWQMLookupMPNsLocal != null)
        {
            List<MWQMLookupMPN> mwqmLookupMPNLocalList = (from c in webAllMWQMLookupMPNsLocal.MWQMLookupMPNList
                                                          where c.DBCommand != DBCommandEnum.Original
                                                          select c).ToList();

            foreach (MWQMLookupMPN mwqmLookupMPNLocal in mwqmLookupMPNLocalList)
            {
                if (webAllMWQMLookupMPNs != null)
                {
                    MWQMLookupMPN? mwqmLookupMPNOriginal = webAllMWQMLookupMPNs.MWQMLookupMPNList.Where(c => c.MWQMLookupMPNID == mwqmLookupMPNLocal.MWQMLookupMPNID).FirstOrDefault();
                    if (mwqmLookupMPNOriginal == null)
                    {
                        webAllMWQMLookupMPNs.MWQMLookupMPNList.Add(mwqmLookupMPNLocal);
                    }
                    else
                    {
                        SyncMWQMLookupMPN(mwqmLookupMPNOriginal, mwqmLookupMPNLocal);
                    }
                }
            }
        }
    }
}

