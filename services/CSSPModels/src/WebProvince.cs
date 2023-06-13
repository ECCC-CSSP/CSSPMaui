namespace CSSPModels;

[NotMapped]
public partial class WebProvince
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<TVItemModel> TVItemModelAreaList { get; set; } = new List<TVItemModel>();
    public List<TVItemModel> TVItemModelMunicipalityList { get; set; } = new List<TVItemModel>();
    public List<TVFileModel> TVFileModelList { get; set; } = new List<TVFileModel>();
    public List<SamplingPlanModel> SamplingPlanModelList { get; set; } = new List<SamplingPlanModel>();
    public List<int> MunicipalityWithInfrastructureTVItemIDList { get; set; } = new List<int>();

    public WebProvince()
    {

    }
}

