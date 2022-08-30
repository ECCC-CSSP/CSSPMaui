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
    public partial class EmailDBLocalIMServiceTest : TestHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private IConfiguration Config { get; set; }
        private IServiceProvider Provider { get; set; }
        private IServiceCollection Services { get; set; }
        private ICSSPCultureService CSSPCultureService { get; set; }
        private ILocalService LocalService { get; set; }
        private IEmailDBLocalIMService EmailDBLocalIMService { get; set; }
        private CSSPDBInMemoryContext dbLocalIM { get; set; }
        private Email email { get; set; }
        #endregion Properties

        #region Constructors
        public EmailDBLocalIMServiceTest() : base()
        {

        }
        #endregion Constructors

        #region Tests Generated Constructor [DBLocalIM]
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task EmailDBLocalIM_Constructor_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));
        }
        #endregion Tests Generated Constructor [DBLocalIM]

        #region Tests Generated [DBLocalIM] CRUD
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task EmailDBLocalIM_CRUD_Good_Test(string culture)
        {
            Assert.True(await Setup(culture));

            email = GetFilledRandomEmail("");

            await DoCRUDDBLocalIMTest();
        }
        #endregion Tests Generated [DBLocalIM] CRUD

        #region Tests Generated Properties
        [Theory]
        [InlineData("en-CA")]
        //[InlineData("fr-CA")]
        public async Task Email_Properties_Test(string culture)
        {
            Assert.True(await Setup(culture));

            int count = 0;
            if (count == 1)
            {
                // just so we don't get a warning during compile [The variable 'count' is assigned but its value is never used]
            }

            var actionEmailList = await EmailDBLocalIMService.GetEmailList();
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

            var actionEmail = await EmailDBLocalIMService.Put(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);

            email = null;
            email = GetFilledRandomEmail("");
            email.EmailID = 10000000;
            actionEmail = await EmailDBLocalIMService.Put(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Email)]
            // email.EmailTVItemID   (Int32)
            // -----------------------------------

            email = null;
            email = GetFilledRandomEmail("");
            email.EmailTVItemID = 0;
            actionEmail = await EmailDBLocalIMService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);

            email = null;
            email = GetFilledRandomEmail("");
            email.EmailTVItemID = 1;
            actionEmail = await EmailDBLocalIMService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [DataType(DataType.EmailAddress)]
            // [CSSPMaxLength(255)]
            // email.EmailAddress   (String)
            // -----------------------------------

            email = null;
            email = GetFilledRandomEmail("EmailAddress");
            actionEmail = await EmailDBLocalIMService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);

            email = null;
            email = GetFilledRandomEmail("");
            email.EmailAddress = GetRandomString("", 256);
            actionEmail = await EmailDBLocalIMService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);
            //Assert.AreEqual(count, emailDBLocalIMService.GetEmailList().Count());

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPEnumType]
            // email.EmailType   (EmailTypeEnum)
            // -----------------------------------

            email = null;
            email = GetFilledRandomEmail("");
            email.EmailType = (EmailTypeEnum)1000000;
            actionEmail = await EmailDBLocalIMService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);


            // -----------------------------------
            // Is NOT Nullable
            // [CSSPAfter(Year = 1980)]
            // email.LastUpdateDate_UTC   (DateTime)
            // -----------------------------------

            email = null;
            email = GetFilledRandomEmail("");
            email.LastUpdateDate_UTC = new DateTime();
            actionEmail = await EmailDBLocalIMService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);
            email = null;
            email = GetFilledRandomEmail("");
            email.LastUpdateDate_UTC = new DateTime(1979, 1, 1);
            actionEmail = await EmailDBLocalIMService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);

            // -----------------------------------
            // Is NOT Nullable
            // [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVtypeList = Contact)]
            // email.LastUpdateContactTVItemID   (Int32)
            // -----------------------------------

            email = null;
            email = GetFilledRandomEmail("");
            email.LastUpdateContactTVItemID = 0;
            actionEmail = await EmailDBLocalIMService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);

            email = null;
            email = GetFilledRandomEmail("");
            email.LastUpdateContactTVItemID = 1;
            actionEmail = await EmailDBLocalIMService.Post(email);
            Assert.IsType<BadRequestObjectResult>(actionEmail.Result);

        }
        #endregion Tests Generated Properties

        #region Functions private
        private async Task DoCRUDDBLocalIMTest()
        {
            email.EmailID = 10000000;

            // Post Email
            var actionEmailAdded = await EmailDBLocalIMService.Post(email);
            Assert.Equal(200, ((ObjectResult)actionEmailAdded.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionEmailAdded.Result).Value);
            Email emailAdded = (Email)((OkObjectResult)actionEmailAdded.Result).Value;
            Assert.NotNull(emailAdded);

            // List<Email>
            var actionEmailList = await EmailDBLocalIMService.GetEmailList();
            Assert.Equal(200, ((ObjectResult)actionEmailList.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionEmailList.Result).Value);
            List<Email> emailList = (List<Email>)((OkObjectResult)actionEmailList.Result).Value;

            int count = ((List<Email>)((OkObjectResult)actionEmailList.Result).Value).Count();
            Assert.True(count > 0);

            // Get Email With EmailID
            var actionEmailGet = await EmailDBLocalIMService.GetEmailWithEmailID(emailList[0].EmailID);
            Assert.Equal(200, ((ObjectResult)actionEmailGet.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionEmailGet.Result).Value);
            Email emailGet = (Email)((OkObjectResult)actionEmailGet.Result).Value;
            Assert.NotNull(emailGet);
            Assert.Equal(emailGet.EmailID, emailList[0].EmailID);

            // Put Email
            var actionEmailUpdated = await EmailDBLocalIMService.Put(email);
            Assert.Equal(200, ((ObjectResult)actionEmailUpdated.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionEmailUpdated.Result).Value);
            Email emailUpdated = (Email)((OkObjectResult)actionEmailUpdated.Result).Value;
            Assert.NotNull(emailUpdated);

            // Delete Email
            var actionEmailDeleted = await EmailDBLocalIMService.Delete(email.EmailID);
            Assert.Equal(200, ((ObjectResult)actionEmailDeleted.Result).StatusCode);
            Assert.NotNull(((OkObjectResult)actionEmailDeleted.Result).Value);
            bool retBool = (bool)((OkObjectResult)actionEmailDeleted.Result).Value;
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
            Services.AddSingleton<IEmailDBLocalIMService, EmailDBLocalIMService>();

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

            EmailDBLocalIMService = Provider.GetService<IEmailDBLocalIMService>();
            Assert.NotNull(EmailDBLocalIMService);

            return await Task.FromResult(true);
        }
        private Email GetFilledRandomEmail(string OmitPropName)
        {
            Email email = new Email();

            if (OmitPropName != "EmailTVItemID") email.EmailTVItemID = 54;
            if (OmitPropName != "EmailAddress") email.EmailAddress = GetRandomEmail();
            if (OmitPropName != "EmailType") email.EmailType = (EmailTypeEnum)GetRandomEnumType(typeof(EmailTypeEnum));
            if (OmitPropName != "LastUpdateDate_UTC") email.LastUpdateDate_UTC = new DateTime(2005, 3, 6);
            if (OmitPropName != "LastUpdateContactTVItemID") email.LastUpdateContactTVItemID = 2;

            try
            {
                dbLocalIM.TVItems.Add(new TVItem() { TVItemID = 54, TVLevel = 1, TVPath = "p1p54", TVType = (TVTypeEnum)7, ParentID = 5, IsActive = true, LastUpdateDate_UTC = new DateTime(2015, 2, 17, 16, 15, 51), LastUpdateContactTVItemID = 2 });
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


            return email;
        }
        private void CheckEmailFields(List<Email> emailList)
        {
            Assert.False(string.IsNullOrWhiteSpace(emailList[0].EmailAddress));
        }

        #endregion Functions private
    }
}
