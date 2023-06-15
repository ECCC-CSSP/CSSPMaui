namespace CSSPReadGzFileServices;

public partial class CSSPReadGzFileService : ICSSPReadGzFileService
{
    private async Task<bool> MergeJsonWebAllContactsAsync(WebAllContacts? webAllContacts, WebAllContacts? webAllContactsLocal)
    {
        string FunctionName = $"async Task<bool> MergeJsonWebAllContactsAsync(WebAllContacts? webAllContacts, WebAllContacts? webAllContactsLocal)";
        CSSPLogService.FunctionLog(FunctionName);

        MergeJsonWebAllContactsContactModelList(webAllContacts, webAllContactsLocal);

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(true);
    }

    private void MergeJsonWebAllContactsContactModelList(WebAllContacts? webAllContacts, WebAllContacts? webAllContactsLocal)
    {
        if (webAllContactsLocal != null)
        {
            List<ContactModel> contactModelLocalList = (from c in webAllContactsLocal.ContactModelList
                                                        where c.Contact != null
                                                        && c.Contact.DBCommand != DBCommandEnum.Original
                                                        select c).ToList();

            foreach (ContactModel contactModelLocal in contactModelLocalList)
            {
                if (webAllContacts != null)
                {
                    ContactModel? contactModelOriginal = webAllContacts.ContactModelList.Where(c => c.Contact.ContactID == contactModelLocal.Contact.ContactID).FirstOrDefault();
                    if (contactModelOriginal == null)
                    {
                        webAllContacts.ContactModelList.Add(contactModelLocal);
                    }
                    else
                    {
                        contactModelOriginal.Contact = contactModelLocal.Contact;
                    }
                }
            }
        }
    }
}

