using attendance.Services;
using attendance.ViewModel;
using attendance.Views;
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
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<ProductViewModel>();
            builder.Services.AddSingleton<Products>();
            builder.Services.AddSingleton<NewProduct>();

            builder.Services.AddSingleton<ProductService>();
            builder.Services.AddSingleton<NewProductService>();

            builder.Services.AddTransient<ProductDetailsViewModel>();
            builder.Services.AddTransient<NewProductViewModel>();

            builder.Services.AddTransient<ProductDetails>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
