namespace CSSPModels;

[NotMapped]
public partial class AppTaskLocalModel
{
    public AppTask AppTask { get; set; } = new AppTask();
    public List<AppTaskLanguage> AppTaskLanguageList { get; set; } = new List<AppTaskLanguage>();

    public AppTaskLocalModel()
    {

    }
}

