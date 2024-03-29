﻿namespace CSSPDBModels;

public partial class LabSheet : LastUpdate
{
    [Key]
    public int LabSheetID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPRange(1, -1)]
    public int OtherServerLabSheetID { get; set; }
    [CSSPExist(ExistTypeName = "SamplingPlan", ExistPlurial = "s", ExistFieldID = "SamplingPlanID")]
    [CSSPForeignKey(TableName = "SamplingPlans", FieldName = "SamplingPlanID")]
    public int SamplingPlanID { get; set; }
    [CSSPMaxLength(250)]
    [CSSPMinLength(1)]
    public string SamplingPlanName { get; set; } = string.Empty;
    [CSSPRange(1980, -1)]
    public int Year { get; set; }
    [CSSPRange(1, 12)]
    public int Month { get; set; }
    [CSSPRange(1, 31)]
    public int Day { get; set; }
    [CSSPRange(1, 100)]
    public int RunNumber { get; set; }
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int SubsectorTVItemID { get; set; }
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int? MWQMRunTVItemID { get; set; }
    [CSSPEnumType]
    public SamplingPlanTypeEnum SamplingPlanType { get; set; } = SamplingPlanTypeEnum.Subsector;
    [CSSPEnumType]
    public SampleTypeEnum SampleType { get; set; } = SampleTypeEnum.Routine;
    [CSSPEnumType]
    public LabSheetTypeEnum LabSheetType { get; set; } = LabSheetTypeEnum.A1;
    [CSSPEnumType]
    public LabSheetStatusEnum LabSheetStatus { get; set; } = LabSheetStatusEnum.Accepted;
    [CSSPMaxLength(250)]
    [CSSPMinLength(1)]
    public string FileName { get; set; } = string.Empty;
    [CSSPAfter(Year = 1980)]
    public DateTime FileLastModifiedDate_Local { get; set; } = DateTime.MinValue;
    public string FileContent { get; set; } = string.Empty;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int? AcceptedOrRejectedByContactTVItemID { get; set; }
    [CSSPAfter(Year = 1980)]
    public DateTime? AcceptedOrRejectedDateTime { get; set; } = null;
    [CSSPMaxLength(250)]
    [CSSPAllowNull]
    public string RejectReason { get; set; } = string.Empty;

    public LabSheet() : base()
    {

    }
}

