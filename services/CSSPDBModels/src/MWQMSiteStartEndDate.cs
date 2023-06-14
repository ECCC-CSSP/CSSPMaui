namespace CSSPDBModels;

public partial class MWQMSiteStartEndDate : LastUpdate
{
    [Key]
    public int MWQMSiteStartEndDateID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int MWQMSiteTVItemID { get; set; }
    [CSSPAfter(Year = 1980)]
    public DateTime StartDate { get; set; } = DateTime.MinValue;
    [CSSPAfter(Year = 1980)]
    [CSSPBigger(OtherField = "StartDate")]
    public DateTime? EndDate { get; set; } = null;

    public MWQMSiteStartEndDate() : base()
    {

    }
}

