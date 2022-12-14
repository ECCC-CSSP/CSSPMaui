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
    public partial class EmailServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILoggedInService LoggedInService { get; set; }
        private IEmailService EmailService { get; set; }
        private CSSPDBContext db { get; set; }
        private CSSPDBLocalContext dbLocal { get; set; }
        private CSSPDBInMemoryContext dbIM { get; set; }
        private Email email { get; set; }
        #endregion Properties

        #region Constructors
        public EmailServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated CRUD
        [Theory]
        [InlineData("en-CA", DBLocationEnum.Local)]
        [InlineData("fr-CA", DBLocationEnum.Local)]
        [InlineData("en-CA", DBLocationEnum.Server)]
        [InlineData("fr-CA", DBLocationEnum.Server)]
        public async Task Email_CRUD_Good_Test(string culture, DBLocationEnum DBLocation)
        {
            // -------------------------------
            // -------------------------------
            // CRUD testing
            // -------------------------------
            // -------------------------------

            Assert.True(await Setup(culture));

            LoggedInService.DBLocation = DBLocation;

            email = GetFilledRandomEmail("");

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
        public async Task Email_Properties_Test(string culture, DBLocationEnum DBLocation)
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

            var actionEmailList = await EmailService.GetEmailList();
            Assert.Equal(200, ((ObjectResult)actionEmailList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionEmailList.Result).Value);
            List<Email> emailList = (List<Email>)((OkObjectResult)actionEmailList.Result).Value;

            count = emailList.Count();

            Email email = GetFilledRandomEmail("");


            // -----------------------------------
            // [Key]
            // Is NOT Nullable
            // email.EmailID   (Int32)
            // -----------------------------------

            email = null;
            email = GetFilledRandomEmail("");
            email.EmailID = 0;

            var actionEmail = await EmailService.Put(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);

            email = null;
            email = GetFilledRandomEmail("");
            email.EmailID = 10000000;
            actionEmail = await EmailService.Put(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Email)]
            // email.EmailTVItemID   (Int32)
            // -----------------------------------

            email = null;
            email = GetFilledRandomEmail("");
            email.EmailTVItemID = 0;
            actionEmail = await EmailService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);

            email = null;
            email = GetFilledRandomEmail("");
            email.EmailTVItemID = 1;
            actionEmail = await EmailService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [DataType(DataType.EmailAddress)]
            // [CSSPMaxLength(255)]
            // email.EmailAddress   (String)
            // -----------------------------------

            email = null;
            email = GetFilledRandomEmail("EmailAddress");
            actionEmail = await EmailService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);

            email = null;
            email = GetFilledRandomEmail("");
            email.EmailAddress = GetRandomString("", 256);
            actionEmail = await EmailService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);
            //Assert.AreEqual(count, emailService.GetEmailList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // email.EmailType   (EmailTypeEnum)
            // -----------------------------------

            email = null;
            email = GetFilledRandomEmail("");
            email.EmailType = (EmailTypeEnum)1000000;
            actionEmail = await EmailService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // email.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            email = null;
            email = GetFilledRandomEmail("");
            email.LastUpdateDate_UTC = new DateTime();
            actionEmail = await EmailService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);
            email = null;
            email = GetFilledRandomEmail("");
            email.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionEmail = await EmailService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // email.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            email = null;
            email = GetFilledRandomEmail("");
            email.LastUpdateContactTVItemID = 0;
            actionEmail = await EmailService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);

            email = null;
            email = GetFilledRandomEmail("");
            email.LastUpdateContactTVItemID = 1;
            actionEmail = await EmailService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDTest()
        {
            // Post Email
            var actionEmailAdded = await EmailService.Post(email);
            Assert.Equal(200, ((ObjectResult)actionEmailAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionEmailAdded.Result).Value);
            Email emailAdded = (Email)((OkObjectResult)actionEmailAdded.Result).Value;
            Assert.NotNull(emailAdded);

            // List<Email>
            var actionEmailList = await EmailService.GetEmailList();
            Assert.Equal(200, ((ObjectResult)actionEmailList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionEmailList.Result).Value);
            List<Email> emailList = (List<Email>)((OkObjectResult)actionEmailList.Result).Value;

            int count = ((List<Email>)((OkObjectResult)actionEmailList.Result).Value).Count();
            Assert.True(count > 0);

            if (LoggedInService.DBLocation == DBLocationEnum.Server)
            {
                // List<Email> with skip and take
                var actionEmailListSkipAndTake = await EmailService.GetEmailList(1, 1);
                Assert.Equal(200, ((ObjectResult)actionEmailListSkipAndTake.Result).StatusCode);
                Assert.NotNull(((OkObjectResult)actionEmailListSkipAndTake.Result).Value);
                List<Email> emailListSkipAndTake = (List<Email>)((OkObjectResult)actionEmailListSkipAndTake.Result).Value;

                int countSkipAndTake = ((List<Email>)((OkObjectResult)actionEmailListSkipAndTake.Result).Value).Count();
                Assert.True(countSkipAndTake == 1);

                Assert.False(emailList[0].EmailID == emailListSkipAndTake[0].EmailID);
            }

            // Get Email With EmailID
            var actionEmailGet = await EmailService.GetEmailWithEmailID(emailList[0].EmailID);
            Assert.Equal(200, ((ObjectResult)actionEmailGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionEmailGet.Result).Value);
            Email emailGet = (Email)((OkObjectResult)actionEmailGet.Result).Value;
            Assert.NotNull(emailGet);
            Assert.Equal(emailGet.EmailID, emailList[0].EmailID);

            // Put Email
            var actionEmailUpdated = await EmailService.Put(email);
            Assert.Equal(200, ((ObjectResult)actionEmailUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionEmailUpdated.Result).Value);
            Email emailUpdated = (Email)((OkObjectResult)actionEmailUpdated.Result).Value;
            Assert.NotNull(emailUpdated);

            // Delete Email
            var actionEmailDeleted = await EmailService.Delete(email.EmailID);
            Assert.Equal(200, ((ObjectResult)actionEmailDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionEmailDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionEmailDeleted.Result).Value;
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
            Services.AddSingleton<IEmailService, EmailService>();

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

            EmailService = Provider.GetService<IEmailService>();
            Assert.NotNull(EmailService);

            return await Task.FromResult(true);
        }
        private Email GetFilledRandomEmail(string OmitPropName)
        {
            List<Email> emailListToDelete = (from c in dbLocal.Emails
                                                               select c).ToList(); 
            
            dbLocal.Emails.RemoveRange(emailListToDelete);
            try
            {
                dbLocal.SaveChanges();
            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
            
            dbIM.Database.EnsureDeleted();

            Email email = new Email();

            if (OmitPropName != "EmailTVItemID") email.EmailTVItemID = 54;
            if (OmitPropName != "EmailAddress") email.EmailAddress = GetRandomEmail();
            if (OmitPropName != "EmailType") email.EmailType = (EmailTypeEnum)GetRandomEnumType(typeof(EmailTypeEnum));
            if (OmitPropName != "LastUpdateDate_UTC") email.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") email.LastUpdateContactTVItemID = 2;

            if (LoggedInService.DBLocation == DBLocationEnum.Local)
            {
                if (OmitPropName != "EmailID") email.EmailID = 10000000;

                try
                {
                    dbIM.TVItems.Add(new TVItem() { TVItemID = 54, TVLevel = 1, TVPath = "p1p54", TVType = (TVTypeEnum)7, ParentID = 5, IsActive = true, LastUpdateDate_UTC = new DateTime(2015, 2, 17, 16, 15, 51), LastUpdateContactTVItemID = 2});
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

            return email;
        }
        private void CheckEmailFields(List<Email> emailList)
        {
            Assert.False(string.IsNullOrWhiteSpace(emailList[0].EmailAddress));
        }
        #endregion Functions private
    }
}
