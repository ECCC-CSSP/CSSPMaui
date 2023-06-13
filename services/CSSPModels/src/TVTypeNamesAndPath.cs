namespace CSSPModels;

[NotMapped]
public partial class TVTypeNamesAndPath
{
    [CSSPMaxLength(255)]
    [CSSPMinLength(1)]
    public string TVTypeName { get; set; } = string.Empty;
    [CSSPRange(1, -1)]
    public int Index { get; set; }
    [CSSPMaxLength(255)]
    [CSSPMinLength(1)]
    public string TVPath { get; set; } = string.Empty;

    public TVTypeNamesAndPath()
    {

    }
}

