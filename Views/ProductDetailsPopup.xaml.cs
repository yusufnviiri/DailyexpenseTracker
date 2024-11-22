using attendance.Models;
using attendance.Services;
using attendance.ViewModel;
using CommunityToolkit.Maui.Views;

namespace attendance.Views;

public partial class ProductDetailsPopup : Popup
{

    public ProductDetailsPopup(Product product)
	{
		InitializeComponent();
        ProductDetailsPopUpViewModel viewModel = new ProductDetailsPopUpViewModel(product,new NewProductService(),this);
        BindingContext = viewModel;
	}
    private void closepopup(object sender, EventArgs e)
    {
        Close();
    }

}