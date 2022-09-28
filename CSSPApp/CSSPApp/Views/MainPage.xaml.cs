namespace CSSPApp.Views;

public partial class MainPage : ContentPage
{
	ICSSPAppService CSSPAppService { get; }

	public MainPage(ICSSPAppService csspAppService) // ICSSPScrambleService csspScrambleService, ICSSPAppService csspAppService)
	{
		InitializeComponent();
        CSSPAppService = csspAppService;
		//BindingContext = vm;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		//if (CSSPAppService.AppCulture != null)
		//{
		//((IMainPageViewModel)BindingContext).SetCulture("en-CA"); // CSSPAppService.AppCulture.Name);
		//}
	}


	private void btnEnglish_Clicked(object sender, EventArgs e)
	{
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-CA");
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-CA");
        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-CA");
		CSSPAppService.AppCulture = new CultureInfo("en-CA");

        Preferences.Set("Culture", "en-CA");

        Shell.Current.GoToAsync("FirstPage");
    }

    private void btnFrench_Clicked(object sender, EventArgs e)
	{
        Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-CA");
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fr-CA");
        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("fr-CA");
        CSSPAppService.AppCulture = new CultureInfo("fr-CA");

        Preferences.Set("Culture", "fr-CA");

        Shell.Current.GoToAsync("FirstPage");
    }
}