namespace CSSPModels;

[NotMapped]
public partial class VPFull
{
    public VPScenario VPScenario { get; set; } = new VPScenario();
    public List<VPAmbient> VPAmbientList { get; set; } = new List<VPAmbient>();
    public List<VPResult> VPResultList { get; set; } = new List<VPResult>();

    public VPFull()
    {

    }
}

