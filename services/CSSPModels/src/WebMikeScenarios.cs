namespace CSSPModels;

[NotMapped]
public partial class WebMikeScenarios
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<MikeScenarioModel> MikeScenarioModelList { get; set; } = new List<MikeScenarioModel>();

    public WebMikeScenarios()
    {

    }
}

