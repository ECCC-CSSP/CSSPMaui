namespace CSSPModels;

[NotMapped]
public partial class MikeSourceModel
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public MikeSource MikeSource { get; set; } = new MikeSource();
    public List<MikeSourceStartEnd> MikeSourceStartEndList { get; set; } = new List<MikeSourceStartEnd>();

    public MikeSourceModel()
    {

    }
}

