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
    public partial class PolSourceGroupingServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILoggedInService LoggedInService { get; set; }
        private IPolSourceGroupingService PolSourceGroupingService { get; set; }
        private CSSPDBContext db { get; set; }
        private CSSPDBLocalContext dbLocal { get; set; }
        private CSSPDBInMemoryContext dbIM { get; set; }
        private PolSourceGrouping polSourceGrouping { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceGroupingServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated CRUD
        [Theory]
        [InlineData("en-CA", DBLocationEnum.Local)]
        [InlineData("fr-CA", DBLocationEnum.Local)]
        [InlineData("en-CA", DBLocationEnum.Server)]
        [InlineData("fr-CA", DBLocationEnum.Server)]
        public async Task PolSourceGrouping_CRUD_Good_Test(string culture, DBLocationEnum DBLocation)
        {
            // -------------------------------
            // -------------------------------
            // CRUD testing
            // -------------------------------
            // -------------------------------

            Assert.True(await Setup(culture));

            LoggedInService.DBLocation = DBLocation;

            polSourceGrouping = GetFilledRandomPolSourceGrouping("");

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
        public async Task PolSourceGrouping_Properties_Test(string culture, DBLocationEnum DBLocation)
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

            var actionPolSourceGroupingList = await PolSourceGroupingService.GetPolSourceGroupingList();
            Assert.Equal(200, ((ObjectResult)actionPolSourceGroupingList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionPolSourceGroupingList.Result).Value);
            List<PolSourceGrouping> polSourceGroupingList = (List<PolSourceGrouping>)((OkObjectResult)actionPolSourceGroupingList.Result).Value;

            count = polSourceGroupingList.Count();

            PolSourceGrouping polSourceGrouping = GetFilledRandomPolSourceGrouping("");


            // -----------------------------------
            // [Key]
            // Is NOT Nullable
            // polSourceGrouping.PolSourceGroupingID   (Int32)
            // -----------------------------------

            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("");
            polSourceGrouping.PolSourceGroupingID = 0;

            var actionPolSourceGrouping = await PolSourceGroupingService.Put(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);

            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("");
            polSourceGrouping.PolSourceGroupingID = 10000000;
            actionPolSourceGrouping = await PolSourceGroupingService.Put(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPRange(10000, 100000)]
            // polSourceGrouping.CSSPID   (Int32)
            // -----------------------------------

            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("");
            polSourceGrouping.CSSPID = 9999;
            actionPolSourceGrouping = await PolSourceGroupingService.Post(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);
            //Assert.AreEqual(count, polSourceGroupingService.GetPolSourceGroupingList().Count());
            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("");
            polSourceGrouping.CSSPID = 100001;
            actionPolSourceGrouping = await PolSourceGroupingService.Post(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);
            //Assert.AreEqual(count, polSourceGroupingService.GetPolSourceGroupingList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPMaxLength(500)]
            // polSourceGrouping.GroupName   (String)
            // -----------------------------------

            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("GroupName");
            actionPolSourceGrouping = await PolSourceGroupingService.Post(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);

            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("");
            polSourceGrouping.GroupName = GetRandomString("", 501);
            actionPolSourceGrouping = await PolSourceGroupingService.Post(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);
            //Assert.AreEqual(count, polSourceGroupingService.GetPolSourceGroupingList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPMaxLength(500)]
            // polSourceGrouping.Child   (String)
            // -----------------------------------

            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("Child");
            actionPolSourceGrouping = await PolSourceGroupingService.Post(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);

            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("");
            polSourceGrouping.Child = GetRandomString("", 501);
            actionPolSourceGrouping = await PolSourceGroupingService.Post(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);
            //Assert.AreEqual(count, polSourceGroupingService.GetPolSourceGroupingList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPMaxLength(500)]
            // polSourceGrouping.Hide   (String)
            // -----------------------------------

            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("Hide");
            actionPolSourceGrouping = await PolSourceGroupingService.Post(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);

            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("");
            polSourceGrouping.Hide = GetRandomString("", 501);
            actionPolSourceGrouping = await PolSourceGroupingService.Post(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);
            //Assert.AreEqual(count, polSourceGroupingService.GetPolSourceGroupingList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // polSourceGrouping.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("");
            polSourceGrouping.LastUpdateDate_UTC = new DateTime();
            actionPolSourceGrouping = await PolSourceGroupingService.Post(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);
            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("");
            polSourceGrouping.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionPolSourceGrouping = await PolSourceGroupingService.Post(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // polSourceGrouping.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("");
            polSourceGrouping.LastUpdateContactTVItemID = 0;
            actionPolSourceGrouping = await PolSourceGroupingService.Post(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);

            polSourceGrouping = null;
            polSourceGrouping = GetFilledRandomPolSourceGrouping("");
            polSourceGrouping.LastUpdateContactTVItemID = 1;
            actionPolSourceGrouping = await PolSourceGroupingService.Post(polSourceGrouping);
            Assert.IsType<BadRequestObjectResult>(actionPolSourceGrouping.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDTest()
        {
            // Post PolSourceGrouping
            var actionPolSourceGroupingAdded = await PolSourceGroupingService.Post(polSourceGrouping);
            Assert.Equal(200, ((ObjectResult)actionPolSourceGroupingAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionPolSourceGroupingAdded.Result).Value);
            PolSourceGrouping polSourceGroupingAdded = (PolSourceGrouping)((OkObjectResult)actionPolSourceGroupingAdded.Result).Value;
            Assert.NotNull(polSourceGroupingAdded);

            // List<PolSourceGrouping>
            var actionPolSourceGroupingList = await PolSourceGroupingService.GetPolSourceGroupingList();
            Assert.Equal(200, ((ObjectResult)actionPolSourceGroupingList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionPolSourceGroupingList.Result).Value);
            List<PolSourceGrouping> polSourceGroupingList = (List<PolSourceGrouping>)((OkObjectResult)actionPolSourceGroupingList.Result).Value;

            int count = ((List<PolSourceGrouping>)((OkObjectResult)actionPolSourceGroupingList.Result).Value).Count();
            Assert.True(count > 0);

            if (LoggedInService.DBLocation == DBLocationEnum.Server)
            {
                // List<PolSourceGrouping> with skip and take
                var actionPolSourceGroupingListSkipAndTake = await PolSourceGroupingService.GetPolSourceGroupingList(1, 1);
                Assert.Equal(200, ((ObjectResult)actionPolSourceGroupingListSkipAndTake.Result).StatusCode);
                Assert.NotNull(((OkObjectResult)actionPolSourceGroupingListSkipAndTake.Result).Value);
                List<PolSourceGrouping> polSourceGroupingListSkipAndTake = (List<PolSourceGrouping>)((OkObjectResult)actionPolSourceGroupingListSkipAndTake.Result).Value;

                int countSkipAndTake = ((List<PolSourceGrouping>)((OkObjectResult)actionPolSourceGroupingListSkipAndTake.Result).Value).Count();
                Assert.True(countSkipAndTake == 1);

                Assert.False(polSourceGroupingList[0].PolSourceGroupingID == polSourceGroupingListSkipAndTake[0].PolSourceGroupingID);
            }

            // Get PolSourceGrouping With PolSourceGroupingID
            var actionPolSourceGroupingGet = await PolSourceGroupingService.GetPolSourceGroupingWithPolSourceGroupingID(polSourceGroupingList[0].PolSourceGroupingID);
            Assert.Equal(200, ((ObjectResult)actionPolSourceGroupingGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionPolSourceGroupingGet.Result).Value);
            PolSourceGrouping polSourceGroupingGet = (PolSourceGrouping)((OkObjectResult)actionPolSourceGroupingGet.Result).Value;
            Assert.NotNull(polSourceGroupingGet);
            Assert.Equal(polSourceGroupingGet.PolSourceGroupingID, polSourceGroupingList[0].PolSourceGroupingID);

            // Put PolSourceGrouping
            var actionPolSourceGroupingUpdated = await PolSourceGroupingService.Put(polSourceGrouping);
            Assert.Equal(200, ((ObjectResult)actionPolSourceGroupingUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionPolSourceGroupingUpdated.Result).Value);
            PolSourceGrouping polSourceGroupingUpdated = (PolSourceGrouping)((OkObjectResult)actionPolSourceGroupingUpdated.Result).Value;
            Assert.NotNull(polSourceGroupingUpdated);

            // Delete PolSourceGrouping
            var actionPolSourceGroupingDeleted = await PolSourceGroupingService.Delete(polSourceGrouping.PolSourceGroupingID);
            Assert.Equal(200, ((ObjectResult)actionPolSourceGroupingDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionPolSourceGroupingDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionPolSourceGroupingDeleted.Result).Value;
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
            Services.AddSingleton<IPolSourceGroupingService, PolSourceGroupingService>();

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

            PolSourceGroupingService = Provider.GetService<IPolSourceGroupingService>();
            Assert.NotNull(PolSourceGroupingService);

            return await Task.FromResult(true);
        }
        private PolSourceGrouping GetFilledRandomPolSourceGrouping(string OmitPropName)
        {
            List<PolSourceGrouping> polSourceGroupingListToDelete = (from c in dbLocal.PolSourceGroupings
                                                               select c).ToList(); 
            
            dbLocal.PolSourceGroupings.RemoveRange(polSourceGroupingListToDelete);
            try
            {
                dbLocal.SaveChanges();
            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
            
            dbIM.Database.EnsureDeleted();

            PolSourceGrouping polSourceGrouping = new PolSourceGrouping();

            if (OmitPropName != "CSSPID") polSourceGrouping.CSSPID = GetRandomInt(10000, 100000);
            if (OmitPropName != "GroupName") polSourceGrouping.GroupName = GetRandomString("", 5);
            if (OmitPropName != "Child") polSourceGrouping.Child = GetRandomString("", 5);
            if (OmitPropName != "Hide") polSourceGrouping.Hide = GetRandomString("", 5);
            if (OmitPropName != "LastUpdateDate_UTC") polSourceGrouping.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") polSourceGrouping.LastUpdateContactTVItemID = 2;

            if (LoggedInService.DBLocation == DBLocationEnum.Local)
            {
                if (OmitPropName != "PolSourceGroupingID") polSourceGrouping.PolSourceGroupingID = 10000000;

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

            return polSourceGrouping;
        }
        private void CheckPolSourceGroupingFields(List<PolSourceGrouping> polSourceGroupingList)
        {
            Assert.False(string.IsNullOrWhiteSpace(polSourceGroupingList[0].GroupName));
            Assert.False(string.IsNullOrWhiteSpace(polSourceGroupingList[0].Child));
            Assert.False(string.IsNullOrWhiteSpace(polSourceGroupingList[0].Hide));
        }
        #endregion Functions private
    }
}
