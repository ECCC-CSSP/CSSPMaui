namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebAllReportTypesAsync(WebAllReportTypes? webAllReportTypes, WebAllReportTypes? webAllReportTypesLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebAllReportTypesAsync(WebAllReportTypes webAllReportTypes, WebAllReportTypes? webAllReportTypesLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebAllReportsTypesReportTypeModelList(webAllReportTypes, webAllReportTypesLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }

    private void MergeJsonWebAllReportsTypesReportTypeModelList(WebAllReportTypes? webAllReportTypes, WebAllReportTypes? webAllReportTypesLocal)
    {
        if (webAllReportTypesLocal != null)
        {
            List<ReportTypeModel> reportTypeModelLocalList = (from c in webAllReportTypesLocal.ReportTypeModelList
                                                              where c.ReportType.DBCommand != DBCommandEnum.Original
                                                              || (from r in c.ReportSectionList
                                                                  where r.DBCommand != DBCommandEnum.Original
                                                                  select r).Any()
                                                              select c).ToList();

            foreach (ReportTypeModel reportTypeModelLocal in reportTypeModelLocalList)
            {
                if (webAllReportTypes != null)
                {
                    ReportTypeModel? reportTypeModelOriginal = webAllReportTypes.ReportTypeModelList.Where(c => c.ReportType.ReportTypeID == reportTypeModelLocal.ReportType.ReportTypeID).FirstOrDefault();
                    if (reportTypeModelOriginal == null)
                    {
                        webAllReportTypes.ReportTypeModelList.Add(reportTypeModelLocal);
                    }
                    else
                    {
                        SyncReportTypeModel(reportTypeModelOriginal, reportTypeModelLocal);
                    }
                }
            }
        }
    }
}
