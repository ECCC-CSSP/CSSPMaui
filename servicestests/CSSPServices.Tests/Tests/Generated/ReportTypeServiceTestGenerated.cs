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
    public partial class ReportTypeServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILoggedInService LoggedInService { get; set; }
        private IReportTypeService ReportTypeService { get; set; }
        private CSSPDBContext db { get; set; }
        private CSSPDBLocalContext dbLocal { get; set; }
        private CSSPDBInMemoryContext dbIM { get; set; }
        private ReportType reportType { get; set; }
        #endregion Properties

        #region Constructors
        public ReportTypeServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated CRUD
        [Theory]
        [InlineData("en-CA", DBLocationEnum.Local)]
        [InlineData("fr-CA", DBLocationEnum.Local)]
        [InlineData("en-CA", DBLocationEnum.Server)]
        [InlineData("fr-CA", DBLocationEnum.Server)]
        public async Task ReportType_CRUD_Good_Test(string culture, DBLocationEnum DBLocation)
        {
            // -------------------------------
            // -------------------------------
            // CRUD testing
            // -------------------------------
            // -------------------------------

            Assert.True(await Setup(culture));

            LoggedInService.DBLocation = DBLocation;

            reportType = GetFilledRandomReportType("");

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
        public async Task ReportType_Properties_Test(string culture, DBLocationEnum DBLocation)
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

            var actionReportTypeList = await ReportTypeService.GetReportTypeList();
            Assert.Equal(200, ((ObjectResult)actionReportTypeList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionReportTypeList.Result).Value);
            List<ReportType> reportTypeList = (List<ReportType>)((OkObjectResult)actionReportTypeList.Result).Value;

            count = reportTypeList.Count();

            ReportType reportType = GetFilledRandomReportType("");


            // -----------------------------------
            // [Key]
            // Is NOT Nullable
            // reportType.ReportTypeID   (Int32)
            // -----------------------------------

            reportType = null;
            reportType = GetFilledRandomReportType("");
            reportType.ReportTypeID = 0;

            var actionReportType = await ReportTypeService.Put(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);

            reportType = null;
            reportType = GetFilledRandomReportType("");
            reportType.ReportTypeID = 10000000;
            actionReportType = await ReportTypeService.Put(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // reportType.TVType   (TVTypeEnum)
            // -----------------------------------

            reportType = null;
            reportType = GetFilledRandomReportType("");
            reportType.TVType = (TVTypeEnum)1000000;
            actionReportType = await ReportTypeService.Post(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // reportType.FileType   (FileTypeEnum)
            // -----------------------------------

            reportType = null;
            reportType = GetFilledRandomReportType("");
            reportType.FileType = (FileTypeEnum)1000000;
            actionReportType = await ReportTypeService.Post(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPMaxLength(100)]
            // reportType.UniqueCode   (String)
            // -----------------------------------

            reportType = null;
            reportType = GetFilledRandomReportType("UniqueCode");
            actionReportType = await ReportTypeService.Post(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);

            reportType = null;
            reportType = GetFilledRandomReportType("");
            reportType.UniqueCode = GetRandomString("", 101);
            actionReportType = await ReportTypeService.Post(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);
            //Assert.AreEqual(count, reportTypeService.GetReportTypeList().Count());

            // -----------------------------------
            // Is Nullable
            // [CSSPEnumType]
            // reportType.Language   (LanguageEnum)
            // -----------------------------------

            reportType = null;
            reportType = GetFilledRandomReportType("");
            reportType.Language = (LanguageEnum)1000000;
            actionReportType = await ReportTypeService.Post(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);


            // -----------------------------------
            // Is Nullable
            // [CSSPMaxLength(100)]
            // reportType.Name   (String)
            // -----------------------------------

            reportType = null;
            reportType = GetFilledRandomReportType("");
            reportType.Name = GetRandomString("", 101);
            actionReportType = await ReportTypeService.Post(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);
            //Assert.AreEqual(count, reportTypeService.GetReportTypeList().Count());

            // -----------------------------------
            // Is Nullable
            // [CSSPMaxLength(1000)]
            // reportType.Description   (String)
            // -----------------------------------

            reportType = null;
            reportType = GetFilledRandomReportType("");
            reportType.Description = GetRandomString("", 1001);
            actionReportType = await ReportTypeService.Post(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);
            //Assert.AreEqual(count, reportTypeService.GetReportTypeList().Count());

            // -----------------------------------
            // Is Nullable
            // [CSSPMaxLength(100)]
            // reportType.StartOfFileName   (String)
            // -----------------------------------

            reportType = null;
            reportType = GetFilledRandomReportType("");
            reportType.StartOfFileName = GetRandomString("", 101);
            actionReportType = await ReportTypeService.Post(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);
            //Assert.AreEqual(count, reportTypeService.GetReportTypeList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // reportType.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            reportType = null;
            reportType = GetFilledRandomReportType("");
            reportType.LastUpdateDate_UTC = new DateTime();
            actionReportType = await ReportTypeService.Post(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);
            reportType = null;
            reportType = GetFilledRandomReportType("");
            reportType.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionReportType = await ReportTypeService.Post(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // reportType.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            reportType = null;
            reportType = GetFilledRandomReportType("");
            reportType.LastUpdateContactTVItemID = 0;
            actionReportType = await ReportTypeService.Post(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);

            reportType = null;
            reportType = GetFilledRandomReportType("");
            reportType.LastUpdateContactTVItemID = 1;
            actionReportType = await ReportTypeService.Post(reportType);
            Assert.IsType<BadRequestObjectResult>(actionReportType.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDTest()
        {
            // Post ReportType
            var actionReportTypeAdded = await ReportTypeService.Post(reportType);
            Assert.Equal(200, ((ObjectResult)actionReportTypeAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionReportTypeAdded.Result).Value);
            ReportType reportTypeAdded = (ReportType)((OkObjectResult)actionReportTypeAdded.Result).Value;
            Assert.NotNull(reportTypeAdded);

            // List<ReportType>
            var actionReportTypeList = await ReportTypeService.GetReportTypeList();
            Assert.Equal(200, ((ObjectResult)actionReportTypeList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionReportTypeList.Result).Value);
            List<ReportType> reportTypeList = (List<ReportType>)((OkObjectResult)actionReportTypeList.Result).Value;

            int count = ((List<ReportType>)((OkObjectResult)actionReportTypeList.Result).Value).Count();
            Assert.True(count > 0);

            if (LoggedInService.DBLocation == DBLocationEnum.Server)
            {
                // List<ReportType> with skip and take
                var actionReportTypeListSkipAndTake = await ReportTypeService.GetReportTypeList(1, 1);
                Assert.Equal(200, ((ObjectResult)actionReportTypeListSkipAndTake.Result).StatusCode);
                Assert.NotNull(((OkObjectResult)actionReportTypeListSkipAndTake.Result).Value);
                List<ReportType> reportTypeListSkipAndTake = (List<ReportType>)((OkObjectResult)actionReportTypeListSkipAndTake.Result).Value;

                int countSkipAndTake = ((List<ReportType>)((OkObjectResult)actionReportTypeListSkipAndTake.Result).Value).Count();
                Assert.True(countSkipAndTake == 1);

                Assert.False(reportTypeList[0].ReportTypeID == reportTypeListSkipAndTake[0].ReportTypeID);
            }

            // Get ReportType With ReportTypeID
            var actionReportTypeGet = await ReportTypeService.GetReportTypeWithReportTypeID(reportTypeList[0].ReportTypeID);
            Assert.Equal(200, ((ObjectResult)actionReportTypeGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionReportTypeGet.Result).Value);
            ReportType reportTypeGet = (ReportType)((OkObjectResult)actionReportTypeGet.Result).Value;
            Assert.NotNull(reportTypeGet);
            Assert.Equal(reportTypeGet.ReportTypeID, reportTypeList[0].ReportTypeID);

            // Put ReportType
            var actionReportTypeUpdated = await ReportTypeService.Put(reportType);
            Assert.Equal(200, ((ObjectResult)actionReportTypeUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionReportTypeUpdated.Result).Value);
            ReportType reportTypeUpdated = (ReportType)((OkObjectResult)actionReportTypeUpdated.Result).Value;
            Assert.NotNull(reportTypeUpdated);

            // Delete ReportType
            var actionReportTypeDeleted = await ReportTypeService.Delete(reportType.ReportTypeID);
            Assert.Equal(200, ((ObjectResult)actionReportTypeDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionReportTypeDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionReportTypeDeleted.Result).Value;
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
            Services.AddSingleton<IReportTypeService, ReportTypeService>();

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

            ReportTypeService = Provider.GetService<IReportTypeService>();
            Assert.NotNull(ReportTypeService);

            return await Task.FromResult(true);
        }
        private ReportType GetFilledRandomReportType(string OmitPropName)
        {
            List<ReportType> reportTypeListToDelete = (from c in dbLocal.ReportTypes
                                                               select c).ToList(); 
            
            dbLocal.ReportTypes.RemoveRange(reportTypeListToDelete);
            try
            {
                dbLocal.SaveChanges();
            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
            
            dbIM.Database.EnsureDeleted();

            ReportType reportType = new ReportType();

            if (OmitPropName != "TVType") reportType.TVType = (TVTypeEnum)GetRandomEnumType(typeof(TVTypeEnum));
            if (OmitPropName != "FileType") reportType.FileType = (FileTypeEnum)GetRandomEnumType(typeof(FileTypeEnum));
            if (OmitPropName != "UniqueCode") reportType.UniqueCode = GetRandomString("", 5);
            if (OmitPropName != "Language") reportType.Language = CSSPCultureServicesRes.Culture.TwoLetterISOLanguageName == "fr" ? LanguageEnum.fr : LanguageEnum.en;
            if (OmitPropName != "Name") reportType.Name = GetRandomString("", 5);
            if (OmitPropName != "Description") reportType.Description = GetRandomString("", 5);
            if (OmitPropName != "StartOfFileName") reportType.StartOfFileName = GetRandomString("", 5);
            if (OmitPropName != "LastUpdateDate_UTC") reportType.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") reportType.LastUpdateContactTVItemID = 2;

            if (LoggedInService.DBLocation == DBLocationEnum.Local)
            {
                if (OmitPropName != "ReportTypeID") reportType.ReportTypeID = 10000000;

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

            return reportType;
        }
        private void CheckReportTypeFields(List<ReportType> reportTypeList)
        {
            Assert.False(string.IsNullOrWhiteSpace(reportTypeList[0].UniqueCode));
            if (reportTypeList[0].Language != null)
            {
                Assert.NotNull(reportTypeList[0].Language);
            }
            if (!string.IsNullOrWhiteSpace(reportTypeList[0].Name))
            {
                Assert.False(string.IsNullOrWhiteSpace(reportTypeList[0].Name));
            }
            if (!string.IsNullOrWhiteSpace(reportTypeList[0].Description))
            {
                Assert.False(string.IsNullOrWhiteSpace(reportTypeList[0].Description));
            }
            if (!string.IsNullOrWhiteSpace(reportTypeList[0].StartOfFileName))
            {
                Assert.False(string.IsNullOrWhiteSpace(reportTypeList[0].StartOfFileName));
            }
        }
        #endregion Functions private
    }
}
