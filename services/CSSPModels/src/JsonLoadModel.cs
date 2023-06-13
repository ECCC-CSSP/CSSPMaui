namespace CSSPModels;

[NotMapped]
public partial class JsonLoadModel
{
    [CSSPEnumType]
    public WebTypeEnum WebType { get; set; } = WebTypeEnum.WebAllAddresses;
    public int TVItemID { get; set; }
    public bool ForceReload { get; set; }

    public JsonLoadModel()
    {

    }
}

