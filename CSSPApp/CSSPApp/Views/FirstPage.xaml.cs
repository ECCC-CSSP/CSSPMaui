namespace CSSPApp.Views;

public partial class FirstPage : ContentPage
{
	public FirstPage(FirstPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}