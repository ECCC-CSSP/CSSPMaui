namespace CSSPModels;

[NotMapped]
public partial class SamplingPlanSubsectorModel
{
    public SamplingPlanSubsector SamplingPlanSubsector { get; set; } = new SamplingPlanSubsector();
    public List<SamplingPlanSubsectorSite> SamplingPlanSubsectorSiteList { get; set; } = new List<SamplingPlanSubsectorSite>();

    public SamplingPlanSubsectorModel()
    {

    }
}

