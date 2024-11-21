using attendance.Models;
using attendance.ViewModel;

namespace attendance.Views;

//[QueryProperty("Product","ProductParam")]

public partial class ProductDetails : ContentPage
{
	public Product Product { get; set; }
	public ProductDetails(ProductDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;
	}
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}