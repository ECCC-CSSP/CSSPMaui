namespace CSSPDBModels;

public partial class DocTemplate : LastUpdate
{
    [Key]
    public int DocTemplateID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPEnumType]
    public LanguageEnum Language { get; set; } = LanguageEnum.en;
    [CSSPEnumType]
    public TVTypeEnum TVType { get; set; } = TVTypeEnum.Address;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int TVFileTVItemID { get; set; }
    [CSSPMaxLength(150)]
    public string FileName { get; set; } = string.Empty;

    public DocTemplate() : base()
    {

    }
}

