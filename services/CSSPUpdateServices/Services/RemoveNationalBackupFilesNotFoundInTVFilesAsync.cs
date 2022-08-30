﻿namespace CSSPUpdateServices;

public partial class CSSPUpdateService : ControllerBase, ICSSPUpdateService
{
    public async Task<ActionResult<bool>> RemoveNationalBackupFilesNotFoundInTVFilesAsync()
    {
        string FunctionName = $"{ this.GetType().Name }.{ CSSPLogService.GetFunctionName(MethodBase.GetCurrentMethod().DeclaringType.Name) }()";
        CSSPLogService.FunctionLog(FunctionName);

        if (!await CSSPLogService.CheckLogin(FunctionName)) return await Task.FromResult(Unauthorized(CSSPLogService.ErrRes));

        DirectoryInfo diNat = new DirectoryInfo(Configuration["NationalBackupAppDataPath"]);
        if (!diNat.Exists)
        {
            CSSPLogService.AppendError($"{ String.Format(CSSPCultureServicesRes.LocalAppDataPathDoesNotExist_, diNat.FullName) }");

            CSSPLogService.EndFunctionLog(MethodBase.GetCurrentMethod().DeclaringType.Name);

            return await Task.FromResult(BadRequest(CSSPLogService.ErrRes));
        }

        List<TVItem> TVItemList = (from c in db.TVItems
                                   where c.TVType == TVTypeEnum.File
                                   orderby c.TVLevel
                                   select c).AsNoTracking().ToList();

        List<TVFile> TVFileList = (from c in db.TVFiles
                                   select c).AsNoTracking().ToList();

        // --------------------------------------------------------------
        // Cleaning National shared drive files not found in TVItems table
        //---------------------------------------------------------------

        List<DirectoryInfo> diNatList = diNat.GetDirectories().ToList();

        foreach (DirectoryInfo diNatSub in diNatList)
        {
            int? ParentIDExist = (from c in TVItemList
                                  where c.ParentID.ToString() == diNatSub.Name
                                  select c.ParentID).FirstOrDefault();

            if (ParentIDExist != null)
            {
                if (diNatSub.Name == "WebTide")
                {
                    continue;
                }

                CSSPLogService.AppendLog($"{String.Format(CSSPCultureServicesRes.DoingNationalSharedDriveDirectory_, diNatSub.Name)}");

                foreach (FileInfo fi in diNatSub.GetFiles().ToList())
                {
                    List<TVItem> tvItemList2 = (from c in TVItemList
                                                where c.ParentID == ParentIDExist
                                                select c).ToList();

                    List<TVFile> tvFileList2 = (from c in TVFileList
                                                where c.ServerFileName == fi.Name
                                                select c).ToList();

                    TVFile tvFile = (from c in tvFileList2
                                     from t in tvItemList2
                                     where t.TVItemID == c.TVFileTVItemID
                                     && t.ParentID == ParentIDExist
                                     && c.ServerFileName == fi.Name
                                     select c).FirstOrDefault();

                    if (tvFile == null)
                    {
                        CSSPLogService.AppendLog($"{String.Format(CSSPCultureServicesRes.DeletingNationalSharedDriveFile_, fi.FullName)}");

                        try
                        {
                            fi.Delete();
                        }
                        catch (Exception ex)
                        {
                            CSSPLogService.AppendError($"{String.Format(CSSPCultureServicesRes.ErrorDeletingNationalSharedDriveFile_Error_, fi.FullName, ex.Message)}");

                            CSSPLogService.EndFunctionLog(MethodBase.GetCurrentMethod().DeclaringType.Name);

                            return await Task.FromResult(BadRequest(CSSPLogService.ErrRes));
                        }
                    }
                }
            }
        }

        CSSPLogService.EndFunctionLog(FunctionName);

        return await Task.FromResult(Ok(true));
    }
}

