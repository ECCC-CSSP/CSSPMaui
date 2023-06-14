namespace CSSPDBModels;

public partial class BoxModelLanguage : LastUpdate
{
    [Key]
    public int BoxModelLanguageID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "BoxModel", ExistPlurial = "s", ExistFieldID = "BoxModelID")]
    [CSSPForeignKey(TableName = "BoxModels", FieldName = "BoxModelID")]
    public int BoxModelID { get; set; }
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    [CSSPMaxLength(250)]
    public string ScenarioName { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatus { get; set; } = TranslationStatusEnum.NotTranslated;

    public BoxModelLanguage() : base()
    {

    }
}

