namespace CSSPDBModels;

public partial class SpillLanguage : LastUpdate
{
    [Key]
    public int SpillLanguageID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "Spill", ExistPlurial = "s", ExistFieldID = "SpillID")]
    [CSSPForeignKey(TableName = "Spills", FieldName = "SpillID")]
    public int SpillID { get; set; }
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    public string SpillComment { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatus { get; set; } = TranslationStatusEnum.NotTranslated;

    public SpillLanguage() : base()
    {

    }
}

