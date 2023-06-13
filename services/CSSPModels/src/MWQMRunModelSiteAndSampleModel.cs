namespace CSSPModels;

[NotMapped]
public partial class MWQMRunModelSiteAndSampleModel
{
    public MWQMRunModel MWQMRunModel { get; set; } = new MWQMRunModel();
    public List<MWQMSiteModelAndSampleModel> MWQMSiteModelAndSampleModelList { get; set; } = new List<MWQMSiteModelAndSampleModel>();

    public MWQMRunModelSiteAndSampleModel()
    {

    }
}

