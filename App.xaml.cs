using attendance.Services;

namespace attendance
{
    public partial class App : Application
    {
        public static DatabaseService? Database { get; private set; }

        public App()
        {
            InitializeComponent();
            //string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Transactions.db3");
            Database = new DatabaseService();
            MainPage = new AppShell();
        }
    }
}
