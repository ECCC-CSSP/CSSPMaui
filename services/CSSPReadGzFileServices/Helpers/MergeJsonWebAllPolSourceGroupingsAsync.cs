namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebAllPolSourceGroupingsAsync(WebAllPolSourceGroupings? webAllPolSourceGroupings, WebAllPolSourceGroupings? webAllPolSourceGroupingsLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebAllPolSourceGroupingsAsync(WebAllPolSourceGroupings? webAllPolSourceGroupings, WebAllPolSourceGroupings? webAllPolSourceGroupingsLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebAllPolSourceGroupingsPolSourceGroupingModelList(webAllPolSourceGroupings, webAllPolSourceGroupingsLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }

    private void MergeJsonWebAllPolSourceGroupingsPolSourceGroupingModelList(WebAllPolSourceGroupings? webAllPolSourceGroupings, WebAllPolSourceGroupings? webAllPolSourceGroupingsLocal)
    {
        if (webAllPolSourceGroupingsLocal != null)
        {
            List<PolSourceGroupingModel> polSourceGroupingModelLocalList = (from c in webAllPolSourceGroupingsLocal.PolSourceGroupingModelList
                                                                            where c.PolSourceGrouping.DBCommand != DBCommandEnum.Original
                                                                            || c.PolSourceGroupingLanguageList[0].DBCommand != DBCommandEnum.Original
                                                                            || c.PolSourceGroupingLanguageList[1].DBCommand != DBCommandEnum.Original
                                                                            select c).ToList();

            foreach (PolSourceGroupingModel polSourceGroupingModelLocal in polSourceGroupingModelLocalList)
            {
                if (webAllPolSourceGroupings != null)
                {
                    PolSourceGroupingModel? polSourceGroupingModelOriginal = webAllPolSourceGroupings.PolSourceGroupingModelList.Where(c => c.PolSourceGrouping.PolSourceGroupingID == polSourceGroupingModelLocal.PolSourceGrouping.PolSourceGroupingID).FirstOrDefault();
                    if (polSourceGroupingModelOriginal == null)
                    {
                        webAllPolSourceGroupings.PolSourceGroupingModelList.Add(polSourceGroupingModelLocal);
                    }
                    else
                    {
                        SyncPolSourceGroupingModel(polSourceGroupingModelOriginal, polSourceGroupingModelLocal);
                    }
                }
            }
        }
    }
}
