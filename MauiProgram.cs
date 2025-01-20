using Microsoft.Extensions.Logging;
using ExamenHansOrtiz.Services;
using ExamenHansOrtiz.ViewModels;
using ExamenHansOrtiz.Views;

namespace ExamenHansOrtiz
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

#if DEBUG
            builder.Logging.AddDebug(); 
#endif

            // Registrar servicios
            builder.Services.AddSingleton<HO_APIService>(); 
            builder.Services.AddSingleton<HO_DatabaseService>();

            // Registrar ViewModels
            builder.Services.AddTransient<HO_CallesViewModel>(); 
            builder.Services.AddTransient<HO_CalledetailViewModel>();
            builder.Services.AddTransient<HO_SavedCallesViewModel>(); 

            // Registrar Vistas
            builder.Services.AddTransient<HO_CallesPage>(); 
            builder.Services.AddTransient<HO_CalleDetailPage>();
            builder.Services.AddTransient<HO_SavedCallesPage>();

            return builder.Build();
        }
    }
}