namespace FirstPageLib;

public partial interface IFirstPageViewModel
{
    string Title { get; set; }
    bool? IsFrench { get; set; }
    bool? IsEnglish { get; set; }
    ObservableCollection<string> Items { get; set; }
    Task Add();
    Task GoToMainPage();
    Task SetCulture(string cultureText);
}

public partial class FirstPageViewModel : ObservableObject, IFirstPageViewModel
{
    private ICSSPAppService? CSSPAppService { get; }

    [ObservableProperty]
    string title = String.Empty;

    [ObservableProperty]
    bool? isFrench = false;

    [ObservableProperty]
    bool? isEnglish = true;

    [ObservableProperty]
    ObservableCollection<string> items = new ObservableCollection<string>()
    {
        "one", "two", "three"
    };

    public FirstPageViewModel(ICSSPAppService csspAppService)
    {
        CSSPAppService = csspAppService;
        if (this.CSSPAppService != null)
        {
            if (this.CSSPAppService.AppCulture != null)
            {
                Task.Run(() =>
                {
                    SetCulture(this.CSSPAppService.AppCulture.Name).Wait();
                }).Wait();
            }
        }
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
        if (CSSPAppService != null)
        {
            await CSSPAppService.SetCulture(cultureText);
            Title = FirstPageRes.Title;
            IsEnglish = CSSPAppService.IsEnglish;
            IsFrench = CSSPAppService.IsFrench;
        }
    }
}
