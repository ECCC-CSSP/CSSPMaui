namespace CSSPModels;

[NotMapped]
public partial class BoxModelModel
{
    public BoxModel BoxModel { get; set; } = new BoxModel();
    public List<BoxModelLanguage> BoxModelLanguageList { get; set; } = new List<BoxModelLanguage>();
    public List<BoxModelResult> BoxModelResultList { get; set; } = new List<BoxModelResult>();

    public BoxModelModel()
    {

    }
}

