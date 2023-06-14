namespace CSSPDBModels;

public partial class TideDataValue : LastUpdate
{
    [Key]
    public int TideDataValueID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "22")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int TideSiteTVItemID { get; set; }
    [CSSPAfter(Year = 1980)]
    public DateTime DateTime_Local { get; set; } = DateTime.MinValue;
    public bool Keep { get; set; }
    [CSSPEnumType]
    public TideDataTypeEnum TideDataType { get; set; } = TideDataTypeEnum.Min60;
    [CSSPEnumType]
    public StorageDataTypeEnum StorageDataType { get; set; } = StorageDataTypeEnum.Archived;
    [CSSPRange(0.0D, 10000.0D)]
    public double Depth_m { get; set; }
    [CSSPRange(0.0D, 10.0D)]
    public double UVelocity_m_s { get; set; }
    [CSSPRange(0.0D, 10.0D)]
    public double VVelocity_m_s { get; set; }
    [CSSPEnumType]
    [CSSPAllowNull]
    public TideTextEnum? TideStart { get; set; } = null;
    [CSSPEnumType]
    [CSSPAllowNull]
    public TideTextEnum? TideEnd { get; set; } = null;

    public TideDataValue() : base()
    {

    }
}

