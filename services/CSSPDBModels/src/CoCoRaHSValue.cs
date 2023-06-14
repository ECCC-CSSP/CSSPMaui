namespace CSSPDBModels;

public partial class CoCoRaHSValue : LastUpdate
{
    [Key]
    public int CoCoRaHSValueID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "CoCoRaHSSite", ExistPlurial = "s", ExistFieldID = "CoCoRaHSSiteID")]
    [CSSPForeignKey(TableName = "CoCoRaHSSites", FieldName = "CoCoRaHSSiteID")]
    public int CoCoRaHSSiteID { get; set; }
    [CSSPAfter(Year = 1980)]
    public DateTime ObservationDateAndTime { get; set; } = DateTime.MinValue;
    [CSSPRange(0.0D, 10000.0D)]
    [CSSPAllowNull]
    public double? TotalPrecipAmt { get; set; } = null;
    [CSSPRange(0.0D, 10000.0D)]
    [CSSPAllowNull]
    public double? NewSnowDepth { get; set; } = null;
    [CSSPRange(0.0D, 10000.0D)]
    [CSSPAllowNull]
    public double? NewSnowSWE { get; set; } = null;
    [CSSPRange(0.0D, 10000.0D)]
    [CSSPAllowNull]
    public double? TotalSnowDepth { get; set; } = null;
    [CSSPRange(0.0D, 10000.0D)]
    [CSSPAllowNull]
    public double? TotalSnowSWE { get; set; } = null;

    public CoCoRaHSValue() : base()
    {

    }
}
