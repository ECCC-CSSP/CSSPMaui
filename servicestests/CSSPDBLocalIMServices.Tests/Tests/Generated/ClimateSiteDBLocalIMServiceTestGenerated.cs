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
    public partial class ClimateSiteDBLocalIMServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILocalService LocalService { get; set; }
        private IClimateSiteDBLocalIMService ClimateSiteDBLocalIMService { get; set; }
        private CSSPDBInMemoryContext dbLocalIM { get; set; }
        private ClimateSite climateSite { get; set; }
        #endregion Properties

        #region Constructors
        public ClimateSiteDBLocalIMServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated Constructor [DBLocalIM]
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task ClimateSiteDBLocalIM_Constructor_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));
        }
        #endregion Tests Generated Constructor [DBLocalIM]

        #region Tests Generated [DBLocalIM] CRUD
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task ClimateSiteDBLocalIM_CRUD_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));

            climateSite = GetFilledRandomClimateSite("");

            await DoCRUDDBLocalIMTest();
        }
        #endregion Tests Generated [DBLocalIM] CRUD

        #region Tests Generated Properties
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task ClimateSite_Properties_Test(string culture)
        {
            Assert.True(await Setup(culture));

            int count = 0;
            if (count == 1)
            {
                // just so we don't get a warning during compile [The variable 'count' is assigned but its value is never used]
            }

            var actionClimateSiteList = await ClimateSiteDBLocalIMService.GetClimateSiteList();
            Assert.Equal(200, ((ObjectResult)actionClimateSiteList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionClimateSiteList.Result).Value);
            List<ClimateSite> climateSiteList = (List<ClimateSite>)((OkObjectResult)actionClimateSiteList.Result).Value;

            count = climateSiteList.Count();

            ClimateSite climateSite = GetFilledRandomClimateSite("");


            // -----------------------------------
            // [Key]
            // Is NOT Nullable
            // climateSite.ClimateSiteID   (Int32)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.ClimateSiteID = 0;

            var actionClimateSite = await ClimateSiteDBLocalIMService.Put(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.ClimateSiteID = 10000000;
            actionClimateSite = await ClimateSiteDBLocalIMService.Put(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = ClimateSite)]
            // climateSite.ClimateSiteTVItemID   (Int32)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.ClimateSiteTVItemID = 0;
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.ClimateSiteTVItemID = 1;
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);


            // -----------------------------------
            // Is Nullable
            // [CSSPRange(1, 100000)]
            // climateSite.ECDBID   (Int32)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.ECDBID = 0;
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            //Assert.AreEqual(count, climateSiteService.GetClimateSiteList().Count());
            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.ECDBID = 100001;
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            //Assert.AreEqual(count, climateSiteDBLocalIMService.GetClimateSiteList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPMaxLength(100)]
            // climateSite.ClimateSiteName   (String)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("ClimateSiteName");
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.ClimateSiteName = GetRandomString("", 101);
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            //Assert.AreEqual(count, climateSiteDBLocalIMService.GetClimateSiteList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPMaxLength(4)]
            // climateSite.Province   (String)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("Province");
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.Province = GetRandomString("", 5);
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            //Assert.AreEqual(count, climateSiteDBLocalIMService.GetClimateSiteList().Count());

            // -----------------------------------
            // Is Nullable
            // [CSSPRange(0, 10000)]
            // climateSite.Elevation_m   (Double)
            // -----------------------------------

            //CSSPError: Type not implemented [Elevation_m]

            //CSSPError: Type not implemented [Elevation_m]

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.Elevation_m = -1.0D;
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            //Assert.AreEqual(count, climateSiteService.GetClimateSiteList().Count());
            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.Elevation_m = 10001.0D;
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            //Assert.AreEqual(count, climateSiteDBLocalIMService.GetClimateSiteList().Count());

            // -----------------------------------
            // Is Nullable
            // [CSSPMaxLength(10)]
            // climateSite.ClimateID   (String)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.ClimateID = GetRandomString("", 11);
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            //Assert.AreEqual(count, climateSiteDBLocalIMService.GetClimateSiteList().Count());

            // -----------------------------------
            // Is Nullable
            // [CSSPRange(1, 100000)]
            // climateSite.WMOID   (Int32)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.WMOID = 0;
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            //Assert.AreEqual(count, climateSiteService.GetClimateSiteList().Count());
            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.WMOID = 100001;
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            //Assert.AreEqual(count, climateSiteDBLocalIMService.GetClimateSiteList().Count());

            // -----------------------------------
            // Is Nullable
            // [CSSPMaxLength(3)]
            // climateSite.TCID   (String)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.TCID = GetRandomString("", 4);
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            //Assert.AreEqual(count, climateSiteDBLocalIMService.GetClimateSiteList().Count());

            // -----------------------------------
            // Is Nullable
            // climateSite.IsQuebecSite   (Boolean)
            // -----------------------------------


            // -----------------------------------
            // Is Nullable
            // climateSite.IsCoCoRaHS   (Boolean)
            // -----------------------------------


            // -----------------------------------
            // Is Nullable
            // [CSSPRange(-10, 0)]
            // climateSite.TimeOffset_hour   (Double)
            // -----------------------------------

            //CSSPError: Type not implemented [TimeOffset_hour]

            //CSSPError: Type not implemented [TimeOffset_hour]

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.TimeOffset_hour = -11.0D;
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            //Assert.AreEqual(count, climateSiteService.GetClimateSiteList().Count());
            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.TimeOffset_hour = 1.0D;
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            //Assert.AreEqual(count, climateSiteDBLocalIMService.GetClimateSiteList().Count());

            // -----------------------------------
            // Is Nullable
            // [CSSPMaxLength(50)]
            // climateSite.File_desc   (String)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.File_desc = GetRandomString("", 51);
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            //Assert.AreEqual(count, climateSiteDBLocalIMService.GetClimateSiteList().Count());

            // -----------------------------------
            // Is Nullable
            // [CSSPAfter(Year = 1980)]
            // climateSite.HourlyStartDate_Local   (DateTime)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.HourlyStartDate_Local = new DateTime(1979, 1, 1);
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);

            // -----------------------------------
            // Is Nullable
            // [CSSPAfter(Year = 1980)]
            // climateSite.HourlyEndDate_Local   (DateTime)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.HourlyEndDate_Local = new DateTime(1979, 1, 1);
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);

            // -----------------------------------
            // Is Nullable
            // climateSite.HourlyNow   (Boolean)
            // -----------------------------------


            // -----------------------------------
            // Is Nullable
            // [CSSPAfter(Year = 1980)]
            // climateSite.DailyStartDate_Local   (DateTime)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.DailyStartDate_Local = new DateTime(1979, 1, 1);
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);

            // -----------------------------------
            // Is Nullable
            // [CSSPAfter(Year = 1980)]
            // climateSite.DailyEndDate_Local   (DateTime)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.DailyEndDate_Local = new DateTime(1979, 1, 1);
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);

            // -----------------------------------
            // Is Nullable
            // climateSite.DailyNow   (Boolean)
            // -----------------------------------


            // -----------------------------------
            // Is Nullable
            // [CSSPAfter(Year = 1980)]
            // climateSite.MonthlyStartDate_Local   (DateTime)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.MonthlyStartDate_Local = new DateTime(1979, 1, 1);
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);

            // -----------------------------------
            // Is Nullable
            // [CSSPAfter(Year = 1980)]
            // climateSite.MonthlyEndDate_Local   (DateTime)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.MonthlyEndDate_Local = new DateTime(1979, 1, 1);
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);

            // -----------------------------------
            // Is Nullable
            // climateSite.MonthlyNow   (Boolean)
            // -----------------------------------


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // climateSite.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.LastUpdateDate_UTC = new DateTime();
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);
            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // climateSite.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.LastUpdateContactTVItemID = 0;
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);

            climateSite = null;
            climateSite = GetFilledRandomClimateSite("");
            climateSite.LastUpdateContactTVItemID = 1;
            actionClimateSite = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.IsType<BadRequestObjectResult>(actionClimateSite.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDDBLocalIMTest()
        {
            climateSite.ClimateSiteID = 10000000;

            // Post ClimateSite
            var actionClimateSiteAdded = await ClimateSiteDBLocalIMService.Post(climateSite);
            Assert.Equal(200, ((ObjectResult)actionClimateSiteAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionClimateSiteAdded.Result).Value);
            ClimateSite climateSiteAdded = (ClimateSite)((OkObjectResult)actionClimateSiteAdded.Result).Value;
            Assert.NotNull(climateSiteAdded);

            // List<ClimateSite>
            var actionClimateSiteList = await ClimateSiteDBLocalIMService.GetClimateSiteList();
            Assert.Equal(200, ((ObjectResult)actionClimateSiteList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionClimateSiteList.Result).Value);
            List<ClimateSite> climateSiteList = (List<ClimateSite>)((OkObjectResult)actionClimateSiteList.Result).Value;

            int count = ((List<ClimateSite>)((OkObjectResult)actionClimateSiteList.Result).Value).Count();
            Assert.True(count > 0);

            // Get ClimateSite With ClimateSiteID
            var actionClimateSiteGet = await ClimateSiteDBLocalIMService.GetClimateSiteWithClimateSiteID(climateSiteList[0].ClimateSiteID);
            Assert.Equal(200, ((ObjectResult)actionClimateSiteGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionClimateSiteGet.Result).Value);
            ClimateSite climateSiteGet = (ClimateSite)((OkObjectResult)actionClimateSiteGet.Result).Value;
            Assert.NotNull(climateSiteGet);
            Assert.Equal(climateSiteGet.ClimateSiteID, climateSiteList[0].ClimateSiteID);

            // Put ClimateSite
            var actionClimateSiteUpdated = await ClimateSiteDBLocalIMService.Put(climateSite);
            Assert.Equal(200, ((ObjectResult)actionClimateSiteUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionClimateSiteUpdated.Result).Value);
            ClimateSite climateSiteUpdated = (ClimateSite)((OkObjectResult)actionClimateSiteUpdated.Result).Value;
            Assert.NotNull(climateSiteUpdated);

            // Delete ClimateSite
            var actionClimateSiteDeleted = await ClimateSiteDBLocalIMService.Delete(climateSite.ClimateSiteID);
            Assert.Equal(200, ((ObjectResult)actionClimateSiteDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionClimateSiteDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionClimateSiteDeleted.Result).Value;
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
            Services.AddSingleton<IClimateSiteDBLocalIMService, ClimateSiteDBLocalIMService>();

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

            ClimateSiteDBLocalIMService = Provider.GetService<IClimateSiteDBLocalIMService>();
            Assert.NotNull(ClimateSiteDBLocalIMService);

            return await Task.FromResult(true);
        }
        private ClimateSite GetFilledRandomClimateSite(string OmitPropName)
        {
            ClimateSite climateSite = new ClimateSite();

            if (OmitPropName != "ClimateSiteTVItemID") climateSite.ClimateSiteTVItemID = 7;
            if (OmitPropName != "ECDBID") climateSite.ECDBID = GetRandomInt(1, 100000);
            if (OmitPropName != "ClimateSiteName") climateSite.ClimateSiteName = GetRandomString("", 5);
            if (OmitPropName != "Province") climateSite.Province = GetRandomString("", 4);
            if (OmitPropName != "Elevation_m") climateSite.Elevation_m = GetRandomDouble(0.0D, 10000.0D);
            if (OmitPropName != "ClimateID") climateSite.ClimateID = GetRandomString("", 5);
            if (OmitPropName != "WMOID") climateSite.WMOID = GetRandomInt(1, 100000);
            if (OmitPropName != "TCID") climateSite.TCID = GetRandomString("", 3);
            if (OmitPropName != "IsQuebecSite") climateSite.IsQuebecSite = true;
            if (OmitPropName != "IsCoCoRaHS") climateSite.IsCoCoRaHS = true;
            if (OmitPropName != "TimeOffset_hour") climateSite.TimeOffset_hour = GetRandomDouble(-10.0D, 0.0D);
            if (OmitPropName != "File_desc") climateSite.File_desc = GetRandomString("", 5);
            if (OmitPropName != "HourlyStartDate_Local") climateSite.HourlyStartDate_Local = new DateTime(2005, 3, 6);
            if (OmitPropName != "HourlyEndDate_Local") climateSite.HourlyEndDate_Local = new DateTime(2005, 3, 7);
            if (OmitPropName != "HourlyNow") climateSite.HourlyNow = true;
            if (OmitPropName != "DailyStartDate_Local") climateSite.DailyStartDate_Local = new DateTime(2005, 3, 6);
            if (OmitPropName != "DailyEndDate_Local") climateSite.DailyEndDate_Local = new DateTime(2005, 3, 7);
            if (OmitPropName != "DailyNow") climateSite.DailyNow = true;
            if (OmitPropName != "MonthlyStartDate_Local") climateSite.MonthlyStartDate_Local = new DateTime(2005, 3, 6);
            if (OmitPropName != "MonthlyEndDate_Local") climateSite.MonthlyEndDate_Local = new DateTime(2005, 3, 7);
            if (OmitPropName != "MonthlyNow") climateSite.MonthlyNow = true;
            if (OmitPropName != "LastUpdateDate_UTC") climateSite.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") climateSite.LastUpdateContactTVItemID = 2;

            try
            {
                dbLocalIM.TVItems.Add(new TVItem() { TVItemID = 7, TVLevel = 3, TVPath = "p1p5p6p7", TVType = (TVTypeEnum)4, ParentID = 6, IsActive = true, LastUpdateDate_UTC = new DateTime(2015, 6, 18, 14, 40, 7), LastUpdateContactTVItemID = 2 });
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


            return climateSite;
        }
        private void CheckClimateSiteFields(List<ClimateSite> climateSiteList)
        {
            if (climateSiteList[0].ECDBID != null)
            {
                Assert.NotNull(climateSiteList[0].ECDBID);
            }
            Assert.False(string.IsNullOrWhiteSpace(climateSiteList[0].ClimateSiteName));
            Assert.False(string.IsNullOrWhiteSpace(climateSiteList[0].Province));
            if (climateSiteList[0].Elevation_m != null)
            {
                Assert.NotNull(climateSiteList[0].Elevation_m);
            }
            if (!string.IsNullOrWhiteSpace(climateSiteList[0].ClimateID))
            {
                Assert.False(string.IsNullOrWhiteSpace(climateSiteList[0].ClimateID));
            }
            if (climateSiteList[0].WMOID != null)
            {
                Assert.NotNull(climateSiteList[0].WMOID);
            }
            if (!string.IsNullOrWhiteSpace(climateSiteList[0].TCID))
            {
                Assert.False(string.IsNullOrWhiteSpace(climateSiteList[0].TCID));
            }
            if (climateSiteList[0].IsQuebecSite != null)
            {
                Assert.NotNull(climateSiteList[0].IsQuebecSite);
            }
            if (climateSiteList[0].IsCoCoRaHS != null)
            {
                Assert.NotNull(climateSiteList[0].IsCoCoRaHS);
            }
            if (climateSiteList[0].TimeOffset_hour != null)
            {
                Assert.NotNull(climateSiteList[0].TimeOffset_hour);
            }
            if (!string.IsNullOrWhiteSpace(climateSiteList[0].File_desc))
            {
                Assert.False(string.IsNullOrWhiteSpace(climateSiteList[0].File_desc));
            }
            if (climateSiteList[0].HourlyStartDate_Local != null)
            {
                Assert.NotNull(climateSiteList[0].HourlyStartDate_Local);
            }
            if (climateSiteList[0].HourlyEndDate_Local != null)
            {
                Assert.NotNull(climateSiteList[0].HourlyEndDate_Local);
            }
            if (climateSiteList[0].HourlyNow != null)
            {
                Assert.NotNull(climateSiteList[0].HourlyNow);
            }
            if (climateSiteList[0].DailyStartDate_Local != null)
            {
                Assert.NotNull(climateSiteList[0].DailyStartDate_Local);
            }
            if (climateSiteList[0].DailyEndDate_Local != null)
            {
                Assert.NotNull(climateSiteList[0].DailyEndDate_Local);
            }
            if (climateSiteList[0].DailyNow != null)
            {
                Assert.NotNull(climateSiteList[0].DailyNow);
            }
            if (climateSiteList[0].MonthlyStartDate_Local != null)
            {
                Assert.NotNull(climateSiteList[0].MonthlyStartDate_Local);
            }
            if (climateSiteList[0].MonthlyEndDate_Local != null)
            {
                Assert.NotNull(climateSiteList[0].MonthlyEndDate_Local);
            }
            if (climateSiteList[0].MonthlyNow != null)
            {
                Assert.NotNull(climateSiteList[0].MonthlyNow);
            }
        }

        #endregion Functions private
    }
}
