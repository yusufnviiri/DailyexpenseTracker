using attendance.Models;
using attendance.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using attendance.Views;
using CommunityToolkit.Mvvm.ComponentModel;


namespace attendance.ViewModel
{//[QueryProperty("Product","ProductParam")]

    public partial class ProductViewModel:SharedViewModel
    {
        public ObservableCollection<Product> ProductCollection { get; set; }= new ObservableCollection<Product>();
        ProductService _productService = new ProductService();

        public ProductViewModel(ProductService service)
        {
            _productService = service;

            Title = "Products Page";

        }
    
      
        [RelayCommand]
        async void GetProducts()
        {
            ProductCollection.Clear();
            var products = _productService.GetProducts();
            if (IsBusy) return;
            try
            {
                IsBusy = true;
                foreach (var product in products)
                {
                    ProductCollection.Add(product);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Warning", $"Error in getting products, {ex.Message}", "Ok");
            }
            finally
            {
                IsBusy = false;
            }
        }
        [RelayCommand]
        async void ProductDetails(Product product)
        {
            if (product is null) return;
            await Shell.Current.GoToAsync($"{nameof(ProductDetails)}", true, new Dictionary<string, object> { { "ProductParam", product } });

        }
        [RelayCommand]

        async void AddProductPage()
        {
            await Shell.Current.GoToAsync($"{nameof(NewProduct)}", true);
        }
    }
}
