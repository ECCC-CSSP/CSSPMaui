/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class MikeScenarioTest
{
    private MikeScenario mikeScenario { get; set; }

    public MikeScenarioTest()
    {
        mikeScenario = new MikeScenario();
    }
    [Fact]
    public void MikeScenario_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "MikeScenarioID", "DBCommand", "MikeScenarioTVItemID", "ParentMikeScenarioID", "ScenarioStatus", "ErrorInfo", "MikeScenarioStartDateTime_Local", "MikeScenarioEndDateTime_Local", "MikeScenarioStartExecutionDateTime_Local", "MikeScenarioExecutionTime_min", "WindSpeed_km_h", "WindDirection_deg", "DecayFactor_per_day", "DecayIsConstant", "DecayFactorAmplitude", "ResultFrequency_min", "AmbientTemperature_C", "AmbientSalinity_PSU", "GenerateDecouplingFiles", "UseDecouplingFiles", "UseSalinityAndTemperatureInitialConditionFromTVFileTVItemID", "ForSimulatingMWQMRunTVItemID", "ManningNumber", "NumberOfElements", "NumberOfTimeSteps", "NumberOfSigmaLayers", "NumberOfZLayers", "NumberOfHydroOutputParameters", "NumberOfTransOutputParameters", "EstimatedHydroFileSize", "EstimatedTransFileSize", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(MikeScenario).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(MikeScenario).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void MikeScenario_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(MikeScenario).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(MikeScenario).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void MikeScenario_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           mikeScenario.MikeScenarioID = val1;
           Assert.Equal(val1, mikeScenario.MikeScenarioID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           mikeScenario.DBCommand = val2;
           Assert.Equal(val2, mikeScenario.DBCommand);
           int val3 = 45;
           mikeScenario.MikeScenarioTVItemID = val3;
           Assert.Equal(val3, mikeScenario.MikeScenarioTVItemID);
           int val4 = 45;
           mikeScenario.ParentMikeScenarioID = val4;
           Assert.Equal(val4, mikeScenario.ParentMikeScenarioID);
           ScenarioStatusEnum val5 = (ScenarioStatusEnum)3;
           mikeScenario.ScenarioStatus = val5;
           Assert.Equal(val5, mikeScenario.ScenarioStatus);
           string val6 = "Some text";
           mikeScenario.ErrorInfo = val6;
           Assert.Equal(val6, mikeScenario.ErrorInfo);
           DateTime val7 = new DateTime(2010, 3, 4);
           mikeScenario.MikeScenarioStartDateTime_Local = val7;
           Assert.Equal(val7, mikeScenario.MikeScenarioStartDateTime_Local);
           DateTime val8 = new DateTime(2010, 3, 4);
           mikeScenario.MikeScenarioEndDateTime_Local = val8;
           Assert.Equal(val8, mikeScenario.MikeScenarioEndDateTime_Local);
           DateTime val9 = new DateTime(2010, 3, 4);
           mikeScenario.MikeScenarioStartExecutionDateTime_Local = val9;
           Assert.Equal(val9, mikeScenario.MikeScenarioStartExecutionDateTime_Local);
           double val10 = 87.9D;
           mikeScenario.MikeScenarioExecutionTime_min = val10;
           Assert.Equal(val10, mikeScenario.MikeScenarioExecutionTime_min);
           double val11 = 87.9D;
           mikeScenario.WindSpeed_km_h = val11;
           Assert.Equal(val11, mikeScenario.WindSpeed_km_h);
           double val12 = 87.9D;
           mikeScenario.WindDirection_deg = val12;
           Assert.Equal(val12, mikeScenario.WindDirection_deg);
           double val13 = 87.9D;
           mikeScenario.DecayFactor_per_day = val13;
           Assert.Equal(val13, mikeScenario.DecayFactor_per_day);
           bool val14 = true;
           mikeScenario.DecayIsConstant = val14;
           Assert.Equal(val14, mikeScenario.DecayIsConstant);
           double val15 = 87.9D;
           mikeScenario.DecayFactorAmplitude = val15;
           Assert.Equal(val15, mikeScenario.DecayFactorAmplitude);
           int val16 = 45;
           mikeScenario.ResultFrequency_min = val16;
           Assert.Equal(val16, mikeScenario.ResultFrequency_min);
           double val17 = 87.9D;
           mikeScenario.AmbientTemperature_C = val17;
           Assert.Equal(val17, mikeScenario.AmbientTemperature_C);
           double val18 = 87.9D;
           mikeScenario.AmbientSalinity_PSU = val18;
           Assert.Equal(val18, mikeScenario.AmbientSalinity_PSU);
           bool val19 = true;
           mikeScenario.GenerateDecouplingFiles = val19;
           Assert.Equal(val19, mikeScenario.GenerateDecouplingFiles);
           bool val20 = true;
           mikeScenario.UseDecouplingFiles = val20;
           Assert.Equal(val20, mikeScenario.UseDecouplingFiles);
           int val21 = 45;
           mikeScenario.UseSalinityAndTemperatureInitialConditionFromTVFileTVItemID = val21;
           Assert.Equal(val21, mikeScenario.UseSalinityAndTemperatureInitialConditionFromTVFileTVItemID);
           int val22 = 45;
           mikeScenario.ForSimulatingMWQMRunTVItemID = val22;
           Assert.Equal(val22, mikeScenario.ForSimulatingMWQMRunTVItemID);
           double val23 = 87.9D;
           mikeScenario.ManningNumber = val23;
           Assert.Equal(val23, mikeScenario.ManningNumber);
           int val24 = 45;
           mikeScenario.NumberOfElements = val24;
           Assert.Equal(val24, mikeScenario.NumberOfElements);
           int val25 = 45;
           mikeScenario.NumberOfTimeSteps = val25;
           Assert.Equal(val25, mikeScenario.NumberOfTimeSteps);
           int val26 = 45;
           mikeScenario.NumberOfSigmaLayers = val26;
           Assert.Equal(val26, mikeScenario.NumberOfSigmaLayers);
           int val27 = 45;
           mikeScenario.NumberOfZLayers = val27;
           Assert.Equal(val27, mikeScenario.NumberOfZLayers);
           int val28 = 45;
           mikeScenario.NumberOfHydroOutputParameters = val28;
           Assert.Equal(val28, mikeScenario.NumberOfHydroOutputParameters);
           int val29 = 45;
           mikeScenario.NumberOfTransOutputParameters = val29;
           Assert.Equal(val29, mikeScenario.NumberOfTransOutputParameters);
           int val30 = 45;
           mikeScenario.EstimatedHydroFileSize = val30;
           Assert.Equal(val30, mikeScenario.EstimatedHydroFileSize);
           int val31 = 45;
           mikeScenario.EstimatedTransFileSize = val31;
           Assert.Equal(val31, mikeScenario.EstimatedTransFileSize);
           DateTime val32 = new DateTime(2010, 3, 4);
           mikeScenario.LastUpdateDate_UTC = val32;
           Assert.Equal(val32, mikeScenario.LastUpdateDate_UTC);
           int val33 = 45;
           mikeScenario.LastUpdateContactTVItemID = val33;
           Assert.Equal(val33, mikeScenario.LastUpdateContactTVItemID);
    }
}
