namespace CSSPModels;

[NotMapped]
public partial class TVItemTVAuth
{
    [CSSPRange(1, -1)]
    public int TVItemUserAuthID { get; set; }
    [CSSPMaxLength(255)]
    [CSSPMinLength(1)]
    public string TVText { get; set; } = string.Empty;
    [CSSPRange(1, -1)]
    public int TVItemID1 { get; set; }
    [CSSPMaxLength(255)]
    [CSSPMinLength(1)]
    public string TVTypeStr { get; set; } = string.Empty;
    [CSSPEnumType]
    public TVAuthEnum TVAuth { get; set; } = TVAuthEnum.NoAccess;
    [CSSPMaxLength(100)]
    [CSSPEnumTypeText(EnumTypeName = "TVAuthEnum", EnumType = "TVAuth")]
    [CSSPAllowNull]
    public string TVAuthText { get; set; } = string.Empty;

    public TVItemTVAuth()
    {

    }
}

