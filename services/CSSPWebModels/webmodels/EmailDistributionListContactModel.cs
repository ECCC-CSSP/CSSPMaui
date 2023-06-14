namespace CSSPWebModels;

[NotMapped]
public partial class EmailDistributionListContactModel
{
    public EmailDistributionListContact EmailDistributionListContact { get; set; } = new EmailDistributionListContact();
    public List<EmailDistributionListContactLanguage> EmailDistributionListContactLanguageList { get; set; } = new List<EmailDistributionListContactLanguage>();

    public EmailDistributionListContactModel()
    {

    }
}

