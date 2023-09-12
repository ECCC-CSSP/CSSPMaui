namespace CSSPAppGenerateCode.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    //private ICSSPAppService? CSSPAppService { get; }

    //[ObservableProperty]
    //ObservableCollection<string> items = new ObservableCollection<string>()
    //{
    //    "one", "two", "three"
    //};

    private IConfigService _configService { get; }

    public MainPageViewModel(IConfigService configService)
    {
        _configService = configService;

        //CSSPAppService = csspAppService;
        //if (this.CSSPAppService != null)
        //{
        //    if (this.CSSPAppService.AppCulture != null)
        //    {
        //        Task.Run(() =>
        //        {
        //            SetCulture(this.CSSPAppService.AppCulture.Name).Wait();
        //        }).Wait();
        //    }
        //}
    }

    [RelayCommand]
    public async Task RunGenerateCSSPEnums()
    {
        _configService
    }

    //[RelayCommand]
    //public async Task GoToMainPage()
    //{
    //    await Shell.Current.GoToAsync("..");
    //}

    //[RelayCommand]
    //public async Task SetCulture(string cultureText)
    //{
    //    await Task.Run(() =>
    //    {
    //        if (CSSPAppService != null)
    //        {
    //            CSSPAppService.SetCulture(cultureText);
    //            //Title = FirstPageRes.Title;
    //            //IsEnglish = CSSPAppService.IsEnglish;
    //            //IsFrench = CSSPAppService.IsFrench;
    //        }
    //    });
    //}
}
