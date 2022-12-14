/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class TVTypeUserAuthorizationTest
{
    private TVTypeUserAuthorization tVTypeUserAuthorization { get; set; }

    public TVTypeUserAuthorizationTest()
    {
        tVTypeUserAuthorization = new TVTypeUserAuthorization();
    }
    [Fact]
    public void TVTypeUserAuthorization_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "TVTypeUserAuthorizationID", "DBCommand", "ContactTVItemID", "TVType", "TVAuth", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorization).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorization).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void TVTypeUserAuthorization_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorization).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorization).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void TVTypeUserAuthorization_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           tVTypeUserAuthorization.TVTypeUserAuthorizationID = val1;
           Assert.Equal(val1, tVTypeUserAuthorization.TVTypeUserAuthorizationID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           tVTypeUserAuthorization.DBCommand = val2;
           Assert.Equal(val2, tVTypeUserAuthorization.DBCommand);
           int val3 = 45;
           tVTypeUserAuthorization.ContactTVItemID = val3;
           Assert.Equal(val3, tVTypeUserAuthorization.ContactTVItemID);
           TVTypeEnum val4 = (TVTypeEnum)3;
           tVTypeUserAuthorization.TVType = val4;
           Assert.Equal(val4, tVTypeUserAuthorization.TVType);
           TVAuthEnum val5 = (TVAuthEnum)3;
           tVTypeUserAuthorization.TVAuth = val5;
           Assert.Equal(val5, tVTypeUserAuthorization.TVAuth);
           DateTime val6 = new DateTime(2010, 3, 4);
           tVTypeUserAuthorization.LastUpdateDate_UTC = val6;
           Assert.Equal(val6, tVTypeUserAuthorization.LastUpdateDate_UTC);
           int val7 = 45;
           tVTypeUserAuthorization.LastUpdateContactTVItemID = val7;
           Assert.Equal(val7, tVTypeUserAuthorization.LastUpdateContactTVItemID);
    }
}
