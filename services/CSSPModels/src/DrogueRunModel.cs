namespace CSSPModels;

[NotMapped]
public partial class DrogueRunModel
{
    public DrogueRun DrogueRun { get; set; } = new DrogueRun();
    public List<DrogueRunPosition> DrogueRunPositionList { get; set; } = new List<DrogueRunPosition>();

    public DrogueRunModel()
    {

    }
}

