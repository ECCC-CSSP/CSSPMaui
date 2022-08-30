﻿namespace CSSPUpdateServices;

public partial class CSSPUpdateService : ControllerBase, ICSSPUpdateService
{
    public async Task<bool> GetNeedToChangedWebAllContactsAsync(DateTime LastWriteTimeUtc)
    {
        bool exist = (from c in db.TVItems
                      where c.TVType == TVTypeEnum.Contact
                      && c.LastUpdateDate_UTC >= LastWriteTimeUtc
                      select c).Any();

        if (exist)
        {
            return await Task.FromResult(exist);
        }

        exist = (from c in db.TVItems
                 from cl in db.TVItemLanguages
                 where c.TVItemID == cl.TVItemID
                 && c.TVType == TVTypeEnum.Contact
                 && cl.LastUpdateDate_UTC >= LastWriteTimeUtc
                 select cl).Any();

        if (exist)
        {
            return await Task.FromResult(exist);
        }

        exist = (from c in db.Contacts
                 where c.LastUpdateDate_UTC >= LastWriteTimeUtc
                 select c).Any();

        if (exist)
        {
            return await Task.FromResult(exist);
        }

        exist = (from t in db.TVItemLinks
                 where t.FromTVType == TVTypeEnum.Contact
                 && (t.ToTVType == TVTypeEnum.Email
                 || t.ToTVType == TVTypeEnum.Tel
                 || t.ToTVType == TVTypeEnum.Address)
                 && t.LastUpdateDate_UTC >= LastWriteTimeUtc
                 select t).Distinct().Any();

        return await Task.FromResult(exist);
    }
}

