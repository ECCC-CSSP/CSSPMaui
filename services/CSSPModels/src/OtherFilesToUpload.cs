namespace CSSPModels;

[NotMapped]
public partial class OtherFilesToUpload
{
    [CSSPRange(1, -1)]
    public int MikeScenarioID { get; set; }
    public List<TVFile> TVFileList { get; set; } = new List<TVFile>();

    public OtherFilesToUpload()
    {

    }
}

