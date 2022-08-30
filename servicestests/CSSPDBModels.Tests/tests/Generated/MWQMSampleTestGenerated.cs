/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class MWQMSampleTest
{
    private MWQMSample mWQMSample { get; set; }

    public MWQMSampleTest()
    {
        mWQMSample = new MWQMSample();
    }
    [Fact]
    public void MWQMSample_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "MWQMSampleID", "DBCommand", "MWQMSiteTVItemID", "MWQMRunTVItemID", "SampleDateTime_Local", "TimeText", "Depth_m", "FecCol_MPN_100ml", "Salinity_PPT", "WaterTemp_C", "PH", "SampleTypesText", "SampleType_old", "Tube_10", "Tube_1_0", "Tube_0_1", "ProcessedBy", "UseForOpenData", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(MWQMSample).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(MWQMSample).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void MWQMSample_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(MWQMSample).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(MWQMSample).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void MWQMSample_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           mWQMSample.MWQMSampleID = val1;
           Assert.Equal(val1, mWQMSample.MWQMSampleID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           mWQMSample.DBCommand = val2;
           Assert.Equal(val2, mWQMSample.DBCommand);
           int val3 = 45;
           mWQMSample.MWQMSiteTVItemID = val3;
           Assert.Equal(val3, mWQMSample.MWQMSiteTVItemID);
           int val4 = 45;
           mWQMSample.MWQMRunTVItemID = val4;
           Assert.Equal(val4, mWQMSample.MWQMRunTVItemID);
           DateTime val5 = new DateTime(2010, 3, 4);
           mWQMSample.SampleDateTime_Local = val5;
           Assert.Equal(val5, mWQMSample.SampleDateTime_Local);
           string val6 = "Some text";
           mWQMSample.TimeText = val6;
           Assert.Equal(val6, mWQMSample.TimeText);
           double val7 = 87.9D;
           mWQMSample.Depth_m = val7;
           Assert.Equal(val7, mWQMSample.Depth_m);
           int val8 = 45;
           mWQMSample.FecCol_MPN_100ml = val8;
           Assert.Equal(val8, mWQMSample.FecCol_MPN_100ml);
           double val9 = 87.9D;
           mWQMSample.Salinity_PPT = val9;
           Assert.Equal(val9, mWQMSample.Salinity_PPT);
           double val10 = 87.9D;
           mWQMSample.WaterTemp_C = val10;
           Assert.Equal(val10, mWQMSample.WaterTemp_C);
           double val11 = 87.9D;
           mWQMSample.PH = val11;
           Assert.Equal(val11, mWQMSample.PH);
           string val12 = "Some text";
           mWQMSample.SampleTypesText = val12;
           Assert.Equal(val12, mWQMSample.SampleTypesText);
           SampleTypeEnum val13 = (SampleTypeEnum)3;
           mWQMSample.SampleType_old = val13;
           Assert.Equal(val13, mWQMSample.SampleType_old);
           int val14 = 45;
           mWQMSample.Tube_10 = val14;
           Assert.Equal(val14, mWQMSample.Tube_10);
           int val15 = 45;
           mWQMSample.Tube_1_0 = val15;
           Assert.Equal(val15, mWQMSample.Tube_1_0);
           int val16 = 45;
           mWQMSample.Tube_0_1 = val16;
           Assert.Equal(val16, mWQMSample.Tube_0_1);
           string val17 = "Some text";
           mWQMSample.ProcessedBy = val17;
           Assert.Equal(val17, mWQMSample.ProcessedBy);
           bool val18 = true;
           mWQMSample.UseForOpenData = val18;
           Assert.Equal(val18, mWQMSample.UseForOpenData);
           DateTime val19 = new DateTime(2010, 3, 4);
           mWQMSample.LastUpdateDate_UTC = val19;
           Assert.Equal(val19, mWQMSample.LastUpdateDate_UTC);
           int val20 = 45;
           mWQMSample.LastUpdateContactTVItemID = val20;
           Assert.Equal(val20, mWQMSample.LastUpdateContactTVItemID);
    }
}
