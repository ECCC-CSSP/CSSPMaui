namespace CSSPModels;

[NotMapped]
public partial class InfrastructureModel
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public Infrastructure Infrastructure { get; set; } = new Infrastructure();
    public List<InfrastructureLanguage> InfrastructureLanguageList { get; set; } = new List<InfrastructureLanguage>();
    public List<TVFileModel> TVFileModelList { get; set; } = new List<TVFileModel>();
    public List<BoxModelModel> BoxModelModelList { get; set; } = new List<BoxModelModel>();
    public List<VPScenarioModel> VPScenarioModelList { get; set; } = new List<VPScenarioModel>();

    public InfrastructureModel()
    {

    }
}

