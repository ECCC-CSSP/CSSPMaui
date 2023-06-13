namespace CSSPModels;

[NotMapped]
public partial class WebRoot
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<TVItemModel> TVItemModelCountryList { get; set; } = new List<TVItemModel>();
    public List<TVFileModel> TVFileModelList { get; set; } = new List<TVFileModel>();

    public WebRoot()
    {

    }
}

