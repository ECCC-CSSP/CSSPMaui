namespace CSSPModels;

[NotMapped]
public partial class WebArea
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<TVItemModel> TVItemModelSectorList { get; set; } = new List<TVItemModel>();
    public List<TVFileModel> TVFileModelList { get; set; } = new List<TVFileModel>();

    public WebArea()
    {

    }
}

