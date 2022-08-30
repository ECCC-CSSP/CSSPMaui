/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class MikeSourceTest
{
    private MikeSource mikeSource { get; set; }

    public MikeSourceTest()
    {
        mikeSource = new MikeSource();
    }
    [Fact]
    public void MikeSource_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "MikeSourceID", "DBCommand", "MikeSourceTVItemID", "IsContinuous", "Include", "IsRiver", "UseHydrometric", "HydrometricTVItemID", "DrainageArea_km2", "Factor", "SourceNumberString", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(MikeSource).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(MikeSource).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void MikeSource_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(MikeSource).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(MikeSource).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void MikeSource_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           mikeSource.MikeSourceID = val1;
           Assert.Equal(val1, mikeSource.MikeSourceID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           mikeSource.DBCommand = val2;
           Assert.Equal(val2, mikeSource.DBCommand);
           int val3 = 45;
           mikeSource.MikeSourceTVItemID = val3;
           Assert.Equal(val3, mikeSource.MikeSourceTVItemID);
           bool val4 = true;
           mikeSource.IsContinuous = val4;
           Assert.Equal(val4, mikeSource.IsContinuous);
           bool val5 = true;
           mikeSource.Include = val5;
           Assert.Equal(val5, mikeSource.Include);
           bool val6 = true;
           mikeSource.IsRiver = val6;
           Assert.Equal(val6, mikeSource.IsRiver);
           bool val7 = true;
           mikeSource.UseHydrometric = val7;
           Assert.Equal(val7, mikeSource.UseHydrometric);
           int val8 = 45;
           mikeSource.HydrometricTVItemID = val8;
           Assert.Equal(val8, mikeSource.HydrometricTVItemID);
           double val9 = 87.9D;
           mikeSource.DrainageArea_km2 = val9;
           Assert.Equal(val9, mikeSource.DrainageArea_km2);
           double val10 = 87.9D;
           mikeSource.Factor = val10;
           Assert.Equal(val10, mikeSource.Factor);
           string val11 = "Some text";
           mikeSource.SourceNumberString = val11;
           Assert.Equal(val11, mikeSource.SourceNumberString);
           DateTime val12 = new DateTime(2010, 3, 4);
           mikeSource.LastUpdateDate_UTC = val12;
           Assert.Equal(val12, mikeSource.LastUpdateDate_UTC);
           int val13 = 45;
           mikeSource.LastUpdateContactTVItemID = val13;
           Assert.Equal(val13, mikeSource.LastUpdateContactTVItemID);
    }
}
