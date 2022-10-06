namespace Delme2;

public partial class SecondPage : ContentPage
{
	

	public SecondPage()
	{
		InitializeComponent();
	}


    private void OnCounterClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("ThirdPage");
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        Route.Text = $"StackCount: {Shell.Current.Navigation.NavigationStack.Count} CurrentLocation: {Shell.Current.CurrentState.Location}";
    }
}

