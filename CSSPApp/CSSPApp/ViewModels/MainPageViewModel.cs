namespace CSSPApp.ViewModels;

public partial class MainPageViewModel : MainPageViewTextModel
{
    [ObservableProperty]
    MainPageViewTextModel mainPageViewTextModel;

    [ObservableProperty]
    ICSSPScrambleService cSSPScrambleService;

    [ObservableProperty]
    string scrambleResult;

    public MainPageViewModel(AppService appService, MainPageViewTextModel mainPageViewTextModel, ICSSPScrambleService csspScrambleService) : base(appService)
    {
        MainPageViewTextModel = mainPageViewTextModel;
        CSSPScrambleService = csspScrambleService;
    }


    [RelayCommand]
    public void SetCulture(string cultureText)
    {
        appService.SetCulture(cultureText);
        MainPageViewTextModel.SetCulture();
    }

    [RelayCommand]
    async Task Start()
    {
        await Shell.Current.GoToAsync(nameof(FirstPage));
    }

    [RelayCommand]
    async Task Email(string email)
    {
        await Application.Current.MainPage.DisplayAlert("Sending Email", email, "Cancel");
    }

    [RelayCommand]
    void Scramble(string text)
    {
        ScrambleResult = CSSPScrambleService.Scramble(text);
    }
}
