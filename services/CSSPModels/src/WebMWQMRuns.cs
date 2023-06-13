namespace CSSPModels;

[NotMapped]
public partial class WebMWQMRuns
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<MWQMRunModel> MWQMRunModelList { get; set; } = new List<MWQMRunModel>();

    public WebMWQMRuns()
    {

    }
}

