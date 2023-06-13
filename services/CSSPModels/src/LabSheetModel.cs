namespace CSSPModels;

[NotMapped]
public partial class LabSheetModel
{
    public LabSheet LabSheet { get; set; } = new LabSheet();
    public LabSheetDetail LabSheetDetail { get; set; } = new LabSheetDetail();
    public List<LabSheetTubeMPNDetail> LabSheetTubeMPNDetailList { get; set; } = new List<LabSheetTubeMPNDetail>();

    public LabSheetModel()
    {

    }
}

