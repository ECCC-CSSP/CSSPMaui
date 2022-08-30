namespace CSSPApp.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		((MainPageViewModel)BindingContext).SetCulture(((MainPageViewModel)BindingContext).AppService.AppCulture.Name);
	}
}