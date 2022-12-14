/* Auto generated from C:\CSSPTools\src\codegen\_package\netcoreapp3.1\ServicesClassNameServiceTestGenerated.exe
 *
 * Do not edit this file.
 *
 */

using CSSPEnums;
using CSSPModels;
using CSSPCultureServices.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Xunit;
using System.ComponentModel.DataAnnotations;
using CSSPCultureServices.Resources;
using LocalServices;

namespace CSSPDBLocalIMServices.Tests
{
    [Collection("Sequential")]
    public partial class BoxModelLanguageDBLocalIMServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILocalService LocalService { get; set; }
        private IBoxModelLanguageDBLocalIMService BoxModelLanguageDBLocalIMService { get; set; }
        private CSSPDBInMemoryContext dbLocalIM { get; set; }
        private BoxModelLanguage boxModelLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelLanguageDBLocalIMServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated Constructor [DBLocalIM]
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task BoxModelLanguageDBLocalIM_Constructor_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));
        }
        #endregion Tests Generated Constructor [DBLocalIM]

        #region Tests Generated [DBLocalIM] CRUD
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task BoxModelLanguageDBLocalIM_CRUD_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));

            boxModelLanguage = GetFilledRandomBoxModelLanguage("");

            await DoCRUDDBLocalIMTest();
        }
        #endregion Tests Generated [DBLocalIM] CRUD

        #region Tests Generated Properties
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task BoxModelLanguage_Properties_Test(string culture)
        {
            Assert.True(await Setup(culture));

            int count = 0;
            if (count == 1)
            {
                // just so we don't get a warning during compile [The variable 'count' is assigned but its value is never used]
            }

            var actionBoxModelLanguageList = await BoxModelLanguageDBLocalIMService.GetBoxModelLanguageList();
            Assert.Equal(200, ((ObjectResult)actionBoxModelLanguageList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionBoxModelLanguageList.Result).Value);
            List<BoxModelLanguage> boxModelLanguageList = (List<BoxModelLanguage>)((OkObjectResult)actionBoxModelLanguageList.Result).Value;

            count = boxModelLanguageList.Count();

            BoxModelLanguage boxModelLanguage = GetFilledRandomBoxModelLanguage("");


            // -----------------------------------
            // [Key]
            // Is NOT Nullable
            // boxModelLanguage.BoxModelLanguageID   (Int32)
            // -----------------------------------

            boxModelLanguage = null;
            boxModelLanguage = GetFilledRandomBoxModelLanguage("");
            boxModelLanguage.BoxModelLanguageID = 0;

            var actionBoxModelLanguage = await BoxModelLanguageDBLocalIMService.Put(boxModelLanguage);
            Assert.IsType<BadRequestObjectResult>(actionBoxModelLanguage.Result);

            boxModelLanguage = null;
            boxModelLanguage = GetFilledRandomBoxModelLanguage("");
            boxModelLanguage.BoxModelLanguageID = 10000000;
            actionBoxModelLanguage = await BoxModelLanguageDBLocalIMService.Put(boxModelLanguage);
            Assert.IsType<BadRequestObjectResult>(actionBoxModelLanguage.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "BoxModel", ExistPlurial = "s", ExistFieldID = "BoxModelID", AllowableTVtypeList = )]
            // boxModelLanguage.BoxModelID   (Int32)
            // -----------------------------------

            boxModelLanguage = null;
            boxModelLanguage = GetFilledRandomBoxModelLanguage("");
            boxModelLanguage.BoxModelID = 0;
            actionBoxModelLanguage = await BoxModelLanguageDBLocalIMService.Post(boxModelLanguage);
            Assert.IsType<BadRequestObjectResult>(actionBoxModelLanguage.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // boxModelLanguage.Language   (LanguageEnum)
            // -----------------------------------

            boxModelLanguage = null;
            boxModelLanguage = GetFilledRandomBoxModelLanguage("");
            boxModelLanguage.Language = (LanguageEnum)1000000;
            actionBoxModelLanguage = await BoxModelLanguageDBLocalIMService.Post(boxModelLanguage);
            Assert.IsType<BadRequestObjectResult>(actionBoxModelLanguage.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPMaxLength(250)]
            // boxModelLanguage.ScenarioName   (String)
            // -----------------------------------

            boxModelLanguage = null;
            boxModelLanguage = GetFilledRandomBoxModelLanguage("ScenarioName");
            actionBoxModelLanguage = await BoxModelLanguageDBLocalIMService.Post(boxModelLanguage);
            Assert.IsType<BadRequestObjectResult>(actionBoxModelLanguage.Result);

            boxModelLanguage = null;
            boxModelLanguage = GetFilledRandomBoxModelLanguage("");
            boxModelLanguage.ScenarioName = GetRandomString("", 251);
            actionBoxModelLanguage = await BoxModelLanguageDBLocalIMService.Post(boxModelLanguage);
            Assert.IsType<BadRequestObjectResult>(actionBoxModelLanguage.Result);
            //Assert.AreEqual(count, boxModelLanguageDBLocalIMService.GetBoxModelLanguageList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // boxModelLanguage.TranslationStatus   (TranslationStatusEnum)
            // -----------------------------------

            boxModelLanguage = null;
            boxModelLanguage = GetFilledRandomBoxModelLanguage("");
            boxModelLanguage.TranslationStatus = (TranslationStatusEnum)1000000;
            actionBoxModelLanguage = await BoxModelLanguageDBLocalIMService.Post(boxModelLanguage);
            Assert.IsType<BadRequestObjectResult>(actionBoxModelLanguage.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // boxModelLanguage.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            boxModelLanguage = null;
            boxModelLanguage = GetFilledRandomBoxModelLanguage("");
            boxModelLanguage.LastUpdateDate_UTC = new DateTime();
            actionBoxModelLanguage = await BoxModelLanguageDBLocalIMService.Post(boxModelLanguage);
            Assert.IsType<BadRequestObjectResult>(actionBoxModelLanguage.Result);
            boxModelLanguage = null;
            boxModelLanguage = GetFilledRandomBoxModelLanguage("");
            boxModelLanguage.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionBoxModelLanguage = await BoxModelLanguageDBLocalIMService.Post(boxModelLanguage);
            Assert.IsType<BadRequestObjectResult>(actionBoxModelLanguage.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // boxModelLanguage.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            boxModelLanguage = null;
            boxModelLanguage = GetFilledRandomBoxModelLanguage("");
            boxModelLanguage.LastUpdateContactTVItemID = 0;
            actionBoxModelLanguage = await BoxModelLanguageDBLocalIMService.Post(boxModelLanguage);
            Assert.IsType<BadRequestObjectResult>(actionBoxModelLanguage.Result);

            boxModelLanguage = null;
            boxModelLanguage = GetFilledRandomBoxModelLanguage("");
            boxModelLanguage.LastUpdateContactTVItemID = 1;
            actionBoxModelLanguage = await BoxModelLanguageDBLocalIMService.Post(boxModelLanguage);
            Assert.IsType<BadRequestObjectResult>(actionBoxModelLanguage.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDDBLocalIMTest()
        {
            boxModelLanguage.BoxModelLanguageID = 10000000;

            // Post BoxModelLanguage
            var actionBoxModelLanguageAdded = await BoxModelLanguageDBLocalIMService.Post(boxModelLanguage);
            Assert.Equal(200, ((ObjectResult)actionBoxModelLanguageAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionBoxModelLanguageAdded.Result).Value);
            BoxModelLanguage boxModelLanguageAdded = (BoxModelLanguage)((OkObjectResult)actionBoxModelLanguageAdded.Result).Value;
            Assert.NotNull(boxModelLanguageAdded);

            // List<BoxModelLanguage>
            var actionBoxModelLanguageList = await BoxModelLanguageDBLocalIMService.GetBoxModelLanguageList();
            Assert.Equal(200, ((ObjectResult)actionBoxModelLanguageList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionBoxModelLanguageList.Result).Value);
            List<BoxModelLanguage> boxModelLanguageList = (List<BoxModelLanguage>)((OkObjectResult)actionBoxModelLanguageList.Result).Value;

            int count = ((List<BoxModelLanguage>)((OkObjectResult)actionBoxModelLanguageList.Result).Value).Count();
            Assert.True(count > 0);

            // Get BoxModelLanguage With BoxModelLanguageID
            var actionBoxModelLanguageGet = await BoxModelLanguageDBLocalIMService.GetBoxModelLanguageWithBoxModelLanguageID(boxModelLanguageList[0].BoxModelLanguageID);
            Assert.Equal(200, ((ObjectResult)actionBoxModelLanguageGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionBoxModelLanguageGet.Result).Value);
            BoxModelLanguage boxModelLanguageGet = (BoxModelLanguage)((OkObjectResult)actionBoxModelLanguageGet.Result).Value;
            Assert.NotNull(boxModelLanguageGet);
            Assert.Equal(boxModelLanguageGet.BoxModelLanguageID, boxModelLanguageList[0].BoxModelLanguageID);

            // Put BoxModelLanguage
            var actionBoxModelLanguageUpdated = await BoxModelLanguageDBLocalIMService.Put(boxModelLanguage);
            Assert.Equal(200, ((ObjectResult)actionBoxModelLanguageUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionBoxModelLanguageUpdated.Result).Value);
            BoxModelLanguage boxModelLanguageUpdated = (BoxModelLanguage)((OkObjectResult)actionBoxModelLanguageUpdated.Result).Value;
            Assert.NotNull(boxModelLanguageUpdated);

            // Delete BoxModelLanguage
            var actionBoxModelLanguageDeleted = await BoxModelLanguageDBLocalIMService.Delete(boxModelLanguage.BoxModelLanguageID);
            Assert.Equal(200, ((ObjectResult)actionBoxModelLanguageDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionBoxModelLanguageDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionBoxModelLanguageDeleted.Result).Value;
            Assert.True(retBool);

        }
        private async Task<bool> Setup(string culture)
        {
            Config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
               .AddJsonFile("appsettings_csspdblocalimservicestests.json")
               .AddUserSecrets("64a6d1e4-0d0c-4e59-9c2e-640182417704")
               .Build();

            Services = new ServiceCollection();

            Services.AddSingleton<IConfiguration>(Config);

            string CSSPDBLoginFileName = Config.GetValue<string>("CSSPDBLogin");
            Assert.NotNull(CSSPDBLoginFileName);

            FileInfo fiCSSPDBLogin = new FileInfo(CSSPDBLoginFileName);

            Services.AddDbContext<CSSPDBLoginContext>(options =>
            {
                options.UseSqlite($"Data Source={ fiCSSPDBLogin.FullName }");
            });

            Services.AddDbContext<CSSPDBLoginInMemoryContext>(options =>
            {
                options.UseSqlite($"Data Source={ fiCSSPDBLogin.FullName }");
            });

            string CSSPDBLocalFileName = Config.GetValue<string>("CSSPDBLocal");
            Assert.NotNull(CSSPDBLocalFileName);

            FileInfo fiCSSPDBLocal = new FileInfo(CSSPDBLocalFileName);

            Services.AddDbContext<CSSPDBInMemoryContext>(options =>
            {
                options.UseInMemoryDatabase($"Data Source={ fiCSSPDBLocal.FullName }");
            });

            Services.AddSingleton<ICSSPCultureService, CSSPCultureService>();
            Services.AddSingleton<ILocalService, LocalService>();
            Services.AddSingleton<IEnums, Enums>();
            Services.AddSingleton<IBoxModelLanguageDBLocalIMService, BoxModelLanguageDBLocalIMService>();

            Provider = Services.BuildServiceProvider();
            Assert.NotNull(Provider);

            CSSPCultureService = Provider.GetService<ICSSPCultureService>();
            Assert.NotNull(CSSPCultureService);

            CSSPCultureService.SetCulture(culture);

            LocalService = Provider.GetService<ILocalService>();
            Assert.NotNull(LocalService);

            Assert.True(await LocalService.SetLoggedInContactInfo());

            dbLocalIM = Provider.GetService<CSSPDBInMemoryContext>();
            Assert.NotNull(dbLocalIM);

            BoxModelLanguageDBLocalIMService = Provider.GetService<IBoxModelLanguageDBLocalIMService>();
            Assert.NotNull(BoxModelLanguageDBLocalIMService);

            return await Task.FromResult(true);
        }
        private BoxModelLanguage GetFilledRandomBoxModelLanguage(string OmitPropName)
        {
            BoxModelLanguage boxModelLanguage = new BoxModelLanguage();

            if (OmitPropName != "BoxModelID") boxModelLanguage.BoxModelID = 1;
            if (OmitPropName != "Language") boxModelLanguage.Language = CSSPCultureServicesRes.Culture.TwoLetterISOLanguageName == "fr" ? LanguageEnum.fr : LanguageEnum.en;
            if (OmitPropName != "ScenarioName") boxModelLanguage.ScenarioName = GetRandomString("", 5);
            if (OmitPropName != "TranslationStatus") boxModelLanguage.TranslationStatus = (TranslationStatusEnum)GetRandomEnumType(typeof(TranslationStatusEnum));
            if (OmitPropName != "LastUpdateDate_UTC") boxModelLanguage.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") boxModelLanguage.LastUpdateContactTVItemID = 2;

            try
            {
                dbLocalIM.BoxModels.Add(new BoxModel() { BoxModelID = 1, InfrastructureTVItemID = 41, Discharge_m3_day = 1021, Depth_m = 1.2, Temperature_C = 10, Dilution = 1000, DecayRate_per_day = 4.6821, FCUntreated_MPN_100ml = 2500000, FCPreDisinfection_MPN_100ml = 357, Concentration_MPN_100ml = 14, T90_hour = 6, DischargeDuration_hour = 24, LastUpdateDate_UTC = new DateTime(2018, 10, 29, 12, 42, 9), LastUpdateContactTVItemID = 2 });
                dbLocalIM.SaveChanges();
            }
            catch (Exception)
            {
                // Assert.True(false, ex.Message);
            }
            try
            {
                dbLocalIM.TVItems.Add(new TVItem() { TVItemID = 2, TVLevel = 1, TVPath = "p1p2", TVType = (TVTypeEnum)5, ParentID = 1, IsActive = true, LastUpdateDate_UTC = new DateTime(2014, 12, 2, 16, 58, 16), LastUpdateContactTVItemID = 2 });
                dbLocalIM.SaveChanges();
            }
            catch (Exception)
            {
                // Assert.True(false, ex.Message);
            }


            return boxModelLanguage;
        }
        private void CheckBoxModelLanguageFields(List<BoxModelLanguage> boxModelLanguageList)
        {
            Assert.False(string.IsNullOrWhiteSpace(boxModelLanguageList[0].ScenarioName));
        }

        #endregion Functions private
    }
}
