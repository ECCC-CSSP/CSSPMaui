namespace ManageServices;

public partial class ManageFile
{
    [Key]
    public int ManageFileID { get; set; }
    [CSSPMaxLength(100)]
    public string AzureStorage { get; set; } = string.Empty;
    [CSSPMaxLength(200)]
    public string AzureFileName { get; set; } = string.Empty;
    [CSSPMaxLength(50)]
    public string AzureETag { get; set; } = string.Empty;
    [CSSPAfter(Year = 1980)]
    public DateTime AzureCreationTimeUTC { get; set; } = DateTime.MinValue;
    public bool LoadedOnce { get; set; }

    public ManageFile()
    {

    }
}

