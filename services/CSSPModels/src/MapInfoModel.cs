namespace CSSPModels;

[NotMapped]
public partial class MapInfoModel
{
    public MapInfo MapInfo { get; set; } = new MapInfo();
    public List<MapInfoPoint> MapInfoPointList { get; set; } = new List<MapInfoPoint>();

    public MapInfoModel()
    {

    }
}

