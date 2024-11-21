using attendance.Models;
using attendance.Services;
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
        async void GetProductsFromDb()
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
            Product product = new Product() {ProductName=Name,Cost=ProductCost};
             await _productService.CreateItemAsync(product);
        }

        [ObservableProperty]
        string? name;
        [ObservableProperty]
        decimal productCost;
        [ObservableProperty]
        int productId;
    }
}
