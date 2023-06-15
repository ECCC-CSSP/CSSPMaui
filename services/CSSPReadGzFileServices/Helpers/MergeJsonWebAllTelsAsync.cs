namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebAllTelsAsync(WebAllTels? webAllTels, WebAllTels? webAllTelsLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebAllTelsAsync(WebAllTels? webAllTels, WebAllTels? webAllTelsLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebAllTelsTelModelList(webAllTels, webAllTelsLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }

    private void MergeJsonWebAllTelsTelModelList(WebAllTels? webAllTels, WebAllTels? webAllTelsLocal)
    {
        if (webAllTelsLocal != null)
        {
            List<Tel> telLocalList = (from c in webAllTelsLocal.TelList
                                      where c.DBCommand != DBCommandEnum.Original
                                      select c).ToList();

            foreach (Tel telLocal in telLocalList)
            {
                if (webAllTels != null)
                {
                    Tel? telOriginal = webAllTels.TelList.Where(c => c.TelID == telLocal.TelID).FirstOrDefault();
                    if (telOriginal == null)
                    {
                        webAllTels.TelList.Add(telLocal);
                    }
                    else
                    {
                        telOriginal = telLocal;
                    }
                }
            }
        }
    }
}
