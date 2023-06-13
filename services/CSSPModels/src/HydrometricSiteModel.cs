namespace CSSPModels;

[NotMapped]
public partial class HydrometricSiteModel
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public HydrometricSite HydrometricSite { get; set; } = new HydrometricSite();
    public List<HydrometricDataValue> HydrometricDataValueList { get; set; } = new List<HydrometricDataValue>();
    public List<RatingCurveModel> RatingCurveModelList { get; set; } = new List<RatingCurveModel>();

    public HydrometricSiteModel()
    {

    }
}

