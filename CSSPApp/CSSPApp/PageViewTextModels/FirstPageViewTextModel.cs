namespace CSSPApp.PageViewTextModels;

public partial class FirstPageViewTextModel : BasePageViewTextModel
{
    [ObservableProperty]
    string title;

    public FirstPageViewTextModel(AppService appService) : base(appService)
	{
        SetCulture();
    }

    public void SetCulture()
    {
        appService.SetCulture(this.appService.AppCulture.Name);

        Title = MainPageRes.CSSPDesktop;
    }
}
