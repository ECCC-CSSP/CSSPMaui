namespace CSSPModels;

[NotMapped]
public partial class AppTaskModel
{
    public AppTask AppTask { get; set; } = new AppTask();
    public List<AppTaskLanguage> AppTaskLanguageList { get; set; } = new List<AppTaskLanguage>();

    public AppTaskModel()
    {

    }
}

