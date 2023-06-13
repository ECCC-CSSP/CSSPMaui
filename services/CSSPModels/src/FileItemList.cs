namespace CSSPModels;

[NotMapped]
public partial class FileItemList
{
    [CSSPMaxLength(255)]
    [CSSPMinLength(1)]
    public string Text { get; set; } = string.Empty;
    [CSSPMaxLength(255)]
    [CSSPMinLength(1)]
    public string FileName { get; set; } = string.Empty;

    public FileItemList()
    {

    }
}

