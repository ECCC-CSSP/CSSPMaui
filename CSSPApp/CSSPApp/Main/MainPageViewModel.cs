namespace CSSPApp;

public partial class MainPageViewModel : ObservableObject
{
    public MainPageViewModel()
    {
        Message = "first";
    }

    [ObservableProperty]
    string message;
}
