namespace CSSPDBModels;

public partial class AppErrLog : LastUpdate
{
    [Key]
    public int AppErrLogID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; }
    [CSSPMaxLength(100)]
    public string Tag { get; set; } = string.Empty;
    [CSSPRange(1, -1)]
    public int LineNumber { get; set; }
    public string Source { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    [CSSPAfter(Year = 1980)]
    public DateTime DateTime_UTC { get; set; }

    public AppErrLog() : base()
    {
    }
}
