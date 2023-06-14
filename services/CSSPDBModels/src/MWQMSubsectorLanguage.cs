namespace CSSPDBModels;

public partial class MWQMSubsectorLanguage : LastUpdate
{
    [Key]
    public int MWQMSubsectorLanguageID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "MWQMSubsector", ExistPlurial = "s", ExistFieldID = "MWQMSubsectorID")]
    [CSSPForeignKey(TableName = "MWQMSubsectors", FieldName = "MWQMSubsectorID")]
    public int MWQMSubsectorID { get; set; }
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    [CSSPMaxLength(250)]
    public string SubsectorDesc { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatusSubsectorDesc { get; set; } = TranslationStatusEnum.NotTranslated;
    [CSSPAllowNull]
    public string LogBook { get; set; } = string.Empty;
    [CSSPEnumType]
    [CSSPAllowNull]
    public TranslationStatusEnum? TranslationStatusLogBook { get; set; } = TranslationStatusEnum.NotTranslated;

    public MWQMSubsectorLanguage() : base()
    {

    }
}

