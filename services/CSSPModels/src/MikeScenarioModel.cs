namespace CSSPModels;

[NotMapped]
public partial class MikeScenarioModel
{
    public MikeScenario MikeScenario { get; set; } = new MikeScenario();
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVFileModel> TVFileModelList { get; set; } = new List<TVFileModel>();
    public List<MikeBoundaryConditionModel> MikeBoundaryConditionModelList { get; set; } = new List<MikeBoundaryConditionModel>();
    public List<MikeSourceModel> MikeSourceModelList { get; set; } = new List<MikeSourceModel>();

    public MikeScenarioModel()
    {

    }
}

