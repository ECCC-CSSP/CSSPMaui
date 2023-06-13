namespace CSSPModels;

[NotMapped]
public partial class ReportTypeModel
{
    public ReportType ReportType { get; set; } = new ReportType();
    public List<ReportSection> ReportSectionList { get; set; } = new List<ReportSection>();

    public ReportTypeModel()
    {

    }
}
