﻿namespace CSSPDBModels;

public partial class MWQMSubsector : LastUpdate
{
    [Key]
    public int MWQMSubsectorID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int MWQMSubsectorTVItemID { get; set; }
    [CSSPMaxLength(20)]
    public string SubsectorHistoricKey { get; set; } = string.Empty;
    [CSSPMaxLength(20)]
    [CSSPAllowNull]
    public string TideLocationSIDText { get; set; } = string.Empty;

    public MWQMSubsector() : base()
    {

    }
}

