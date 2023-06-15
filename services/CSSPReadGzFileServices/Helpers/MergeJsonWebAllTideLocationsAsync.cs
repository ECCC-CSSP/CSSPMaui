namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebAllTideLocationsAsync(WebAllTideLocations? webAllTideLocations, WebAllTideLocations? webAllTideLocationsLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebAllTideLocationsAsync(WebAllTideLocations? webAllTideLocations, WebAllTideLocations? webAllTideLocationsLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebAllTideLocationsTideLocationList(webAllTideLocations, webAllTideLocationsLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }

    private void MergeJsonWebAllTideLocationsTideLocationList(WebAllTideLocations? webAllTideLocations, WebAllTideLocations? webAllTideLocationsLocal)
    {
        if (webAllTideLocationsLocal != null)
        {
            List<TideLocation> tideLocationLocalList = (from c in webAllTideLocationsLocal.TideLocationList
                                                        where c.DBCommand != DBCommandEnum.Original
                                                        select c).ToList();

            foreach (TideLocation tideLocationLocal in tideLocationLocalList)
            {
                if (webAllTideLocations != null)
                {
                    TideLocation? tideLocationOriginal = webAllTideLocations.TideLocationList.Where(c => c.TideLocationID == tideLocationLocal.TideLocationID).FirstOrDefault();
                    if (tideLocationOriginal == null)
                    {
                        webAllTideLocations.TideLocationList.Add(tideLocationLocal);
                    }
                    else
                    {
                        SyncTideLocation(tideLocationOriginal, tideLocationLocal);
                    }
                }
            }
        }
    }
}
