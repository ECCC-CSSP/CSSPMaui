namespace CSSPDBModels;

public partial class PolSourceObservationIssue : LastUpdate
{
    [Key]
    public int PolSourceObservationIssueID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "PolSourceObservation", ExistPlurial = "s", ExistFieldID = "PolSourceObservationID")]
    [CSSPForeignKey(TableName = "PolSourceObservations", FieldName = "PolSourceObservationID")]
    public int PolSourceObservationID { get; set; }
    [CSSPMaxLength(250)]
    public string ObservationInfo { get; set; } = string.Empty;
    [CSSPRange(0, 1000)]
    public int Ordinal { get; set; }
    [CSSPAllowNull]
    public string ExtraComment { get; set; } = string.Empty;

    public PolSourceObservationIssue() : base()
    {

    }
}

