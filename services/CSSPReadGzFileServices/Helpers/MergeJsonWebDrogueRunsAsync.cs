namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebDrogueRunsAsync(WebDrogueRuns? webDrogueRuns, WebDrogueRuns? webDrogueRunsLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebDrogueRunsAsync(WebDrogueRuns? webDrogueRuns, WebDrogueRuns? webDrogueRunsLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebDrogueRunsTVItemModel(webDrogueRuns, webDrogueRunsLocal);

        MergeJsonWebDrogueRunsTVItemModelParentList(webDrogueRuns, webDrogueRunsLocal);

        MergeJsonWebDrogueRunsDrogueRunModelList(webDrogueRuns, webDrogueRunsLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }
    private void MergeJsonWebDrogueRunsTVItemModel(WebDrogueRuns? webDrogueRuns, WebDrogueRuns? webDrogueRunsLocal)
    {
        if (webDrogueRunsLocal != null)
        {
            if (webDrogueRunsLocal.TVItemModel.TVItem.TVItemID != 0
                && (webDrogueRunsLocal.TVItemModel.TVItem.DBCommand != DBCommandEnum.Original
               || webDrogueRunsLocal.TVItemModel.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
               || webDrogueRunsLocal.TVItemModel.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original))
            {
                if (webDrogueRuns != null)
                {
                    SyncTVItemModel(webDrogueRuns.TVItemModel, webDrogueRunsLocal.TVItemModel);
                }
            }
        }
    }
    private void MergeJsonWebDrogueRunsTVItemModelParentList(WebDrogueRuns? webDrogueRuns, WebDrogueRuns? webDrogueRunsLocal)
    {
        if (webDrogueRunsLocal != null)
        {
            if ((from c in webDrogueRunsLocal.TVItemModelParentList
                 where c.TVItem.TVItemID != 0
                 && (c.TVItem.DBCommand != DBCommandEnum.Original
                 || c.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                 || c.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original)
                 select c).Any())
            {
                if (webDrogueRuns != null)
                {
                    SyncTVItemModelParentList(webDrogueRuns.TVItemModelParentList, webDrogueRunsLocal.TVItemModelParentList);
                }
            }
        }
    }
    private void MergeJsonWebDrogueRunsDrogueRunModelList(WebDrogueRuns? webDrogueRuns, WebDrogueRuns? webDrogueRunsLocal)
    {
        if (webDrogueRunsLocal != null)
        {
            List<DrogueRunModel> DrogueRunModelLocalList = (from c in webDrogueRunsLocal.DrogueRunModelList
                                                            where c.DrogueRun.DrogueRunID != 0
                                                            && (c.DrogueRun.DBCommand != DBCommandEnum.Original
                                                            || (from d in c.DrogueRunPositionList
                                                                where d.DBCommand != DBCommandEnum.Original
                                                                select d).Any())
                                                            select c).ToList();

            foreach (DrogueRunModel drogueRunModelLocal in DrogueRunModelLocalList)
            {
                if (webDrogueRuns != null)
                {
                    DrogueRunModel? drogueRunModelOriginal = webDrogueRuns.DrogueRunModelList.Where(c => c.DrogueRun.DrogueRunID == drogueRunModelLocal.DrogueRun.DrogueRunID).FirstOrDefault();
                    if (drogueRunModelOriginal == null)
                    {
                        webDrogueRuns.DrogueRunModelList.Add(drogueRunModelLocal);
                    }
                    else
                    {
                        drogueRunModelOriginal = drogueRunModelLocal;
                    }
                }
            }
        }
    }
}

