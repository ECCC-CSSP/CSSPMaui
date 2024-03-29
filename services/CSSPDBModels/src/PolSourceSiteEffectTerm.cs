﻿namespace CSSPDBModels;

public partial class PolSourceSiteEffectTerm : LastUpdate
{
    [Key]
    public int PolSourceSiteEffectTermID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    public bool IsGroup { get; set; }
    [CSSPExist(ExistTypeName = "PolSourceSiteEffectTerm", ExistPlurial = "s", ExistFieldID = "PolSourceSiteEffectTermID")]
    [CSSPForeignKey(TableName = "PolSourceSiteEffectTerms", FieldName = "PolSourceSiteEffectTermID")]
    public int? UnderGroupID { get; set; }
    [CSSPMaxLength(100)]
    public string EffectTermEN { get; set; } = string.Empty;
    [CSSPMaxLength(100)]
    public string EffectTermFR { get; set; } = string.Empty;

    public PolSourceSiteEffectTerm() : base()
    {

    }
}

