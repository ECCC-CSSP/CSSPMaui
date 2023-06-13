namespace CSSPModels;

[NotMapped]
public partial class MWQMSubsectorModel
{
    public MWQMSubsector MWQMSubsector { get; set; } = new MWQMSubsector();
    public List<MWQMSubsectorLanguage> MWQMSubsectorLanguageList { get; set; } = new List<MWQMSubsectorLanguage>();

    public MWQMSubsectorModel()
    {

    }
}

