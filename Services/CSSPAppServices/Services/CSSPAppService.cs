namespace CSSPAppServices;

public interface ICSSPAppService
{
    CultureInfo? AppCulture { get; set; }
    //bool? IsFrench { get; set; }
    //bool? IsEnglish { get; set; }

    void SetCulture(string CultureText);
}

public partial class CSSPAppService : ICSSPAppService
{
    public CultureInfo? AppCulture { get; set; }

    //public bool? IsFrench { get; set; }

    //public bool? IsEnglish { get; set; }

    public CSSPAppService()
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

        Thread.CurrentThread.CurrentCulture =
        Thread.CurrentThread.CurrentUICulture =
        CultureInfo.DefaultThreadCurrentCulture =
        CultureInfo.DefaultThreadCurrentUICulture =
        AppCulture = new CultureInfo(CultureText);

        //IsFrench = AppCulture.TwoLetterISOLanguageName == "fr" ? true : false;
        //IsEnglish = !IsFrench;
    }
}

