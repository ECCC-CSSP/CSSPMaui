namespace CSSPModels;

[NotMapped]
public partial class TVFileModelByPurpose
{
    [CSSPEnumType]
    public FilePurposeEnum FilePurpose { get; set; } = FilePurposeEnum.Picture;
    public List<TVFileModel> TVFileModelList { get; set; } = new List<TVFileModel>();

    public TVFileModelByPurpose()
    {

    }
}

