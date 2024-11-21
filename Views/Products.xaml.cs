using attendance.ViewModel;

namespace attendance.Views;

public partial class Products : ContentPage
{
	public Products(ProductViewModel productViewModel)
	{
		InitializeComponent();
		BindingContext=productViewModel;
	}

   
}