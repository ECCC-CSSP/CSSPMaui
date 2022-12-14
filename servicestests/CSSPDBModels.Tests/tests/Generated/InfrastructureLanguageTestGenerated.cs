/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class InfrastructureLanguageTest
{
    private InfrastructureLanguage infrastructureLanguage { get; set; }

    public InfrastructureLanguageTest()
    {
        infrastructureLanguage = new InfrastructureLanguage();
    }
    [Fact]
    public void InfrastructureLanguage_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "InfrastructureLanguageID", "DBCommand", "InfrastructureID", "Language", "Comment", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguage).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void InfrastructureLanguage_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguage).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void InfrastructureLanguage_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           infrastructureLanguage.InfrastructureLanguageID = val1;
           Assert.Equal(val1, infrastructureLanguage.InfrastructureLanguageID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           infrastructureLanguage.DBCommand = val2;
           Assert.Equal(val2, infrastructureLanguage.DBCommand);
           int val3 = 45;
           infrastructureLanguage.InfrastructureID = val3;
           Assert.Equal(val3, infrastructureLanguage.InfrastructureID);
           LanguageEnum val4 = (LanguageEnum)3;
           infrastructureLanguage.Language = val4;
           Assert.Equal(val4, infrastructureLanguage.Language);
           string val5 = "Some text";
           infrastructureLanguage.Comment = val5;
           Assert.Equal(val5, infrastructureLanguage.Comment);
           TranslationStatusEnum val6 = (TranslationStatusEnum)3;
           infrastructureLanguage.TranslationStatus = val6;
           Assert.Equal(val6, infrastructureLanguage.TranslationStatus);
           DateTime val7 = new DateTime(2010, 3, 4);
           infrastructureLanguage.LastUpdateDate_UTC = val7;
           Assert.Equal(val7, infrastructureLanguage.LastUpdateDate_UTC);
           int val8 = 45;
           infrastructureLanguage.LastUpdateContactTVItemID = val8;
           Assert.Equal(val8, infrastructureLanguage.LastUpdateContactTVItemID);
    }
}
