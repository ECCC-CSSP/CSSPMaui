namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebAllSearchAsync(WebAllSearch? webAllSearch, WebAllSearch? webAllSearchLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebAllSearchAsync(WebAllSearch? webAllSearch, WebAllSearch? webAllSearchLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebAllSearchTVItemModelList(webAllSearch, webAllSearchLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }
    private void MergeJsonWebAllSearchTVItemModelList(WebAllSearch? webAllSearch, WebAllSearch? webAllSearchLocal)
    {
        if (webAllSearchLocal != null)
        {
            List<TVItemModel> TVItemModelList = (from c in webAllSearchLocal.TVItemModelList
                                                 where c.TVItem.TVItemID != 0
                                                 && (c.TVItem.DBCommand != DBCommandEnum.Original
                                                 || c.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                                                 || c.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original)
                                                 select c).ToList();

            foreach (TVItemModel tvItemModel in TVItemModelList)
            {
                if (webAllSearch != null)
                {
                    TVItemModel? TVItemModelOriginal = webAllSearch.TVItemModelList.Where(c => c.TVItem.TVItemID == tvItemModel.TVItem.TVItemID).FirstOrDefault();
                    if (TVItemModelOriginal == null)
                    {
                        webAllSearch.TVItemModelList.Add(tvItemModel);
                    }
                    else
                    {
                        SyncTVModel(TVItemModelOriginal, tvItemModel);
                    }
                }
            }
        }
    }
}
