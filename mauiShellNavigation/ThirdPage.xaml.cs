namespace Delme2;

public partial class ThirdPage : ContentPage
{
	

	public ThirdPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        /* does not work and this is the code it would expect to work */
        /* It works if the stack has size 2, does not work with stack size 3 */
        Shell.Current.GoToAsync("//MainPage");

        /* does not work either */
        //Shell.Current.CurrentItem.Navigation.PopToRootAsync();

        /* does not work either */
        //Shell.Current.GoToAsync("../..");

        /* kinda does work but you navigate to the second page for a short moment */
        //Shell.Current.GoToAsync("..");
        //Shell.Current.GoToAsync("..");

        /* kinda does work... the stack of //MainPage is still populated but the refresh is done */
        //It works if you go to AlonePage section
        //Shell.Current.GoToAsync("//AlonePage");
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        Route.Text = $"StackCount: {Shell.Current.Navigation.NavigationStack.Count} CurrentLocation: {Shell.Current.CurrentState.Location}";
    }
}

