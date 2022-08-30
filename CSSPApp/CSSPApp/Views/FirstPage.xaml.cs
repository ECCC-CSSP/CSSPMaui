namespace CSSPApp.Views;

public partial class FirstPage : ContentPage
{
    public FirstPage(FirstPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ((FirstPageViewModel)BindingContext).SetCulture(((FirstPageViewModel)BindingContext).appService.AppCulture.Name);
    }
}