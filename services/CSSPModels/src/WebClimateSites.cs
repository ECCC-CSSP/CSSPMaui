namespace CSSPModels;

[NotMapped]
public partial class WebClimateSites
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<ClimateSiteModel> ClimateSiteModelList { get; set; } = new List<ClimateSiteModel>();

    public WebClimateSites()
    {

    }
}

