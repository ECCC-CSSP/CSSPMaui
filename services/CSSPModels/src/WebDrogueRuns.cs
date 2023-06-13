namespace CSSPModels;

[NotMapped]
public partial class WebDrogueRuns
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<DrogueRunModel> DrogueRunModelList { get; set; } = new List<DrogueRunModel>();

    public WebDrogueRuns()
    {

    }
}

