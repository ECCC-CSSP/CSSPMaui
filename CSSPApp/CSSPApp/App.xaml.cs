namespace CSSPApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        string culture = Preferences.Get("Culture", "en-CA");

        if (culture == "fr-CA")
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-CA");
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fr-CA");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("fr-CA");
        }
        else
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-CA");
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-CA");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-CA");
        }

        Preferences.Set("Culture", culture);

        MainPage = new AppShell();
	}
}
