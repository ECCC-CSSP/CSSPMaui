namespace CSSPModels;

[NotMapped]
public partial class TVItemSubsectorAndMWQMSite
{
    public TVItem TVItemSubsector { get; set; } = new TVItem();
    public List<TVItem> TVItemMWQMSiteList { get; set; } = new List<TVItem>();
    public TVItem TVItemMWQMSiteDuplicate { get; set; } = new TVItem();

    public TVItemSubsectorAndMWQMSite()
    {

    }
}

