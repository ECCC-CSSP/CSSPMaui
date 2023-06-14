namespace CSSPDBModels;

public partial class SamplingPlan : LastUpdate
{
    [Key]
    public int SamplingPlanID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    public bool IsActive { get; set; }
    [CSSPMaxLength(200)]
    public string SamplingPlanName { get; set; } = string.Empty;
    [CSSPMaxLength(100)]
    public string ForGroupName { get; set; } = string.Empty;
    [CSSPEnumType]
    public SampleTypeEnum SampleType { get; set; } = SampleTypeEnum.Routine;
    [CSSPEnumType]
    public SamplingPlanTypeEnum SamplingPlanType { get; set; } = SamplingPlanTypeEnum.Subsector;
    [CSSPEnumType]
    public LabSheetTypeEnum LabSheetType { get; set; } = LabSheetTypeEnum.A1;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "18")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int ProvinceTVItemID { get; set; }
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int CreatorTVItemID { get; set; }
    [CSSPRange(2000, 2050)]
    public int Year { get; set; }
    [CSSPMaxLength(15)]
    public string AccessCode { get; set; } = string.Empty;
    [CSSPRange(0.0D, 100.0D)]
    public double DailyDuplicatePrecisionCriteria { get; set; }
    [CSSPRange(0.0D, 100.0D)]
    public double IntertechDuplicatePrecisionCriteria { get; set; }
    public bool IncludeLaboratoryQAQC { get; set; }
    [CSSPMaxLength(15)]
    public string ApprovalCode { get; set; } = string.Empty;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int? SamplingPlanFileTVItemID { get; set; }
    [CSSPEnumType]
    [CSSPAllowNull]
    public AnalyzeMethodEnum? AnalyzeMethodDefault { get; set; } = AnalyzeMethodEnum.MPN;
    [CSSPEnumType]
    [CSSPAllowNull]
    public SampleMatrixEnum? SampleMatrixDefault { get; set; } = SampleMatrixEnum.Water;
    [CSSPEnumType]
    [CSSPAllowNull]
    public LaboratoryEnum? LaboratoryDefault { get; set; } = LaboratoryEnum.PEIAnalyticalLaboratory;
    [CSSPMaxLength(250)]
    public string BackupDirectory { get; set; } = string.Empty;

    public SamplingPlan() : base()
    {

    }
}

