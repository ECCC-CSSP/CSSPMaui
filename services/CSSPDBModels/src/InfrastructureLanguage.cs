namespace CSSPDBModels;

public partial class InfrastructureLanguage : LastUpdate
{
    [Key]
    public int InfrastructureLanguageID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "Infrastructure", ExistPlurial = "s", ExistFieldID = "InfrastructureID")]
    [CSSPForeignKey(TableName = "Infrastructures", FieldName = "InfrastructureID")]
    public int InfrastructureID { get; set; }
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    public string Comment { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatus { get; set; } = TranslationStatusEnum.NotTranslated;

    public InfrastructureLanguage() : base()
    {

    }
}

