namespace CSSPReadGzFileServices.Tests;

public partial class GetUncompressJSONTests : CSSPReadGzFileServiceTests
{
    [Theory]
    [InlineData("en-CA")]
    //[InlineData("fr-CA")]
    public async Task WebAllContacts_Good_Test(string culture)
    {
        Assert.True(await CSSPReadGzFileServiceSetup(culture));

        int TVItemID = 0;
        WebTypeEnum webType = WebTypeEnum.WebAllContacts;

        await DoFullGetUncompressJSONTest(webType, TVItemID);
    }
}

