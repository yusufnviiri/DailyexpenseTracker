using attendance.Models;
using attendance.ViewModel;
using CommunityToolkit.Maui.Views;

namespace attendance.Views;

public partial class ProductDetailsPopup : Popup
{

    public ProductDetailsPopup(Product product)
	{
		InitializeComponent();
        ProductDetailsPopUpViewModel viewModel = new ProductDetailsPopUpViewModel(product);
        BindingContext = viewModel;
	}
    private void closepopup(object sender, EventArgs e)
    {
        Close();
    }

}