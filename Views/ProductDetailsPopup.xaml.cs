using attendance.Models;
using CommunityToolkit.Maui.Views;

namespace attendance.Views;

public partial class ProductDetailsPopup : Popup
{
   public  Product Product { get; set; }

    public ProductDetailsPopup(Product product)
	{
		InitializeComponent();
        BindingContext = this;
       this.Product = product;
	}
    private void closepopup(object sender, EventArgs e)
    {
        Close();
    }

}