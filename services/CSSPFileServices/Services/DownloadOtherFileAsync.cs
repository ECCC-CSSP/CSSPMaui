namespace CSSPFileServices;

public partial class CSSPFileService : ControllerBase, ICSSPFileService
{
    public async Task<ActionResult> DownloadOtherFileAsync(string FileName)
    {
        string FunctionName = $"async Task<ActionResult> DownloadOtherFileAsync(string FileName) - FileName: { FileName }";
        CSSPLogService.FunctionLog(FunctionName);

        if (!await CSSPLogService.CheckLogin(FunctionName)) return await Task.FromResult(Unauthorized(CSSPLogService.ErrRes));

        FileInfo fi = new FileInfo($"{ Configuration["CSSPOtherFilesPath"] }\\{FileName}");

        if (!fi.Exists)
        {
            return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, string.Format(CSSPCultureServicesRes.CouldNotFindFile_, fi.FullName));
        }

        CSSPLogService.EndFunctionLog(FunctionName);

        return PhysicalFile(fi.FullName, "application/octet-stream");
    }
}

