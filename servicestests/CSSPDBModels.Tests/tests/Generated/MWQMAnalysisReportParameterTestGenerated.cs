/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class MWQMAnalysisReportParameterTest
{
    private MWQMAnalysisReportParameter mWQMAnalysisReportParameter { get; set; }

    public MWQMAnalysisReportParameterTest()
    {
        mWQMAnalysisReportParameter = new MWQMAnalysisReportParameter();
    }
    [Fact]
    public void MWQMAnalysisReportParameter_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "MWQMAnalysisReportParameterID", "DBCommand", "SubsectorTVItemID", "AnalysisName", "AnalysisReportYear", "StartDate", "EndDate", "AnalysisCalculationType", "NumberOfRuns", "FullYear", "SalinityHighlightDeviationFromAverage", "ShortRangeNumberOfDays", "MidRangeNumberOfDays", "DryLimit24h", "DryLimit48h", "DryLimit72h", "DryLimit96h", "WetLimit24h", "WetLimit48h", "WetLimit72h", "WetLimit96h", "RunsToOmit", "ShowDataTypes", "ExcelTVFileTVItemID", "Command", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(MWQMAnalysisReportParameter).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(MWQMAnalysisReportParameter).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void MWQMAnalysisReportParameter_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(MWQMAnalysisReportParameter).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(MWQMAnalysisReportParameter).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void MWQMAnalysisReportParameter_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           mWQMAnalysisReportParameter.MWQMAnalysisReportParameterID = val1;
           Assert.Equal(val1, mWQMAnalysisReportParameter.MWQMAnalysisReportParameterID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           mWQMAnalysisReportParameter.DBCommand = val2;
           Assert.Equal(val2, mWQMAnalysisReportParameter.DBCommand);
           int val3 = 45;
           mWQMAnalysisReportParameter.SubsectorTVItemID = val3;
           Assert.Equal(val3, mWQMAnalysisReportParameter.SubsectorTVItemID);
           string val4 = "Some text";
           mWQMAnalysisReportParameter.AnalysisName = val4;
           Assert.Equal(val4, mWQMAnalysisReportParameter.AnalysisName);
           int val5 = 45;
           mWQMAnalysisReportParameter.AnalysisReportYear = val5;
           Assert.Equal(val5, mWQMAnalysisReportParameter.AnalysisReportYear);
           DateTime val6 = new DateTime(2010, 3, 4);
           mWQMAnalysisReportParameter.StartDate = val6;
           Assert.Equal(val6, mWQMAnalysisReportParameter.StartDate);
           DateTime val7 = new DateTime(2010, 3, 4);
           mWQMAnalysisReportParameter.EndDate = val7;
           Assert.Equal(val7, mWQMAnalysisReportParameter.EndDate);
           AnalysisCalculationTypeEnum val8 = (AnalysisCalculationTypeEnum)3;
           mWQMAnalysisReportParameter.AnalysisCalculationType = val8;
           Assert.Equal(val8, mWQMAnalysisReportParameter.AnalysisCalculationType);
           int val9 = 45;
           mWQMAnalysisReportParameter.NumberOfRuns = val9;
           Assert.Equal(val9, mWQMAnalysisReportParameter.NumberOfRuns);
           bool val10 = true;
           mWQMAnalysisReportParameter.FullYear = val10;
           Assert.Equal(val10, mWQMAnalysisReportParameter.FullYear);
           double val11 = 87.9D;
           mWQMAnalysisReportParameter.SalinityHighlightDeviationFromAverage = val11;
           Assert.Equal(val11, mWQMAnalysisReportParameter.SalinityHighlightDeviationFromAverage);
           int val12 = 45;
           mWQMAnalysisReportParameter.ShortRangeNumberOfDays = val12;
           Assert.Equal(val12, mWQMAnalysisReportParameter.ShortRangeNumberOfDays);
           int val13 = 45;
           mWQMAnalysisReportParameter.MidRangeNumberOfDays = val13;
           Assert.Equal(val13, mWQMAnalysisReportParameter.MidRangeNumberOfDays);
           int val14 = 45;
           mWQMAnalysisReportParameter.DryLimit24h = val14;
           Assert.Equal(val14, mWQMAnalysisReportParameter.DryLimit24h);
           int val15 = 45;
           mWQMAnalysisReportParameter.DryLimit48h = val15;
           Assert.Equal(val15, mWQMAnalysisReportParameter.DryLimit48h);
           int val16 = 45;
           mWQMAnalysisReportParameter.DryLimit72h = val16;
           Assert.Equal(val16, mWQMAnalysisReportParameter.DryLimit72h);
           int val17 = 45;
           mWQMAnalysisReportParameter.DryLimit96h = val17;
           Assert.Equal(val17, mWQMAnalysisReportParameter.DryLimit96h);
           int val18 = 45;
           mWQMAnalysisReportParameter.WetLimit24h = val18;
           Assert.Equal(val18, mWQMAnalysisReportParameter.WetLimit24h);
           int val19 = 45;
           mWQMAnalysisReportParameter.WetLimit48h = val19;
           Assert.Equal(val19, mWQMAnalysisReportParameter.WetLimit48h);
           int val20 = 45;
           mWQMAnalysisReportParameter.WetLimit72h = val20;
           Assert.Equal(val20, mWQMAnalysisReportParameter.WetLimit72h);
           int val21 = 45;
           mWQMAnalysisReportParameter.WetLimit96h = val21;
           Assert.Equal(val21, mWQMAnalysisReportParameter.WetLimit96h);
           string val22 = "Some text";
           mWQMAnalysisReportParameter.RunsToOmit = val22;
           Assert.Equal(val22, mWQMAnalysisReportParameter.RunsToOmit);
           string val23 = "Some text";
           mWQMAnalysisReportParameter.ShowDataTypes = val23;
           Assert.Equal(val23, mWQMAnalysisReportParameter.ShowDataTypes);
           int val24 = 45;
           mWQMAnalysisReportParameter.ExcelTVFileTVItemID = val24;
           Assert.Equal(val24, mWQMAnalysisReportParameter.ExcelTVFileTVItemID);
           AnalysisReportExportCommandEnum val25 = (AnalysisReportExportCommandEnum)3;
           mWQMAnalysisReportParameter.Command = val25;
           Assert.Equal(val25, mWQMAnalysisReportParameter.Command);
           DateTime val26 = new DateTime(2010, 3, 4);
           mWQMAnalysisReportParameter.LastUpdateDate_UTC = val26;
           Assert.Equal(val26, mWQMAnalysisReportParameter.LastUpdateDate_UTC);
           int val27 = 45;
           mWQMAnalysisReportParameter.LastUpdateContactTVItemID = val27;
           Assert.Equal(val27, mWQMAnalysisReportParameter.LastUpdateContactTVItemID);
    }
}
