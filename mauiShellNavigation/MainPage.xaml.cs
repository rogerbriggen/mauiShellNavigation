namespace Delme2;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("SecondPage");
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        Route.Text = $"StackCount: {Shell.Current.Navigation.NavigationStack.Count} CurrentLocation: {Shell.Current.CurrentState.Location}";
    }


}

