using attendance.Models;
using attendance.Services;
using attendance.Views;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace attendance.ViewModel
{
    public partial class ProductDetailsPopUpViewModel:SharedViewModel
    {
        private readonly NewProductService _productService;

        [ObservableProperty]
        Product product;

        [ObservableProperty]
        string name;
        [ObservableProperty]
        decimal cost;
        [ObservableProperty]
        int id;
        [ObservableProperty]
        bool enabled =true;
        //public static Product prod;
        ProductDetailsPopup _popup;

        public ProductDetailsPopUpViewModel(Product product, NewProductService service, ProductDetailsPopup popup )
        {
            Product = product;
            Id=product.ProductId;
            Name=product.ProductName;
            Cost=product.Cost;
            _productService = service;
            _popup = popup;
            Enabled = true;
            //prod = product;
        }


        [RelayCommand]
        async void UpadteProduct()
        {
            Product product = new Product() { ProductName = Name, Cost = Convert.ToDecimal(Cost),ProductId=Id };
            await _productService.CreateItemAsync(product);
            _popup.Close();



        }
        [RelayCommand]
        async void DeleteProduct()
        {

            Product product = new Product() { ProductName = Name, Cost = Convert.ToDecimal(Cost), ProductId = Id }; 
          

            await _productService.DeleteItemAsync(product);
            _popup.Close();

            //Enabled = false;

            //await Shell.Current.GoToAsync($"{nameof(ProductDetails)}", true, new Dictionary<string, object> { { "ProductParam", product } });

        }
        [RelayCommand]
        private  void Close()
        {
            _popup.Close();
        }
        private void Closer()
        {
            _popup.Close();
        }


    }
}
