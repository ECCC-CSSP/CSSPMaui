﻿namespace CSSPDBModels;

public partial class HelpDoc : LastUpdate
{
    [Key]
    public int HelpDocID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPMaxLength(100)]
    public string DocKey { get; set; } = string.Empty;
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    [CSSPMaxLength(100000)]
    public string DocHTMLText { get; set; } = string.Empty;

    public HelpDoc() : base()
    {

    }
}

