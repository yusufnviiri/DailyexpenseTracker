using attendance.Models;
using attendance.ViewModel;
using Microsoft.Maui.Graphics.Text;
using SQLite;
using System.Collections.ObjectModel;

namespace attendance.Views;

public partial class NewProduct : ContentPage
{
    private readonly SQLiteAsyncConnection _database;


    public NewProduct(NewProductViewModel productViewModel)
    {
        InitializeComponent();
        BindingContext = productViewModel;
    }
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }


}