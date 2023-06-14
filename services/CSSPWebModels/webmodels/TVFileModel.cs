namespace CSSPWebModels;

[NotMapped]
public partial class TVFileModel
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public TVFile TVFile { get; set; } = new TVFile();
    public List<TVFileLanguage> TVFileLanguageList { get; set; } = new List<TVFileLanguage>();
    public bool IsLocalized { get; set; }
    public bool ErrorLocalizing { get; set; }

    public TVFileModel()
    {

    }
}

