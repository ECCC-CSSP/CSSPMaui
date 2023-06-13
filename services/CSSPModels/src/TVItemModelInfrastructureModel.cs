namespace CSSPModels;

[NotMapped]
public partial class TVItemModelInfrastructureModel
{
    public List<TVItemModel> TVItemModeWithInfrastructurelList { get; set; } = new List<TVItemModel>();
    public List<TVItemModel> TVItemModelWithoutInfrastructureList { get; set; } = new List<TVItemModel>();

    public TVItemModelInfrastructureModel()
    {

    }
}

