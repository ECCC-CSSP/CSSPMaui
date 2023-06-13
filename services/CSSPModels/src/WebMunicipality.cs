namespace CSSPModels;

[NotMapped]
public partial class WebMunicipality
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<TVFileModel> TVFileModelList { get; set; } = new List<TVFileModel>();
    public List<ContactModel> MunicipalityContactModelList { get; set; } = new List<ContactModel>();
    public List<TVItemLink> MunicipalityTVItemLinkList { get; set; } = new List<TVItemLink>();
    public List<InfrastructureModel> InfrastructureModelList { get; set; } = new List<InfrastructureModel>();

    public WebMunicipality()
    {

    }
}

