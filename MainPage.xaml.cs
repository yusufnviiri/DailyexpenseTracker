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

        private void GetProducts(object sender, EventArgs e)
        {

        }

        private void GetTransactions(object sender, EventArgs e)
        {

        }

        private void CreateTransaction(object sender, EventArgs e)
        {

        }
    }

}
