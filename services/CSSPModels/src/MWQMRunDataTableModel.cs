namespace CSSPModels;

[NotMapped]
public partial class MWQMRunDataTableModel
{
    public string MWQMSiteName { get; set; } = string.Empty;
    public DateTime SampleDate { get; set; } = DateTime.MinValue;
    public int FC { get; set; }
    public double Sal { get; set; }
    public double Temp { get; set; }
    public string ProcessedBy { get; set; } = string.Empty;
    public string SampleTypes { get; set; } = string.Empty;
    public string SampleNote { get; set; } = string.Empty;

    public MWQMRunDataTableModel()
    {

    }
}

