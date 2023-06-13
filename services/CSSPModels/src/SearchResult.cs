namespace CSSPModels;

[NotMapped]
public partial class SearchResult
{
    public TVItem TVItem { get; set; } = new TVItem();
    public TVItemLanguage TVItemLanguage { get; set; } = new TVItemLanguage();

    public SearchResult()
    {

    }
}

