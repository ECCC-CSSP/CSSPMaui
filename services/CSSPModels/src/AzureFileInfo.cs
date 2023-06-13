namespace CSSPModels;

[NotMapped]
public partial class AzureFileInfo
{
    public int ParentTVItemID { get; set; }
    public string FileName { get; set; } = string.Empty;
    public long Length { get; set; }

    public AzureFileInfo()
    {

    }
}

