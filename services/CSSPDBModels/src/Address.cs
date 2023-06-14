namespace CSSPDBModels;

public partial class Address : LastUpdate
{
    [Key]
    public int AddressID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "2")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int AddressTVItemID { get; set; }
    [CSSPEnumType]
    public AddressTypeEnum AddressType { get; set; } = AddressTypeEnum.Civic;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "6")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int CountryTVItemID { get; set; }
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "18")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int ProvinceTVItemID { get; set; }
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "15")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int MunicipalityTVItemID { get; set; }
    [CSSPMaxLength(200)]
    [CSSPAllowNull]
    public string StreetName { get; set; } = string.Empty;
    [CSSPMaxLength(50)]
    [CSSPAllowNull]
    public string StreetNumber { get; set; } = string.Empty;
    [CSSPEnumType]
    [CSSPAllowNull]
    public StreetTypeEnum? StreetType { get; set; } = null;
    [CSSPMaxLength(11)]
    [CSSPMinLength(6)]
    [CSSPAllowNull]
    public string PostalCode { get; set; } = string.Empty;
    [CSSPMaxLength(200)]
    [CSSPMinLength(10)]
    [CSSPAllowNull]
    public string GoogleAddressText { get; set; } = string.Empty;

    public Address() : base()
    {

    }
}


