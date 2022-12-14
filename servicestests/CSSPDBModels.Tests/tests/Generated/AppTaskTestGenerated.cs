/*
 * Auto generated from C:\CSSPTools\src\codegen\GenerateCSSPDBModels_TestsGenerated\bin\Debug\net6.0\GenerateCSSPDBModels_TestsGenerated.exe
 *
 * Do not edit this file.
 *
 */ 

namespace CSSPDBModels.Tests;

public partial class AppTaskTest
{
    private AppTask appTask { get; set; }

    public AppTaskTest()
    {
        appTask = new AppTask();
    }
    [Fact]
    public void AppTask_Properties_Test()
    {
        List<string> propNameList = new List<string>() { "AppTaskID", "DBCommand", "TVItemID", "TVItemID2", "AppTaskCommand", "AppTaskStatus", "PercentCompleted", "Parameters", "Language", "StartDateTime_UTC", "EndDateTime_UTC", "EstimatedLength_second", "RemainingTime_second", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(AppTask).GetProperties().OrderBy(c => c.Name))
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
        foreach (PropertyInfo propertyInfo in typeof(AppTask).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void AppTask_Navigation_Test()
    {
        List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
        List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

        int index = 0;
        foreach (PropertyInfo propertyInfo in typeof(AppTask).GetProperties())
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
        foreach (PropertyInfo propertyInfo in typeof(AppTask).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
    public void AppTask_Every_Property_Has_Get_Set_Test()
    {
           int val1 = 45;
           appTask.AppTaskID = val1;
           Assert.Equal(val1, appTask.AppTaskID);
           DBCommandEnum val2 = (DBCommandEnum)3;
           appTask.DBCommand = val2;
           Assert.Equal(val2, appTask.DBCommand);
           int val3 = 45;
           appTask.TVItemID = val3;
           Assert.Equal(val3, appTask.TVItemID);
           int val4 = 45;
           appTask.TVItemID2 = val4;
           Assert.Equal(val4, appTask.TVItemID2);
           AppTaskCommandEnum val5 = (AppTaskCommandEnum)3;
           appTask.AppTaskCommand = val5;
           Assert.Equal(val5, appTask.AppTaskCommand);
           AppTaskStatusEnum val6 = (AppTaskStatusEnum)3;
           appTask.AppTaskStatus = val6;
           Assert.Equal(val6, appTask.AppTaskStatus);
           int val7 = 45;
           appTask.PercentCompleted = val7;
           Assert.Equal(val7, appTask.PercentCompleted);
           string val8 = "Some text";
           appTask.Parameters = val8;
           Assert.Equal(val8, appTask.Parameters);
           LanguageEnum val9 = (LanguageEnum)3;
           appTask.Language = val9;
           Assert.Equal(val9, appTask.Language);
           DateTime val10 = new DateTime(2010, 3, 4);
           appTask.StartDateTime_UTC = val10;
           Assert.Equal(val10, appTask.StartDateTime_UTC);
           DateTime val11 = new DateTime(2010, 3, 4);
           appTask.EndDateTime_UTC = val11;
           Assert.Equal(val11, appTask.EndDateTime_UTC);
           int val12 = 45;
           appTask.EstimatedLength_second = val12;
           Assert.Equal(val12, appTask.EstimatedLength_second);
           int val13 = 45;
           appTask.RemainingTime_second = val13;
           Assert.Equal(val13, appTask.RemainingTime_second);
           DateTime val14 = new DateTime(2010, 3, 4);
           appTask.LastUpdateDate_UTC = val14;
           Assert.Equal(val14, appTask.LastUpdateDate_UTC);
           int val15 = 45;
           appTask.LastUpdateContactTVItemID = val15;
           Assert.Equal(val15, appTask.LastUpdateContactTVItemID);
    }
}
