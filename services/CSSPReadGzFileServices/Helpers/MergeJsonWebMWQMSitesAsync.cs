namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebMWQMSitesAsync(WebMWQMSites? webMWQMSites, WebMWQMSites? webMWQMSitesLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebMWQMSitesAsync(WebMWQMSites? webMWQMSites, WebMWQMSites? webMWQMSitesLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebMWQMSitesTVItemModel(webMWQMSites, webMWQMSitesLocal);

        MergeJsonWebMWQMSitesTVItemModelParentList(webMWQMSites, webMWQMSitesLocal);

        MergeJsonWebMWQMSitesMWQMSiteModelList(webMWQMSites, webMWQMSitesLocal);

        MergeJsonWebMWQMSitesIsLocalized(webMWQMSites, webMWQMSitesLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }
    private void MergeJsonWebMWQMSitesTVItemModel(WebMWQMSites? webMWQMSites, WebMWQMSites? webMWQMSitesLocal)
    {
        if (webMWQMSitesLocal != null)
        {
            if (webMWQMSitesLocal.TVItemModel.TVItem.TVItemID != 0
                && (webMWQMSitesLocal.TVItemModel.TVItem.DBCommand != DBCommandEnum.Original
              || webMWQMSitesLocal.TVItemModel.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
              || webMWQMSitesLocal.TVItemModel.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original))
            {
                if (webMWQMSites != null)
                {
                    SyncTVItemModel(webMWQMSites.TVItemModel, webMWQMSitesLocal.TVItemModel);
                }
            }
        }
    }
    private void MergeJsonWebMWQMSitesTVItemModelParentList(WebMWQMSites? webMWQMSites, WebMWQMSites? webMWQMSitesLocal)
    {
        if (webMWQMSitesLocal != null)
        {
            if ((from c in webMWQMSitesLocal.TVItemModelParentList
                 where c.TVItem.TVItemID != 0
                 && (c.TVItem.DBCommand != DBCommandEnum.Original
                 || c.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                 || c.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original)
                 select c).Any())
            {
                if (webMWQMSites != null)
                {
                    SyncTVItemModelParentList(webMWQMSites.TVItemModelParentList, webMWQMSitesLocal.TVItemModelParentList);
                }
            }
        }
    }
    private void MergeJsonWebMWQMSitesMWQMSiteModelList(WebMWQMSites? webMWQMSites, WebMWQMSites? webMWQMSitesLocal)
    {
        if (webMWQMSitesLocal != null)
        {
            List<MWQMSiteModel> MWQMSiteModelLocalList = (from c in webMWQMSitesLocal.MWQMSiteModelList
                                                          where c.TVItemModel.TVItem.TVItemID != 0
                                                          && c.TVItemModel.TVItem.DBCommand != DBCommandEnum.Original
                                                          select c).ToList();

            foreach (MWQMSiteModel mwqmSiteModelLocal in MWQMSiteModelLocalList)
            {
                if (webMWQMSites != null)
                {
                    MWQMSiteModel? mwqmSiteModelOriginal = (from c in webMWQMSites.MWQMSiteModelList
                                                            where c.TVItemModel.TVItem.TVItemID == mwqmSiteModelLocal.TVItemModel.TVItem.TVItemID
                                                            select c).FirstOrDefault();
                    if (mwqmSiteModelOriginal == null)
                    {
                        webMWQMSites.MWQMSiteModelList.Add(mwqmSiteModelLocal);
                    }
                    else
                    {
                        SyncMWQMSiteModel(mwqmSiteModelOriginal, mwqmSiteModelLocal);
                    }
                }
            }
        }
    }
    private void MergeJsonWebMWQMSitesIsLocalized(WebMWQMSites? webMWQMSites, WebMWQMSites? webMWQMSitesLocal)
    {
        if (webMWQMSites != null)
        {
            foreach (MWQMSiteModel mwqmSiteModel in webMWQMSites.MWQMSiteModelList)
            {
                // checking if files are localized
                DirectoryInfo di = new DirectoryInfo($"{Configuration["CSSPFilesPath"]}{mwqmSiteModel.TVItemModel.TVItem.TVItemID}\\");

                if (di.Exists)
                {
                    List<FileInfo> FileInfoList = di.GetFiles().ToList();

                    foreach (TVFileModel tvFileModel in mwqmSiteModel.TVFileModelList)
                    {
                        if ((from c in FileInfoList
                             where c.Name == tvFileModel.TVFile.ServerFileName
                             select c).Any())
                        {
                            tvFileModel.IsLocalized = true;
                        }
                        else
                        {
                            tvFileModel.IsLocalized = false;
                        }
                    }
                }
            }
        }
    }
}

