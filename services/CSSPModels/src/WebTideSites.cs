namespace CSSPModels;

[NotMapped]
public partial class WebTideSites
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<TideSiteModel> TideSiteModelList { get; set; } = new List<TideSiteModel>();

    public WebTideSites()
    {

    }
}

