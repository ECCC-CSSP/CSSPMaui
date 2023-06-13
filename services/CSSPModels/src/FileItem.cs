namespace CSSPModels;

[NotMapped]
public partial class FileItem
{
    [CSSPMaxLength(255)]
    [CSSPMinLength(1)]
    public string Name { get; set; } = string.Empty;
    [CSSPRange(1, -1)]
    public int TVItemID { get; set; }

    public FileItem()
    {

    }
}

