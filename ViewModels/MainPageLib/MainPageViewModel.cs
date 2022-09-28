namespace MainPageLib;

public partial interface IMainPageViewModel
{
    bool? IsFrench { get; set; }
    bool? IsEnglish { get; set; }
    string CSSPDesktop { get; set; }
    string StartText { get; set; }
    string CSSPFullText { get; set; }
    string CSSPDesktopApplicationWillLetYou { get; set; }
    string ViewAndUpdateWWTPInfo { get; set; }
    string MakeCalculationUsingBoxModelAndVP { get; set; }
    string SetupAndRunMIKEScenariosAndStoreInputsAndResults { get; set; }
    string VisualizeAndManageMarineWQInfo { get; set; }
    string PleaseContactASiteAdministratorListedBelowForAccess { get; set; }
    string ScrambleResult { get; set; }
    Task SetCulture(string cultureText);
    Task Start();
    Task Email(string email);
    Task Scramble(string text);
}

public partial class MainPageViewModel : ObservableObject, IMainPageViewModel
{
    private ICSSPAppService? CSSPAppService { get; }

    private ICSSPScrambleService? CSSPScrambleService { get; }

    [ObservableProperty]
    bool? isFrench;

    [ObservableProperty]
    bool? isEnglish;

    [ObservableProperty]
    string cSSPDesktop = String.Empty;

    [ObservableProperty]
    string startText = String.Empty;

    [ObservableProperty]
    string cSSPFullText = String.Empty;

    [ObservableProperty]
    string cSSPDesktopApplicationWillLetYou = String.Empty;

    [ObservableProperty]
    string viewAndUpdateWWTPInfo = String.Empty;

    [ObservableProperty]
    string makeCalculationUsingBoxModelAndVP = String.Empty;

    [ObservableProperty]
    string setupAndRunMIKEScenariosAndStoreInputsAndResults = String.Empty;

    [ObservableProperty]
    string visualizeAndManageMarineWQInfo = String.Empty;

    [ObservableProperty]
    string pleaseContactASiteAdministratorListedBelowForAccess = String.Empty;

    [ObservableProperty]
    string scrambleResult = String.Empty;

    public MainPageViewModel(ICSSPScrambleService csspScrambleService, ICSSPAppService csspAppService)
    {
        CSSPAppService = csspAppService;
        CSSPScrambleService = csspScrambleService;

        if (this.CSSPAppService.AppCulture != null)
        {
            Task.Run(() =>
            {
                SetCulture("en-CA").Wait(); // this.CSSPAppService.AppCulture.Name).Wait();
            }).Wait();
        }
    }

    [RelayCommand]
    public async Task SetCulture(string cultureText)
    {
        if (CSSPAppService != null)
        {
            await CSSPAppService.SetCulture(cultureText);

            CSSPDesktop = MainPageRes.CSSPDesktop;
            StartText = MainPageRes.StartText;
            CSSPFullText = MainPageRes.CSSPFullText;
            CSSPDesktopApplicationWillLetYou = MainPageRes.CSSPDesktopApplicationWillLetYou;
            ViewAndUpdateWWTPInfo = MainPageRes.ViewAndUpdateWWTPInfo;
            MakeCalculationUsingBoxModelAndVP = MainPageRes.MakeCalculationUsingBoxModelAndVP;
            SetupAndRunMIKEScenariosAndStoreInputsAndResults = MainPageRes.SetupAndRunMIKEScenariosAndStoreInputsAndResults;
            VisualizeAndManageMarineWQInfo = MainPageRes.VisualizeAndManageMarineWQInfo;
            PleaseContactASiteAdministratorListedBelowForAccess = MainPageRes.PleaseContactASiteAdministratorListedBelowForAccess;
            IsEnglish = CSSPAppService.IsEnglish;
            IsFrench = CSSPAppService.IsFrench;
        }
    }

    [RelayCommand]
    public async Task Start()
    {
        await Shell.Current.GoToAsync("FirstPage");
    }

    [RelayCommand]
    public async Task Email(string email)
    {
        if (Application.Current != null)
        {
            if (Application.Current.MainPage != null)
            {
                await Application.Current.MainPage.DisplayAlert("Sending Email", email, "Cancel");
            }

        }
    }

    [RelayCommand]
    public async Task Scramble(string text)
    {
        if (CSSPScrambleService != null)
        {
            await Task.Run(() =>
            {
                ScrambleResult = CSSPScrambleService.Scramble(text);
            });
        }
    }
}