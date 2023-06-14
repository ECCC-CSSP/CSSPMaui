namespace CSSPDBModels;

public partial class EmailDistributionListContactLanguage : LastUpdate
{
    [Key]
    public int EmailDistributionListContactLanguageID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "EmailDistributionListContact", ExistPlurial = "s", ExistFieldID = "EmailDistributionListContactID")]
    [CSSPForeignKey(TableName = "EmailDistributionListContacts", FieldName = "EmailDistributionListContactID")]
    public int EmailDistributionListContactID { get; set; }
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    [CSSPMaxLength(100)]
    [CSSPMinLength(1)]
    public string Agency { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatus { get; set; } = TranslationStatusEnum.NotTranslated;

    public EmailDistributionListContactLanguage() : base()
    {

    }
}

