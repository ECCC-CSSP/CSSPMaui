namespace CSSPModels;

[NotMapped]
public partial class MWQMRunModel
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public MWQMRun MWQMRun { get; set; } = new MWQMRun();
    public List<MWQMRunLanguage> MWQMRunLanguageList { get; set; } = new List<MWQMRunLanguage>();

    public MWQMRunModel()
    {

    }
}

