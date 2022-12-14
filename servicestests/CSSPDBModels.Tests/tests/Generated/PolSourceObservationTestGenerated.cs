/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class PolSourceObservationTest
{
    private PolSourceObservation polSourceObservation { get; set; }

    public PolSourceObservationTest()
    {
        polSourceObservation = new PolSourceObservation();
    }
    [Fact]
    public void PolSourceObservation_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "PolSourceObservationID", "DBCommand", "PolSourceSiteID", "ObservationDate_Local", "ContactTVItemID", "DesktopReviewed", "Observation_ToBeDeleted", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void PolSourceObservation_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void PolSourceObservation_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           polSourceObservation.PolSourceObservationID = val1;
           Assert.Equal(val1, polSourceObservation.PolSourceObservationID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           polSourceObservation.DBCommand = val2;
           Assert.Equal(val2, polSourceObservation.DBCommand);
           int val3 = 45;
           polSourceObservation.PolSourceSiteID = val3;
           Assert.Equal(val3, polSourceObservation.PolSourceSiteID);
           DateTime val4 = new DateTime(2010, 3, 4);
           polSourceObservation.ObservationDate_Local = val4;
           Assert.Equal(val4, polSourceObservation.ObservationDate_Local);
           int val5 = 45;
           polSourceObservation.ContactTVItemID = val5;
           Assert.Equal(val5, polSourceObservation.ContactTVItemID);
           bool val6 = true;
           polSourceObservation.DesktopReviewed = val6;
           Assert.Equal(val6, polSourceObservation.DesktopReviewed);
           string val7 = "Some text";
           polSourceObservation.Observation_ToBeDeleted = val7;
           Assert.Equal(val7, polSourceObservation.Observation_ToBeDeleted);
           DateTime val8 = new DateTime(2010, 3, 4);
           polSourceObservation.LastUpdateDate_UTC = val8;
           Assert.Equal(val8, polSourceObservation.LastUpdateDate_UTC);
           int val9 = 45;
           polSourceObservation.LastUpdateContactTVItemID = val9;
           Assert.Equal(val9, polSourceObservation.LastUpdateContactTVItemID);
    }
}
