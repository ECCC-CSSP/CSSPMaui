namespace CSSPModels;

[NotMapped]
public partial class WebMWQMSites
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<MWQMSiteModel> MWQMSiteModelList { get; set; } = new List<MWQMSiteModel>();

    public WebMWQMSites()
    {

    }
}

