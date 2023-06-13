namespace CSSPModels;

[NotMapped]
public partial class TVTextLanguage
{
    public string TVText { get; set; } = string.Empty;
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    [CSSPMaxLength(100)]
    [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
    [CSSPAllowNull]
    public string LanguageText { get; set; } = string.Empty;

    public TVTextLanguage()
    {

    }
}

