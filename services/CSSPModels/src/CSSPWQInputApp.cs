namespace CSSPModels;

[NotMapped]
public partial class CSSPWQInputApp
{
    [CSSPMaxLength(100)]
    [CSSPMinLength(1)]
    public string AccessCode { get; set; } = string.Empty;
    [CSSPMaxLength(4)]
    [CSSPMinLength(4)]
    public string ActiveYear { get; set; } = string.Empty;
    [CSSPRange(0.0D, 100.0D)]
    public double DailyDuplicatePrecisionCriteria { get; set; }
    [CSSPRange(0.0D, 100.0D)]
    public double IntertechDuplicatePrecisionCriteria { get; set; }
    public bool IncludeLaboratoryQAQC { get; set; }
    [CSSPMaxLength(100)]
    [CSSPMinLength(1)]
    public string ApprovalCode { get; set; } = string.Empty;
    [CSSPAfter(Year = 1980)]
    public DateTime ApprovalDate { get; set; } = DateTime.MinValue;

    public CSSPWQInputApp()
    {

    }
}

