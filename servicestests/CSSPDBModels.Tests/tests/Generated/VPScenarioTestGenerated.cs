/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class VPScenarioTest
{
    private VPScenario vPScenario { get; set; }

    public VPScenarioTest()
    {
        vPScenario = new VPScenario();
    }
    [Fact]
    public void VPScenario_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "VPScenarioID", "DBCommand", "InfrastructureTVItemID", "VPScenarioStatus", "UseAsBestEstimate", "EffluentFlow_m3_s", "EffluentConcentration_MPN_100ml", "FroudeNumber", "PortDiameter_m", "PortDepth_m", "PortElevation_m", "VerticalAngle_deg", "HorizontalAngle_deg", "NumberOfPorts", "PortSpacing_m", "AcuteMixZone_m", "ChronicMixZone_m", "EffluentSalinity_PSU", "EffluentTemperature_C", "EffluentVelocity_m_s", "RawResults", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(VPScenario).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(VPScenario).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void VPScenario_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(VPScenario).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(VPScenario).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void VPScenario_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           vPScenario.VPScenarioID = val1;
           Assert.Equal(val1, vPScenario.VPScenarioID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           vPScenario.DBCommand = val2;
           Assert.Equal(val2, vPScenario.DBCommand);
           int val3 = 45;
           vPScenario.InfrastructureTVItemID = val3;
           Assert.Equal(val3, vPScenario.InfrastructureTVItemID);
           ScenarioStatusEnum val4 = (ScenarioStatusEnum)3;
           vPScenario.VPScenarioStatus = val4;
           Assert.Equal(val4, vPScenario.VPScenarioStatus);
           bool val5 = true;
           vPScenario.UseAsBestEstimate = val5;
           Assert.Equal(val5, vPScenario.UseAsBestEstimate);
           double val6 = 87.9D;
           vPScenario.EffluentFlow_m3_s = val6;
           Assert.Equal(val6, vPScenario.EffluentFlow_m3_s);
           int val7 = 45;
           vPScenario.EffluentConcentration_MPN_100ml = val7;
           Assert.Equal(val7, vPScenario.EffluentConcentration_MPN_100ml);
           double val8 = 87.9D;
           vPScenario.FroudeNumber = val8;
           Assert.Equal(val8, vPScenario.FroudeNumber);
           double val9 = 87.9D;
           vPScenario.PortDiameter_m = val9;
           Assert.Equal(val9, vPScenario.PortDiameter_m);
           double val10 = 87.9D;
           vPScenario.PortDepth_m = val10;
           Assert.Equal(val10, vPScenario.PortDepth_m);
           double val11 = 87.9D;
           vPScenario.PortElevation_m = val11;
           Assert.Equal(val11, vPScenario.PortElevation_m);
           double val12 = 87.9D;
           vPScenario.VerticalAngle_deg = val12;
           Assert.Equal(val12, vPScenario.VerticalAngle_deg);
           double val13 = 87.9D;
           vPScenario.HorizontalAngle_deg = val13;
           Assert.Equal(val13, vPScenario.HorizontalAngle_deg);
           int val14 = 45;
           vPScenario.NumberOfPorts = val14;
           Assert.Equal(val14, vPScenario.NumberOfPorts);
           double val15 = 87.9D;
           vPScenario.PortSpacing_m = val15;
           Assert.Equal(val15, vPScenario.PortSpacing_m);
           double val16 = 87.9D;
           vPScenario.AcuteMixZone_m = val16;
           Assert.Equal(val16, vPScenario.AcuteMixZone_m);
           double val17 = 87.9D;
           vPScenario.ChronicMixZone_m = val17;
           Assert.Equal(val17, vPScenario.ChronicMixZone_m);
           double val18 = 87.9D;
           vPScenario.EffluentSalinity_PSU = val18;
           Assert.Equal(val18, vPScenario.EffluentSalinity_PSU);
           double val19 = 87.9D;
           vPScenario.EffluentTemperature_C = val19;
           Assert.Equal(val19, vPScenario.EffluentTemperature_C);
           double val20 = 87.9D;
           vPScenario.EffluentVelocity_m_s = val20;
           Assert.Equal(val20, vPScenario.EffluentVelocity_m_s);
           string val21 = "Some text";
           vPScenario.RawResults = val21;
           Assert.Equal(val21, vPScenario.RawResults);
           DateTime val22 = new DateTime(2010, 3, 4);
           vPScenario.LastUpdateDate_UTC = val22;
           Assert.Equal(val22, vPScenario.LastUpdateDate_UTC);
           int val23 = 45;
           vPScenario.LastUpdateContactTVItemID = val23;
           Assert.Equal(val23, vPScenario.LastUpdateContactTVItemID);
    }
}
