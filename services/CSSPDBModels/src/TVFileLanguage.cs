namespace CSSPDBModels;

public partial class TVFileLanguage : LastUpdate
{
    [Key]
    public int TVFileLanguageID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "TVFile", ExistPlurial = "s", ExistFieldID = "TVFileID")]
    [CSSPForeignKey(TableName = "TVFiles", FieldName = "TVFileID")]
    public int TVFileID { get; set; }
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    [CSSPAllowNull]
    public string FileDescription { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatus { get; set; } = TranslationStatusEnum.NotTranslated;

    public TVFileLanguage() : base()
    {

    }
}

