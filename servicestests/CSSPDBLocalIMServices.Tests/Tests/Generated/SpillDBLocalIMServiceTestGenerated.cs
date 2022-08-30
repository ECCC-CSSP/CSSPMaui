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
    public partial class SpillDBLocalIMServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILocalService LocalService { get; set; }
        private ISpillDBLocalIMService SpillDBLocalIMService { get; set; }
        private CSSPDBInMemoryContext dbLocalIM { get; set; }
        private Spill spill { get; set; }
        #endregion Properties

        #region Constructors
        public SpillDBLocalIMServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated Constructor [DBLocalIM]
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task SpillDBLocalIM_Constructor_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));
        }
        #endregion Tests Generated Constructor [DBLocalIM]

        #region Tests Generated [DBLocalIM] CRUD
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task SpillDBLocalIM_CRUD_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));

            spill = GetFilledRandomSpill("");

            await DoCRUDDBLocalIMTest();
        }
        #endregion Tests Generated [DBLocalIM] CRUD

        #region Tests Generated Properties
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task Spill_Properties_Test(string culture)
        {
            Assert.True(await Setup(culture));

            int count = 0;
            if (count == 1)
            {
                // just so we don't get a warning during compile [The variable 'count' is assigned but its value is never used]
            }

            var actionSpillList = await SpillDBLocalIMService.GetSpillList();
            Assert.Equal(200, ((ObjectResult)actionSpillList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionSpillList.Result).Value);
            List<Spill> spillList = (List<Spill>)((OkObjectResult)actionSpillList.Result).Value;

            count = spillList.Count();

            Spill spill = GetFilledRandomSpill("");


            // -----------------------------------
            // [Key]
            // Is NOT Nullable
            // spill.SpillID   (Int32)
            // -----------------------------------

            spill = null;
            spill = GetFilledRandomSpill("");
            spill.SpillID = 0;

            var actionSpill = await SpillDBLocalIMService.Put(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);

            spill = null;
            spill = GetFilledRandomSpill("");
            spill.SpillID = 10000000;
            actionSpill = await SpillDBLocalIMService.Put(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Municipality)]
            // spill.MunicipalityTVItemID   (Int32)
            // -----------------------------------

            spill = null;
            spill = GetFilledRandomSpill("");
            spill.MunicipalityTVItemID = 0;
            actionSpill = await SpillDBLocalIMService.Post(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);

            spill = null;
            spill = GetFilledRandomSpill("");
            spill.MunicipalityTVItemID = 1;
            actionSpill = await SpillDBLocalIMService.Post(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);


            // -----------------------------------
            // Is Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Infrastructure)]
            // spill.InfrastructureTVItemID   (Int32)
            // -----------------------------------

            spill = null;
            spill = GetFilledRandomSpill("");
            spill.InfrastructureTVItemID = 0;
            actionSpill = await SpillDBLocalIMService.Post(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);

            spill = null;
            spill = GetFilledRandomSpill("");
            spill.InfrastructureTVItemID = 1;
            actionSpill = await SpillDBLocalIMService.Post(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // spill.StartDateTime_Local   (DateTime)
            // -----------------------------------

            spill = null;
            spill = GetFilledRandomSpill("");
            spill.StartDateTime_Local = new DateTime();
            actionSpill = await SpillDBLocalIMService.Post(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);
            spill = null;
            spill = GetFilledRandomSpill("");
            spill.StartDateTime_Local = new DateTime(1979, 1, 1);
            actionSpill = await SpillDBLocalIMService.Post(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);

            // -----------------------------------
            // Is Nullable
            // [CSSPAfter(Year = 1980)]
            // [CSSPBigger(OtherField = StartDateTime_Local)]
            // spill.EndDateTime_Local   (DateTime)
            // -----------------------------------

            spill = null;
            spill = GetFilledRandomSpill("");
            spill.EndDateTime_Local = new DateTime(1979, 1, 1);
            actionSpill = await SpillDBLocalIMService.Post(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPRange(0, 1000000)]
            // spill.AverageFlow_m3_day   (Double)
            // -----------------------------------

            //CSSPError: Type not implemented [AverageFlow_m3_day]

            //CSSPError: Type not implemented [AverageFlow_m3_day]

            spill = null;
            spill = GetFilledRandomSpill("");
            spill.AverageFlow_m3_day = -1.0D;
            actionSpill = await SpillDBLocalIMService.Post(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);
            //Assert.AreEqual(count, spillService.GetSpillList().Count());
            spill = null;
            spill = GetFilledRandomSpill("");
            spill.AverageFlow_m3_day = 1000001.0D;
            actionSpill = await SpillDBLocalIMService.Post(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);
            //Assert.AreEqual(count, spillDBLocalIMService.GetSpillList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // spill.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            spill = null;
            spill = GetFilledRandomSpill("");
            spill.LastUpdateDate_UTC = new DateTime();
            actionSpill = await SpillDBLocalIMService.Post(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);
            spill = null;
            spill = GetFilledRandomSpill("");
            spill.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionSpill = await SpillDBLocalIMService.Post(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // spill.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            spill = null;
            spill = GetFilledRandomSpill("");
            spill.LastUpdateContactTVItemID = 0;
            actionSpill = await SpillDBLocalIMService.Post(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);

            spill = null;
            spill = GetFilledRandomSpill("");
            spill.LastUpdateContactTVItemID = 1;
            actionSpill = await SpillDBLocalIMService.Post(spill);
            Assert.IsType<BadRequestObjectResult>(actionSpill.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDDBLocalIMTest()
        {
            spill.SpillID = 10000000;

            // Post Spill
            var actionSpillAdded = await SpillDBLocalIMService.Post(spill);
            Assert.Equal(200, ((ObjectResult)actionSpillAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionSpillAdded.Result).Value);
            Spill spillAdded = (Spill)((OkObjectResult)actionSpillAdded.Result).Value;
            Assert.NotNull(spillAdded);

            // List<Spill>
            var actionSpillList = await SpillDBLocalIMService.GetSpillList();
            Assert.Equal(200, ((ObjectResult)actionSpillList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionSpillList.Result).Value);
            List<Spill> spillList = (List<Spill>)((OkObjectResult)actionSpillList.Result).Value;

            int count = ((List<Spill>)((OkObjectResult)actionSpillList.Result).Value).Count();
            Assert.True(count > 0);

            // Get Spill With SpillID
            var actionSpillGet = await SpillDBLocalIMService.GetSpillWithSpillID(spillList[0].SpillID);
            Assert.Equal(200, ((ObjectResult)actionSpillGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionSpillGet.Result).Value);
            Spill spillGet = (Spill)((OkObjectResult)actionSpillGet.Result).Value;
            Assert.NotNull(spillGet);
            Assert.Equal(spillGet.SpillID, spillList[0].SpillID);

            // Put Spill
            var actionSpillUpdated = await SpillDBLocalIMService.Put(spill);
            Assert.Equal(200, ((ObjectResult)actionSpillUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionSpillUpdated.Result).Value);
            Spill spillUpdated = (Spill)((OkObjectResult)actionSpillUpdated.Result).Value;
            Assert.NotNull(spillUpdated);

            // Delete Spill
            var actionSpillDeleted = await SpillDBLocalIMService.Delete(spill.SpillID);
            Assert.Equal(200, ((ObjectResult)actionSpillDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionSpillDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionSpillDeleted.Result).Value;
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
            Services.AddSingleton<ISpillDBLocalIMService, SpillDBLocalIMService>();

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

            SpillDBLocalIMService = Provider.GetService<ISpillDBLocalIMService>();
            Assert.NotNull(SpillDBLocalIMService);

            return await Task.FromResult(true);
        }
        private Spill GetFilledRandomSpill(string OmitPropName)
        {
            Spill spill = new Spill();

            if (OmitPropName != "MunicipalityTVItemID") spill.MunicipalityTVItemID = 39;
            if (OmitPropName != "InfrastructureTVItemID") spill.InfrastructureTVItemID = 41;
            if (OmitPropName != "StartDateTime_Local") spill.StartDateTime_Local = new DateTime(2005, 3, 6);
            if (OmitPropName != "EndDateTime_Local") spill.EndDateTime_Local = new DateTime(2005, 3, 7);
            if (OmitPropName != "AverageFlow_m3_day") spill.AverageFlow_m3_day = GetRandomDouble(0.0D, 1000000.0D);
            if (OmitPropName != "LastUpdateDate_UTC") spill.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") spill.LastUpdateContactTVItemID = 2;

            try
            {
                dbLocalIM.TVItems.Add(new TVItem() { TVItemID = 39, TVLevel = 3, TVPath = "p1p5p6p39", TVType = (TVTypeEnum)15, ParentID = 6, IsActive = true, LastUpdateDate_UTC = new DateTime(2015, 2, 22, 14, 12, 19), LastUpdateContactTVItemID = 2 });
                dbLocalIM.SaveChanges();
            }
            catch (Exception)
            {
                // Assert.True(false, ex.Message);
            }
            try
            {
                dbLocalIM.TVItems.Add(new TVItem() { TVItemID = 41, TVLevel = 4, TVPath = "p1p5p6p39p41", TVType = (TVTypeEnum)10, ParentID = 39, IsActive = true, LastUpdateDate_UTC = new DateTime(2014, 12, 2, 21, 29, 23), LastUpdateContactTVItemID = 2 });
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


            return spill;
        }
        private void CheckSpillFields(List<Spill> spillList)
        {
            if (spillList[0].InfrastructureTVItemID != null)
            {
                Assert.NotNull(spillList[0].InfrastructureTVItemID);
            }
            if (spillList[0].EndDateTime_Local != null)
            {
                Assert.NotNull(spillList[0].EndDateTime_Local);
            }
        }

        #endregion Functions private
    }
}
