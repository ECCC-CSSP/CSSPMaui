namespace CSSPModels;

[NotMapped]
public partial class WebHydrometricSites
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<HydrometricSiteModel> HydrometricSiteModelList { get; set; } = new List<HydrometricSiteModel>();

    public WebHydrometricSites()
    {

    }
}

