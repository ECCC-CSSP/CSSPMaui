namespace CSSPModels;

[NotMapped]
public partial class MikeBoundaryConditionModel
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public MikeBoundaryCondition MikeBoundaryCondition { get; set; } = new MikeBoundaryCondition();

    public MikeBoundaryConditionModel()
    {

    }
}

