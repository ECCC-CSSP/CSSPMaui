namespace CSSPModels;

[NotMapped]
public partial class MWQMSampleModel
{
    public MWQMSample MWQMSample { get; set; } = new MWQMSample();
    public List<MWQMSampleLanguage> MWQMSampleLanguageList { get; set; } = new List<MWQMSampleLanguage>();

    public MWQMSampleModel()
    {

    }
}

