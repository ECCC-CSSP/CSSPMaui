namespace CSSPModels;

[NotMapped]
public partial class RatingCurveModel
{
    public RatingCurve RatingCurve { get; set; } = new RatingCurve();
    public List<RatingCurveValue> RatingCurveValueList { get; set; } = new List<RatingCurveValue>();

    public RatingCurveModel()
    {

    }
}

