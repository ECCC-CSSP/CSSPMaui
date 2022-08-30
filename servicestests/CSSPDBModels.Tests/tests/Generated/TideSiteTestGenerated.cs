/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class TideSiteTest
{
    private TideSite tideSite { get; set; }

    public TideSiteTest()
    {
        tideSite = new TideSite();
    }
    [Fact]
    public void TideSite_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "TideSiteID", "DBCommand", "TideSiteTVItemID", "TideSiteName", "Province", "sid", "Zone", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void TideSite_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void TideSite_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           tideSite.TideSiteID = val1;
           Assert.Equal(val1, tideSite.TideSiteID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           tideSite.DBCommand = val2;
           Assert.Equal(val2, tideSite.DBCommand);
           int val3 = 45;
           tideSite.TideSiteTVItemID = val3;
           Assert.Equal(val3, tideSite.TideSiteTVItemID);
           string val4 = "Some text";
           tideSite.TideSiteName = val4;
           Assert.Equal(val4, tideSite.TideSiteName);
           string val5 = "Some text";
           tideSite.Province = val5;
           Assert.Equal(val5, tideSite.Province);
           int val6 = 45;
           tideSite.sid = val6;
           Assert.Equal(val6, tideSite.sid);
           int val7 = 45;
           tideSite.Zone = val7;
           Assert.Equal(val7, tideSite.Zone);
           DateTime val8 = new DateTime(2010, 3, 4);
           tideSite.LastUpdateDate_UTC = val8;
           Assert.Equal(val8, tideSite.LastUpdateDate_UTC);
           int val9 = 45;
           tideSite.LastUpdateContactTVItemID = val9;
           Assert.Equal(val9, tideSite.LastUpdateContactTVItemID);
    }
}
