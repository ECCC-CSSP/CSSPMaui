/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class EmailDistributionListContactLanguageTest
{
    private EmailDistributionListContactLanguage emailDistributionListContactLanguage { get; set; }

    public EmailDistributionListContactLanguageTest()
    {
        emailDistributionListContactLanguage = new EmailDistributionListContactLanguage();
    }
    [Fact]
    public void EmailDistributionListContactLanguage_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "EmailDistributionListContactLanguageID", "DBCommand", "EmailDistributionListContactID", "Language", "Agency", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguage).GetProperties().OrderBy(c => c.Name))
        {
            if (!propertyInfo.GetGetMethod().IsVirtual
                && propertyInfo.Name != "ValidationResults"
                && !propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains("NotMappedAttribute")).Any())
            {
                Assert.Equal(propNameList[index], propertyInfo.Name);
                index += 1;
            }
        }

        Assert.Equal(propNameList.Count, index);

        index = 0;
        foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
        {
            foreach (CustomAttributeData customAttributeData in propertyInfo.CustomAttributes)
            {
                if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                {
                }
            }
        }


    }
    [Fact]
    public void EmailDistributionListContactLanguage_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguage).GetProperties())
        {
            if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
            {
                bool foreignNameExist = foreignNameList.Contains(propertyInfo.Name);
                Assert.True(foreignNameExist);
                index += 1;
            }
        }

        Assert.Equal(foreignNameList.Count, index);

        index = 0;
        foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
        {
            if (propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
            {
                bool foreignNameCollectionExist = foreignNameCollectionList.Contains(propertyInfo.Name);
                Assert.True(foreignNameCollectionExist);
                index += 1;
            }
        }

        Assert.Equal(foreignNameCollectionList.Count, index);

    }
    [Fact]
    public void EmailDistributionListContactLanguage_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           emailDistributionListContactLanguage.EmailDistributionListContactLanguageID = val1;
           Assert.Equal(val1, emailDistributionListContactLanguage.EmailDistributionListContactLanguageID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           emailDistributionListContactLanguage.DBCommand = val2;
           Assert.Equal(val2, emailDistributionListContactLanguage.DBCommand);
           int val3 = 45;
           emailDistributionListContactLanguage.EmailDistributionListContactID = val3;
           Assert.Equal(val3, emailDistributionListContactLanguage.EmailDistributionListContactID);
           LanguageEnum val4 = (LanguageEnum)3;
           emailDistributionListContactLanguage.Language = val4;
           Assert.Equal(val4, emailDistributionListContactLanguage.Language);
           string val5 = "Some text";
           emailDistributionListContactLanguage.Agency = val5;
           Assert.Equal(val5, emailDistributionListContactLanguage.Agency);
           TranslationStatusEnum val6 = (TranslationStatusEnum)3;
           emailDistributionListContactLanguage.TranslationStatus = val6;
           Assert.Equal(val6, emailDistributionListContactLanguage.TranslationStatus);
           DateTime val7 = new DateTime(2010, 3, 4);
           emailDistributionListContactLanguage.LastUpdateDate_UTC = val7;
           Assert.Equal(val7, emailDistributionListContactLanguage.LastUpdateDate_UTC);
           int val8 = 45;
           emailDistributionListContactLanguage.LastUpdateContactTVItemID = val8;
           Assert.Equal(val8, emailDistributionListContactLanguage.LastUpdateContactTVItemID);
    }
}
