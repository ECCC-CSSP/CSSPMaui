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
    public partial class TideDataValueDBLocalIMServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILocalService LocalService { get; set; }
        private ITideDataValueDBLocalIMService TideDataValueDBLocalIMService { get; set; }
        private CSSPDBInMemoryContext dbLocalIM { get; set; }
        private TideDataValue tideDataValue { get; set; }
        #endregion Properties

        #region Constructors
        public TideDataValueDBLocalIMServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated Constructor [DBLocalIM]
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task TideDataValueDBLocalIM_Constructor_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));
        }
        #endregion Tests Generated Constructor [DBLocalIM]

        #region Tests Generated [DBLocalIM] CRUD
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task TideDataValueDBLocalIM_CRUD_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));

            tideDataValue = GetFilledRandomTideDataValue("");

            await DoCRUDDBLocalIMTest();
        }
        #endregion Tests Generated [DBLocalIM] CRUD

        #region Tests Generated Properties
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task TideDataValue_Properties_Test(string culture)
        {
            Assert.True(await Setup(culture));

            int count = 0;
            if (count == 1)
            {
                // just so we don't get a warning during compile [The variable 'count' is assigned but its value is never used]
            }

            var actionTideDataValueList = await TideDataValueDBLocalIMService.GetTideDataValueList();
            Assert.Equal(200, ((ObjectResult)actionTideDataValueList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTideDataValueList.Result).Value);
            List<TideDataValue> tideDataValueList = (List<TideDataValue>)((OkObjectResult)actionTideDataValueList.Result).Value;

            count = tideDataValueList.Count();

            TideDataValue tideDataValue = GetFilledRandomTideDataValue("");


            // -----------------------------------
            // [Key]
            // Is NOT Nullable
            // tideDataValue.TideDataValueID   (Int32)
            // -----------------------------------

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.TideDataValueID = 0;

            var actionTideDataValue = await TideDataValueDBLocalIMService.Put(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.TideDataValueID = 10000000;
            actionTideDataValue = await TideDataValueDBLocalIMService.Put(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = TideSite)]
            // tideDataValue.TideSiteTVItemID   (Int32)
            // -----------------------------------

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.TideSiteTVItemID = 0;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.TideSiteTVItemID = 1;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // tideDataValue.DateTime_Local   (DateTime)
            // -----------------------------------

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.DateTime_Local = new DateTime();
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);
            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.DateTime_Local = new DateTime(1979, 1, 1);
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);

            // -----------------------------------
            // Is NOT Nullable
            // tideDataValue.Keep   (Boolean)
            // -----------------------------------


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // tideDataValue.TideDataType   (TideDataTypeEnum)
            // -----------------------------------

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.TideDataType = (TideDataTypeEnum)1000000;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // tideDataValue.StorageDataType   (StorageDataTypeEnum)
            // -----------------------------------

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.StorageDataType = (StorageDataTypeEnum)1000000;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPRange(0, 10000)]
            // tideDataValue.Depth_m   (Double)
            // -----------------------------------

            //CSSPError: Type not implemented [Depth_m]

            //CSSPError: Type not implemented [Depth_m]

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.Depth_m = -1.0D;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);
            //Assert.AreEqual(count, tideDataValueService.GetTideDataValueList().Count());
            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.Depth_m = 10001.0D;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);
            //Assert.AreEqual(count, tideDataValueDBLocalIMService.GetTideDataValueList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPRange(0, 10)]
            // tideDataValue.UVelocity_m_s   (Double)
            // -----------------------------------

            //CSSPError: Type not implemented [UVelocity_m_s]

            //CSSPError: Type not implemented [UVelocity_m_s]

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.UVelocity_m_s = -1.0D;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);
            //Assert.AreEqual(count, tideDataValueService.GetTideDataValueList().Count());
            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.UVelocity_m_s = 11.0D;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);
            //Assert.AreEqual(count, tideDataValueDBLocalIMService.GetTideDataValueList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPRange(0, 10)]
            // tideDataValue.VVelocity_m_s   (Double)
            // -----------------------------------

            //CSSPError: Type not implemented [VVelocity_m_s]

            //CSSPError: Type not implemented [VVelocity_m_s]

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.VVelocity_m_s = -1.0D;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);
            //Assert.AreEqual(count, tideDataValueService.GetTideDataValueList().Count());
            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.VVelocity_m_s = 11.0D;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);
            //Assert.AreEqual(count, tideDataValueDBLocalIMService.GetTideDataValueList().Count());

            // -----------------------------------
            // Is Nullable
            // [CSSPEnumType]
            // tideDataValue.TideStart   (TideTextEnum)
            // -----------------------------------

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.TideStart = (TideTextEnum)1000000;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);


            // -----------------------------------
            // Is Nullable
            // [CSSPEnumType]
            // tideDataValue.TideEnd   (TideTextEnum)
            // -----------------------------------

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.TideEnd = (TideTextEnum)1000000;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // tideDataValue.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.LastUpdateDate_UTC = new DateTime();
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);
            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // tideDataValue.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.LastUpdateContactTVItemID = 0;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);

            tideDataValue = null;
            tideDataValue = GetFilledRandomTideDataValue("");
            tideDataValue.LastUpdateContactTVItemID = 1;
            actionTideDataValue = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.IsType<BadRequestObjectResult>(actionTideDataValue.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDDBLocalIMTest()
        {
            tideDataValue.TideDataValueID = 10000000;

            // Post TideDataValue
            var actionTideDataValueAdded = await TideDataValueDBLocalIMService.Post(tideDataValue);
            Assert.Equal(200, ((ObjectResult)actionTideDataValueAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTideDataValueAdded.Result).Value);
            TideDataValue tideDataValueAdded = (TideDataValue)((OkObjectResult)actionTideDataValueAdded.Result).Value;
            Assert.NotNull(tideDataValueAdded);

            // List<TideDataValue>
            var actionTideDataValueList = await TideDataValueDBLocalIMService.GetTideDataValueList();
            Assert.Equal(200, ((ObjectResult)actionTideDataValueList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTideDataValueList.Result).Value);
            List<TideDataValue> tideDataValueList = (List<TideDataValue>)((OkObjectResult)actionTideDataValueList.Result).Value;

            int count = ((List<TideDataValue>)((OkObjectResult)actionTideDataValueList.Result).Value).Count();
            Assert.True(count > 0);

            // Get TideDataValue With TideDataValueID
            var actionTideDataValueGet = await TideDataValueDBLocalIMService.GetTideDataValueWithTideDataValueID(tideDataValueList[0].TideDataValueID);
            Assert.Equal(200, ((ObjectResult)actionTideDataValueGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTideDataValueGet.Result).Value);
            TideDataValue tideDataValueGet = (TideDataValue)((OkObjectResult)actionTideDataValueGet.Result).Value;
            Assert.NotNull(tideDataValueGet);
            Assert.Equal(tideDataValueGet.TideDataValueID, tideDataValueList[0].TideDataValueID);

            // Put TideDataValue
            var actionTideDataValueUpdated = await TideDataValueDBLocalIMService.Put(tideDataValue);
            Assert.Equal(200, ((ObjectResult)actionTideDataValueUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTideDataValueUpdated.Result).Value);
            TideDataValue tideDataValueUpdated = (TideDataValue)((OkObjectResult)actionTideDataValueUpdated.Result).Value;
            Assert.NotNull(tideDataValueUpdated);

            // Delete TideDataValue
            var actionTideDataValueDeleted = await TideDataValueDBLocalIMService.Delete(tideDataValue.TideDataValueID);
            Assert.Equal(200, ((ObjectResult)actionTideDataValueDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTideDataValueDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionTideDataValueDeleted.Result).Value;
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
            Services.AddSingleton<ITideDataValueDBLocalIMService, TideDataValueDBLocalIMService>();

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

            TideDataValueDBLocalIMService = Provider.GetService<ITideDataValueDBLocalIMService>();
            Assert.NotNull(TideDataValueDBLocalIMService);

            return await Task.FromResult(true);
        }
        private TideDataValue GetFilledRandomTideDataValue(string OmitPropName)
        {
            TideDataValue tideDataValue = new TideDataValue();

            if (OmitPropName != "TideSiteTVItemID") tideDataValue.TideSiteTVItemID = 38;
            if (OmitPropName != "DateTime_Local") tideDataValue.DateTime_Local = new DateTime(2005, 3, 6);
            if (OmitPropName != "Keep") tideDataValue.Keep = true;
            if (OmitPropName != "TideDataType") tideDataValue.TideDataType = (TideDataTypeEnum)GetRandomEnumType(typeof(TideDataTypeEnum));
            if (OmitPropName != "StorageDataType") tideDataValue.StorageDataType = (StorageDataTypeEnum)GetRandomEnumType(typeof(StorageDataTypeEnum));
            if (OmitPropName != "Depth_m") tideDataValue.Depth_m = GetRandomDouble(0.0D, 10000.0D);
            if (OmitPropName != "UVelocity_m_s") tideDataValue.UVelocity_m_s = GetRandomDouble(0.0D, 10.0D);
            if (OmitPropName != "VVelocity_m_s") tideDataValue.VVelocity_m_s = GetRandomDouble(0.0D, 10.0D);
            if (OmitPropName != "TideStart") tideDataValue.TideStart = (TideTextEnum)GetRandomEnumType(typeof(TideTextEnum));
            if (OmitPropName != "TideEnd") tideDataValue.TideEnd = (TideTextEnum)GetRandomEnumType(typeof(TideTextEnum));
            if (OmitPropName != "LastUpdateDate_UTC") tideDataValue.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") tideDataValue.LastUpdateContactTVItemID = 2;

            try
            {
                dbLocalIM.TVItems.Add(new TVItem() { TVItemID = 38, TVLevel = 3, TVPath = "p1p5p6p38", TVType = (TVTypeEnum)22, ParentID = 6, IsActive = true, LastUpdateDate_UTC = new DateTime(2019, 1, 22, 18, 36, 9), LastUpdateContactTVItemID = 2 });
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


            return tideDataValue;
        }
        private void CheckTideDataValueFields(List<TideDataValue> tideDataValueList)
        {
            if (tideDataValueList[0].TideStart != null)
            {
                Assert.NotNull(tideDataValueList[0].TideStart);
            }
            if (tideDataValueList[0].TideEnd != null)
            {
                Assert.NotNull(tideDataValueList[0].TideEnd);
            }
        }

        #endregion Functions private
    }
}
