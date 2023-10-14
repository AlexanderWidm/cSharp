using CimoApp.Mvvm.Views;

namespace CimoApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(AddPage), typeof(AddPage));
        Routing.RegisterRoute(nameof(EditPage), typeof(EditPage));
        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
    }
	
}
