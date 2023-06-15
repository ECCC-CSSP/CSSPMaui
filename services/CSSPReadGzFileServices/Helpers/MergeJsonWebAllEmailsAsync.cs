namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebAllEmailsAsync(WebAllEmails? webAllEmails, WebAllEmails? webAllEmailsLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebAllEmailsAsync(WebAllEmails? webAllEmails, WebAllEmails? webAllEmailsLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebAllEmailsEmailModelList(webAllEmails, webAllEmailsLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }

    private void MergeJsonWebAllEmailsEmailModelList(WebAllEmails? webAllEmails, WebAllEmails? webAllEmailsLocal)
    {
        if (webAllEmailsLocal != null)
        {
            List<Email> emailLocalList = (from c in webAllEmailsLocal.EmailList
                                          where c.DBCommand != DBCommandEnum.Original
                                          select c).ToList();

            foreach (Email emailLocal in emailLocalList)
            {
                if (webAllEmails != null)
                {
                    Email? emailOriginal = webAllEmails.EmailList.Where(c => c.EmailID == emailLocal.EmailID).FirstOrDefault();
                    if (emailOriginal == null)
                    {
                        webAllEmails.EmailList.Add(emailLocal);
                    }
                    else
                    {
                        emailOriginal = emailLocal;
                    }
                }
            }
        }
    }
}

