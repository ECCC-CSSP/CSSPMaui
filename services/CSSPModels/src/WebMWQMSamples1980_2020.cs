namespace CSSPModels;

[NotMapped]
public partial class WebMWQMSamples1980_2020
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<MWQMSampleModel> MWQMSampleModelList { get; set; } = new List<MWQMSampleModel>();

    public WebMWQMSamples1980_2020()
    {

    }
}

