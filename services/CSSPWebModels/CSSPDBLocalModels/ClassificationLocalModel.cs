namespace CSSPModels;

[NotMapped]
public partial class ClassificationLocalModel
{
    public TVItem TVItemParent { get; set; } = new TVItem();
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public Classification Classification { get; set; } = new Classification();
    
    public ClassificationLocalModel()
    {

    }
}

