using attendance.Models;
using attendance.ViewModel;
using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Graphics.Text;
using SQLite;
using System.Collections.ObjectModel;

namespace attendance.Views;

public partial class NewProduct : ContentPage
{
    private readonly SQLiteAsyncConnection _database;

    NewProductViewModel viewModel;
    public NewProduct(NewProductViewModel productViewModel)
    {
        InitializeComponent();
        BindingContext = productViewModel;
        viewModel = productViewModel;
    }
    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {       
        base.OnNavigatedTo(args);
        await viewModel.GetProductsAsync();
        
    }
   public async Task ProductDetails(Product product)
    {
        //await this.ShowPopupAsync(new ProductDetailsPopup(product));

        var DetailsPage = new ProductDetailsPopup(product);
         Shell.Current.CurrentPage.ShowPopup(DetailsPage);




    }

}