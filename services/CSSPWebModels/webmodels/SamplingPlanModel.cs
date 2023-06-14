namespace CSSPWebModels;

[NotMapped]
public partial class SamplingPlanModel
{
    public SamplingPlan SamplingPlan { get; set; } = new SamplingPlan();
    public List<SamplingPlanSubsectorModel> SamplingPlanSubsectorModelList { get; set; } = new List<SamplingPlanSubsectorModel>();
    public List<SamplingPlanEmail> SamplingPlanEmailList { get; set; } = new List<SamplingPlanEmail>();

    public SamplingPlanModel()
    {

    }
}

