namespace CSSPModels;

[NotMapped]
public partial class TVLocation
{
    [CSSPRange(1, -1)]
    public int TVItemID { get; set; }
    [CSSPMaxLength(255)]
    [CSSPMinLength(1)]
    public string TVText { get; set; } = string.Empty;
    [CSSPEnumType]
    public TVTypeEnum TVType { get; set; } = TVTypeEnum.Address;
    [CSSPEnumType]
    public TVTypeEnum SubTVType { get; set; } = TVTypeEnum.Address;
    [CSSPMaxLength(100)]
    [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
    [CSSPAllowNull]
    public string TVTypeText { get; set; } = string.Empty;
    [CSSPMaxLength(100)]
    [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "SubTVType")]
    [CSSPAllowNull]
    public string SubTVTypeText { get; set; } = string.Empty;
    public List<MapObj> MapObjList { get; set; } = new List<MapObj>();

    public TVLocation()
    {

    }
}

