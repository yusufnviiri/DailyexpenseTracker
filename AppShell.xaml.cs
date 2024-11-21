using attendance.Views;

namespace attendance
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ProductDetails),typeof(ProductDetails));
            Routing.RegisterRoute(nameof(NewProduct), typeof(NewProduct));

        }
    }
}
