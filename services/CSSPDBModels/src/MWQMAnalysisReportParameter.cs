﻿namespace CSSPDBModels;

public partial class MWQMAnalysisReportParameter : LastUpdate
{
    [Key]
    public int MWQMAnalysisReportParameterID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int SubsectorTVItemID { get; set; }
    [CSSPMaxLength(250)]
    [CSSPMinLength(5)]
    public string AnalysisName { get; set; } = string.Empty;
    [CSSPRange(1980, 2050)]
    public int? AnalysisReportYear { get; set; }
    [CSSPAfter(Year = 1980)]
    public DateTime StartDate { get; set; } = DateTime.MinValue;
    [CSSPAfter(Year = 1980)]
    [CSSPBigger(OtherField = "StartDate")]
    public DateTime EndDate { get; set; } = DateTime.MinValue;
    [CSSPEnumType]
    public AnalysisCalculationTypeEnum AnalysisCalculationType { get; set; } = AnalysisCalculationTypeEnum.All;
    [CSSPRange(1, 1000)]
    public int NumberOfRuns { get; set; }
    public bool FullYear { get; set; }
    [CSSPRange(1.0D, 20.0D)]
    public double SalinityHighlightDeviationFromAverage { get; set; }
    [CSSPRange(0, 5)]
    public int ShortRangeNumberOfDays { get; set; }
    [CSSPRange(2, 7)]
    public int MidRangeNumberOfDays { get; set; }
    [CSSPRange(1, 100)]
    public int DryLimit24h { get; set; }
    [CSSPRange(1, 100)]
    public int DryLimit48h { get; set; }
    [CSSPRange(1, 100)]
    public int DryLimit72h { get; set; }
    [CSSPRange(1, 100)]
    public int DryLimit96h { get; set; }
    [CSSPRange(1, 100)]
    public int WetLimit24h { get; set; }
    [CSSPRange(1, 100)]
    public int WetLimit48h { get; set; }
    [CSSPRange(1, 100)]
    public int WetLimit72h { get; set; }
    [CSSPRange(1, 100)]
    public int WetLimit96h { get; set; }
    [CSSPMaxLength(250)]
    public string RunsToOmit { get; set; } = string.Empty;
    [CSSPMaxLength(20)]
    [CSSPAllowNull]
    public string ShowDataTypes { get; set; } = string.Empty;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int? ExcelTVFileTVItemID { get; set; }
    [CSSPEnumType]
    public AnalysisReportExportCommandEnum Command { get; set; } = AnalysisReportExportCommandEnum.Report;

    public MWQMAnalysisReportParameter() : base()
    {

    }
}

