using attendance.Models;
using attendance.Services;
using attendance.Views;
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

    public partial class TransactionDetailsPopUpViewModel : SharedViewModel
    {
        private readonly TransactionService _transactionService;


        [ObservableProperty]
        int prodId;
        [ObservableProperty]
        int transactionId;

        [ObservableProperty]
        Transaction transactionData;
        [ObservableProperty]

        string? prodName;
        [ObservableProperty]


        int quantity;
        [ObservableProperty]

        string? agentName;
        [ObservableProperty]

        decimal saleValue;
        //public static Product prod;
        TransactionDetailsPopUp _popup;

        public TransactionDetailsPopUpViewModel(Transaction transaction, TransactionService service, TransactionDetailsPopUp popup)
        {
            TransactionData = transaction;
            ProdId = transaction.ProductId;
            ProdName = transaction.ProductName;
            SaleValue = transaction.SaleValue;
            AgentName = transaction.AgentName;
            Quantity = transaction.Quantity;
            TransactionId = transaction.TransactionId;
            _transactionService = service;
            _popup = popup;
            //prod = product;
        }


        [RelayCommand]
        async void UpdateTransaction()
        {
            Transaction transaction = new() { ProductName = ProdName, SaleValue = Convert.ToDecimal(SaleValue), AgentName = AgentName, ProductId = ProdId, Quantity = Quantity,TransactionId=TransactionId };
            await _transactionService.CreateItemAsync(transaction);
            _popup.Close();
        }
        [RelayCommand]
        async void DeleteTransaction()
        {

            Transaction transaction = new() { ProductName = ProdName, SaleValue = Convert.ToDecimal(SaleValue), AgentName = AgentName, ProductId = ProdId, Quantity = Quantity, TransactionId = TransactionId };

            await _transactionService.DeleteItemAsync(transaction);
            _popup.Close();

            //Enabled = false;

            //await Shell.Current.GoToAsync($"{nameof(ProductDetails)}", true, new Dictionary<string, object> { { "ProductParam", product } });

        }
        [RelayCommand]
        private void Close()
        {
            _popup.Close();
        }
        private void Closer()
        {
            _popup.Close();
        }


    }
}