namespace CSSPModels;

[NotMapped]
public partial class WebPolSourceSites
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<PolSourceSiteModel> PolSourceSiteModelList { get; set; } = new List<PolSourceSiteModel>();

    public WebPolSourceSites()
    {

    }
}

