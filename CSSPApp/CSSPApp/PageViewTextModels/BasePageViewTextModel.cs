namespace CSSPApp.PageViewTextModels;

public partial class BasePageViewTextModel : ObservableObject
{
    [ObservableProperty]
    public AppService appService;

    public BasePageViewTextModel(AppService appService)
    {
        this.appService = appService;
    }
}
