using attendance.Services;
using attendance.ViewModel;
using attendance.Views;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace attendance
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<ProductViewModel>();
            builder.Services.AddSingleton<Products>();
            builder.Services.AddSingleton<ProductService>();
            builder.Services.AddSingleton<NewProductService>();
            builder.Services.AddTransient<ProductDetailsViewModel>();
            builder.Services.AddTransient<NewProductViewModel>();
            builder.Services.AddSingleton<NewProduct>();

            builder.Services.AddSingleton<TransactionViewModel>();
            builder.Services.AddSingleton<TransactionService>();
            builder.Services.AddSingleton<TransactionsList>();

            builder.Services.AddTransient<TransactionDetailsPopUpViewModel>();
            builder.Services.AddTransient<CreateTransaction>();






#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
