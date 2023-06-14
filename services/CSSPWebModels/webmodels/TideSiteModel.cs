namespace CSSPWebModels;

[NotMapped]
public partial class TideSiteModel
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public TideSite TideSite { get; set; } = new TideSite();
    public List<TideDataValue> TideDataValueList { get; set; } = new List<TideDataValue>();

    public TideSiteModel()
    {

    }
}

