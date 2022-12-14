/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class CoCoRaHSValueTest
{
    private CoCoRaHSValue coCoRaHSValue { get; set; }

    public CoCoRaHSValueTest()
    {
        coCoRaHSValue = new CoCoRaHSValue();
    }
    [Fact]
    public void CoCoRaHSValue_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "CoCoRaHSValueID", "DBCommand", "CoCoRaHSSiteID", "ObservationDateAndTime", "TotalPrecipAmt", "NewSnowDepth", "NewSnowSWE", "TotalSnowDepth", "TotalSnowSWE", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(CoCoRaHSValue).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(CoCoRaHSValue).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void CoCoRaHSValue_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(CoCoRaHSValue).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(CoCoRaHSValue).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void CoCoRaHSValue_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           coCoRaHSValue.CoCoRaHSValueID = val1;
           Assert.Equal(val1, coCoRaHSValue.CoCoRaHSValueID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           coCoRaHSValue.DBCommand = val2;
           Assert.Equal(val2, coCoRaHSValue.DBCommand);
           int val3 = 45;
           coCoRaHSValue.CoCoRaHSSiteID = val3;
           Assert.Equal(val3, coCoRaHSValue.CoCoRaHSSiteID);
           DateTime val4 = new DateTime(2010, 3, 4);
           coCoRaHSValue.ObservationDateAndTime = val4;
           Assert.Equal(val4, coCoRaHSValue.ObservationDateAndTime);
           double val5 = 87.9D;
           coCoRaHSValue.TotalPrecipAmt = val5;
           Assert.Equal(val5, coCoRaHSValue.TotalPrecipAmt);
           double val6 = 87.9D;
           coCoRaHSValue.NewSnowDepth = val6;
           Assert.Equal(val6, coCoRaHSValue.NewSnowDepth);
           double val7 = 87.9D;
           coCoRaHSValue.NewSnowSWE = val7;
           Assert.Equal(val7, coCoRaHSValue.NewSnowSWE);
           double val8 = 87.9D;
           coCoRaHSValue.TotalSnowDepth = val8;
           Assert.Equal(val8, coCoRaHSValue.TotalSnowDepth);
           double val9 = 87.9D;
           coCoRaHSValue.TotalSnowSWE = val9;
           Assert.Equal(val9, coCoRaHSValue.TotalSnowSWE);
           DateTime val10 = new DateTime(2010, 3, 4);
           coCoRaHSValue.LastUpdateDate_UTC = val10;
           Assert.Equal(val10, coCoRaHSValue.LastUpdateDate_UTC);
           int val11 = 45;
           coCoRaHSValue.LastUpdateContactTVItemID = val11;
           Assert.Equal(val11, coCoRaHSValue.LastUpdateContactTVItemID);
    }
}
