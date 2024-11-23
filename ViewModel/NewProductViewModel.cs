using attendance.Models;
using attendance.Services;
using attendance.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance.ViewModel
{
   public partial class NewProductViewModel:SharedViewModel
    {
        public ObservableCollection<Product> ProductCollection { get; set; } = new ObservableCollection<Product>();
        private readonly NewProductService _productService;
        public NewProductViewModel(NewProductService productService)
        {
            _productService = productService;
            Title = "Product Analysis Page";
        }


        [RelayCommand]
        async Task GetProductsFromDb()
        {
            var products = await _productService.GetItemsAsync();
            ProductCollection.Clear();
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
      async void SaveProduct()
        {
            Product product = new Product() {ProductName=Name,Cost=Convert.ToDecimal(ProductCost) };
             await _productService.CreateItemAsync(product);
            Name = "";
            ProductCost = 0;
            await GetProductsFromDb();

        }
        [RelayCommand]
        async void DeleteProduct(Product product)
        {
            if (product is null) return;
            await Shell.Current.DisplayAlert("Warning", $"Product {product.ProductName} is to be deleted!!!", "Ok");

            await _productService.DeleteItemAsync(product);
            await GetProductsFromDb();
            //await Shell.Current.GoToAsync($"{nameof(ProductDetails)}", true, new Dictionary<string, object> { { "ProductParam", product } });

        }
      public  async Task GetProductsAsync()
        {
            var products = await _productService.GetItemsAsync();
            ProductCollection.Clear();
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
            //await Shell.Current.GoToAsync($"{nameof(ProductDetails)}", true, new Dictionary<string, object> { { "ProductParam", product } });
            NewProduct page = new NewProduct(this);
            await page.ProductDetails(product);

        }

        [ObservableProperty]
        string? name;
        [ObservableProperty]
        decimal productCost;
        [ObservableProperty]
        int productId;
    }
}
