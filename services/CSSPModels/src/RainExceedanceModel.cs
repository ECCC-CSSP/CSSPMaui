namespace CSSPModels;

[NotMapped]
public partial class RainExceedanceModel
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public RainExceedance RainExceedance { get; set; } = new RainExceedance();
    public List<RainExceedanceClimateSite> RainExceedanceClimateSiteList { get; set; } = new List<RainExceedanceClimateSite>();

    public RainExceedanceModel()
    {

    }
}

