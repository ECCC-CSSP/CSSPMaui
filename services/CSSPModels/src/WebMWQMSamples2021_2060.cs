namespace CSSPModels;

[NotMapped]
public partial class WebMWQMSamples2021_2060
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<MWQMSampleModel> MWQMSampleModelList { get; set; } = new List<MWQMSampleModel>();

    public WebMWQMSamples2021_2060()
    {

    }
}

