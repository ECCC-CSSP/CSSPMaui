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
    public partial class DrogueRunDBLocalIMServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILocalService LocalService { get; set; }
        private IDrogueRunDBLocalIMService DrogueRunDBLocalIMService { get; set; }
        private CSSPDBInMemoryContext dbLocalIM { get; set; }
        private DrogueRun drogueRun { get; set; }
        #endregion Properties

        #region Constructors
        public DrogueRunDBLocalIMServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated Constructor [DBLocalIM]
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task DrogueRunDBLocalIM_Constructor_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));
        }
        #endregion Tests Generated Constructor [DBLocalIM]

        #region Tests Generated [DBLocalIM] CRUD
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task DrogueRunDBLocalIM_CRUD_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));

            drogueRun = GetFilledRandomDrogueRun("");

            await DoCRUDDBLocalIMTest();
        }
        #endregion Tests Generated [DBLocalIM] CRUD

        #region Tests Generated Properties
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task DrogueRun_Properties_Test(string culture)
        {
            Assert.True(await Setup(culture));

            int count = 0;
            if (count == 1)
            {
                // just so we don't get a warning during compile [The variable 'count' is assigned but its value is never used]
            }

            var actionDrogueRunList = await DrogueRunDBLocalIMService.GetDrogueRunList();
            Assert.Equal(200, ((ObjectResult)actionDrogueRunList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionDrogueRunList.Result).Value);
            List<DrogueRun> drogueRunList = (List<DrogueRun>)((OkObjectResult)actionDrogueRunList.Result).Value;

            count = drogueRunList.Count();

            DrogueRun drogueRun = GetFilledRandomDrogueRun("");


            // -----------------------------------
            // [Key]
            // Is NOT Nullable
            // drogueRun.DrogueRunID   (Int32)
            // -----------------------------------

            drogueRun = null;
            drogueRun = GetFilledRandomDrogueRun("");
            drogueRun.DrogueRunID = 0;

            var actionDrogueRun = await DrogueRunDBLocalIMService.Put(drogueRun);
            Assert.IsType<BadRequestObjectResult>(actionDrogueRun.Result);

            drogueRun = null;
            drogueRun = GetFilledRandomDrogueRun("");
            drogueRun.DrogueRunID = 10000000;
            actionDrogueRun = await DrogueRunDBLocalIMService.Put(drogueRun);
            Assert.IsType<BadRequestObjectResult>(actionDrogueRun.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Subsector)]
            // drogueRun.SubsectorTVItemID   (Int32)
            // -----------------------------------

            drogueRun = null;
            drogueRun = GetFilledRandomDrogueRun("");
            drogueRun.SubsectorTVItemID = 0;
            actionDrogueRun = await DrogueRunDBLocalIMService.Post(drogueRun);
            Assert.IsType<BadRequestObjectResult>(actionDrogueRun.Result);

            drogueRun = null;
            drogueRun = GetFilledRandomDrogueRun("");
            drogueRun.SubsectorTVItemID = 1;
            actionDrogueRun = await DrogueRunDBLocalIMService.Post(drogueRun);
            Assert.IsType<BadRequestObjectResult>(actionDrogueRun.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPRange(0, 100)]
            // drogueRun.DrogueNumber   (Int32)
            // -----------------------------------

            drogueRun = null;
            drogueRun = GetFilledRandomDrogueRun("");
            drogueRun.DrogueNumber = -1;
            actionDrogueRun = await DrogueRunDBLocalIMService.Post(drogueRun);
            Assert.IsType<BadRequestObjectResult>(actionDrogueRun.Result);
            //Assert.AreEqual(count, drogueRunService.GetDrogueRunList().Count());
            drogueRun = null;
            drogueRun = GetFilledRandomDrogueRun("");
            drogueRun.DrogueNumber = 101;
            actionDrogueRun = await DrogueRunDBLocalIMService.Post(drogueRun);
            Assert.IsType<BadRequestObjectResult>(actionDrogueRun.Result);
            //Assert.AreEqual(count, drogueRunDBLocalIMService.GetDrogueRunList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // drogueRun.DrogueType   (DrogueTypeEnum)
            // -----------------------------------

            drogueRun = null;
            drogueRun = GetFilledRandomDrogueRun("");
            drogueRun.DrogueType = (DrogueTypeEnum)1000000;
            actionDrogueRun = await DrogueRunDBLocalIMService.Post(drogueRun);
            Assert.IsType<BadRequestObjectResult>(actionDrogueRun.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // drogueRun.RunStartDateTime   (DateTime)
            // -----------------------------------

            drogueRun = null;
            drogueRun = GetFilledRandomDrogueRun("");
            drogueRun.RunStartDateTime = new DateTime();
            actionDrogueRun = await DrogueRunDBLocalIMService.Post(drogueRun);
            Assert.IsType<BadRequestObjectResult>(actionDrogueRun.Result);
            drogueRun = null;
            drogueRun = GetFilledRandomDrogueRun("");
            drogueRun.RunStartDateTime = new DateTime(1979, 1, 1);
            actionDrogueRun = await DrogueRunDBLocalIMService.Post(drogueRun);
            Assert.IsType<BadRequestObjectResult>(actionDrogueRun.Result);

            // -----------------------------------
            // Is NOT Nullable
            // drogueRun.IsRisingTide   (Boolean)
            // -----------------------------------


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // drogueRun.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            drogueRun = null;
            drogueRun = GetFilledRandomDrogueRun("");
            drogueRun.LastUpdateDate_UTC = new DateTime();
            actionDrogueRun = await DrogueRunDBLocalIMService.Post(drogueRun);
            Assert.IsType<BadRequestObjectResult>(actionDrogueRun.Result);
            drogueRun = null;
            drogueRun = GetFilledRandomDrogueRun("");
            drogueRun.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionDrogueRun = await DrogueRunDBLocalIMService.Post(drogueRun);
            Assert.IsType<BadRequestObjectResult>(actionDrogueRun.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // drogueRun.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            drogueRun = null;
            drogueRun = GetFilledRandomDrogueRun("");
            drogueRun.LastUpdateContactTVItemID = 0;
            actionDrogueRun = await DrogueRunDBLocalIMService.Post(drogueRun);
            Assert.IsType<BadRequestObjectResult>(actionDrogueRun.Result);

            drogueRun = null;
            drogueRun = GetFilledRandomDrogueRun("");
            drogueRun.LastUpdateContactTVItemID = 1;
            actionDrogueRun = await DrogueRunDBLocalIMService.Post(drogueRun);
            Assert.IsType<BadRequestObjectResult>(actionDrogueRun.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDDBLocalIMTest()
        {
            drogueRun.DrogueRunID = 10000000;

            // Post DrogueRun
            var actionDrogueRunAdded = await DrogueRunDBLocalIMService.Post(drogueRun);
            Assert.Equal(200, ((ObjectResult)actionDrogueRunAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionDrogueRunAdded.Result).Value);
            DrogueRun drogueRunAdded = (DrogueRun)((OkObjectResult)actionDrogueRunAdded.Result).Value;
            Assert.NotNull(drogueRunAdded);

            // List<DrogueRun>
            var actionDrogueRunList = await DrogueRunDBLocalIMService.GetDrogueRunList();
            Assert.Equal(200, ((ObjectResult)actionDrogueRunList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionDrogueRunList.Result).Value);
            List<DrogueRun> drogueRunList = (List<DrogueRun>)((OkObjectResult)actionDrogueRunList.Result).Value;

            int count = ((List<DrogueRun>)((OkObjectResult)actionDrogueRunList.Result).Value).Count();
            Assert.True(count > 0);

            // Get DrogueRun With DrogueRunID
            var actionDrogueRunGet = await DrogueRunDBLocalIMService.GetDrogueRunWithDrogueRunID(drogueRunList[0].DrogueRunID);
            Assert.Equal(200, ((ObjectResult)actionDrogueRunGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionDrogueRunGet.Result).Value);
            DrogueRun drogueRunGet = (DrogueRun)((OkObjectResult)actionDrogueRunGet.Result).Value;
            Assert.NotNull(drogueRunGet);
            Assert.Equal(drogueRunGet.DrogueRunID, drogueRunList[0].DrogueRunID);

            // Put DrogueRun
            var actionDrogueRunUpdated = await DrogueRunDBLocalIMService.Put(drogueRun);
            Assert.Equal(200, ((ObjectResult)actionDrogueRunUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionDrogueRunUpdated.Result).Value);
            DrogueRun drogueRunUpdated = (DrogueRun)((OkObjectResult)actionDrogueRunUpdated.Result).Value;
            Assert.NotNull(drogueRunUpdated);

            // Delete DrogueRun
            var actionDrogueRunDeleted = await DrogueRunDBLocalIMService.Delete(drogueRun.DrogueRunID);
            Assert.Equal(200, ((ObjectResult)actionDrogueRunDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionDrogueRunDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionDrogueRunDeleted.Result).Value;
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
            Services.AddSingleton<IDrogueRunDBLocalIMService, DrogueRunDBLocalIMService>();

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

            DrogueRunDBLocalIMService = Provider.GetService<IDrogueRunDBLocalIMService>();
            Assert.NotNull(DrogueRunDBLocalIMService);

            return await Task.FromResult(true);
        }
        private DrogueRun GetFilledRandomDrogueRun(string OmitPropName)
        {
            DrogueRun drogueRun = new DrogueRun();

            if (OmitPropName != "SubsectorTVItemID") drogueRun.SubsectorTVItemID = 11;
            if (OmitPropName != "DrogueNumber") drogueRun.DrogueNumber = GetRandomInt(0, 100);
            if (OmitPropName != "DrogueType") drogueRun.DrogueType = (DrogueTypeEnum)GetRandomEnumType(typeof(DrogueTypeEnum));
            if (OmitPropName != "RunStartDateTime") drogueRun.RunStartDateTime = new DateTime(2005, 3, 6);
            if (OmitPropName != "IsRisingTide") drogueRun.IsRisingTide = true;
            if (OmitPropName != "LastUpdateDate_UTC") drogueRun.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") drogueRun.LastUpdateContactTVItemID = 2;

            try
            {
                dbLocalIM.TVItems.Add(new TVItem() { TVItemID = 11, TVLevel = 5, TVPath = "p1p5p6p9p10p11", TVType = (TVTypeEnum)20, ParentID = 10, IsActive = true, LastUpdateDate_UTC = new DateTime(2014, 12, 2, 18, 53, 40), LastUpdateContactTVItemID = 2 });
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


            return drogueRun;
        }
        private void CheckDrogueRunFields(List<DrogueRun> drogueRunList)
        {
        }

        #endregion Functions private
    }
}
