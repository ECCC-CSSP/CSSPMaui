namespace CSSPModels;

[NotMapped]
public partial class DataPathOfTide
{
    [CSSPMaxLength(200)]
    [CSSPMinLength(1)]
    public string Text { get; set; } = string.Empty;
    [CSSPEnumType]
    [CSSPAllowNull]
    public WebTideDataSetEnum? WebTideDataSet { get; set; } = null;
    [CSSPMaxLength(100)]
    [CSSPEnumTypeText(EnumTypeName = "WebTideDataSetEnum", EnumType = "WebTideDataSet")]
    [CSSPAllowNull]
    public string WebTideDataSetText { get; set; } = string.Empty;

    public DataPathOfTide()
    {

    }
}

