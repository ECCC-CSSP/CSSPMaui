namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebAllProvincesAsync(WebAllProvinces? webAllProvinces, WebAllProvinces? webAllProvincesLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebAllProvincesAsync(WebAllProvinces? webAllProvinces, WebAllProvinces? webAllProvincesLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebAllProvincesTVItemModelList(webAllProvinces, webAllProvincesLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }

    private void MergeJsonWebAllProvincesTVItemModelList(WebAllProvinces? webAllProvinces, WebAllProvinces? webAllProvincesLocal)
    {
        if (webAllProvincesLocal != null)
        {
            List<TVItemModel> tvItemModelLocalList = (from c in webAllProvincesLocal.TVItemModelList
                                                      where c.TVItem.DBCommand != DBCommandEnum.Original
                                                      || c.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                                                      || c.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original
                                                      select c).ToList();

            foreach (TVItemModel tvItemModelLocal in tvItemModelLocalList)
            {
                if (webAllProvinces != null)
                {
                    TVItemModel? tvItemModelOriginal = webAllProvinces.TVItemModelList.Where(c => c.TVItem.TVItemID == tvItemModelLocal.TVItem.TVItemID).FirstOrDefault();
                    if (tvItemModelOriginal == null)
                    {
                        webAllProvinces.TVItemModelList.Add(tvItemModelLocal);
                    }
                    else
                    {
                        SyncTVModel(tvItemModelOriginal, tvItemModelLocal);
                    }
                }
            }
        }
    }
}
