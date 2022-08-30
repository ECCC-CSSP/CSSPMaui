/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class DrogueRunPositionTest
{
    private DrogueRunPosition drogueRunPosition { get; set; }

    public DrogueRunPositionTest()
    {
        drogueRunPosition = new DrogueRunPosition();
    }
    [Fact]
    public void DrogueRunPosition_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "DrogueRunPositionID", "DBCommand", "DrogueRunID", "Ordinal", "StepLat", "StepLng", "StepDateTime_Local", "CalculatedSpeed_m_s", "CalculatedDirection_deg", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(DrogueRunPosition).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(DrogueRunPosition).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void DrogueRunPosition_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(DrogueRunPosition).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(DrogueRunPosition).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void DrogueRunPosition_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           drogueRunPosition.DrogueRunPositionID = val1;
           Assert.Equal(val1, drogueRunPosition.DrogueRunPositionID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           drogueRunPosition.DBCommand = val2;
           Assert.Equal(val2, drogueRunPosition.DBCommand);
           int val3 = 45;
           drogueRunPosition.DrogueRunID = val3;
           Assert.Equal(val3, drogueRunPosition.DrogueRunID);
           int val4 = 45;
           drogueRunPosition.Ordinal = val4;
           Assert.Equal(val4, drogueRunPosition.Ordinal);
           double val5 = 87.9D;
           drogueRunPosition.StepLat = val5;
           Assert.Equal(val5, drogueRunPosition.StepLat);
           double val6 = 87.9D;
           drogueRunPosition.StepLng = val6;
           Assert.Equal(val6, drogueRunPosition.StepLng);
           DateTime val7 = new DateTime(2010, 3, 4);
           drogueRunPosition.StepDateTime_Local = val7;
           Assert.Equal(val7, drogueRunPosition.StepDateTime_Local);
           double val8 = 87.9D;
           drogueRunPosition.CalculatedSpeed_m_s = val8;
           Assert.Equal(val8, drogueRunPosition.CalculatedSpeed_m_s);
           double val9 = 87.9D;
           drogueRunPosition.CalculatedDirection_deg = val9;
           Assert.Equal(val9, drogueRunPosition.CalculatedDirection_deg);
           DateTime val10 = new DateTime(2010, 3, 4);
           drogueRunPosition.LastUpdateDate_UTC = val10;
           Assert.Equal(val10, drogueRunPosition.LastUpdateDate_UTC);
           int val11 = 45;
           drogueRunPosition.LastUpdateContactTVItemID = val11;
           Assert.Equal(val11, drogueRunPosition.LastUpdateContactTVItemID);
    }
}
