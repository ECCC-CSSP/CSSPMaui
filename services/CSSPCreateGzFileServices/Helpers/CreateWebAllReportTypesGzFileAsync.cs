﻿namespace CSSPCreateGzFileServices;

public partial class CSSPCreateGzFileService : ControllerBase, ICSSPCreateGzFileService
{
    private async Task<bool> CreateWebAllReportTypesGzFileAsync()
    {
        string FunctionName = $"async Task<bool> CreateWebAllReportTypesGzFileAsync()";
        CSSPLogService.FunctionLog(FunctionName);

        WebAllReportTypes webAllReportTypes = new WebAllReportTypes();

        try
        {
            if (!await FillReportTypeModelListAsync(webAllReportTypes.ReportTypeModelList)) return await Task.FromResult(false);

            if (Local)
            {
                if (!await StoreLocalAsync<WebAllReportTypes>(webAllReportTypes, $"{ WebTypeEnum.WebAllReportTypes }.gz")) return await Task.FromResult(false);
            }
            else
            {
                if (!await StoreAsync<WebAllReportTypes>(webAllReportTypes, $"{ WebTypeEnum.WebAllReportTypes }.gz")) return await Task.FromResult(false);
            }
        }
        catch (Exception ex)
        {
            string inner = ex.InnerException != null ? $"Inner: { ex.InnerException.Message }" : "";
            CSSPLogService.AppendError($"{ ex.Message } { inner }");
            CSSPLogService.EndFunctionLog(FunctionName);
            return await Task.FromResult(false);
        }

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }
}

