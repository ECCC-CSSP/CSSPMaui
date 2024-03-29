﻿namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebLabSheetsAsync(WebLabSheets? webLabSheets, WebLabSheets? webLabSheetsLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebLabSheetsAsync(WebLabSheets? webLabSheets, WebLabSheets? webLabSheetsLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebLabSheetsTVItemModel(webLabSheets, webLabSheetsLocal);

        MergeJsonWebLabSheetsTVItemModelParentList(webLabSheets, webLabSheetsLocal);

        MergeJsonWebLabSheetsLabSheetModelList(webLabSheets, webLabSheetsLocal);

        CSSPLogService.FunctionLog(FunctionName);

        return await Task.FromResult(true);
    }
    private void MergeJsonWebLabSheetsTVItemModel(WebLabSheets? webLabSheets, WebLabSheets? webLabSheetsLocal)
    {
        if (webLabSheetsLocal != null)
        {
            if (webLabSheetsLocal.TVItemModel.TVItem.TVItemID != 0
                && (webLabSheetsLocal.TVItemModel.TVItem.DBCommand != DBCommandEnum.Original
               || webLabSheetsLocal.TVItemModel.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
               || webLabSheetsLocal.TVItemModel.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original))
            {
                if (webLabSheets != null)
                {
                    SyncTVItemModel(webLabSheets.TVItemModel, webLabSheetsLocal.TVItemModel);
                }
            }
        }
    }
    private void MergeJsonWebLabSheetsTVItemModelParentList(WebLabSheets? webLabSheets, WebLabSheets? webLabSheetsLocal)
    {
        if (webLabSheetsLocal != null)
        {
            if ((from c in webLabSheetsLocal.TVItemModelParentList
                 where c.TVItem.TVItemID != 0
                 && (c.TVItem.DBCommand != DBCommandEnum.Original
                 || c.TVItemLanguageList[0].DBCommand != DBCommandEnum.Original
                 || c.TVItemLanguageList[1].DBCommand != DBCommandEnum.Original)
                 select c).Any())
            {
                if (webLabSheets != null)
                {
                    SyncTVItemModelParentList(webLabSheets.TVItemModelParentList, webLabSheetsLocal.TVItemModelParentList);
                }
            }
        }
    }
    private void MergeJsonWebLabSheetsLabSheetModelList(WebLabSheets? webLabSheets, WebLabSheets? webLabSheetsLocal)
    {
        if (webLabSheetsLocal != null)
        {
            List<LabSheetModel> LabSheetModelList = (from c in webLabSheetsLocal.LabSheetModelList
                                                     where c.LabSheet.LabSheetID != 0
                                                     && (c.LabSheet.DBCommand != DBCommandEnum.Original
                                                     || c.LabSheetDetail.DBCommand != DBCommandEnum.Original
                                                     || (from d in c.LabSheetTubeMPNDetailList
                                                         where d.DBCommand != DBCommandEnum.Original
                                                         select d).Any())
                                                     select c).ToList();

            foreach (LabSheetModel labSheetModel in LabSheetModelList)
            {
                if (webLabSheets != null)
                {
                    LabSheetModel? labSheetModelOriginal = webLabSheets.LabSheetModelList.Where(c => c.LabSheet.LabSheetID == labSheetModel.LabSheet.LabSheetID).FirstOrDefault();
                    if (labSheetModelOriginal == null)
                    {
                        webLabSheets.LabSheetModelList.Add(labSheetModel);
                    }
                    else
                    {
                        labSheetModelOriginal = labSheetModel;
                    }
                }
            }
        }
    }
}

