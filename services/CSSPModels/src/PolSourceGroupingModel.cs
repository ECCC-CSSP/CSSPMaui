namespace CSSPModels;

[NotMapped]
public partial class PolSourceGroupingModel
{
    public PolSourceGrouping PolSourceGrouping { get; set; } = new PolSourceGrouping();
    public List<PolSourceGroupingLanguage> PolSourceGroupingLanguageList { get; set; } = new List<PolSourceGroupingLanguage>();

    public PolSourceGroupingModel()
    {

    }
}

