namespace CSSPModels;

[NotMapped]
public partial class TVFullText
{
    [CSSPMaxLength(255)]
    [CSSPMinLength(1)]
    public string TVPath { get; set; } = string.Empty;
    [CSSPMaxLength(255)]
    [CSSPMinLength(1)]
    public string FullText { get; set; } = string.Empty;

    public TVFullText()
    {

    }
}

