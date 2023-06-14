namespace CSSPDBModels;

public partial class Tel : LastUpdate
{
    [Key]
    public int TelID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "21")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int TelTVItemID { get; set; }
    [CSSPMaxLength(50)]
    public string TelNumber { get; set; } = string.Empty;
    [CSSPEnumType]
    public TelTypeEnum TelType { get; set; } = TelTypeEnum.Work;

    public Tel() : base()
    {

    }
}

