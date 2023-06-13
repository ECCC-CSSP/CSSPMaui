namespace CSSPModels;

[NotMapped]
public partial class LabSheetA1Measurement
{
    public string Site { get; set; } = string.Empty;
    [CSSPRange(1, -1)]
    public int TVItemID { get; set; }
    [CSSPAllowNull]
    public DateTime? Time { get; set; } = null;
    [CSSPAllowNull]
    public int? MPN { get; set; }
    [CSSPAllowNull]
    public int? Tube10 { get; set; }
    [CSSPAllowNull]
    public int? Tube1_0 { get; set; }
    [CSSPAllowNull]
    public int? Tube0_1 { get; set; }
    [CSSPAllowNull]
    public double? Salinity { get; set; }
    public double Temperature { get; set; }
    [CSSPAllowNull]
    public string ProcessedBy { get; set; } = string.Empty;
    [CSSPEnumType]
    [CSSPAllowNull]
    public SampleTypeEnum? SampleType { get; set; } = null;
    [CSSPMaxLength(100000)]
    public string SiteComment { get; set; } = string.Empty;
    [CSSPMaxLength(100)]
    [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]
    [CSSPAllowNull]
    public string SampleTypeText { get; set; } = string.Empty;

    public LabSheetA1Measurement()
    {

    }
}

