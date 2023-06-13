namespace CSSPModels;

[NotMapped]
public partial class PolSourceObsInfoChild
{
    [CSSPEnumType]
    public PolSourceObsInfoEnum PolSourceObsInfo { get; set; } = PolSourceObsInfoEnum.AgriculturalSourceBarn;
    [CSSPEnumType]
    public PolSourceObsInfoEnum PolSourceObsInfoChildStart { get; set; } = PolSourceObsInfoEnum.AgriculturalSourceBarn;
    [CSSPMaxLength(100)]
    [CSSPEnumTypeText(EnumTypeName = "PolSourceObsInfoEnum", EnumType = "PolSourceObsInfo")]
    [CSSPAllowNull]
    public string PolSourceObsInfoText { get; set; } = string.Empty;
    [CSSPMaxLength(100)]
    [CSSPEnumTypeText(EnumTypeName = "PolSourceObsInfoEnum", EnumType = "PolSourceObsInfoChildStart")]
    [CSSPAllowNull]
    public string PolSourceObsInfoChildStartText { get; set; } = string.Empty;

    public PolSourceObsInfoChild()
    {

    }
}

