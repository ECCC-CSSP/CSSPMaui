namespace CSSPDBModels;

public partial class VPScenarioLanguage : LastUpdate
{
    public int VPScenarioLanguageID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "VPScenario", ExistPlurial = "s", ExistFieldID = "VPScenarioID")]
    [CSSPForeignKey(TableName = "VPScenarios", FieldName = "VPScenarioID")]
    public int VPScenarioID { get; set; }
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    [CSSPMaxLength(100)]
    public string VPScenarioName { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatus { get; set; } = TranslationStatusEnum.NotTranslated;

    public VPScenarioLanguage() : base()
    {

    }
}

