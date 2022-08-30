namespace CSSPApp.PageViewTextModels;

public partial class MainPageViewTextModel : BasePageViewTextModel
{
    [ObservableProperty]
    string title;

    [ObservableProperty]
    string startText;

    [ObservableProperty]
    string csspFullText;

    [ObservableProperty]
    string cSSPDesktopApplicationWillLetYou;

    [ObservableProperty]
    string viewAndUpdateWWTPInfo;

    [ObservableProperty]
    string makeCalculationUsingBoxModelAndVP;

    [ObservableProperty]
    string setupAndRunMIKEScenariosAndStoreInputsAndResults;

    [ObservableProperty]
    string visualizeAndManageMarineWQInfo;

    [ObservableProperty]
    MainPageViewTextModel mainPageModelVal;

    [ObservableProperty]
    string pleaseContactASiteAdministratorListedBelowForAccess;

    public MainPageViewTextModel(AppService appService) : base(appService)
	{
        SetCulture();
    }

    public void SetCulture()
    {
        appService.SetCulture(this.appService.AppCulture.Name);

        Title = MainPageRes.CSSPDesktop;
        StartText = MainPageRes.StartText;
        CsspFullText = MainPageRes.CSSPFullText;
        CSSPDesktopApplicationWillLetYou = MainPageRes.CSSPDesktopApplicationWillLetYou;
        ViewAndUpdateWWTPInfo = MainPageRes.ViewAndUpdateWWTPInfo;
        MakeCalculationUsingBoxModelAndVP = MainPageRes.MakeCalculationUsingBoxModelAndVP;
        SetupAndRunMIKEScenariosAndStoreInputsAndResults = MainPageRes.SetupAndRunMIKEScenariosAndStoreInputsAndResults;
        VisualizeAndManageMarineWQInfo = MainPageRes.VisualizeAndManageMarineWQInfo;
        PleaseContactASiteAdministratorListedBelowForAccess = MainPageRes.PleaseContactASiteAdministratorListedBelowForAccess;
    }
}
