
namespace CSSPApp.Services;

public partial class AppService : ObservableObject
{
    [ObservableProperty]
    public CultureInfo appCulture;

    [ObservableProperty]
    public bool isFrench;

    [ObservableProperty]
    public bool isEnglish;

    public AppService()
    {
        SetCulture("en-CA");
    }

    public void SetCulture(string CultureText)
    {
        if (string.IsNullOrWhiteSpace(CultureText)
            || !(CultureText == "en-CA" || CultureText == "fr-CA"))
        {
            CultureText = "en-CA";
        }

        Thread.CurrentThread.CurrentCulture = //new CultureInfo(CultureText);
        Thread.CurrentThread.CurrentUICulture = //new CultureInfo(CultureText);
        CultureInfo.DefaultThreadCurrentCulture = //new CultureInfo(CultureText);
        CultureInfo.DefaultThreadCurrentUICulture = //new CultureInfo(CultureText);
        AppCulture = new CultureInfo(CultureText);

        IsFrench = AppCulture.TwoLetterISOLanguageName == "fr" ? true : false;
        IsEnglish = !IsFrench;
    }
}
