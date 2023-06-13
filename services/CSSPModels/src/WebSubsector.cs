namespace CSSPModels;

[NotMapped]
public partial class WebSubsector
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<TVFileModel> TVFileModelList { get; set; } = new List<TVFileModel>();
    public List<ClassificationModel> ClassificationModelList { get; set; } = new List<ClassificationModel>();

    public WebSubsector()
    {

    }
}

