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
    public partial class MWQMSiteStartEndDateDBLocalIMServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILocalService LocalService { get; set; }
        private IMWQMSiteStartEndDateDBLocalIMService MWQMSiteStartEndDateDBLocalIMService { get; set; }
        private CSSPDBInMemoryContext dbLocalIM { get; set; }
        private MWQMSiteStartEndDate mwqmSiteStartEndDate { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSiteStartEndDateDBLocalIMServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated Constructor [DBLocalIM]
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task MWQMSiteStartEndDateDBLocalIM_Constructor_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));
        }
        #endregion Tests Generated Constructor [DBLocalIM]

        #region Tests Generated [DBLocalIM] CRUD
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task MWQMSiteStartEndDateDBLocalIM_CRUD_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));

            mwqmSiteStartEndDate = GetFilledRandomMWQMSiteStartEndDate("");

            await DoCRUDDBLocalIMTest();
        }
        #endregion Tests Generated [DBLocalIM] CRUD

        #region Tests Generated Properties
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task MWQMSiteStartEndDate_Properties_Test(string culture)
        {
            Assert.True(await Setup(culture));

            int count = 0;
            if (count == 1)
            {
                // just so we don't get a warning during compile [The variable 'count' is assigned but its value is never used]
            }

            var actionMWQMSiteStartEndDateList = await MWQMSiteStartEndDateDBLocalIMService.GetMWQMSiteStartEndDateList();
            Assert.Equal(200, ((ObjectResult)actionMWQMSiteStartEndDateList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionMWQMSiteStartEndDateList.Result).Value);
            List<MWQMSiteStartEndDate> mwqmSiteStartEndDateList = (List<MWQMSiteStartEndDate>)((OkObjectResult)actionMWQMSiteStartEndDateList.Result).Value;

            count = mwqmSiteStartEndDateList.Count();

            MWQMSiteStartEndDate mwqmSiteStartEndDate = GetFilledRandomMWQMSiteStartEndDate("");


            // -----------------------------------
            // [Key]
            // Is NOT Nullable
            // mwqmSiteStartEndDate.MWQMSiteStartEndDateID   (Int32)
            // -----------------------------------

            mwqmSiteStartEndDate = null;
            mwqmSiteStartEndDate = GetFilledRandomMWQMSiteStartEndDate("");
            mwqmSiteStartEndDate.MWQMSiteStartEndDateID = 0;

            var actionMWQMSiteStartEndDate = await MWQMSiteStartEndDateDBLocalIMService.Put(mwqmSiteStartEndDate);
            Assert.IsType<BadRequestObjectResult>(actionMWQMSiteStartEndDate.Result);

            mwqmSiteStartEndDate = null;
            mwqmSiteStartEndDate = GetFilledRandomMWQMSiteStartEndDate("");
            mwqmSiteStartEndDate.MWQMSiteStartEndDateID = 10000000;
            actionMWQMSiteStartEndDate = await MWQMSiteStartEndDateDBLocalIMService.Put(mwqmSiteStartEndDate);
            Assert.IsType<BadRequestObjectResult>(actionMWQMSiteStartEndDate.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = MWQMSite)]
            // mwqmSiteStartEndDate.MWQMSiteTVItemID   (Int32)
            // -----------------------------------

            mwqmSiteStartEndDate = null;
            mwqmSiteStartEndDate = GetFilledRandomMWQMSiteStartEndDate("");
            mwqmSiteStartEndDate.MWQMSiteTVItemID = 0;
            actionMWQMSiteStartEndDate = await MWQMSiteStartEndDateDBLocalIMService.Post(mwqmSiteStartEndDate);
            Assert.IsType<BadRequestObjectResult>(actionMWQMSiteStartEndDate.Result);

            mwqmSiteStartEndDate = null;
            mwqmSiteStartEndDate = GetFilledRandomMWQMSiteStartEndDate("");
            mwqmSiteStartEndDate.MWQMSiteTVItemID = 1;
            actionMWQMSiteStartEndDate = await MWQMSiteStartEndDateDBLocalIMService.Post(mwqmSiteStartEndDate);
            Assert.IsType<BadRequestObjectResult>(actionMWQMSiteStartEndDate.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // mwqmSiteStartEndDate.StartDate   (DateTime)
            // -----------------------------------

            mwqmSiteStartEndDate = null;
            mwqmSiteStartEndDate = GetFilledRandomMWQMSiteStartEndDate("");
            mwqmSiteStartEndDate.StartDate = new DateTime();
            actionMWQMSiteStartEndDate = await MWQMSiteStartEndDateDBLocalIMService.Post(mwqmSiteStartEndDate);
            Assert.IsType<BadRequestObjectResult>(actionMWQMSiteStartEndDate.Result);
            mwqmSiteStartEndDate = null;
            mwqmSiteStartEndDate = GetFilledRandomMWQMSiteStartEndDate("");
            mwqmSiteStartEndDate.StartDate = new DateTime(1979, 1, 1);
            actionMWQMSiteStartEndDate = await MWQMSiteStartEndDateDBLocalIMService.Post(mwqmSiteStartEndDate);
            Assert.IsType<BadRequestObjectResult>(actionMWQMSiteStartEndDate.Result);

            // -----------------------------------
            // Is Nullable
            // [CSSPAfter(Year = 1980)]
            // [CSSPBigger(OtherField = StartDate)]
            // mwqmSiteStartEndDate.EndDate   (DateTime)
            // -----------------------------------

            mwqmSiteStartEndDate = null;
            mwqmSiteStartEndDate = GetFilledRandomMWQMSiteStartEndDate("");
            mwqmSiteStartEndDate.EndDate = new DateTime(1979, 1, 1);
            actionMWQMSiteStartEndDate = await MWQMSiteStartEndDateDBLocalIMService.Post(mwqmSiteStartEndDate);
            Assert.IsType<BadRequestObjectResult>(actionMWQMSiteStartEndDate.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // mwqmSiteStartEndDate.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            mwqmSiteStartEndDate = null;
            mwqmSiteStartEndDate = GetFilledRandomMWQMSiteStartEndDate("");
            mwqmSiteStartEndDate.LastUpdateDate_UTC = new DateTime();
            actionMWQMSiteStartEndDate = await MWQMSiteStartEndDateDBLocalIMService.Post(mwqmSiteStartEndDate);
            Assert.IsType<BadRequestObjectResult>(actionMWQMSiteStartEndDate.Result);
            mwqmSiteStartEndDate = null;
            mwqmSiteStartEndDate = GetFilledRandomMWQMSiteStartEndDate("");
            mwqmSiteStartEndDate.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionMWQMSiteStartEndDate = await MWQMSiteStartEndDateDBLocalIMService.Post(mwqmSiteStartEndDate);
            Assert.IsType<BadRequestObjectResult>(actionMWQMSiteStartEndDate.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // mwqmSiteStartEndDate.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            mwqmSiteStartEndDate = null;
            mwqmSiteStartEndDate = GetFilledRandomMWQMSiteStartEndDate("");
            mwqmSiteStartEndDate.LastUpdateContactTVItemID = 0;
            actionMWQMSiteStartEndDate = await MWQMSiteStartEndDateDBLocalIMService.Post(mwqmSiteStartEndDate);
            Assert.IsType<BadRequestObjectResult>(actionMWQMSiteStartEndDate.Result);

            mwqmSiteStartEndDate = null;
            mwqmSiteStartEndDate = GetFilledRandomMWQMSiteStartEndDate("");
            mwqmSiteStartEndDate.LastUpdateContactTVItemID = 1;
            actionMWQMSiteStartEndDate = await MWQMSiteStartEndDateDBLocalIMService.Post(mwqmSiteStartEndDate);
            Assert.IsType<BadRequestObjectResult>(actionMWQMSiteStartEndDate.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDDBLocalIMTest()
        {
            mwqmSiteStartEndDate.MWQMSiteStartEndDateID = 10000000;

            // Post MWQMSiteStartEndDate
            var actionMWQMSiteStartEndDateAdded = await MWQMSiteStartEndDateDBLocalIMService.Post(mwqmSiteStartEndDate);
            Assert.Equal(200, ((ObjectResult)actionMWQMSiteStartEndDateAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionMWQMSiteStartEndDateAdded.Result).Value);
            MWQMSiteStartEndDate mwqmSiteStartEndDateAdded = (MWQMSiteStartEndDate)((OkObjectResult)actionMWQMSiteStartEndDateAdded.Result).Value;
            Assert.NotNull(mwqmSiteStartEndDateAdded);

            // List<MWQMSiteStartEndDate>
            var actionMWQMSiteStartEndDateList = await MWQMSiteStartEndDateDBLocalIMService.GetMWQMSiteStartEndDateList();
            Assert.Equal(200, ((ObjectResult)actionMWQMSiteStartEndDateList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionMWQMSiteStartEndDateList.Result).Value);
            List<MWQMSiteStartEndDate> mwqmSiteStartEndDateList = (List<MWQMSiteStartEndDate>)((OkObjectResult)actionMWQMSiteStartEndDateList.Result).Value;

            int count = ((List<MWQMSiteStartEndDate>)((OkObjectResult)actionMWQMSiteStartEndDateList.Result).Value).Count();
            Assert.True(count > 0);

            // Get MWQMSiteStartEndDate With MWQMSiteStartEndDateID
            var actionMWQMSiteStartEndDateGet = await MWQMSiteStartEndDateDBLocalIMService.GetMWQMSiteStartEndDateWithMWQMSiteStartEndDateID(mwqmSiteStartEndDateList[0].MWQMSiteStartEndDateID);
            Assert.Equal(200, ((ObjectResult)actionMWQMSiteStartEndDateGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionMWQMSiteStartEndDateGet.Result).Value);
            MWQMSiteStartEndDate mwqmSiteStartEndDateGet = (MWQMSiteStartEndDate)((OkObjectResult)actionMWQMSiteStartEndDateGet.Result).Value;
            Assert.NotNull(mwqmSiteStartEndDateGet);
            Assert.Equal(mwqmSiteStartEndDateGet.MWQMSiteStartEndDateID, mwqmSiteStartEndDateList[0].MWQMSiteStartEndDateID);

            // Put MWQMSiteStartEndDate
            var actionMWQMSiteStartEndDateUpdated = await MWQMSiteStartEndDateDBLocalIMService.Put(mwqmSiteStartEndDate);
            Assert.Equal(200, ((ObjectResult)actionMWQMSiteStartEndDateUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionMWQMSiteStartEndDateUpdated.Result).Value);
            MWQMSiteStartEndDate mwqmSiteStartEndDateUpdated = (MWQMSiteStartEndDate)((OkObjectResult)actionMWQMSiteStartEndDateUpdated.Result).Value;
            Assert.NotNull(mwqmSiteStartEndDateUpdated);

            // Delete MWQMSiteStartEndDate
            var actionMWQMSiteStartEndDateDeleted = await MWQMSiteStartEndDateDBLocalIMService.Delete(mwqmSiteStartEndDate.MWQMSiteStartEndDateID);
            Assert.Equal(200, ((ObjectResult)actionMWQMSiteStartEndDateDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionMWQMSiteStartEndDateDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionMWQMSiteStartEndDateDeleted.Result).Value;
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
            Services.AddSingleton<IMWQMSiteStartEndDateDBLocalIMService, MWQMSiteStartEndDateDBLocalIMService>();

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

            MWQMSiteStartEndDateDBLocalIMService = Provider.GetService<IMWQMSiteStartEndDateDBLocalIMService>();
            Assert.NotNull(MWQMSiteStartEndDateDBLocalIMService);

            return await Task.FromResult(true);
        }
        private MWQMSiteStartEndDate GetFilledRandomMWQMSiteStartEndDate(string OmitPropName)
        {
            MWQMSiteStartEndDate mwqmSiteStartEndDate = new MWQMSiteStartEndDate();

            if (OmitPropName != "MWQMSiteTVItemID") mwqmSiteStartEndDate.MWQMSiteTVItemID = 44;
            if (OmitPropName != "StartDate") mwqmSiteStartEndDate.StartDate = new DateTime(2005, 3, 6);
            if (OmitPropName != "EndDate") mwqmSiteStartEndDate.EndDate = new DateTime(2005, 3, 7);
            if (OmitPropName != "LastUpdateDate_UTC") mwqmSiteStartEndDate.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") mwqmSiteStartEndDate.LastUpdateContactTVItemID = 2;

            try
            {
                dbLocalIM.TVItems.Add(new TVItem() { TVItemID = 44, TVLevel = 6, TVPath = "p1p5p6p9p10p12p44", TVType = (TVTypeEnum)16, ParentID = 12, IsActive = true, LastUpdateDate_UTC = new DateTime(2017, 10, 12, 17, 39, 34), LastUpdateContactTVItemID = 2 });
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


            return mwqmSiteStartEndDate;
        }
        private void CheckMWQMSiteStartEndDateFields(List<MWQMSiteStartEndDate> mwqmSiteStartEndDateList)
        {
            if (mwqmSiteStartEndDateList[0].EndDate != null)
            {
                Assert.NotNull(mwqmSiteStartEndDateList[0].EndDate);
            }
        }

        #endregion Functions private
    }
}
