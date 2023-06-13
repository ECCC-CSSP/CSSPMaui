namespace CSSPModels;

[NotMapped]
public partial class WebSector
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<TVItemModel> TVItemModelSubsectorList { get; set; } = new List<TVItemModel>();
    public List<TVFileModel> TVFileModelList { get; set; } = new List<TVFileModel>();

    public WebSector()
    {

    }
}

