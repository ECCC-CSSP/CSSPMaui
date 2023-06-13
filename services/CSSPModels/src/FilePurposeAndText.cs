namespace CSSPModels;

[NotMapped]
public partial class FilePurposeAndText
{
    [CSSPEnumType]
    public FilePurposeEnum FilePurpose { get; set; } = FilePurposeEnum.MikeInput;
    [CSSPMaxLength(100)]
    [CSSPEnumTypeText(EnumTypeName = "FilePurposeEnum", EnumType = "FilePurpose")]
    [CSSPAllowNull]
    public string FilePurposeText { get; set; } = string.Empty;

    public FilePurposeAndText()
    {

    }
}

