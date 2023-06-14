namespace CSSPFileServices;

public partial class CSSPFileService : ControllerBase, ICSSPFileService
{
    public async Task<ActionResult<bool>> LocalizeAzureFileAsync(int ParentTVItemID, string FileName)
    {
        string FunctionName = $"async Task<ActionResult<bool>> LocalizeAzureFileAsync(int ParentTVItemID, string FileName) - ParentTVItemID: {ParentTVItemID}  FileName: {FileName}";
        CSSPLogService.FunctionLog(FunctionName);

        if (!await CSSPLogService.CheckLogin(FunctionName)) return await Task.FromResult(Unauthorized(CSSPLogService.ErrRes));

        ShareFileClient shareFileClient;
        ShareFileProperties shareFileProperties;
        try
        {
            ShareClient shareClient = new ShareClient(CSSPScrambleService.Descramble(CSSPLocalLoggedInService.LoggedInContactInfo.LoggedInContact.AzureStoreHash), Configuration["AzureStoreCSSPFilesPath"]);
            ShareDirectoryClient shareDirectoryClient = shareClient.GetDirectoryClient($"{ParentTVItemID}");
            shareFileClient = shareDirectoryClient.GetFileClient(FileName);
            shareFileProperties = shareFileClient.GetProperties();
        }
        catch (Exception ex)
        {
            string ErrorText = ex.Message + (ex.InnerException == null ? "" : " InnerException: " + ex.InnerException.Message);

            return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, string.Format(CSSPCultureServicesRes.ErrorWhileTryingToGetAzureFileInfoFor_Error_, $"{ParentTVItemID}\\{FileName}", ErrorText));
        }

        FileInfo fiDownload = new FileInfo($"{Configuration["CSSPFilesPath"]}{ParentTVItemID}\\{FileName}");
        bool ShouldDownload = false;

        if (fiDownload.Exists)
        {
            string? AzureStoreCSSPFilesPathText = Configuration["AzureStoreCSSPFilesPath"];
            if (AzureStoreCSSPFilesPathText == null)
            {
                string ErrorText = "Configuration[\"AzureStoreCSSPFilesPath\"] == null";
                return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, ErrorText);
            }

