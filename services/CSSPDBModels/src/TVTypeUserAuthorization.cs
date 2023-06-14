namespace CSSPDBModels;

public partial class TVTypeUserAuthorization : LastUpdate
{
    [Key]
    public int TVTypeUserAuthorizationID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int ContactTVItemID { get; set; }
    [CSSPEnumType]
    public TVTypeEnum TVType { get; set; } = TVTypeEnum.Address;
    [CSSPEnumType]
    public TVAuthEnum TVAuth { get; set; } = TVAuthEnum.Read;

    public TVTypeUserAuthorization() : base()
    {

    }
}

