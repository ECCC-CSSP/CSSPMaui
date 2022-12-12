namespace CSSPApp.ViewModels;

public partial class FirstPageViewModel : ObservableObject
{
    private ICSSPAppService? CSSPAppService { get; }

    [ObservableProperty]
    ObservableCollection<string> items = new ObservableCollection<string>()
    {
        "one", "two", "three"
    };

    public FirstPageViewModel(/*ICSSPAppService csspAppService*/)
    {
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
    public async Task Add()
    {
        await Task.Run(() =>
        {
            Items.Add("bonjour");
        });
    }

    [RelayCommand]
    public async Task GoToMainPage()
    {
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    public async Task SetCulture(string cultureText)
    {
        await Task.Run(() =>
        {
            if (CSSPAppService != null)
            {
                CSSPAppService.SetCulture(cultureText);
                //Title = FirstPageRes.Title;
                //IsEnglish = CSSPAppService.IsEnglish;
                //IsFrench = CSSPAppService.IsFrench;
            }
        });
    }
}
