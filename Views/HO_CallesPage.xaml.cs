using ExamenHansOrtiz.Models;
using ExamenHansOrtiz.Services;
using ExamenHansOrtiz.ViewModels;

namespace ExamenHansOrtiz.Views;

public partial class HO_CallesPage : ContentPage
{
    public HO_CallesPage()
    {
        InitializeComponent();
        BindingContext = new HO_CallesViewModel(App.Current.Handler.MauiContext.Services.GetService<HO_APIService>());
    }

    private async void OnCalleSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is HO_Calle calleSeleccionada)
        {
            // Navegar a la página de detalles
            await Navigation.PushAsync(new HO_CalleDetailPage(calleSeleccionada));
        }
    }

    private async void OnVerCallesGuardadasClicked(object sender, System.EventArgs e)
    {
        // Navegar a la página de calles guardadas
        await Navigation.PushAsync(new HO_SavedCallesPage());
    }
}