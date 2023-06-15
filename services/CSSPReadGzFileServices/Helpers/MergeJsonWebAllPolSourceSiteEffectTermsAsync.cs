namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebAllPolSourceSiteEffectTermsAsync(WebAllPolSourceSiteEffectTerms? webAllPolSourceSiteEffectTerms, WebAllPolSourceSiteEffectTerms? webAllPolSourceSiteEffectTermsLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebAllPolSourceSiteEffectTermsAsync(WebAllPolSourceSiteEffectTerms? webAllPolSourceSiteEffectTerms, WebAllPolSourceSiteEffectTerms? webAllPolSourceSiteEffectTermsLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebAllPolSourceSiteEffectsTermsPolSourceSiteEffectTermList(webAllPolSourceSiteEffectTerms, webAllPolSourceSiteEffectTermsLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }

    private void MergeJsonWebAllPolSourceSiteEffectsTermsPolSourceSiteEffectTermList(WebAllPolSourceSiteEffectTerms? webAllPolSourceSiteEffectTerms, WebAllPolSourceSiteEffectTerms? webAllPolSourceSiteEffectTermsLocal)
    {
        if (webAllPolSourceSiteEffectTermsLocal != null)
        {
            List<PolSourceSiteEffectTerm> polSourceSiteEffectTermLocalList = (from c in webAllPolSourceSiteEffectTermsLocal.PolSourceSiteEffectTermList
                                                                              where c.DBCommand != DBCommandEnum.Original
                                                                              select c).ToList();

            foreach (PolSourceSiteEffectTerm polSourceSiteEffectTermLocal in polSourceSiteEffectTermLocalList)
            {
                if (webAllPolSourceSiteEffectTerms != null)
                {
                    PolSourceSiteEffectTerm? polSourceSiteEffectTermOriginal = webAllPolSourceSiteEffectTerms.PolSourceSiteEffectTermList.Where(c => c.PolSourceSiteEffectTermID == polSourceSiteEffectTermLocal.PolSourceSiteEffectTermID).FirstOrDefault();
                    if (polSourceSiteEffectTermOriginal == null)
                    {
                        webAllPolSourceSiteEffectTerms.PolSourceSiteEffectTermList.Add(polSourceSiteEffectTermLocal);
                    }
                    else
                    {
                        SyncPolSourceSiteEffectTerm(polSourceSiteEffectTermOriginal, polSourceSiteEffectTermLocal);
                    }
                }
            }
        }
    }
}
