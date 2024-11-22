using attendance.Models;
using attendance.Services;
using attendance.ViewModel;
using CommunityToolkit.Maui.Views;

namespace attendance.Views;

public partial class CreateTransaction : ContentPage
{
    TransactionViewModel viewModel;

    public CreateTransaction(TransactionViewModel transactionViewModel)
	{
		InitializeComponent();
        viewModel = transactionViewModel;
		BindingContext=viewModel;
	}

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        await viewModel.GetTransactionsAsync();

    }
    public async Task TransactionDetails(Transaction transaction)
    {
        //await this.ShowPopupAsync(new ProductDetailsPopup(product));

        var DetailsPage = new TransactionDetailsPopUp(transaction);
        Shell.Current.CurrentPage.ShowPopup(DetailsPage);




    }
}