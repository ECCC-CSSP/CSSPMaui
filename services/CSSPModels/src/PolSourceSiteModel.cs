namespace CSSPModels;

[NotMapped]
public partial class PolSourceSiteModel
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public PolSourceSite PolSourceSite { get; set; } = new PolSourceSite();
    public List<TVFileModel> TVFileModelList { get; set; } = new List<TVFileModel>();
    public List<PolSourceObservationModel> PolSourceObservationModelList { get; set; } = new List<PolSourceObservationModel>();
    public List<PolSourceSiteEffect> PolSourceSiteEffectList { get; set; } = new List<PolSourceSiteEffect>();

    public PolSourceSiteModel()
    {

    }
}

