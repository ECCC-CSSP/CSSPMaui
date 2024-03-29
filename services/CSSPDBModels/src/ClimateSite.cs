﻿namespace CSSPDBModels;

public partial class ClimateSite : LastUpdate
{
    [Key]
    public int ClimateSiteID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "4")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int ClimateSiteTVItemID { get; set; }
    [CSSPRange(1, 100000)]
    public int? ECDBID { get; set; }
    [CSSPMaxLength(100)]
    public string ClimateSiteName { get; set; } = string.Empty;
    [CSSPMaxLength(4)]
    public string Province { get; set; } = string.Empty;
    [CSSPRange(0.0D, 10000.0D)]
    public double? Elevation_m { get; set; }
    [CSSPMaxLength(10)]
    [CSSPAllowNull]
    public string ClimateID { get; set; } = string.Empty;
    [CSSPRange(1, 100000)]
    public int? WMOID { get; set; }
    [CSSPMaxLength(3)]
    [CSSPAllowNull]
    public string TCID { get; set; } = string.Empty;
    public bool? IsQuebecSite { get; set; }
    public bool? IsCoCoRaHS { get; set; }
    [CSSPRange(-10.0D, 0.0D)]
    public double? TimeOffset_hour { get; set; }
    [CSSPMaxLength(50)]
    [CSSPAllowNull]
    public string File_desc { get; set; } = string.Empty;
    [CSSPAfter(Year = 1980)]
    public DateTime? HourlyStartDate_Local { get; set; } = null;
    [CSSPAfter(Year = 1980)]
    public DateTime? HourlyEndDate_Local { get; set; } = null;
    public bool? HourlyNow { get; set; }
    [CSSPAfter(Year = 1980)]
    public DateTime? DailyStartDate_Local { get; set; } = null;
    [CSSPAfter(Year = 1980)]
    public DateTime? DailyEndDate_Local { get; set; } = null;
    public bool? DailyNow { get; set; }
    [CSSPAfter(Year = 1980)]
    public DateTime? MonthlyStartDate_Local { get; set; } = null;
    [CSSPAfter(Year = 1980)]
    public DateTime? MonthlyEndDate_Local { get; set; } = null;
    public bool? MonthlyNow { get; set; }

    public ClimateSite() : base()
    {

    }
}

