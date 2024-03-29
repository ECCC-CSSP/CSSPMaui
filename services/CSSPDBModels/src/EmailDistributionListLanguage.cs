﻿namespace CSSPDBModels;

public partial class EmailDistributionListLanguage : LastUpdate
{
    [Key]
    public int EmailDistributionListLanguageID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "EmailDistributionList", ExistPlurial = "s", ExistFieldID = "EmailDistributionListID")]
    [CSSPForeignKey(TableName = "EmailDistributionLists", FieldName = "EmailDistributionListID")]
    public int EmailDistributionListID { get; set; }
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    [CSSPMaxLength(100)]
    [CSSPMinLength(1)]
    public string EmailListName { get; set; } = string.Empty;
    [CSSPEnumType]
    public TranslationStatusEnum TranslationStatus { get; set; } = TranslationStatusEnum.NotTranslated;

    public EmailDistributionListLanguage() : base()
    {

    }
}

