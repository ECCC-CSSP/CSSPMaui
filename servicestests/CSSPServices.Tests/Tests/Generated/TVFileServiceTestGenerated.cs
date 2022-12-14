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
    public partial class TVFileServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILoggedInService LoggedInService { get; set; }
        private ITVFileService TVFileService { get; set; }
        private CSSPDBContext db { get; set; }
        private CSSPDBLocalContext dbLocal { get; set; }
        private CSSPDBInMemoryContext dbIM { get; set; }
        private TVFile tvFile { get; set; }
        #endregion Properties

        #region Constructors
        public TVFileServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated CRUD
        [Theory]
        [InlineData("en-CA", DBLocationEnum.Local)]
        [InlineData("fr-CA", DBLocationEnum.Local)]
        [InlineData("en-CA", DBLocationEnum.Server)]
        [InlineData("fr-CA", DBLocationEnum.Server)]
        public async Task TVFile_CRUD_Good_Test(string culture, DBLocationEnum DBLocation)
        {
            // -------------------------------
            // -------------------------------
            // CRUD testing
            // -------------------------------
            // -------------------------------

            Assert.True(await Setup(culture));

            LoggedInService.DBLocation = DBLocation;

            tvFile = GetFilledRandomTVFile("");

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
        public async Task TVFile_Properties_Test(string culture, DBLocationEnum DBLocation)
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

            var actionTVFileList = await TVFileService.GetTVFileList();
            Assert.Equal(200, ((ObjectResult)actionTVFileList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTVFileList.Result).Value);
            List<TVFile> tvFileList = (List<TVFile>)((OkObjectResult)actionTVFileList.Result).Value;

            count = tvFileList.Count();

            TVFile tvFile = GetFilledRandomTVFile("");


            // -----------------------------------
            // [Key]
            // Is NOT Nullable
            // tvFile.TVFileID   (Int32)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.TVFileID = 0;

            var actionTVFile = await TVFileService.Put(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.TVFileID = 10000000;
            actionTVFile = await TVFileService.Put(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = File)]
            // tvFile.TVFileTVItemID   (Int32)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.TVFileTVItemID = 0;
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.TVFileTVItemID = 1;
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);


            // -----------------------------------
            // Is Nullable
            // [CSSPEnumType]
            // tvFile.TemplateTVType   (TVTypeEnum)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.TemplateTVType = (TVTypeEnum)1000000;
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);


            // -----------------------------------
            // Is Nullable
            // [CSSPExist(ExistTypeName = "ReportType", ExistPlurial = "s", ExistFieldID = "ReportTypeID", AllowableTVtypeList = )]
            // tvFile.ReportTypeID   (Int32)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.ReportTypeID = 0;
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);


            // -----------------------------------
            // Is Nullable
            // tvFile.Parameters   (String)
            // -----------------------------------


            // -----------------------------------
            // Is Nullable
            // [CSSPRange(1980, 2050)]
            // tvFile.Year   (Int32)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.Year = 1979;
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);
            //Assert.AreEqual(count, tvFileService.GetTVFileList().Count());
            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.Year = 2051;
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);
            //Assert.AreEqual(count, tvFileService.GetTVFileList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // tvFile.Language   (LanguageEnum)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.Language = (LanguageEnum)1000000;
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // tvFile.FilePurpose   (FilePurposeEnum)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.FilePurpose = (FilePurposeEnum)1000000;
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // tvFile.FileType   (FileTypeEnum)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.FileType = (FileTypeEnum)1000000;
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPRange(0, 100000000)]
            // tvFile.FileSize_kb   (Int32)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.FileSize_kb = -1;
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);
            //Assert.AreEqual(count, tvFileService.GetTVFileList().Count());
            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.FileSize_kb = 100000001;
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);
            //Assert.AreEqual(count, tvFileService.GetTVFileList().Count());

            // -----------------------------------
            // Is Nullable
            // tvFile.FileInfo   (String)
            // -----------------------------------


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // tvFile.FileCreatedDate_UTC   (DateTime)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.FileCreatedDate_UTC = new DateTime();
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);
            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.FileCreatedDate_UTC = new DateTime(1979, 1, 1);
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);

            // -----------------------------------
            // Is Nullable
            // tvFile.FromWater   (Boolean)
            // -----------------------------------


            // -----------------------------------
            // Is Nullable
            // [CSSPMaxLength(250)]
            // tvFile.ClientFilePath   (String)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.ClientFilePath = GetRandomString("", 251);
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);
            //Assert.AreEqual(count, tvFileService.GetTVFileList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPMaxLength(250)]
            // tvFile.ServerFileName   (String)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("ServerFileName");
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.ServerFileName = GetRandomString("", 251);
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);
            //Assert.AreEqual(count, tvFileService.GetTVFileList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPMaxLength(250)]
            // tvFile.ServerFilePath   (String)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("ServerFilePath");
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.ServerFilePath = GetRandomString("", 251);
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);
            //Assert.AreEqual(count, tvFileService.GetTVFileList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // tvFile.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.LastUpdateDate_UTC = new DateTime();
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);
            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // tvFile.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.LastUpdateContactTVItemID = 0;
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);

            tvFile = null;
            tvFile = GetFilledRandomTVFile("");
            tvFile.LastUpdateContactTVItemID = 1;
            actionTVFile = await TVFileService.Post(tvFile);
            Assert.IsType<BadRequestObjectResult>(actionTVFile.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDTest()
        {
            // Post TVFile
            var actionTVFileAdded = await TVFileService.Post(tvFile);
            Assert.Equal(200, ((ObjectResult)actionTVFileAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTVFileAdded.Result).Value);
            TVFile tvFileAdded = (TVFile)((OkObjectResult)actionTVFileAdded.Result).Value;
            Assert.NotNull(tvFileAdded);

            // List<TVFile>
            var actionTVFileList = await TVFileService.GetTVFileList();
            Assert.Equal(200, ((ObjectResult)actionTVFileList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTVFileList.Result).Value);
            List<TVFile> tvFileList = (List<TVFile>)((OkObjectResult)actionTVFileList.Result).Value;

            int count = ((List<TVFile>)((OkObjectResult)actionTVFileList.Result).Value).Count();
            Assert.True(count > 0);

            if (LoggedInService.DBLocation == DBLocationEnum.Server)
            {
                // List<TVFile> with skip and take
                var actionTVFileListSkipAndTake = await TVFileService.GetTVFileList(1, 1);
                Assert.Equal(200, ((ObjectResult)actionTVFileListSkipAndTake.Result).StatusCode);
                Assert.NotNull(((OkObjectResult)actionTVFileListSkipAndTake.Result).Value);
                List<TVFile> tvFileListSkipAndTake = (List<TVFile>)((OkObjectResult)actionTVFileListSkipAndTake.Result).Value;

                int countSkipAndTake = ((List<TVFile>)((OkObjectResult)actionTVFileListSkipAndTake.Result).Value).Count();
                Assert.True(countSkipAndTake == 1);

                Assert.False(tvFileList[0].TVFileID == tvFileListSkipAndTake[0].TVFileID);
            }

            // Get TVFile With TVFileID
            var actionTVFileGet = await TVFileService.GetTVFileWithTVFileID(tvFileList[0].TVFileID);
            Assert.Equal(200, ((ObjectResult)actionTVFileGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTVFileGet.Result).Value);
            TVFile tvFileGet = (TVFile)((OkObjectResult)actionTVFileGet.Result).Value;
            Assert.NotNull(tvFileGet);
            Assert.Equal(tvFileGet.TVFileID, tvFileList[0].TVFileID);

            // Put TVFile
            var actionTVFileUpdated = await TVFileService.Put(tvFile);
            Assert.Equal(200, ((ObjectResult)actionTVFileUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTVFileUpdated.Result).Value);
            TVFile tvFileUpdated = (TVFile)((OkObjectResult)actionTVFileUpdated.Result).Value;
            Assert.NotNull(tvFileUpdated);

            // Delete TVFile
            var actionTVFileDeleted = await TVFileService.Delete(tvFile.TVFileID);
            Assert.Equal(200, ((ObjectResult)actionTVFileDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionTVFileDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionTVFileDeleted.Result).Value;
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
            Services.AddSingleton<ITVFileService, TVFileService>();

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

            TVFileService = Provider.GetService<ITVFileService>();
            Assert.NotNull(TVFileService);

            return await Task.FromResult(true);
        }
        private TVFile GetFilledRandomTVFile(string OmitPropName)
        {
            List<TVFile> tvFileListToDelete = (from c in dbLocal.TVFiles
                                                               select c).ToList(); 
            
            dbLocal.TVFiles.RemoveRange(tvFileListToDelete);
            try
            {
                dbLocal.SaveChanges();
            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
            
            dbIM.Database.EnsureDeleted();

            TVFile tvFile = new TVFile();

            if (OmitPropName != "TVFileTVItemID") tvFile.TVFileTVItemID = 42;
            if (OmitPropName != "TemplateTVType") tvFile.TemplateTVType = (TVTypeEnum)GetRandomEnumType(typeof(TVTypeEnum));
            if (OmitPropName != "ReportTypeID") tvFile.ReportTypeID = 1;
            if (OmitPropName != "Parameters") tvFile.Parameters = GetRandomString("", 20);
            if (OmitPropName != "Year") tvFile.Year = GetRandomInt(1980, 2050);
            if (OmitPropName != "Language") tvFile.Language = CSSPCultureServicesRes.Culture.TwoLetterISOLanguageName == "fr" ? LanguageEnum.fr : LanguageEnum.en;
            if (OmitPropName != "FilePurpose") tvFile.FilePurpose = (FilePurposeEnum)GetRandomEnumType(typeof(FilePurposeEnum));
            if (OmitPropName != "FileType") tvFile.FileType = (FileTypeEnum)GetRandomEnumType(typeof(FileTypeEnum));
            if (OmitPropName != "FileSize_kb") tvFile.FileSize_kb = GetRandomInt(0, 100000000);
            if (OmitPropName != "FileInfo") tvFile.FileInfo = GetRandomString("", 20);
            if (OmitPropName != "FileCreatedDate_UTC") tvFile.FileCreatedDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "FromWater") tvFile.FromWater = true;
            if (OmitPropName != "ClientFilePath") tvFile.ClientFilePath = GetRandomString("", 5);
            if (OmitPropName != "ServerFileName") tvFile.ServerFileName = GetRandomString("", 5);
            if (OmitPropName != "ServerFilePath") tvFile.ServerFilePath = GetRandomString("", 5);
            if (OmitPropName != "LastUpdateDate_UTC") tvFile.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") tvFile.LastUpdateContactTVItemID = 2;

            if (LoggedInService.DBLocation == DBLocationEnum.Local)
            {
                if (OmitPropName != "TVFileID") tvFile.TVFileID = 10000000;

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
                    dbIM.ReportTypes.Add(new ReportType() { ReportTypeID = 1, TVType = (TVTypeEnum)20, FileType = (FileTypeEnum)11, UniqueCode = "FCSummaryStatENDOCX", Language = (LanguageEnum)1, Name = "FC summary statistics", Description = "Summary statistics of FC densities", StartOfFileName = "{subsector}_{year}_Summary_Stat_FC_{datecreated}_en", LastUpdateDate_UTC = new DateTime(2017, 11, 15, 14, 27, 14), LastUpdateContactTVItemID = 2 });
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

            return tvFile;
        }
        private void CheckTVFileFields(List<TVFile> tvFileList)
        {
            if (tvFileList[0].TemplateTVType != null)
            {
                Assert.NotNull(tvFileList[0].TemplateTVType);
            }
            if (tvFileList[0].ReportTypeID != null)
            {
                Assert.NotNull(tvFileList[0].ReportTypeID);
            }
            if (!string.IsNullOrWhiteSpace(tvFileList[0].Parameters))
            {
                Assert.False(string.IsNullOrWhiteSpace(tvFileList[0].Parameters));
            }
            if (tvFileList[0].Year != null)
            {
                Assert.NotNull(tvFileList[0].Year);
            }
            if (!string.IsNullOrWhiteSpace(tvFileList[0].FileInfo))
            {
                Assert.False(string.IsNullOrWhiteSpace(tvFileList[0].FileInfo));
            }
            if (tvFileList[0].FromWater != null)
            {
                Assert.NotNull(tvFileList[0].FromWater);
            }
            if (!string.IsNullOrWhiteSpace(tvFileList[0].ClientFilePath))
            {
                Assert.False(string.IsNullOrWhiteSpace(tvFileList[0].ClientFilePath));
            }
            Assert.False(string.IsNullOrWhiteSpace(tvFileList[0].ServerFileName));
            Assert.False(string.IsNullOrWhiteSpace(tvFileList[0].ServerFilePath));
        }
        #endregion Functions private
    }
}
