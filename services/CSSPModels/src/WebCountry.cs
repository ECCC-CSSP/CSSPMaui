namespace CSSPModels;

[NotMapped]
public partial class WebCountry
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<TVItemModel> TVItemModelProvinceList { get; set; } = new List<TVItemModel>();
    public List<TVFileModel> TVFileModelList { get; set; } = new List<TVFileModel>();
    public List<RainExceedanceModel> RainExceedanceModelList { get; set; } = new List<RainExceedanceModel>();
    public List<EmailDistributionListModel> EmailDistributionListModelList { get; set; } = new List<EmailDistributionListModel>();

    public WebCountry()
    {

    }
}

