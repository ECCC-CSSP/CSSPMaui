namespace CSSPDBModels;

public partial class MWQMRun : LastUpdate
{
    [Key]
    public int MWQMRunID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int SubsectorTVItemID { get; set; }
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int MWQMRunTVItemID { get; set; }
    [CSSPEnumType]
    public SampleTypeEnum RunSampleType { get; set; } = SampleTypeEnum.Routine;
    [CSSPAfter(Year = 1980)]
    public DateTime DateTime_Local { get; set; } = DateTime.MinValue;
    [CSSPRange(1, 1000)]
    public int RunNumber { get; set; }
    [CSSPAfter(Year = 1980)]
    public DateTime? StartDateTime_Local { get; set; } = null;
    [CSSPAfter(Year = 1980)]
    [CSSPBigger(OtherField = "StartDateTime_Local")]
    public DateTime? EndDateTime_Local { get; set; } = null;
    [CSSPAfter(Year = 1980)]
    public DateTime? LabReceivedDateTime_Local { get; set; } = null;
    [CSSPRange(-10.0D, 40.0D)]
    public double? TemperatureControl1_C { get; set; }
    [CSSPRange(-10.0D, 40.0D)]
    public double? TemperatureControl2_C { get; set; }
    [CSSPEnumType]
    [CSSPAllowNull]
    public BeaufortScaleEnum? SeaStateAtStart_BeaufortScale { get; set; } = BeaufortScaleEnum.Calm;
    [CSSPEnumType]
    [CSSPAllowNull]
    public BeaufortScaleEnum? SeaStateAtEnd_BeaufortScale { get; set; } = BeaufortScaleEnum.Calm;
    [CSSPRange(0.0D, 100.0D)]
    public double? WaterLevelAtBrook_m { get; set; }
    [CSSPRange(0.0D, 100.0D)]
    public double? WaveHightAtStart_m { get; set; }
    [CSSPRange(0.0D, 100.0D)]
    public double? WaveHightAtEnd_m { get; set; }
    [CSSPMaxLength(20)]
    [CSSPAllowNull]
    public string SampleCrewInitials { get; set; } = string.Empty;
    [CSSPEnumType]
    [CSSPAllowNull]
    public AnalyzeMethodEnum? AnalyzeMethod { get; set; } = AnalyzeMethodEnum.MPN;
    [CSSPEnumType]
    [CSSPAllowNull]
    public SampleMatrixEnum? SampleMatrix { get; set; } = SampleMatrixEnum.Water;
    [CSSPEnumType]
    [CSSPAllowNull]
    public LaboratoryEnum? Laboratory { get; set; } = LaboratoryEnum.PEIAnalyticalLaboratory;
    [CSSPEnumType]
    [CSSPAllowNull]
    public SampleStatusEnum? SampleStatus { get; set; } = SampleStatusEnum.Active;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int? LabSampleApprovalContactTVItemID { get; set; }
    [CSSPAfter(Year = 1980)]
    public DateTime? LabAnalyzeBath1IncubationStartDateTime_Local { get; set; } = null;
    [CSSPAfter(Year = 1980)]
    public DateTime? LabAnalyzeBath2IncubationStartDateTime_Local { get; set; } = null;
    [CSSPAfter(Year = 1980)]
    public DateTime? LabAnalyzeBath3IncubationStartDateTime_Local { get; set; } = null;
    [CSSPAfter(Year = 1980)]
    public DateTime? LabRunSampleApprovalDateTime_Local { get; set; } = null;
    [CSSPEnumType]
    [CSSPAllowNull]
    public TideTextEnum? Tide_Start { get; set; } = null;
    [CSSPEnumType]
    [CSSPAllowNull]
    public TideTextEnum? Tide_End { get; set; } = null;
    [CSSPRange(0.0D, 300.0D)]
    public double? RainDay0_mm { get; set; }
    [CSSPRange(0.0D, 300.0D)]
    public double? RainDay1_mm { get; set; }
    [CSSPRange(0.0D, 300.0D)]
    public double? RainDay2_mm { get; set; }
    [CSSPRange(0.0D, 300.0D)]
    public double? RainDay3_mm { get; set; }
    [CSSPRange(0.0D, 300.0D)]
    public double? RainDay4_mm { get; set; }
    [CSSPRange(0.0D, 300.0D)]
    public double? RainDay5_mm { get; set; }
    [CSSPRange(0.0D, 300.0D)]
    public double? RainDay6_mm { get; set; }
    [CSSPRange(0.0D, 300.0D)]
    public double? RainDay7_mm { get; set; }
    [CSSPRange(0.0D, 300.0D)]
    public double? RainDay8_mm { get; set; }
    [CSSPRange(0.0D, 300.0D)]
    public double? RainDay9_mm { get; set; }
    [CSSPRange(0.0D, 300.0D)]
    public double? RainDay10_mm { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h0_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h1_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h2_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h3_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h4_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h5_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h6_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h7_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h8_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h9_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h10_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h11_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h12_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h13_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h14_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h15_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h16_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h17_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h18_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h19_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h20_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h21_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h22_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h23_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h24_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h25_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h26_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h27_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h28_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h29_m { get; set; }
    [CSSPRange(-20.0D, 20.0D)]
    public double? Tide_h30_m { get; set; }
    [CSSPEnumType]
    [CSSPAllowNull]
    public TideTextEnum? Tide_Start_From_WebTide { get; set; } = null;
    [CSSPEnumType]
    [CSSPAllowNull]
    public TideTextEnum? Tide_End_From_WebTide { get; set; } = null;
    public bool? RemoveFromStat { get; set; }

    public MWQMRun() : base()
    {
    }
}

