/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class TVItemTest
{
    private TVItem tVItem { get; set; }

    public TVItemTest()
    {
        tVItem = new TVItem();
    }
    [Fact]
    public void TVItem_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "TVItemID", "DBCommand", "TVLevel", "TVPath", "TVType", "ParentID", "IsActive", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(TVItem).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(TVItem).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void TVItem_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(TVItem).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(TVItem).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void TVItem_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           tVItem.TVItemID = val1;
           Assert.Equal(val1, tVItem.TVItemID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           tVItem.DBCommand = val2;
           Assert.Equal(val2, tVItem.DBCommand);
           int val3 = 45;
           tVItem.TVLevel = val3;
           Assert.Equal(val3, tVItem.TVLevel);
           string val4 = "Some text";
           tVItem.TVPath = val4;
           Assert.Equal(val4, tVItem.TVPath);
           TVTypeEnum val5 = (TVTypeEnum)3;
           tVItem.TVType = val5;
           Assert.Equal(val5, tVItem.TVType);
           int val6 = 45;
           tVItem.ParentID = val6;
           Assert.Equal(val6, tVItem.ParentID);
           bool val7 = true;
           tVItem.IsActive = val7;
           Assert.Equal(val7, tVItem.IsActive);
           DateTime val8 = new DateTime(2010, 3, 4);
           tVItem.LastUpdateDate_UTC = val8;
           Assert.Equal(val8, tVItem.LastUpdateDate_UTC);
           int val9 = 45;
           tVItem.LastUpdateContactTVItemID = val9;
           Assert.Equal(val9, tVItem.LastUpdateContactTVItemID);
    }
}
