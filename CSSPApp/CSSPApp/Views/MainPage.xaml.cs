namespace CSSPApp.Views;

public partial class MainPage : ContentPage
{
    ICSSPAppService CSSPAppService { get; }
    ICSSPScrambleService CSSPScrambleService { get; }

    public MainPage(ICSSPAppService csspAppService, ICSSPScrambleService csspScrambleService)
    {
        InitializeComponent();
        CSSPAppService = csspAppService;
        CSSPScrambleService = csspScrambleService;
        //BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lblTest.Text = "bonjour";
        lblTest2.Text = CSSPScrambleService.Scramble(lblTest.Text);
    }


    private void btnEnglish_Clicked(object sender, EventArgs e)
    {
        ChangeCulture("en-CA");
    }

    private void btnFrench_Clicked(object sender, EventArgs e)
    {
        ChangeCulture("fr-CA");
    }

    private void ChangeCulture(string cultureText)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureText);
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureText);
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(cultureText);
        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo(cultureText);
        CSSPAppService.AppCulture = new CultureInfo(cultureText);

        Preferences.Set("Culture", cultureText);

        if (Application.Current != null)
        {
            Application.Current.MainPage = new AppShell();
        }

        Shell.Current.GoToAsync(nameof(FirstPage));
        //Shell.Current.GoToAsync(nameof(MainPage));
    }
}