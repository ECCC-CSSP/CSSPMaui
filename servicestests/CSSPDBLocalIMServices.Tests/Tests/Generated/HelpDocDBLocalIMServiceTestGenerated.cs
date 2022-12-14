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
    public partial class HelpDocDBLocalIMServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILocalService LocalService { get; set; }
        private IHelpDocDBLocalIMService HelpDocDBLocalIMService { get; set; }
        private CSSPDBInMemoryContext dbLocalIM { get; set; }
        private HelpDoc helpDoc { get; set; }
        #endregion Properties

        #region Constructors
        public HelpDocDBLocalIMServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated Constructor [DBLocalIM]
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task HelpDocDBLocalIM_Constructor_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));
        }
        #endregion Tests Generated Constructor [DBLocalIM]

        #region Tests Generated [DBLocalIM] CRUD
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task HelpDocDBLocalIM_CRUD_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));

            helpDoc = GetFilledRandomHelpDoc("");

            await DoCRUDDBLocalIMTest();
        }
        #endregion Tests Generated [DBLocalIM] CRUD

        #region Tests Generated Properties
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task HelpDoc_Properties_Test(string culture)
        {
            Assert.True(await Setup(culture));

            int count = 0;
            if (count == 1)
            {
                // just so we don't get a warning during compile [The variable 'count' is assigned but its value is never used]
            }

            var actionHelpDocList = await HelpDocDBLocalIMService.GetHelpDocList();
            Assert.Equal(200, ((ObjectResult)actionHelpDocList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionHelpDocList.Result).Value);
            List<HelpDoc> helpDocList = (List<HelpDoc>)((OkObjectResult)actionHelpDocList.Result).Value;

            count = helpDocList.Count();

            HelpDoc helpDoc = GetFilledRandomHelpDoc("");


            // -----------------------------------
            // [Key]
            // Is NOT Nullable
            // helpDoc.HelpDocID   (Int32)
            // -----------------------------------

            helpDoc = null;
            helpDoc = GetFilledRandomHelpDoc("");
            helpDoc.HelpDocID = 0;

            var actionHelpDoc = await HelpDocDBLocalIMService.Put(helpDoc);
            Assert.IsType<BadRequestObjectResult>(actionHelpDoc.Result);

            helpDoc = null;
            helpDoc = GetFilledRandomHelpDoc("");
            helpDoc.HelpDocID = 10000000;
            actionHelpDoc = await HelpDocDBLocalIMService.Put(helpDoc);
            Assert.IsType<BadRequestObjectResult>(actionHelpDoc.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPMaxLength(100)]
            // helpDoc.DocKey   (String)
            // -----------------------------------

            helpDoc = null;
            helpDoc = GetFilledRandomHelpDoc("DocKey");
            actionHelpDoc = await HelpDocDBLocalIMService.Post(helpDoc);
            Assert.IsType<BadRequestObjectResult>(actionHelpDoc.Result);

            helpDoc = null;
            helpDoc = GetFilledRandomHelpDoc("");
            helpDoc.DocKey = GetRandomString("", 101);
            actionHelpDoc = await HelpDocDBLocalIMService.Post(helpDoc);
            Assert.IsType<BadRequestObjectResult>(actionHelpDoc.Result);
            //Assert.AreEqual(count, helpDocDBLocalIMService.GetHelpDocList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // helpDoc.Language   (LanguageEnum)
            // -----------------------------------

            helpDoc = null;
            helpDoc = GetFilledRandomHelpDoc("");
            helpDoc.Language = (LanguageEnum)1000000;
            actionHelpDoc = await HelpDocDBLocalIMService.Post(helpDoc);
            Assert.IsType<BadRequestObjectResult>(actionHelpDoc.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPMaxLength(100000)]
            // helpDoc.DocHTMLText   (String)
            // -----------------------------------

            helpDoc = null;
            helpDoc = GetFilledRandomHelpDoc("DocHTMLText");
            actionHelpDoc = await HelpDocDBLocalIMService.Post(helpDoc);
            Assert.IsType<BadRequestObjectResult>(actionHelpDoc.Result);

            helpDoc = null;
            helpDoc = GetFilledRandomHelpDoc("");
            helpDoc.DocHTMLText = GetRandomString("", 100001);
            actionHelpDoc = await HelpDocDBLocalIMService.Post(helpDoc);
            Assert.IsType<BadRequestObjectResult>(actionHelpDoc.Result);
            //Assert.AreEqual(count, helpDocDBLocalIMService.GetHelpDocList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // helpDoc.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            helpDoc = null;
            helpDoc = GetFilledRandomHelpDoc("");
            helpDoc.LastUpdateDate_UTC = new DateTime();
            actionHelpDoc = await HelpDocDBLocalIMService.Post(helpDoc);
            Assert.IsType<BadRequestObjectResult>(actionHelpDoc.Result);
            helpDoc = null;
            helpDoc = GetFilledRandomHelpDoc("");
            helpDoc.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionHelpDoc = await HelpDocDBLocalIMService.Post(helpDoc);
            Assert.IsType<BadRequestObjectResult>(actionHelpDoc.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // helpDoc.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            helpDoc = null;
            helpDoc = GetFilledRandomHelpDoc("");
            helpDoc.LastUpdateContactTVItemID = 0;
            actionHelpDoc = await HelpDocDBLocalIMService.Post(helpDoc);
            Assert.IsType<BadRequestObjectResult>(actionHelpDoc.Result);

            helpDoc = null;
            helpDoc = GetFilledRandomHelpDoc("");
            helpDoc.LastUpdateContactTVItemID = 1;
            actionHelpDoc = await HelpDocDBLocalIMService.Post(helpDoc);
            Assert.IsType<BadRequestObjectResult>(actionHelpDoc.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDDBLocalIMTest()
        {
            helpDoc.HelpDocID = 10000000;

            // Post HelpDoc
            var actionHelpDocAdded = await HelpDocDBLocalIMService.Post(helpDoc);
            Assert.Equal(200, ((ObjectResult)actionHelpDocAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionHelpDocAdded.Result).Value);
            HelpDoc helpDocAdded = (HelpDoc)((OkObjectResult)actionHelpDocAdded.Result).Value;
            Assert.NotNull(helpDocAdded);

            // List<HelpDoc>
            var actionHelpDocList = await HelpDocDBLocalIMService.GetHelpDocList();
            Assert.Equal(200, ((ObjectResult)actionHelpDocList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionHelpDocList.Result).Value);
            List<HelpDoc> helpDocList = (List<HelpDoc>)((OkObjectResult)actionHelpDocList.Result).Value;

            int count = ((List<HelpDoc>)((OkObjectResult)actionHelpDocList.Result).Value).Count();
            Assert.True(count > 0);

            // Get HelpDoc With HelpDocID
            var actionHelpDocGet = await HelpDocDBLocalIMService.GetHelpDocWithHelpDocID(helpDocList[0].HelpDocID);
            Assert.Equal(200, ((ObjectResult)actionHelpDocGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionHelpDocGet.Result).Value);
            HelpDoc helpDocGet = (HelpDoc)((OkObjectResult)actionHelpDocGet.Result).Value;
            Assert.NotNull(helpDocGet);
            Assert.Equal(helpDocGet.HelpDocID, helpDocList[0].HelpDocID);

            // Put HelpDoc
            var actionHelpDocUpdated = await HelpDocDBLocalIMService.Put(helpDoc);
            Assert.Equal(200, ((ObjectResult)actionHelpDocUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionHelpDocUpdated.Result).Value);
            HelpDoc helpDocUpdated = (HelpDoc)((OkObjectResult)actionHelpDocUpdated.Result).Value;
            Assert.NotNull(helpDocUpdated);

            // Delete HelpDoc
            var actionHelpDocDeleted = await HelpDocDBLocalIMService.Delete(helpDoc.HelpDocID);
            Assert.Equal(200, ((ObjectResult)actionHelpDocDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionHelpDocDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionHelpDocDeleted.Result).Value;
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
            Services.AddSingleton<IHelpDocDBLocalIMService, HelpDocDBLocalIMService>();

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

            HelpDocDBLocalIMService = Provider.GetService<IHelpDocDBLocalIMService>();
            Assert.NotNull(HelpDocDBLocalIMService);

            return await Task.FromResult(true);
        }
        private HelpDoc GetFilledRandomHelpDoc(string OmitPropName)
        {
            HelpDoc helpDoc = new HelpDoc();

            if (OmitPropName != "DocKey") helpDoc.DocKey = GetRandomString("", 5);
            if (OmitPropName != "Language") helpDoc.Language = CSSPCultureServicesRes.Culture.TwoLetterISOLanguageName == "fr" ? LanguageEnum.fr : LanguageEnum.en;
            if (OmitPropName != "DocHTMLText") helpDoc.DocHTMLText = GetRandomString("", 5);
            if (OmitPropName != "LastUpdateDate_UTC") helpDoc.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") helpDoc.LastUpdateContactTVItemID = 2;

            try
            {
                dbLocalIM.TVItems.Add(new TVItem() { TVItemID = 2, TVLevel = 1, TVPath = "p1p2", TVType = (TVTypeEnum)5, ParentID = 1, IsActive = true, LastUpdateDate_UTC = new DateTime(2014, 12, 2, 16, 58, 16), LastUpdateContactTVItemID = 2 });
                dbLocalIM.SaveChanges();
            }
            catch (Exception)
            {
                // Assert.True(false, ex.Message);
            }


            return helpDoc;
        }
        private void CheckHelpDocFields(List<HelpDoc> helpDocList)
        {
            Assert.False(string.IsNullOrWhiteSpace(helpDocList[0].DocKey));
            Assert.False(string.IsNullOrWhiteSpace(helpDocList[0].DocHTMLText));
        }

        #endregion Functions private
    }
}
