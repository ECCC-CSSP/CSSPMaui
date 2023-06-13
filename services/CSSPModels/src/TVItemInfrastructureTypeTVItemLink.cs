namespace CSSPModels;

[NotMapped]
public partial class TVItemInfrastructureTypeTVItemLink
{
    [CSSPEnumType]
    public InfrastructureTypeEnum InfrastructureType { get; set; } = new InfrastructureTypeEnum();
    [CSSPAllowNull]
    public int? SeeOtherMunicipalityTVItemID { get; set; }
    [CSSPMaxLength(100)]
    [CSSPEnumTypeText(EnumTypeName = "InfrastructureTypeEnum", EnumType = "InfrastructureType")]
    [CSSPAllowNull]
    public string InfrastructureTypeText { get; set; } = string.Empty;
    public TVItem TVItem { get; set; } = new TVItem();
    public List<TVItemLink> TVItemLinkList { get; set; } = new List<TVItemLink>();
    public TVItemInfrastructureTypeTVItemLink FlowTo { get; set; } = new TVItemInfrastructureTypeTVItemLink();

    public TVItemInfrastructureTypeTVItemLink()
    {

    }
}

