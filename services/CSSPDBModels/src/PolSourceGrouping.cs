namespace CSSPDBModels;

public partial class PolSourceGrouping : LastUpdate
{
    [Key]
    public int PolSourceGroupingID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; }
    [CSSPRange(10000, 100000)]
    public int CSSPID { get; set; }
    [CSSPMaxLength(500)]
    public string GroupName { get; set; } = string.Empty;
    [CSSPMaxLength(500)]
    public string Child { get; set; } = string.Empty;
    [CSSPMaxLength(500)]
    public string Hide { get; set; } = string.Empty;

    public PolSourceGrouping() : base()
    {
    }
}

