using CSSPApp.Main.Strings;

namespace CSSPApp;

public partial class MainPage : ContentPage
{
	int count = 0;

    public MainPage(MainPageViewModel vm, IStringLocalizer<MainPageRes> sl)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		((MainPageViewModel)BindingContext).Message = "somehting got clicked";

		if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "en")
		{
			Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-CA");

			MainPageRes.Culture = new CultureInfo("fr-CA");
        }
		else
		{
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-CA");

            MainPageRes.Culture = new CultureInfo("en-CA");
        }

        count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

		
    }
}

