namespace CSSPModels;

[NotMapped]
public partial class LabSheetAndA1Sheet
{
    public LabSheet LabSheet { get; set; } = new LabSheet();
    public LabSheetA1Sheet LabSheetA1Sheet { get; set; } = new LabSheetA1Sheet();
    public LabSheetAndA1Sheet()
    {

    }
}

