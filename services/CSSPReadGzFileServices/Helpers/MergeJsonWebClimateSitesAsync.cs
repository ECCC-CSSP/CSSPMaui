namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebClimateSitesAsync(WebClimateSites? webClimateSites, WebClimateSites? webClimateSitesLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebClimateSitesAsync(WebClimateSites? webClimateSites, WebClimateSites? webClimateSitesLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebClimateSitesTVItemModel(webClimateSites, webClimateSitesLocal);

        MergeJsonWebClimateSitesTVItemModelParentList(webClimateSites, webClimateSitesLocal);

        MergeJsonWebClimateSitesClimateSiteModelList(webClimateSites, webClimateSitesLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }
    private void MergeJsonWebClimateSitesTVItemModel(WebClimateSites? webClimateSites, WebClimateSites? webClimateSitesLocal)
    {
        if (webClimateSitesLocal != null)
        {
            if (webClimateSitesLocal.TVItemModel.TVItem.TVItemID != 0
                && (webClimateSitesLocal.TVItemModel.TVItem.DBCommand != DBCommandEnum.Original
                || webClimateSitesLocal.TVItemModel.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                || webClimateSitesLocal.TVItemModel.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original))
            {
                if (webClimateSites != null)
                {
                    SyncTVItemModel(webClimateSites.TVItemModel, webClimateSitesLocal.TVItemModel);
                }
            }
        }
    }
    private void MergeJsonWebClimateSitesTVItemModelParentList(WebClimateSites? webClimateSites, WebClimateSites? webClimateSitesLocal)
    {
        if (webClimateSitesLocal != null)
        {
            if ((from c in webClimateSitesLocal.TVItemModelParentList
                 where c.TVItem.TVItemID != 0
                 && (c.TVItem.DBCommand != DBCommandEnum.Original
                 || c.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                 || c.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original)
                 select c).Any())
            {
                if (webClimateSites != null)
                {
                    SyncTVItemModelParentList(webClimateSites.TVItemModelParentList, webClimateSitesLocal.TVItemModelParentList);
                }
            }
        }
    }
    private void MergeJsonWebClimateSitesClimateSiteModelList(WebClimateSites? webClimateSites, WebClimateSites? webClimateSitesLocal)
    {
        if (webClimateSitesLocal != null)
        {
            List<ClimateSiteModel> ClimateSiteModelLocalList = (from c in webClimateSitesLocal.ClimateSiteModelList
                                                                where c.TVItemModel.TVItem.TVItemID != 0
                                                                select c).ToList();

            foreach (ClimateSiteModel climateSiteModelLocal in ClimateSiteModelLocalList)
            {
                if (webClimateSites != null)
                {
                    ClimateSiteModel? climateSiteModelOriginal = webClimateSites.ClimateSiteModelList.Where(c => c.TVItemModel.TVItem.TVItemID == climateSiteModelLocal.TVItemModel.TVItem.TVItemID).FirstOrDefault();

                    if (climateSiteModelLocal.TVItemModel.TVItem.TVItemID != 0
                        && (climateSiteModelLocal.TVItemModel.TVItem.DBCommand != DBCommandEnum.Original
                        || climateSiteModelLocal.TVItemModel.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                        || climateSiteModelLocal.TVItemModel.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original))
                    {
                        if (climateSiteModelOriginal == null)
                        {
                            webClimateSites.ClimateSiteModelList.Add(climateSiteModelLocal);
                        }
                        else
                        {
                            SyncClimateSiteModel(climateSiteModelOriginal, climateSiteModelLocal);
                        }
                    }
                }
            }
        }
    }
}

