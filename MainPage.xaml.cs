using attendance.Views;
using Microsoft.Maui.Controls.Platform;

namespace attendance
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            ;
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
            await Shell.Current.GoToAsync($"{nameof(CreateTransaction)}", true);

        }

        private async void CreateTransaction(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(CreateTransaction)}", true);

        }
    }

}
