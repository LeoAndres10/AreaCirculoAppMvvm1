using AreaCirculoAppMvvm1.ViewModel;

namespace AreaCirculoAppMvvm1.Views;

public partial class AreaCirculoView : ContentPage
{
	private AreaCirculoViewModel viewModel;
	public AreaCirculoView()
	{
		InitializeComponent();
		viewModel = new AreaCirculoViewModel();
		BindingContext=viewModel;
	}
}