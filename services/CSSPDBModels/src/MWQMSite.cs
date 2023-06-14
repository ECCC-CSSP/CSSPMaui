namespace CSSPDBModels;

public partial class MWQMSite : LastUpdate
{
    [Key]
    public int MWQMSiteID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int MWQMSiteTVItemID { get; set; }
    [CSSPMaxLength(8)]
    public string MWQMSiteNumber { get; set; } = string.Empty;
    [CSSPMaxLength(200)]
    public string MWQMSiteDescription { get; set; } = string.Empty;
    [CSSPEnumType]
    public MWQMSiteLatestClassificationEnum MWQMSiteLatestClassification { get; set; } = MWQMSiteLatestClassificationEnum.Unclassified;
    [CSSPRange(0, 1000)]
    public int Ordinal { get; set; }

    public MWQMSite() : base()
    {

    }
}

