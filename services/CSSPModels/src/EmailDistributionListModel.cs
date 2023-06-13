namespace CSSPModels;

[NotMapped]
public partial class EmailDistributionListModel
{
    public EmailDistributionList EmailDistributionList { get; set; } = new EmailDistributionList();
    public List<EmailDistributionListLanguage> EmailDistributionListLanguageList { get; set; } = new List<EmailDistributionListLanguage>();
    public List<EmailDistributionListContactModel> EmailDistributionListContactModelList { get; set; } = new List<EmailDistributionListContactModel>();

    public EmailDistributionListModel()
    {

    }
}

