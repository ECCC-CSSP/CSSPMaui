namespace CSSPApp.Views;

public partial class FirstPage : ContentPage
{
    public string bonjour = "bonjour";

    //ICSSPAppService CSSPAppService { get; }
    public FirstPage()//IFirstPageViewModel vm/*, ICSSPAppService csspAppService*/)
    {
        InitializeComponent();
        //CSSPAppService = csspAppService;

        //bonjour = "allo working";
        //BindingContext = csspAppService;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        //if (CSSPAppService.AppCulture != null)
        //{
        //((IFirstPageViewModel)BindingContext).SetCulture("en-CA"); // CSSPAppService.AppCulture.Name);
        //}
    }
}