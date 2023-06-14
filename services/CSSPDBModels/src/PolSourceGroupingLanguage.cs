namespace CSSPDBModels;

public partial class PolSourceGroupingLanguage : LastUpdate
{
    [Key]
    public int PolSourceGroupingLanguageID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "PolSourceGrouping", ExistPlurial = "s", ExistFieldID = "PolSourceGroupingID")]
    [CSSPForeignKey(TableName = "PolSourceGroupings", FieldName = "PolSourceGroupingID")]
    public int PolSourceGroupingID { get; set; }
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    [CSSPMaxLength(500)]
    public string SourceName { get; set; } = string.Empty;
    [CSSPRange(0, 1000)]
    public int SourceNameOrder { get; set; }
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatusSourceName { get; set; } = TranslationStatusEnum.NotTranslated;
    [CSSPMaxLength(50)]
    public string Init { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatusInit { get; set; } = TranslationStatusEnum.NotTranslated;
    [CSSPMaxLength(500)]
    public string Description { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatusDescription { get; set; } = TranslationStatusEnum.NotTranslated;
    [CSSPMaxLength(500)]
    public string Report { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatusReport { get; set; } = TranslationStatusEnum.NotTranslated;
    [CSSPMaxLength(500)]
    public string Text { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatusText { get; set; } = TranslationStatusEnum.NotTranslated;

    public PolSourceGroupingLanguage() : base()
    {

    }
}