            var manageFileExist = await ManageFileService.GetWithAzureStorageAndAzureFileNameAsync(AzureStoreCSSPFilesPathText, $"{ParentTVItemID}\\{FileName}");
            var manageFileResult = manageFileExist.Result;
            if (manageFileResult != null)
            {
                ManageFile? manageFile = (ManageFile?)((OkObjectResult)manageFileResult).Value;
                if (manageFile != null)
                {
                    if (!manageFile.LoadedOnce)
                    {
                        manageFile.LoadedOnce = true;

                        var actionCSSPFileAdded = await ManageFileService.ModifyAsync(manageFile);
                        var csspFileResult = actionCSSPFileAdded.Result;
                        if (csspFileResult != null)
                        {
                            if (((OkObjectResult)csspFileResult).StatusCode == 200)
                            {
                                manageFile = (ManageFile?)((OkObjectResult)csspFileResult).Value;
                            }
                            else if (((UnauthorizedObjectResult)csspFileResult).StatusCode == 401)
                            {
                                return await CSSPLogService.EndFunctionReturnUnauthorized(FunctionName, CSSPCultureServicesRes.YouDoNotHaveAuthorization);
                            }
                            else if (((BadRequestObjectResult)csspFileResult).StatusCode == 400)
                            {
                                object? val = ((BadRequestObjectResult)csspFileResult).Value;
                                if (val != null)
                                {
                                    return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, "" + val.ToString());
                                }

                                return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, CSSPCultureServicesRes.BadRequest);
                            }
                            else
                            {
                                return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, CSSPCultureServicesRes.BadRequest);
                            }
                        }
                    }

                    string eTag = shareFileProperties.ETag.ToString().Replace("\"", "");

                    if (manageFile != null)
                    {
                        if (manageFile.AzureETag != eTag)
                        {
                            ShouldDownload = true;

                            try
                            {
                                fiDownload.Delete();
                            }
                            catch (Exception ex)
                            {
                                string ErrorText = ex.Message + (ex.InnerException == null ? "" : " InnerException: " + ex.InnerException.Message);

                                return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, string.Format(CSSPCultureServicesRes.CouldNotDeleteFile_Error_, fiDownload.FullName, ErrorText));
                            }
                        }
                    }
                }
                else
                {
                    ShouldDownload = true;
                }

            }
        }
        else
        {
            ShouldDownload = true;
        }

        if (ShouldDownload)
        {
            if (fiDownload.Directory != null)
            {
                DirectoryInfo di = new DirectoryInfo(fiDownload.Directory.FullName);
                if (!di.Exists)
                {
                    try
                    {
                        di.Create();
                    }
                    catch (Exception ex)
                    {
                        string ErrorText = ex.Message + (ex.InnerException == null ? "" : " InnerException: " + ex.InnerException.Message);

                        return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, string.Format(CSSPCultureServicesRes.CouldNoCreateDirectory_, di.FullName, ErrorText));
                    }
                }

                try
                {
                    ShareFileDownloadInfo download = shareFileClient.Download();
                    using (FileStream stream = System.IO.File.OpenWrite(fiDownload.FullName))
                    {
                        download.Content.CopyTo(stream);
                    }
                }
                catch (Exception ex)
                {
                    string ErrorText = ex.Message + (ex.InnerException == null ? "" : " InnerException: " + ex.InnerException.Message);

                    return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, string.Format(CSSPCultureServicesRes.CouldNotLocalizeAzureFile_Error_, $"{ParentTVItemID}\\{FileName}", ErrorText));
                }
            }

            string? AzureStoreCSSPFilesPathText = Configuration["AzureStoreCSSPFilesPath"];
            if (AzureStoreCSSPFilesPathText == null)
            {
                string ErrorText = "Configuration[\"AzureStoreCSSPFilesPath\"] == null";
                return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, ErrorText);
            }

            var actionCSSPFile = await ManageFileService.GetWithAzureStorageAndAzureFileNameAsync(AzureStoreCSSPFilesPathText, $"{ParentTVItemID}\\{FileName}");
            var csspFileResult = actionCSSPFile.Result;
            if (csspFileResult != null)
            {
                ManageFile? manageFile = (ManageFile?)((OkObjectResult)csspFileResult).Value;

                string eTag = shareFileProperties.ETag.ToString().Replace("\"", "");

                if (manageFile == null)
                {
                    manageFile = new ManageFile()
                    {
                        ManageFileID = 0,
                        AzureStorage = AzureStoreCSSPFilesPathText,
                        AzureFileName = $"{ParentTVItemID}\\{FileName}",
                        AzureETag = eTag,
                        AzureCreationTimeUTC = DateTime.Parse(shareFileProperties.LastModified.ToString()),
                        LoadedOnce = true,
                    };

                    var actionCSSPFileAdded = await ManageFileService.AddAsync(manageFile);
                    if (((OkObjectResult)csspFileResult).StatusCode == 200)
                    {
                        // information got uploaded to CSSPDBManage.db Table ManageFiles properly
                    }
                    else if (((UnauthorizedObjectResult)csspFileResult).StatusCode == 401)
                    {
                        return await CSSPLogService.EndFunctionReturnUnauthorized(FunctionName, CSSPCultureServicesRes.YouDoNotHaveAuthorization);
                    }
                    else if (((BadRequestObjectResult)csspFileResult).StatusCode == 400)
                    {
                        object? val = ((BadRequestObjectResult)csspFileResult).Value;
                        if (val != null)
                        {
                            return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, "" + val.ToString());
                        }

                        return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, CSSPCultureServicesRes.BadRequest);
                    }
                    else
                    {
                        return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, CSSPCultureServicesRes.BadRequest);
                    }
                }
                else
                {
                    manageFile.AzureETag = eTag;
                    manageFile.AzureCreationTimeUTC = DateTime.Parse(shareFileProperties.LastModified.ToString());
                    manageFile.LoadedOnce = true;

                    var actionCSSPFilePut = await ManageFileService.AddAsync(manageFile);
                    if (((OkObjectResult)csspFileResult).StatusCode == 200)
                    {
                        // information got uploaded to CSSPDBManage.db Table ManageFiles properly
                    }
                    else if (((UnauthorizedObjectResult)csspFileResult).StatusCode == 401)
                    {
                        return await CSSPLogService.EndFunctionReturnUnauthorized(FunctionName, CSSPCultureServicesRes.YouDoNotHaveAuthorization);
                    }
                    else if (((BadRequestObjectResult)csspFileResult).StatusCode == 400)
                    {
                        object? val = ((BadRequestObjectResult)csspFileResult).Value;
                        if (val != null)
                        {
                            return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, "" + val.ToString());
                        }

                        return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, CSSPCultureServicesRes.BadRequest);
                    }
                    else
                    {
                        return await CSSPLogService.EndFunctionReturnBadRequest(FunctionName, CSSPCultureServicesRes.BadRequest);
                    }
                }
            }

            return await CSSPLogService.EndFunctionReturnOkTrue(FunctionName);
        }

        return await CSSPLogService.EndFunctionReturnOkTrue(FunctionName);
    }
}