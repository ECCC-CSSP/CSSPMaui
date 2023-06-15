using CSSPCultureServices.Resources;

namespace CSSPAzureLoginServices.Tests;

public partial class CSSPAzureLoginServiceTests
{
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Login_Good_Test(string culture)
    {
        Assert.True(await CSSPAzureLoginServiceSetup(culture));

        Assert.NotNull(Configuration);

        string? LoginEmailText = Configuration["LoginEmail"];
        string? PasswordText = Configuration["Password"];

        Assert.NotNull(LoginEmailText);
        Assert.NotNull(PasswordText);

        LoginModel loginModel = new LoginModel()
        {
            LoginEmail = LoginEmailText,
            Password = PasswordText,
        };

        Assert.NotNull(CSSPAzureLoginService);

        var actionRes = await CSSPAzureLoginService.AzureLoginAsync(loginModel);
        var azureLoginRes = actionRes.Result;
        
        Assert.NotNull(azureLoginRes);
                
        Assert.Equal(200, ((ObjectResult)azureLoginRes).StatusCode);
        Assert.NotNull(((OkObjectResult)azureLoginRes).Value);
        Assert.True((bool?)((OkObjectResult)azureLoginRes).Value);

        Assert.NotNull(CSSPLogService);
        Assert.Empty(CSSPLogService.ErrRes.ErrList);

        Assert.NotNull(dbManage);

        Contact? contact = new Contact();
        contact = (from c in dbManage.Contacts
                   select c).FirstOrDefault();
        Assert.NotNull(contact);

        Assert.NotNull(CSSPLocalLoggedInService);
        Assert.NotNull(CSSPLocalLoggedInService.LoggedInContactInfo);
        Assert.NotNull(CSSPLocalLoggedInService.LoggedInContactInfo.LoggedInContact);
        Assert.Equal(contact.ContactTVItemID, CSSPLocalLoggedInService.LoggedInContactInfo.LoggedInContact.ContactTVItemID);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Login_LoginEmail_Required_Error_Test(string culture)
    {
        Assert.True(await CSSPAzureLoginServiceSetup(culture));

        Assert.NotNull(Configuration);

        string? LoginEmailText = Configuration["LoginEmail"];
        string? PasswordText = Configuration["Password"];

        Assert.NotNull(LoginEmailText);
        Assert.NotNull(PasswordText);

        LoginModel loginModel = new LoginModel()
        {
            LoginEmail = LoginEmailText,
            Password = PasswordText,
        };

        loginModel.LoginEmail = "";

        Assert.NotNull(CSSPAzureLoginService);

        var actionRes = await CSSPAzureLoginService.AzureLoginAsync(loginModel);
        var azureLoginRes = actionRes.Result;

        Assert.NotNull(azureLoginRes);

        Assert.Equal(400, ((ObjectResult)azureLoginRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)azureLoginRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)azureLoginRes).Value;

        Assert.NotNull(CSSPLogService);

        Assert.NotNull(errRes);
        Assert.NotEmpty(errRes.ErrList);
        Assert.Equal(string.Format(CSSPCultureServicesRes._IsRequired, "LoginEmail"), CSSPLogService.ErrRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Login_Password_Required_Error_Test(string culture)
    {
        Assert.True(await CSSPAzureLoginServiceSetup(culture));

        Assert.NotNull(Configuration);

        string? LoginEmailText = Configuration["LoginEmail"];
        string? PasswordText = Configuration["Password"];

        Assert.NotNull(LoginEmailText);
        Assert.NotNull(PasswordText);

        LoginModel loginModel = new LoginModel()
        {
            LoginEmail = LoginEmailText,
            Password = PasswordText,
        };

        loginModel.Password = "";

        Assert.NotNull(CSSPAzureLoginService);

        var actionRes = await CSSPAzureLoginService.AzureLoginAsync(loginModel);
        var azureLoginRes = actionRes.Result;

        Assert.NotNull(azureLoginRes);

        Assert.Equal(400, ((ObjectResult)azureLoginRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)azureLoginRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)azureLoginRes).Value;

        Assert.NotNull(CSSPLogService);

        Assert.NotNull(errRes);
        Assert.NotEmpty(errRes.ErrList);
        Assert.Equal(string.Format(CSSPCultureServicesRes._IsRequired, "Password"), CSSPLogService.ErrRes.ErrList[0]);
    }
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task Login_UnableToLogin_Error_Test(string culture)
    {
        Assert.True(await CSSPAzureLoginServiceSetup(culture));

        Assert.NotNull(Configuration);

        string? LoginEmailText = Configuration["LoginEmail"];
        string? PasswordText = Configuration["Password"];

        Assert.NotNull(LoginEmailText);
        Assert.NotNull(PasswordText);

        LoginModel loginModel = new LoginModel()
        {
            LoginEmail = LoginEmailText,
            Password = PasswordText,
        };

        loginModel.LoginEmail = "WillNotWork" + loginModel.LoginEmail;

        Assert.NotNull(CSSPAzureLoginService);

        var actionRes = await CSSPAzureLoginService.AzureLoginAsync(loginModel);
        var azureLoginRes = actionRes.Result;

        Assert.NotNull(azureLoginRes);

        Assert.Equal(400, ((ObjectResult)azureLoginRes).StatusCode);
        Assert.NotNull(((BadRequestObjectResult)azureLoginRes).Value);
        
        ErrRes? errRes = (ErrRes?)((BadRequestObjectResult)azureLoginRes).Value;

        Assert.NotNull(CSSPLogService);

        Assert.NotNull(errRes);
        Assert.NotEmpty(errRes.ErrList);
        Assert.Equal(string.Format(CSSPCultureServicesRes.UnableToLoginAs_WithProvidedPassword, loginModel.LoginEmail), CSSPLogService.ErrRes.ErrList[0]);
    }
}

