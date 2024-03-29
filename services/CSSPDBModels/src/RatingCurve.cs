﻿namespace CSSPDBModels;

public partial class RatingCurve : LastUpdate
{
    [Key]
    public int RatingCurveID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "HydrometricSite", ExistPlurial = "s", ExistFieldID = "HydrometricSiteID")]
    [CSSPForeignKey(TableName = "HydrometricSites", FieldName = "HydrometricSiteID")]
    public int HydrometricSiteID { get; set; }
    [CSSPMaxLength(50)]
    public string RatingCurveNumber { get; set; } = string.Empty;

    public RatingCurve() : base()
    {

    }
}

