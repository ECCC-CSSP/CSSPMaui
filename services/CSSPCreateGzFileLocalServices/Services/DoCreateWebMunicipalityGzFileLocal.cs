/*
 * Manually edited
 * 
 */
using CSSPCultureServices.Resources;
using CSSPEnums;
using CSSPDBModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using CSSPWebModels;

namespace CreateGzFileLocalServices
{
    public partial class CreateGzFileLocalService : ControllerBase, ICreateGzFileLocalService
    {
        private async Task<ActionResult<bool>> DoCreateWebMunicipalityGzFileLocal(int MunicipalityTVItemID)
        {
            if (LoggedInService.LoggedInContactInfo.LoggedInContact == null)
            {
                return await Task.FromResult(Unauthorized(CSSPCultureServicesRes.YouDoNotHaveAuthorization));
            }

            TVItem TVItemMunicipality = await GetTVItemWithTVItemID(MunicipalityTVItemID);

            if (TVItemMunicipality == null || TVItemMunicipality.TVType != TVTypeEnum.Municipality)
            {
                return await Task.FromResult(BadRequest(string.Format(CSSPCultureServicesRes._CouldNotBeFoundFor_Equal_And_Equal_,
                    "TVItem", MunicipalityTVItemID.ToString(), "TVType", TVTypeEnum.Municipality.ToString())));
            }

            WebMunicipality webMunicipality = new WebMunicipality();

            try
            {
                await FillTVItemModelLocal(webMunicipality.TVItemModel, TVItemMunicipality);

                await FillParentListTVItemModelListLocal(webMunicipality.TVItemParentList, TVItemMunicipality);

                await FillChildListTVItemModelListLocal(webMunicipality.TVItemFileList, TVItemMunicipality, TVTypeEnum.File);

                await FillChildListTVItemContactModelListLocal(webMunicipality.MunicipalityContactModelList, TVItemMunicipality);

                webMunicipality.MunicipalityTVItemLinkList = await GetInfrastructureTVItemLinkListUnderMunicipality(TVItemMunicipality);

                DoStoreLocal<WebMunicipality>(webMunicipality, $"{ WebTypeEnum.WebMunicipality }_{ MunicipalityTVItemID }.gz");
            }
            catch (Exception ex)
            {
                string inner = ex.InnerException != null ? $"Inner: { ex.InnerException.Message }" : "";
                return await Task.FromResult(BadRequest($"{ ex.Message } { inner }"));
            }

            return await Task.FromResult(Ok(true));
        }
    }
}
