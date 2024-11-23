using attendance.Views;

namespace attendance
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NewProduct), typeof(NewProduct));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

            Routing.RegisterRoute(nameof(CreateTransaction), typeof(CreateTransaction));
            Routing.RegisterRoute(nameof(TransactionsList), typeof(TransactionsList));



        }
    }
}
