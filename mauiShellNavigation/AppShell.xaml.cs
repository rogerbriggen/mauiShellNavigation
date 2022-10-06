namespace Delme2;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("SecondPage", typeof(SecondPage));
        Routing.RegisterRoute("ThirdPage", typeof(ThirdPage));
    }
}
