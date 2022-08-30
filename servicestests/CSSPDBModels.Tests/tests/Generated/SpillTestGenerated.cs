/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class SpillTest
{
    private Spill spill { get; set; }

    public SpillTest()
    {
        spill = new Spill();
    }
    [Fact]
    public void Spill_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "SpillID", "DBCommand", "MunicipalityTVItemID", "InfrastructureTVItemID", "StartDateTime_Local", "EndDateTime_Local", "AverageFlow_m3_day", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(Spill).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(Spill).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void Spill_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(Spill).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(Spill).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void Spill_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           spill.SpillID = val1;
           Assert.Equal(val1, spill.SpillID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           spill.DBCommand = val2;
           Assert.Equal(val2, spill.DBCommand);
           int val3 = 45;
           spill.MunicipalityTVItemID = val3;
           Assert.Equal(val3, spill.MunicipalityTVItemID);
           int val4 = 45;
           spill.InfrastructureTVItemID = val4;
           Assert.Equal(val4, spill.InfrastructureTVItemID);
           DateTime val5 = new DateTime(2010, 3, 4);
           spill.StartDateTime_Local = val5;
           Assert.Equal(val5, spill.StartDateTime_Local);
           DateTime val6 = new DateTime(2010, 3, 4);
           spill.EndDateTime_Local = val6;
           Assert.Equal(val6, spill.EndDateTime_Local);
           double val7 = 87.9D;
           spill.AverageFlow_m3_day = val7;
           Assert.Equal(val7, spill.AverageFlow_m3_day);
           DateTime val8 = new DateTime(2010, 3, 4);
           spill.LastUpdateDate_UTC = val8;
           Assert.Equal(val8, spill.LastUpdateDate_UTC);
           int val9 = 45;
           spill.LastUpdateContactTVItemID = val9;
           Assert.Equal(val9, spill.LastUpdateContactTVItemID);
    }
}
