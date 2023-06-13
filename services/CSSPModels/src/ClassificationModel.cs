namespace CSSPModels;

[NotMapped]
public partial class ClassificationModel
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public Classification Classification { get; set; } = new Classification();

    public ClassificationModel()
    {

    }
}

