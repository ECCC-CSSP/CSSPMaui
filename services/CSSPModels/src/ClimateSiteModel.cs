namespace CSSPModels;

[NotMapped]
public partial class ClimateSiteModel
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public ClimateSite ClimateSite { get; set; } = new ClimateSite();
    public List<ClimateDataValue> ClimateDataValueList { get; set; } = new List<ClimateDataValue>();

    public ClimateSiteModel()
    {

    }
}

