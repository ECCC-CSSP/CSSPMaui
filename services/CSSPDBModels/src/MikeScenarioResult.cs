﻿namespace CSSPDBModels;

public partial class MikeScenarioResult : LastUpdate
{
    [Key]
    public int MikeScenarioResultID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "13")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int MikeScenarioTVItemID { get; set; }
    [CSSPAllowNull]
    public string MikeResultsJSON { get; set; } = string.Empty;

    public MikeScenarioResult() : base()
    {

    }
}

