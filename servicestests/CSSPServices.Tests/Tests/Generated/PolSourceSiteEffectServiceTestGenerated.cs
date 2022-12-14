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
    public partial class PolSourceSiteEffectServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILoggedInService LoggedInService { get; set; }
        private IPolSourceSiteEffectService PolSourceSiteEffectService { get; set; }
        private CSSPDBContext db { get; set; }
        private CSSPDBLocalContext dbLocal { get; set; }
        private CSSPDBInMemoryContext dbIM { get; set; }
        private PolSourceSiteEffect polSourceSiteEffect { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceSiteEffectServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated CRUD
        [Theory]
        [InlineData("en-CA", DBLocationEnum.Local)]
        [InlineData("fr-CA", DBLocationEnum.Local)]
        [InlineData("en-CA", DBLocationEnum.Server)]
        [InlineData("fr-CA", DBLocationEnum.Server)]
        public async Task PolSourceSiteEffect_CRUD_Good_Test(string culture, DBLocationEnum DBLocation)
        {
            // -------------------------------
            // -------------------------------
            // CRUD testing
            // -------------------------------
            // -------------------------------

            Assert.True(await Setup(culture));

            LoggedInService.DBLocation = DBLocation;

            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");

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
        public async Task PolSourceSiteEffect_Properties_Test(string culture, DBLocationEnum DBLocation)
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

            var actionPolSourceSiteEffectList = await PolSourceSiteEffectService.GetPolSourceSiteEffectList();
            Assert.Equal(200, ((ObjectResult)actionPolSourceSiteEffectList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionPolSourceSiteEffectList.Result).Value);
            List<PolSourceSiteEffect> polSourceSiteEffectList = (List<PolSourceSiteEffect>)((OkObjectResult)actionPolSourceSiteEffectList.Result).Value;

            count = polSourceSiteEffectList.Count();

            PolSourceSiteEffect polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");


            // -----------------------------------
            // [Key]
            // Is NOT Nullable
            // polSourceSiteEffect.PolSourceSiteEffectID   (Int32)
            // -----------------------------------

            polSourceSiteEffect = null;
            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");
            polSourceSiteEffect.PolSourceSiteEffectID = 0;

            var actionPolSourceSiteEffect = await PolSourceSiteEffectService.Put(polSourceSiteEffect);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceSiteEffect.Result);

            polSourceSiteEffect = null;
            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");
            polSourceSiteEffect.PolSourceSiteEffectID = 10000000;
            actionPolSourceSiteEffect = await PolSourceSiteEffectService.Put(polSourceSiteEffect);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceSiteEffect.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Infrastructure,PolSourceSite)]
            // polSourceSiteEffect.PolSourceSiteOrInfrastructureTVItemID   (Int32)
            // -----------------------------------

            polSourceSiteEffect = null;
            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");
            polSourceSiteEffect.PolSourceSiteOrInfrastructureTVItemID = 0;
            actionPolSourceSiteEffect = await PolSourceSiteEffectService.Post(polSourceSiteEffect);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceSiteEffect.Result);

            polSourceSiteEffect = null;
            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");
            polSourceSiteEffect.PolSourceSiteOrInfrastructureTVItemID = 1;
            actionPolSourceSiteEffect = await PolSourceSiteEffectService.Post(polSourceSiteEffect);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceSiteEffect.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = MWQMSite)]
            // polSourceSiteEffect.MWQMSiteTVItemID   (Int32)
            // -----------------------------------

            polSourceSiteEffect = null;
            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");
            polSourceSiteEffect.MWQMSiteTVItemID = 0;
            actionPolSourceSiteEffect = await PolSourceSiteEffectService.Post(polSourceSiteEffect);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceSiteEffect.Result);

            polSourceSiteEffect = null;
            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");
            polSourceSiteEffect.MWQMSiteTVItemID = 1;
            actionPolSourceSiteEffect = await PolSourceSiteEffectService.Post(polSourceSiteEffect);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceSiteEffect.Result);


            // -----------------------------------
            // Is Nullable
            // [CSSPMaxLength(250)]
            // polSourceSiteEffect.PolSourceSiteEffectTermIDs   (String)
            // -----------------------------------

            polSourceSiteEffect = null;
            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");
            polSourceSiteEffect.PolSourceSiteEffectTermIDs = GetRandomString("", 251);
            actionPolSourceSiteEffect = await PolSourceSiteEffectService.Post(polSourceSiteEffect);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceSiteEffect.Result);
            //Assert.AreEqual(count, polSourceSiteEffectService.GetPolSourceSiteEffectList().Count());

            // -----------------------------------
            // Is Nullable
            // polSourceSiteEffect.Comments   (String)
            // -----------------------------------


            // -----------------------------------
            // Is Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = File)]
            // polSourceSiteEffect.AnalysisDocumentTVItemID   (Int32)
            // -----------------------------------

            polSourceSiteEffect = null;
            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");
            polSourceSiteEffect.AnalysisDocumentTVItemID = 0;
            actionPolSourceSiteEffect = await PolSourceSiteEffectService.Post(polSourceSiteEffect);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceSiteEffect.Result);

            polSourceSiteEffect = null;
            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");
            polSourceSiteEffect.AnalysisDocumentTVItemID = 1;
            actionPolSourceSiteEffect = await PolSourceSiteEffectService.Post(polSourceSiteEffect);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceSiteEffect.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // polSourceSiteEffect.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            polSourceSiteEffect = null;
            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");
            polSourceSiteEffect.LastUpdateDate_UTC = new DateTime();
            actionPolSourceSiteEffect = await PolSourceSiteEffectService.Post(polSourceSiteEffect);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceSiteEffect.Result);
            polSourceSiteEffect = null;
            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");
            polSourceSiteEffect.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionPolSourceSiteEffect = await PolSourceSiteEffectService.Post(polSourceSiteEffect);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceSiteEffect.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // polSourceSiteEffect.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            polSourceSiteEffect = null;
            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");
            polSourceSiteEffect.LastUpdateContactTVItemID = 0;
            actionPolSourceSiteEffect = await PolSourceSiteEffectService.Post(polSourceSiteEffect);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceSiteEffect.Result);

            polSourceSiteEffect = null;
            polSourceSiteEffect = GetFilledRandomPolSourceSiteEffect("");
            polSourceSiteEffect.LastUpdateContactTVItemID = 1;
            actionPolSourceSiteEffect = await PolSourceSiteEffectService.Post(polSourceSiteEffect);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceSiteEffect.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDTest()
        {
            // Post PolSourceSiteEffect
            var actionPolSourceSiteEffectAdded = await PolSourceSiteEffectService.Post(polSourceSiteEffect);
            Assert.Equal(200, ((ObjectResult)actionPolSourceSiteEffectAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionPolSourceSiteEffectAdded.Result).Value);
            PolSourceSiteEffect polSourceSiteEffectAdded = (PolSourceSiteEffect)((OkObjectResult)actionPolSourceSiteEffectAdded.Result).Value;
            Assert.NotNull(polSourceSiteEffectAdded);

            // List<PolSourceSiteEffect>
            var actionPolSourceSiteEffectList = await PolSourceSiteEffectService.GetPolSourceSiteEffectList();
            Assert.Equal(200, ((ObjectResult)actionPolSourceSiteEffectList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionPolSourceSiteEffectList.Result).Value);
            List<PolSourceSiteEffect> polSourceSiteEffectList = (List<PolSourceSiteEffect>)((OkObjectResult)actionPolSourceSiteEffectList.Result).Value;

            int count = ((List<PolSourceSiteEffect>)((OkObjectResult)actionPolSourceSiteEffectList.Result).Value).Count();
            Assert.True(count > 0);

            if (LoggedInService.DBLocation == DBLocationEnum.Server)
            {
                // List<PolSourceSiteEffect> with skip and take
                var actionPolSourceSiteEffectListSkipAndTake = await PolSourceSiteEffectService.GetPolSourceSiteEffectList(1, 1);
                Assert.Equal(200, ((ObjectResult)actionPolSourceSiteEffectListSkipAndTake.Result).StatusCode);
                Assert.NotNull(((OkObjectResult)actionPolSourceSiteEffectListSkipAndTake.Result).Value);
                List<PolSourceSiteEffect> polSourceSiteEffectListSkipAndTake = (List<PolSourceSiteEffect>)((OkObjectResult)actionPolSourceSiteEffectListSkipAndTake.Result).Value;

                int countSkipAndTake = ((List<PolSourceSiteEffect>)((OkObjectResult)actionPolSourceSiteEffectListSkipAndTake.Result).Value).Count();
                Assert.True(countSkipAndTake == 1);

                Assert.False(polSourceSiteEffectList[0].PolSourceSiteEffectID == polSourceSiteEffectListSkipAndTake[0].PolSourceSiteEffectID);
            }

            // Get PolSourceSiteEffect With PolSourceSiteEffectID
            var actionPolSourceSiteEffectGet = await PolSourceSiteEffectService.GetPolSourceSiteEffectWithPolSourceSiteEffectID(polSourceSiteEffectList[0].PolSourceSiteEffectID);
            Assert.Equal(200, ((ObjectResult)actionPolSourceSiteEffectGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionPolSourceSiteEffectGet.Result).Value);
            PolSourceSiteEffect polSourceSiteEffectGet = (PolSourceSiteEffect)((OkObjectResult)actionPolSourceSiteEffectGet.Result).Value;
            Assert.NotNull(polSourceSiteEffectGet);
            Assert.Equal(polSourceSiteEffectGet.PolSourceSiteEffectID, polSourceSiteEffectList[0].PolSourceSiteEffectID);

            // Put PolSourceSiteEffect
            var actionPolSourceSiteEffectUpdated = await PolSourceSiteEffectService.Put(polSourceSiteEffect);
            Assert.Equal(200, ((ObjectResult)actionPolSourceSiteEffectUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionPolSourceSiteEffectUpdated.Result).Value);
            PolSourceSiteEffect polSourceSiteEffectUpdated = (PolSourceSiteEffect)((OkObjectResult)actionPolSourceSiteEffectUpdated.Result).Value;
            Assert.NotNull(polSourceSiteEffectUpdated);

            // Delete PolSourceSiteEffect
            var actionPolSourceSiteEffectDeleted = await PolSourceSiteEffectService.Delete(polSourceSiteEffect.PolSourceSiteEffectID);
            Assert.Equal(200, ((ObjectResult)actionPolSourceSiteEffectDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionPolSourceSiteEffectDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionPolSourceSiteEffectDeleted.Result).Value;
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
            Services.AddSingleton<IPolSourceSiteEffectService, PolSourceSiteEffectService>();

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

            PolSourceSiteEffectService = Provider.GetService<IPolSourceSiteEffectService>();
            Assert.NotNull(PolSourceSiteEffectService);

            return await Task.FromResult(true);
        }
        private PolSourceSiteEffect GetFilledRandomPolSourceSiteEffect(string OmitPropName)
        {
            List<PolSourceSiteEffect> polSourceSiteEffectListToDelete = (from c in dbLocal.PolSourceSiteEffects
                                                               select c).ToList(); 
            
            dbLocal.PolSourceSiteEffects.RemoveRange(polSourceSiteEffectListToDelete);
            try
            {
                dbLocal.SaveChanges();
            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
            
            dbIM.Database.EnsureDeleted();

            PolSourceSiteEffect polSourceSiteEffect = new PolSourceSiteEffect();

            if (OmitPropName != "PolSourceSiteOrInfrastructureTVItemID") polSourceSiteEffect.PolSourceSiteOrInfrastructureTVItemID = 41;
            if (OmitPropName != "MWQMSiteTVItemID") polSourceSiteEffect.MWQMSiteTVItemID = 44;
            if (OmitPropName != "PolSourceSiteEffectTermIDs") polSourceSiteEffect.PolSourceSiteEffectTermIDs = GetRandomString("", 5);
            if (OmitPropName != "Comments") polSourceSiteEffect.Comments = GetRandomString("", 20);
            if (OmitPropName != "AnalysisDocumentTVItemID") polSourceSiteEffect.AnalysisDocumentTVItemID = 42;
            if (OmitPropName != "LastUpdateDate_UTC") polSourceSiteEffect.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") polSourceSiteEffect.LastUpdateContactTVItemID = 2;

            if (LoggedInService.DBLocation == DBLocationEnum.Local)
            {
                if (OmitPropName != "PolSourceSiteEffectID") polSourceSiteEffect.PolSourceSiteEffectID = 10000000;

                try
                {
                    dbIM.TVItems.Add(new TVItem() { TVItemID = 41, TVLevel = 4, TVPath = "p1p5p6p39p41", TVType = (TVTypeEnum)10, ParentID = 39, IsActive = true, LastUpdateDate_UTC = new DateTime(2014, 12, 2, 21, 29, 23), LastUpdateContactTVItemID = 2});
                    dbIM.SaveChanges();
                }
                catch (Exception)
                {
                   // nothing for now
                }
                try
                {
                    dbIM.TVItems.Add(new TVItem() { TVItemID = 44, TVLevel = 6, TVPath = "p1p5p6p9p10p12p44", TVType = (TVTypeEnum)16, ParentID = 12, IsActive = true, LastUpdateDate_UTC = new DateTime(2017, 10, 12, 17, 39, 34), LastUpdateContactTVItemID = 2});
                    dbIM.SaveChanges();
                }
                catch (Exception)
                {
                   // nothing for now
                }
                try
                {
                    dbIM.TVItems.Add(new TVItem() { TVItemID = 42, TVLevel = 5, TVPath = "p1p5p6p39p41p42", TVType = (TVTypeEnum)8, ParentID = 41, IsActive = true, LastUpdateDate_UTC = new DateTime(2016, 5, 5, 17, 18, 26), LastUpdateContactTVItemID = 2});
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

            return polSourceSiteEffect;
        }
        private void CheckPolSourceSiteEffectFields(List<PolSourceSiteEffect> polSourceSiteEffectList)
        {
            if (!string.IsNullOrWhiteSpace(polSourceSiteEffectList[0].PolSourceSiteEffectTermIDs))
            {
                Assert.False(string.IsNullOrWhiteSpace(polSourceSiteEffectList[0].PolSourceSiteEffectTermIDs));
            }
            if (!string.IsNullOrWhiteSpace(polSourceSiteEffectList[0].Comments))
            {
                Assert.False(string.IsNullOrWhiteSpace(polSourceSiteEffectList[0].Comments));
            }
            if (polSourceSiteEffectList[0].AnalysisDocumentTVItemID != null)
            {
                Assert.NotNull(polSourceSiteEffectList[0].AnalysisDocumentTVItemID);
            }
        }
        #endregion Functions private
    }
}
