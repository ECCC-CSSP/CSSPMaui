
namespace CSSPApp.ViewModels;

public partial class FirstPageViewModel : BasePageViewTextModel
{
    [ObservableProperty]
    ObservableCollection<string> items = new ObservableCollection<string>()
    {
        "one", "two", "three"
    };

    [ObservableProperty]
    FirstPageViewTextModel firstPageViewTextModel;

    public FirstPageViewModel(AppService appService, FirstPageViewTextModel firstPageViewTextModel) : base(appService)
    {
        FirstPageViewTextModel = firstPageViewTextModel;
    }
     
    [RelayCommand]
    async Task Add()
    {
        await Task.Run(() =>
        {
            Items.Add("bonjour");
        });
    }

    [RelayCommand]
    async Task GoToMainPage()
    {
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    public void SetCulture(string cultureText)
    {
        appService.SetCulture(cultureText);
        FirstPageViewTextModel.SetCulture();
    }
}
