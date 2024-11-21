using attendance.Models;
using attendance.ViewModel;
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


}