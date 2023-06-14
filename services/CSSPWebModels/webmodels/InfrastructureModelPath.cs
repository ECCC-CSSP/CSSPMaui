namespace CSSPWebModels;

[NotMapped]
public partial class InfrastructureModelPath
{
    public InfrastructureModel InfrastructureModel { get; set; } = new InfrastructureModel();
    public List<InfrastructureModelPath> InfrastructureModelChildList { get; set; } = new List<InfrastructureModelPath>();
    public int Count { get; set; }
    public bool ShowOnMap { get; set; }

    public InfrastructureModelPath()
    {

    }
}

