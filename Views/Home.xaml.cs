namespace attendance.Views;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}
    private async void CreateProduct(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(NewProduct)}", true);


    }

    private async void GetProducts(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(NewProduct)}", true);

    }

    private async void GetTransactions(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync($"{nameof(TransactionsList)}", true);


    }

    private async void CreateTransaction(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(CreateTransaction)}", true);

    }
}