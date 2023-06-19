namespace CSSPCreateGzFileServices;

public partial class CSSPCreateGzFileService : ControllerBase, ICSSPCreateGzFileService
{
    private async Task<bool> FillReportTypeModelListAsync(List<ReportTypeModel> ReportTypeModelList)
    {
        string FunctionName = $"async Task<bool> FillReportTypeModelListAsync(List<ReportTypeModel> ReportTypeModelList)";
        CSSPLogService.FunctionLog(FunctionName);

        List<ReportType> ReportTypeList = await GetReportTypeListAsync();
        List<ReportSection> ReportSectionList = await GetReportSectionListAsync();

        foreach (ReportType ReportType in ReportTypeList)
        {
            ReportTypeModel ReportTypeModel = new ReportTypeModel();
            ReportTypeModel.ReportType = ReportType;
            ReportTypeModel.ReportSectionList = ReportSectionList.Where(c => c.ReportTypeID == ReportType.ReportTypeID).ToList();

            ReportTypeModelList.Add(ReportTypeModel);
        }

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }
}
