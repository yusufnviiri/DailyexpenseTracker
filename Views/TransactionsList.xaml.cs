using attendance.ViewModel;

namespace attendance.Views;

public partial class TransactionsList : ContentPage
{
    TransactionViewModel viewModel;

    public TransactionsList(TransactionViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        await viewModel.GetTransactionsAsync();

    }
}