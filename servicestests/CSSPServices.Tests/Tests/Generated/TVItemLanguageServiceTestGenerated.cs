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

namespace CSSPServices.Tests
{
    [Collection("Sequential")]
    public partial class TVItemLanguageServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILoggedInService LoggedInService { get; set; }
        private ITVItemLanguageService TVItemLanguageService { get; set; }
        private CSSPDBContext db { get; set; }
        private CSSPDBLocalContext dbLocal { get; set; }
        private CSSPDBInMemoryContext dbIM { get; set; }
        private TVItemLanguage tvItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemLanguageServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated CRUD
        [Theory]
        [InlineData("en-CA", DBLocationEnum.Local)]
        [InlineData("fr-CA", DBLocationEnum.Local)]
        [InlineData("en-CA", DBLocationEnum.Server)]
        [InlineData("fr-CA", DBLocationEnum.Server)]
        public async Task TVItemLanguage_CRUD_Good_Test(string culture, DBLocationEnum DBLocation)
        {
            // -------------------------------
            // -------------------------------
            // CRUD testing
            // -------------------------------
            // -------------------------------

            Assert.True(await Setup(culture));

            LoggedInService.DBLocation = DBLocation;

            tvItemLanguage = GetFilledRandomTVItemLanguage("");

            if (LoggedInService.DBLocation == DBLocationEnum.Local)
            {
                await DoCRUDTest();
            }
            else
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    await DoCRUDTest();
                }
            }
        }
        #endregion Tests Generated CRUD

        #region Tests Generated Properties
        [Theory]
        [InlineData("en-CA", DBLocationEnum.Local)]
        [InlineData("fr-CA", DBLocationEnum.Local)]
        [InlineData("en-CA", DBLocationEnum.Server)]
        [InlineData("fr-CA", DBLocationEnum.Server)]
        public async Task TVItemLanguage_Properties_Test(string culture, DBLocationEnum DBLocation)
        {
            // -------------------------------
            // -------------------------------
            // Properties testing
            // -------------------------------
            // -------------------------------

            Assert.True(await Setup(culture));

            LoggedInService.DBLocation = DBLocation;

            int count = 0;
            if (count == 1)
            {
                // just so we don't get a warning during compile [The variable 'count' is assigned but its value is never used]
            }

            var actionTVItemLanguageList = await TVItemLanguageService.GetTVItemLanguageList();
            Assert.Equal(200, ((ObjectResult)actionTVItemLanguageList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTVItemLanguageList.Result).Value);
            List<TVItemLanguage> tvItemLanguageList = (List<TVItemLanguage>)((OkObjectResult)actionTVItemLanguageList.Result).Value;

            count = tvItemLanguageList.Count();

            TVItemLanguage tvItemLanguage = GetFilledRandomTVItemLanguage("");


            // -----------------------------------
            // [Key]
            // Is NOT Nullable
            // tvItemLanguage.TVItemLanguageID   (Int32)
            // -----------------------------------

            tvItemLanguage = null;
            tvItemLanguage = GetFilledRandomTVItemLanguage("");
            tvItemLanguage.TVItemLanguageID = 0;

            var actionTVItemLanguage = await TVItemLanguageService.Put(tvItemLanguage);
            Assert.IsType<BadRequestObjectResult>(actionTVItemLanguage.Result);

            tvItemLanguage = null;
            tvItemLanguage = GetFilledRandomTVItemLanguage("");
            tvItemLanguage.TVItemLanguageID = 10000000;
            actionTVItemLanguage = await TVItemLanguageService.Put(tvItemLanguage);
            Assert.IsType<BadRequestObjectResult>(actionTVItemLanguage.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Root,Address,Area,ClimateSite,Contact,Country,Email,HydrometricSite,Infrastructure,MikeBoundaryConditionWebTide,MikeBoundaryConditionMesh,MikeScenario,MikeSource,Municipality,MWQMSite,PolSourceSite,Province,Sector,Subsector,Tel,MWQMRun,Classification)]
            // tvItemLanguage.TVItemID   (Int32)
            // -----------------------------------

            tvItemLanguage = null;
            tvItemLanguage = GetFilledRandomTVItemLanguage("");
            tvItemLanguage.TVItemID = 0;
            actionTVItemLanguage = await TVItemLanguageService.Post(tvItemLanguage);
            Assert.IsType<BadRequestObjectResult>(actionTVItemLanguage.Result);

            tvItemLanguage = null;
            tvItemLanguage = GetFilledRandomTVItemLanguage("");
            tvItemLanguage.TVItemID = 38;
            actionTVItemLanguage = await TVItemLanguageService.Post(tvItemLanguage);
            Assert.IsType<BadRequestObjectResult>(actionTVItemLanguage.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // tvItemLanguage.Language   (LanguageEnum)
            // -----------------------------------

            tvItemLanguage = null;
            tvItemLanguage = GetFilledRandomTVItemLanguage("");
            tvItemLanguage.Language = (LanguageEnum)1000000;
            actionTVItemLanguage = await TVItemLanguageService.Post(tvItemLanguage);
            Assert.IsType<BadRequestObjectResult>(actionTVItemLanguage.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPMaxLength(200)]
            // tvItemLanguage.TVText   (String)
            // -----------------------------------

            tvItemLanguage = null;
            tvItemLanguage = GetFilledRandomTVItemLanguage("TVText");
            actionTVItemLanguage = await TVItemLanguageService.Post(tvItemLanguage);
            Assert.IsType<BadRequestObjectResult>(actionTVItemLanguage.Result);

            tvItemLanguage = null;
            tvItemLanguage = GetFilledRandomTVItemLanguage("");
            tvItemLanguage.TVText = GetRandomString("", 201);
            actionTVItemLanguage = await TVItemLanguageService.Post(tvItemLanguage);
            Assert.IsType<BadRequestObjectResult>(actionTVItemLanguage.Result);
            //Assert.AreEqual(count, tvItemLanguageService.GetTVItemLanguageList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // tvItemLanguage.TranslationStatus   (TranslationStatusEnum)
            // -----------------------------------

            tvItemLanguage = null;
            tvItemLanguage = GetFilledRandomTVItemLanguage("");
            tvItemLanguage.TranslationStatus = (TranslationStatusEnum)1000000;
            actionTVItemLanguage = await TVItemLanguageService.Post(tvItemLanguage);
            Assert.IsType<BadRequestObjectResult>(actionTVItemLanguage.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // tvItemLanguage.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            tvItemLanguage = null;
            tvItemLanguage = GetFilledRandomTVItemLanguage("");
            tvItemLanguage.LastUpdateDate_UTC = new DateTime();
            actionTVItemLanguage = await TVItemLanguageService.Post(tvItemLanguage);
            Assert.IsType<BadRequestObjectResult>(actionTVItemLanguage.Result);
            tvItemLanguage = null;
            tvItemLanguage = GetFilledRandomTVItemLanguage("");
            tvItemLanguage.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionTVItemLanguage = await TVItemLanguageService.Post(tvItemLanguage);
            Assert.IsType<BadRequestObjectResult>(actionTVItemLanguage.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // tvItemLanguage.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            tvItemLanguage = null;
            tvItemLanguage = GetFilledRandomTVItemLanguage("");
            tvItemLanguage.LastUpdateContactTVItemID = 0;
            actionTVItemLanguage = await TVItemLanguageService.Post(tvItemLanguage);
            Assert.IsType<BadRequestObjectResult>(actionTVItemLanguage.Result);

            tvItemLanguage = null;
            tvItemLanguage = GetFilledRandomTVItemLanguage("");
            tvItemLanguage.LastUpdateContactTVItemID = 1;
            actionTVItemLanguage = await TVItemLanguageService.Post(tvItemLanguage);
            Assert.IsType<BadRequestObjectResult>(actionTVItemLanguage.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDTest()
        {
            // Post TVItemLanguage
            var actionTVItemLanguageAdded = await TVItemLanguageService.Post(tvItemLanguage);
            Assert.Equal(200, ((ObjectResult)actionTVItemLanguageAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTVItemLanguageAdded.Result).Value);
            TVItemLanguage tvItemLanguageAdded = (TVItemLanguage)((OkObjectResult)actionTVItemLanguageAdded.Result).Value;
            Assert.NotNull(tvItemLanguageAdded);

            // List<TVItemLanguage>
            var actionTVItemLanguageList = await TVItemLanguageService.GetTVItemLanguageList();
            Assert.Equal(200, ((ObjectResult)actionTVItemLanguageList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTVItemLanguageList.Result).Value);
            List<TVItemLanguage> tvItemLanguageList = (List<TVItemLanguage>)((OkObjectResult)actionTVItemLanguageList.Result).Value;

            int count = ((List<TVItemLanguage>)((OkObjectResult)actionTVItemLanguageList.Result).Value).Count();
            Assert.True(count > 0);

            if (LoggedInService.DBLocation == DBLocationEnum.Server)
            {
                // List<TVItemLanguage> with skip and take
                var actionTVItemLanguageListSkipAndTake = await TVItemLanguageService.GetTVItemLanguageList(1, 1);
                Assert.Equal(200, ((ObjectResult)actionTVItemLanguageListSkipAndTake.Result).StatusCode);
                Assert.NotNull(((OkObjectResult)actionTVItemLanguageListSkipAndTake.Result).Value);
                List<TVItemLanguage> tvItemLanguageListSkipAndTake = (List<TVItemLanguage>)((OkObjectResult)actionTVItemLanguageListSkipAndTake.Result).Value;

                int countSkipAndTake = ((List<TVItemLanguage>)((OkObjectResult)actionTVItemLanguageListSkipAndTake.Result).Value).Count();
                Assert.True(countSkipAndTake == 1);

                Assert.False(tvItemLanguageList[0].TVItemLanguageID == tvItemLanguageListSkipAndTake[0].TVItemLanguageID);
            }

            // Get TVItemLanguage With TVItemLanguageID
            var actionTVItemLanguageGet = await TVItemLanguageService.GetTVItemLanguageWithTVItemLanguageID(tvItemLanguageList[0].TVItemLanguageID);
            Assert.Equal(200, ((ObjectResult)actionTVItemLanguageGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTVItemLanguageGet.Result).Value);
            TVItemLanguage tvItemLanguageGet = (TVItemLanguage)((OkObjectResult)actionTVItemLanguageGet.Result).Value;
            Assert.NotNull(tvItemLanguageGet);
            Assert.Equal(tvItemLanguageGet.TVItemLanguageID, tvItemLanguageList[0].TVItemLanguageID);

            // Put TVItemLanguage
            var actionTVItemLanguageUpdated = await TVItemLanguageService.Put(tvItemLanguage);
            Assert.Equal(200, ((ObjectResult)actionTVItemLanguageUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTVItemLanguageUpdated.Result).Value);
            TVItemLanguage tvItemLanguageUpdated = (TVItemLanguage)((OkObjectResult)actionTVItemLanguageUpdated.Result).Value;
            Assert.NotNull(tvItemLanguageUpdated);

            // Delete TVItemLanguage
            var actionTVItemLanguageDeleted = await TVItemLanguageService.Delete(tvItemLanguage.TVItemLanguageID);
            Assert.Equal(200, ((ObjectResult)actionTVItemLanguageDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTVItemLanguageDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionTVItemLanguageDeleted.Result).Value;
            Assert.True(retBool);
        }
        private async Task<bool> Setup(string culture)
        {
            Config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
               .AddJsonFile("appsettings_csspservicestests.json")
               .AddUserSecrets("6f27cbbe-6ffb-4154-b49b-d739597c4f60")
               .Build();

            Services = new ServiceCollection();

            Services.AddSingleton<IConfiguration>(Config);

            string CSSPDBLocalFileName = Config.GetValue<string>("CSSPDBLocal");
            Assert.NotNull(CSSPDBLocalFileName);

            string TestDBConnString = Config.GetValue<string>("TestDB");
            Assert.NotNull(TestDBConnString);

            Services.AddDbContext<CSSPDBContext>(options =>
            {
                options.UseSqlServer(TestDBConnString);
            });

            Services.AddDbContext<CSSPDBInMemoryContext>(options =>
            {
                options.UseInMemoryDatabase(TestDBConnString);
            });

            FileInfo fiAppDataPath = new FileInfo(CSSPDBLocalFileName);

            Services.AddDbContext<CSSPDBLocalContext>(options =>
            {
                options.UseSqlite($"Data Source={ fiAppDataPath.FullName }");
            });

            Services.AddSingleton<ICSSPCultureService, CSSPCultureService>();
            Services.AddSingleton<ILoggedInService, LoggedInService>();
            Services.AddSingleton<IEnums, Enums>();
            Services.AddSingleton<ITVItemLanguageService, TVItemLanguageService>();

            Provider = Services.BuildServiceProvider();
            Assert.NotNull(Provider);

            CSSPCultureService = Provider.GetService<ICSSPCultureService>();
            Assert.NotNull(CSSPCultureService);

            CSSPCultureService.SetCulture(culture);

            LoggedInService = Provider.GetService<ILoggedInService>();
            Assert.NotNull(LoggedInService);

            string Id = Config.GetValue<string>("Id");
            Assert.True(await LoggedInService.SetLoggedInContactInfo(Id));

            LoggedInService.DBLocation = DBLocationEnum.Local;

            dbIM = Provider.GetService<CSSPDBInMemoryContext>();
            Assert.NotNull(dbIM);

            dbLocal = Provider.GetService<CSSPDBLocalContext>();
            Assert.NotNull(dbLocal);

            TVItemLanguageService = Provider.GetService<ITVItemLanguageService>();
            Assert.NotNull(TVItemLanguageService);

            return await Task.FromResult(true);
        }
        private TVItemLanguage GetFilledRandomTVItemLanguage(string OmitPropName)
        {
            List<TVItemLanguage> tvItemLanguageListToDelete = (from c in dbLocal.TVItemLanguages
                                                               select c).ToList(); 
            
            dbLocal.TVItemLanguages.RemoveRange(tvItemLanguageListToDelete);
            try
            {
                dbLocal.SaveChanges();
            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
            
            dbIM.Database.EnsureDeleted();

            TVItemLanguage tvItemLanguage = new TVItemLanguage();

            if (OmitPropName != "TVItemID") tvItemLanguage.TVItemID = 1;
            if (OmitPropName != "Language") tvItemLanguage.Language = CSSPCultureServicesRes.Culture.TwoLetterISOLanguageName == "fr" ? LanguageEnum.fr : LanguageEnum.en;
            if (OmitPropName != "TVText") tvItemLanguage.TVText = GetRandomString("", 5);
            if (OmitPropName != "TranslationStatus") tvItemLanguage.TranslationStatus = (TranslationStatusEnum)GetRandomEnumType(typeof(TranslationStatusEnum));
            if (OmitPropName != "LastUpdateDate_UTC") tvItemLanguage.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") tvItemLanguage.LastUpdateContactTVItemID = 2;

            if (LoggedInService.DBLocation == DBLocationEnum.Local)
            {
                if (OmitPropName != "TVItemLanguageID") tvItemLanguage.TVItemLanguageID = 10000000;

                try
                {
                    dbIM.TVItems.Add(new TVItem() { TVItemID = 1, TVLevel = 0, TVPath = "p1", TVType = (TVTypeEnum)1, ParentID = 1, IsActive = true, LastUpdateDate_UTC = new DateTime(2014, 12, 2, 16, 58, 16), LastUpdateContactTVItemID = 2});
                    dbIM.SaveChanges();
                }
                catch (Exception)
                {
                   // nothing for now
                }
                try
                {
                    dbIM.TVItems.Add(new TVItem() { TVItemID = 2, TVLevel = 1, TVPath = "p1p2", TVType = (TVTypeEnum)5, ParentID = 1, IsActive = true, LastUpdateDate_UTC = new DateTime(2014, 12, 2, 16, 58, 16), LastUpdateContactTVItemID = 2});
                    dbIM.SaveChanges();
                }
                catch (Exception)
                {
                   // nothing for now
                }
            }

            return tvItemLanguage;
        }
        private void CheckTVItemLanguageFields(List<TVItemLanguage> tvItemLanguageList)
        {
            Assert.False(string.IsNullOrWhiteSpace(tvItemLanguageList[0].TVText));
        }
        #endregion Functions private
    }
}
