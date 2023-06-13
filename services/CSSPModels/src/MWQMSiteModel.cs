namespace CSSPModels;

[NotMapped]
public partial class MWQMSiteModel
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public MWQMSite MWQMSite { get; set; } = new MWQMSite();
    public List<TVFileModel> TVFileModelList { get; set; } = new List<TVFileModel>();
    public List<MWQMSiteStartEndDate> MWQMSiteStartEndDateList { get; set; } = new List<MWQMSiteStartEndDate>();

    public MWQMSiteModel()
    {

    }
}

