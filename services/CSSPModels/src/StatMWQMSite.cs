namespace CSSPModels;

[NotMapped]
public partial class StatMWQMSite
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public MWQMSiteModel MWQMSiteModel { get; set; } = new MWQMSiteModel();
    public List<StatMWQMSiteSample> StatMWQMSiteSampleList { get; set; } = new List<StatMWQMSiteSample>();
    public double SalinityAverage { get; set; }

    public StatMWQMSite()
    {

    }
}

