namespace CSSPModels;

[NotMapped]
public partial class PolSourceObservationModel
{
    public PolSourceObservation PolSourceObservation { get; set; } = new PolSourceObservation();
    public List<PolSourceObservationIssue> PolSourceObservationIssueList { get; set; } = new List<PolSourceObservationIssue>();

    public PolSourceObservationModel()
    {

    }
}

