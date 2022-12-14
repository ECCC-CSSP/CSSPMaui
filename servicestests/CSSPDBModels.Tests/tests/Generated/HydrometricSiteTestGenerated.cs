/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class HydrometricSiteTest
{
    private HydrometricSite hydrometricSite { get; set; }

    public HydrometricSiteTest()
    {
        hydrometricSite = new HydrometricSite();
    }
    [Fact]
    public void HydrometricSite_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "HydrometricSiteID", "DBCommand", "HydrometricSiteTVItemID", "FedSiteNumber", "QuebecSiteNumber", "HydrometricSiteName", "Description", "Province", "Elevation_m", "StartDate_Local", "EndDate_Local", "TimeOffset_hour", "DrainageArea_km2", "IsNatural", "IsActive", "Sediment", "RHBN", "RealTime", "HasDischarge", "HasLevel", "HasRatingCurve", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(HydrometricSite).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(HydrometricSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void HydrometricSite_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(HydrometricSite).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(HydrometricSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void HydrometricSite_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           hydrometricSite.HydrometricSiteID = val1;
           Assert.Equal(val1, hydrometricSite.HydrometricSiteID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           hydrometricSite.DBCommand = val2;
           Assert.Equal(val2, hydrometricSite.DBCommand);
           int val3 = 45;
           hydrometricSite.HydrometricSiteTVItemID = val3;
           Assert.Equal(val3, hydrometricSite.HydrometricSiteTVItemID);
           string val4 = "Some text";
           hydrometricSite.FedSiteNumber = val4;
           Assert.Equal(val4, hydrometricSite.FedSiteNumber);
           string val5 = "Some text";
           hydrometricSite.QuebecSiteNumber = val5;
           Assert.Equal(val5, hydrometricSite.QuebecSiteNumber);
           string val6 = "Some text";
           hydrometricSite.HydrometricSiteName = val6;
           Assert.Equal(val6, hydrometricSite.HydrometricSiteName);
           string val7 = "Some text";
           hydrometricSite.Description = val7;
           Assert.Equal(val7, hydrometricSite.Description);
           string val8 = "Some text";
           hydrometricSite.Province = val8;
           Assert.Equal(val8, hydrometricSite.Province);
           double val9 = 87.9D;
           hydrometricSite.Elevation_m = val9;
           Assert.Equal(val9, hydrometricSite.Elevation_m);
           DateTime val10 = new DateTime(2010, 3, 4);
           hydrometricSite.StartDate_Local = val10;
           Assert.Equal(val10, hydrometricSite.StartDate_Local);
           DateTime val11 = new DateTime(2010, 3, 4);
           hydrometricSite.EndDate_Local = val11;
           Assert.Equal(val11, hydrometricSite.EndDate_Local);
           double val12 = 87.9D;
           hydrometricSite.TimeOffset_hour = val12;
           Assert.Equal(val12, hydrometricSite.TimeOffset_hour);
           double val13 = 87.9D;
           hydrometricSite.DrainageArea_km2 = val13;
           Assert.Equal(val13, hydrometricSite.DrainageArea_km2);
           bool val14 = true;
           hydrometricSite.IsNatural = val14;
           Assert.Equal(val14, hydrometricSite.IsNatural);
           bool val15 = true;
           hydrometricSite.IsActive = val15;
           Assert.Equal(val15, hydrometricSite.IsActive);
           bool val16 = true;
           hydrometricSite.Sediment = val16;
           Assert.Equal(val16, hydrometricSite.Sediment);
           bool val17 = true;
           hydrometricSite.RHBN = val17;
           Assert.Equal(val17, hydrometricSite.RHBN);
           bool val18 = true;
           hydrometricSite.RealTime = val18;
           Assert.Equal(val18, hydrometricSite.RealTime);
           bool val19 = true;
           hydrometricSite.HasDischarge = val19;
           Assert.Equal(val19, hydrometricSite.HasDischarge);
           bool val20 = true;
           hydrometricSite.HasLevel = val20;
           Assert.Equal(val20, hydrometricSite.HasLevel);
           bool val21 = true;
           hydrometricSite.HasRatingCurve = val21;
           Assert.Equal(val21, hydrometricSite.HasRatingCurve);
           DateTime val22 = new DateTime(2010, 3, 4);
           hydrometricSite.LastUpdateDate_UTC = val22;
           Assert.Equal(val22, hydrometricSite.LastUpdateDate_UTC);
           int val23 = 45;
           hydrometricSite.LastUpdateContactTVItemID = val23;
           Assert.Equal(val23, hydrometricSite.LastUpdateContactTVItemID);
    }
}
