namespace CSSPModels;

[NotMapped]
public partial class VPScenarioModel
{
    public VPScenario VPScenario { get; set; } = new VPScenario();
    public List<VPScenarioLanguage> VPScenarioLanguageList { get; set; } = new List<VPScenarioLanguage>();
    public List<VPAmbient> VPAmbientList { get; set; } = new List<VPAmbient>();
    public List<VPResult> VPResultList { get; set; } = new List<VPResult>();

    public VPScenarioModel()
    {

    }
}

