﻿namespace CSSPDBModels;

public partial class ReportType : LastUpdate
{
    [Key]
    public int ReportTypeID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPEnumType]
    public TVTypeEnum TVType { get; set; } = TVTypeEnum.Address;
    [CSSPEnumType]
    public FileTypeEnum FileType { get; set; } = FileTypeEnum.CSV;
    [CSSPMaxLength(100)]
    public string UniqueCode { get; set; } = string.Empty;
    [CSSPEnumType]
    [CSSPAllowNull]
    public LanguageEnum? Language { get; set; } = LanguageEnum.en;
    [CSSPMaxLength(100)]
    [CSSPAllowNull]
    public string Name { get; set; } = string.Empty;
    [CSSPMaxLength(1000)]
    [CSSPAllowNull]
    public string Description { get; set; } = string.Empty;
    [CSSPMaxLength(100)]
    [CSSPAllowNull]
    public string StartOfFileName { get; set; } = string.Empty;

    public ReportType() : base()
    {

    }
}

