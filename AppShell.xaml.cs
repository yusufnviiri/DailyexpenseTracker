using attendance.Views;

namespace attendance
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NewProduct), typeof(NewProduct));
            Routing.RegisterRoute(nameof(CreateTransaction), typeof(CreateTransaction));


        }
    }
}
