namespace CSSPModels;

[NotMapped]
public partial class WebLabSheets
{
    public TVItemModel TVItemModel { get; set; } = new TVItemModel();
    public List<TVItemModel> TVItemModelParentList { get; set; } = new List<TVItemModel>();
    public List<LabSheetModel> LabSheetModelList { get; set; } = new List<LabSheetModel>();

    public WebLabSheets()
    {

    }
}

