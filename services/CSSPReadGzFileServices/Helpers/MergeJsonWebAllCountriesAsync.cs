namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebAllCountriesAsync(WebAllCountries? webAllCountries, WebAllCountries? webAllCountriesLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebAllCountriesAsync(WebAllCountries? webAllCountries, WebAllCountries? webAllCountriesLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebAllCountriesTVItemModelList(webAllCountries, webAllCountriesLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }

    private void MergeJsonWebAllCountriesTVItemModelList(WebAllCountries? webAllCountries, WebAllCountries? webAllCountriesLocal)
    {
        if (webAllCountriesLocal != null)
        {
            List<TVItemModel> tvItemModelLocalList = (from c in webAllCountriesLocal.TVItemModelList
                                                      where c.TVItem.DBCommand != DBCommandEnum.Original
                                                      || c.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                                                      || c.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original
                                                      select c).ToList();

            foreach (TVItemModel tvItemModelLocal in tvItemModelLocalList)
            {
                if (webAllCountries != null)
                {
                    TVItemModel? tvItemModelOriginal = webAllCountries.TVItemModelList.Where(c => c.TVItem.TVItemID == tvItemModelLocal.TVItem.TVItemID).FirstOrDefault();
                    if (tvItemModelOriginal == null)
                    {
                        webAllCountries.TVItemModelList.Add(tvItemModelLocal);
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

