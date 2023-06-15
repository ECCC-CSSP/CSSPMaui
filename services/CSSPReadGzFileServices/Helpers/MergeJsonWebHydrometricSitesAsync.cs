namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebHydrometricSitesAsync(WebHydrometricSites? webHydrometricSites, WebHydrometricSites? webHydrometricSitesLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebHydrometricSitesAsync(WebHydrometricSites? webHydrometricSites, WebHydrometricSites? webHydrometricSitesLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebHydrometricSitesTVItemModel(webHydrometricSites, webHydrometricSitesLocal);

        MergeJsonWebHydrometricSitesTVItemModelParentList(webHydrometricSites, webHydrometricSitesLocal);

        MergeJsonWebHydrometricSitesHydrometricSiteModelList(webHydrometricSites, webHydrometricSitesLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }
    private void MergeJsonWebHydrometricSitesTVItemModel(WebHydrometricSites? webHydrometricSites, WebHydrometricSites? webHydrometricSitesLocal)
    {
        if (webHydrometricSitesLocal != null)
        {
            if (webHydrometricSitesLocal.TVItemModel.TVItem.TVItemID != 0
                && (webHydrometricSitesLocal.TVItemModel.TVItem.DBCommand != DBCommandEnum.Original
                || webHydrometricSitesLocal.TVItemModel.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                || webHydrometricSitesLocal.TVItemModel.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original))
            {
                if (webHydrometricSites != null)
                {
                    SyncTVItemModel(webHydrometricSites.TVItemModel, webHydrometricSitesLocal.TVItemModel);
                }
            }
        }
    }
    private void MergeJsonWebHydrometricSitesTVItemModelParentList(WebHydrometricSites? webHydrometricSites, WebHydrometricSites? webHydrometricSitesLocal)
    {
        if (webHydrometricSitesLocal != null)
        {
            if ((from c in webHydrometricSitesLocal.TVItemModelParentList
                 where c.TVItem.TVItemID != 0
                 && (c.TVItem.DBCommand != DBCommandEnum.Original
                 || c.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                 || c.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original)
                 select c).Any())
            {
                if (webHydrometricSites != null)
                {
                    SyncTVItemModelParentList(webHydrometricSites.TVItemModelParentList, webHydrometricSitesLocal.TVItemModelParentList);
                }
            }
        }
    }
    private void MergeJsonWebHydrometricSitesHydrometricSiteModelList(WebHydrometricSites? webHydrometricSites, WebHydrometricSites? webHydrometricSitesLocal)
    {
        if (webHydrometricSitesLocal != null)
        {
            List<HydrometricSiteModel> HydrometricSiteModelLocalList = (from c in webHydrometricSitesLocal.HydrometricSiteModelList
                                                                        where c.TVItemModel.TVItem.TVItemID != 0
                                                                        select c).ToList();

            foreach (HydrometricSiteModel HydrometricSiteModelLocal in HydrometricSiteModelLocalList)
            {
                if (webHydrometricSites != null)
                {
                    HydrometricSiteModel? HydrometricSiteModel = webHydrometricSites.HydrometricSiteModelList.Where(c => c.TVItemModel.TVItem.TVItemID == HydrometricSiteModelLocal.TVItemModel.TVItem.TVItemID).FirstOrDefault();

                    if (HydrometricSiteModelLocal.TVItemModel.TVItem.TVItemID != 0
                        && (HydrometricSiteModelLocal.TVItemModel.TVItem.DBCommand != DBCommandEnum.Original
                        || HydrometricSiteModelLocal.TVItemModel.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                        || HydrometricSiteModelLocal.TVItemModel.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original))
                    {
                        if (HydrometricSiteModel == null)
                        {
                            webHydrometricSites.HydrometricSiteModelList.Add(HydrometricSiteModelLocal);
                        }
                        else
                        {
                            SyncHydrometricSiteModel(HydrometricSiteModel, HydrometricSiteModelLocal);
                        }
                    }
                }
            }
        }
    }
}

