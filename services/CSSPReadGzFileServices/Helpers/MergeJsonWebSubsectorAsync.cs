namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebSubsectorAsync(WebSubsector? webSubsector, WebSubsector? webSubsectorLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebSubsectorAsync(WebSubsector? webSubsector, WebSubsector? webSubsectorLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebSubsectorTVItemModel(webSubsector, webSubsectorLocal);

        MergeJsonWebSubsectorTVItemModelParentList(webSubsector, webSubsectorLocal);

        MergeJsonWebSubsectorTVFileModelList(webSubsector, webSubsectorLocal);

        MergeJsonWebSubsectorIsLocalized(webSubsector, webSubsectorLocal);

        MergeJsonWebSubsectorClassificationModelList(webSubsector, webSubsectorLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }
    private void MergeJsonWebSubsectorTVItemModel(WebSubsector? webSubsector, WebSubsector? webSubsectorLocal)
    {
        if (webSubsectorLocal != null)
        {
            if (webSubsectorLocal.TVItemModel.TVItem.TVItemID != 0
                && (webSubsectorLocal.TVItemModel.TVItem.DBCommand != DBCommandEnum.Original
               || webSubsectorLocal.TVItemModel.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
               || webSubsectorLocal.TVItemModel.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original))
            {
                if (webSubsector != null)
                {
                    SyncTVItemModel(webSubsector.TVItemModel, webSubsectorLocal.TVItemModel);
                }
            }
        }
    }
    private void MergeJsonWebSubsectorTVItemModelParentList(WebSubsector? webSubsector, WebSubsector? webSubsectorLocal)
    {
        if (webSubsectorLocal != null)
        {
            if ((from c in webSubsectorLocal.TVItemModelParentList
                 where c.TVItem.TVItemID != 0
                 && (c.TVItem.DBCommand != DBCommandEnum.Original
                 || c.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                 || c.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original)
                 select c).Any())
            {
                if (webSubsector != null)
                {
                    SyncTVItemModelParentList(webSubsector.TVItemModelParentList, webSubsectorLocal.TVItemModelParentList);
                }
            }
        }
    }
    private void MergeJsonWebSubsectorTVFileModelList(WebSubsector? webSubsector, WebSubsector? webSubsectorLocal)
    {
        if (webSubsectorLocal != null)
        {
            List<TVFileModel> TVFileModelLocalList = (from c in webSubsectorLocal.TVFileModelList
                                                      where c.TVFile.TVFileID != 0
                                                      && (c.TVFile.DBCommand != DBCommandEnum.Original
                                                      || c.TVFileLanguageList[0].DBCommand != DBCommandEnum.Original
                                                      || c.TVFileLanguageList[1].DBCommand != DBCommandEnum.Original)
                                                      select c).ToList();

            foreach (TVFileModel tvFileModelLocal in TVFileModelLocalList)
            {
                if (webSubsector != null)
                {
                    TVFileModel? tvFileModelOriginal = webSubsector.TVFileModelList.Where(c => c.TVFile.TVFileID == tvFileModelLocal.TVFile.TVFileID).FirstOrDefault();
                    if (tvFileModelOriginal == null)
                    {
                        webSubsector.TVFileModelList.Add(tvFileModelLocal);
                    }
                    else
                    {
                        SyncTVFileModel(tvFileModelOriginal, tvFileModelLocal);
                    }
                }
            }
        }
    }
    private void MergeJsonWebSubsectorIsLocalized(WebSubsector? webSubsector, WebSubsector? webSubsectorLocal)
    {
        if (webSubsector != null)
        {
            DirectoryInfo di = new DirectoryInfo($"{Configuration["CSSPFilesPath"]}{webSubsector.TVItemModel.TVItem.TVItemID}\\");

            if (di.Exists)
            {
                List<FileInfo> FileInfoList = di.GetFiles().ToList();

                foreach (TVFileModel tvFileModel in webSubsector.TVFileModelList)
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
    private void MergeJsonWebSubsectorClassificationModelList(WebSubsector? webSubsector, WebSubsector? webSubsectorLocal)
    {
        if (webSubsectorLocal != null)
        {
            List<ClassificationModel> ClassificationModelLocalList = (from c in webSubsectorLocal.ClassificationModelList
                                                                      where c.TVItemModel.TVItem.TVItemID != 0
                                                                      && (c.TVItemModel.TVItem.DBCommand != DBCommandEnum.Original
                                                                      || c.TVItemModel.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                                                                      || c.TVItemModel.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original)
                                                                      select c).ToList();

            foreach (ClassificationModel classificationModelLocal in ClassificationModelLocalList)
            {
                if (webSubsector != null)
                {
                    ClassificationModel? classificationModelOriginal = webSubsector.ClassificationModelList.Where(c => c.TVItemModel.TVItem.TVItemID == classificationModelLocal.TVItemModel.TVItem.TVItemID).FirstOrDefault();
                    if (classificationModelOriginal == null)
                    {
                        webSubsector.ClassificationModelList.Add(classificationModelLocal);
                    }
                    else
                    {
                        SyncClassificationModel(classificationModelOriginal, classificationModelLocal);
                    }
                }
            }
        }
    }
}

