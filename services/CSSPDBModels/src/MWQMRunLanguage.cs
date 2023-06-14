namespace CSSPDBModels;

public partial class MWQMRunLanguage : LastUpdate
{
    [Key]
    public int MWQMRunLanguageID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "MWQMRun", ExistPlurial = "s", ExistFieldID = "MWQMRunID")]
    [CSSPForeignKey(TableName = "MWQMRuns", FieldName = "MWQMRunID")]
    public int MWQMRunID { get; set; }
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    public string RunComment { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatusRunComment { get; set; } = TranslationStatusEnum.NotTranslated;
    public string RunWeatherComment { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatusRunWeatherComment { get; set; } = TranslationStatusEnum.NotTranslated;

    public MWQMRunLanguage() : base()
    {

    }
}

