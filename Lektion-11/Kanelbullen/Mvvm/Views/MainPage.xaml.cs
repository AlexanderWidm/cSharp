using Kanelbullen.Mvvm.ViewModels;

namespace Kanelbullen;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;
	}
}

