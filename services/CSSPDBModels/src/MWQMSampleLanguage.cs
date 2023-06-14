namespace CSSPDBModels;

public partial class MWQMSampleLanguage : LastUpdate
{
    [Key]
    public int MWQMSampleLanguageID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "MWQMSample", ExistPlurial = "s", ExistFieldID = "MWQMSampleID")]
    [CSSPForeignKey(TableName = "MWQMSamples", FieldName = "MWQMSampleID")]
    public int MWQMSampleID { get; set; }
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    public string MWQMSampleNote { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatus { get; set; } = TranslationStatusEnum.NotTranslated;

    public MWQMSampleLanguage() : base()
    {

    }
}

