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
using System.Xml.Linq;

namespace attendance.ViewModel
{

    public partial class TransactionViewModel : SharedViewModel
    {
        public ObservableCollection<Transaction> TransactionCollection { get; set; } = new ObservableCollection<Transaction>();
        private readonly TransactionService _transactionService;
        List<Transaction> SortedList = [];
        public TransactionViewModel(TransactionService transactionService)
        {
            _transactionService = transactionService;
            Title = "Transaction Analysis Page";
        }


        [RelayCommand]
        async Task GetTransactionsFromDb()
        {
            var transactions = await _transactionService.GetItemsAsync();
            TransactionCollection.Clear();
            if (IsBusy) return;
            try
            {
                IsBusy = true;
                foreach (var trade in transactions)
                {
                    TransactionCollection.Add(trade);
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
        async void SaveTransaction()
        {
            Transaction transaction = new () { ProductName = ProdName,SaleValue = Convert.ToDecimal(SaleValue),AgentName=AgentName,ProductId=ProdId,Quantity=Quantity };
            await _transactionService.CreateItemAsync(transaction);
            ProdName = "";
            AgentName = "";
            SaleValue = Quantity=0;
            await GetTransactionsFromDb();

        }
        [RelayCommand]
        async void DeleteTransaction(Transaction transaction)
        {
            if (transaction is null) return;
            await Shell.Current.DisplayAlert("Warning", $"Transaction of {transaction.ProductName} for {transaction.DateOfTransaction.Day}/{transaction.DateOfTransaction.Month}/{transaction.DateOfTransaction.Year} is to be deleted!!!", "Ok");

            await _transactionService.DeleteItemAsync(transaction);
            await GetTransactionsFromDb();
            //await Shell.Current.GoToAsync($"{nameof(ProductDetails)}", true, new Dictionary<string, object> { { "ProductParam", product } });

        }
        public async Task GetTransactionsAsync()
        {
            var transactions = await _transactionService.GetItemsAsync();
            TransactionCollection.Clear();
            if (IsBusy) return;
            try
            {
                IsBusy = true;
                foreach (var item in transactions)
                { 
                    TransactionCollection.Add(item);
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
        async void TransactionDetails(Transaction transaction)
        {
            if (transaction is null) return;
            //await Shell.Current.GoToAsync($"{nameof(ProductDetails)}", true, new Dictionary<string, object> { { "ProductParam", product } });
            CreateTransaction page = new  CreateTransaction(this);
            await page.TransactionDetails(transaction);
        }
        [RelayCommand]
        async void TransactionsList()
        {
            SearchProductName = "";
         await Shell.Current.GoToAsync($"{nameof(TransactionsList)}", true );
        }
        [RelayCommand]
        async void BackHome()
        {
            await Shell.Current.GoToAsync(nameof(Home));
        }
        [RelayCommand]
        async void ClearInputs()
        {
            SearchProductName = "";
            YearOfTransaction = 0;
            MonthOfTransaction = 0;
            DayOfTransaction = 0;
            await GetTransactionsFromDb();
        }
        [RelayCommand]
        async void SearchList()
        {
            if (SearchProductName.Length > 1 && MonthOfTransaction<1 && DayOfTransaction<1)
            {

                SortedList =  TransactionCollection.Where(k => k.ProductName.ToLower().Contains(SearchProductName.ToLower())).ToList();
                TransactionCollection.Clear();
                foreach (var item in SortedList)
                {
                    TransactionCollection.Add(item);
                }
            } else if(SearchProductName.Length < 1 && MonthOfTransaction < 1 && DayOfTransaction > 1)
            {
                SortedList = TransactionCollection.Where(k => k.DateOfTransaction.Day.Equals(DayOfTransaction)).ToList();
                TransactionCollection.Clear();
                foreach (var item in SortedList)
                {
                    TransactionCollection.Add(item);
                }
            }
            else if (SearchProductName.Length < 1 && MonthOfTransaction < 1 && DayOfTransaction < 1)
            {
                SortedList = TransactionCollection.Where(k => k.DateOfTransaction.Month.Equals(MonthOfTransaction)).ToList();
                TransactionCollection.Clear();
                foreach (var item in SortedList)
                {
                    TransactionCollection.Add(item);
                }
            }
            else
            {
                await GetTransactionsFromDb();

            }
        }

        [ObservableProperty]
         int prodId;
        [ObservableProperty]

        string? prodName;
        [ObservableProperty]

         int quantity;
        [ObservableProperty]

         string? agentName ;
        [ObservableProperty]
        string? dateString;
        [ObservableProperty]
        decimal saleValue;
        [ObservableProperty]
        int dayOfTransaction;
        [ObservableProperty]
        int monthOfTransaction;
        [ObservableProperty]
        int yearOfTransaction;
        [ObservableProperty]
        string? searchProductName =string.Empty;
        
    }
}