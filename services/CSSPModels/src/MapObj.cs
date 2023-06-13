namespace CSSPModels;

[NotMapped]
public partial class MapObj
{
    [CSSPRange(1, -1)]
    public int MapInfoID { get; set; }
    [CSSPEnumType]
    public MapInfoDrawTypeEnum MapInfoDrawType { get; set; } = MapInfoDrawTypeEnum.Point;
    [CSSPMaxLength(100)]
    [CSSPEnumTypeText(EnumTypeName = "MapInfoDrawTypeEnum", EnumType = "MapInfoDrawType")]
    [CSSPAllowNull]
    public string MapInfoDrawTypeText { get; set; } = string.Empty;
    public List<Coord> CoordList { get; set; } = new List<Coord>();

    public MapObj()
    {

    }
}

