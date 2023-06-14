namespace CSSPDBModels;

public partial class TideLocation : LastUpdate
{
    [Key]
    public int TideLocationID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPRange(0, 10000)]
    public int Zone { get; set; }
    [CSSPMaxLength(100)]
    public string Name { get; set; } = string.Empty;
    [CSSPMaxLength(100)]
    public string Prov { get; set; } = string.Empty;
    [CSSPRange(0, 100000)]
    public int sid { get; set; }
    [CSSPRange(-90.0D, 90.0D)]
    public double Lat { get; set; }
    [CSSPRange(-180.0D, 180.0D)]
    public double Lng { get; set; }

    public TideLocation() : base()
    {

    }
}

