namespace CSSPModels;

[NotMapped]
public partial class TVItemModel
{
    public TVItem TVItem { get; set; } = new TVItem();
    public List<TVItemLanguage> TVItemLanguageList { get; set; } = new List<TVItemLanguage>();
    public List<TVItemStat> TVItemStatList { get; set; } = new List<TVItemStat>();
    public List<MapInfoModel> MapInfoModelList { get; set; } = new List<MapInfoModel>();

    public TVItemModel()
    {

    }
}

