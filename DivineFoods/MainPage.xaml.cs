
namespace DivineFoods;


public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		//var viewModel = new MainViewModel();
		BindingContext = viewModel;
	}


}


