using ExamenHansOrtiz.Models;
using ExamenHansOrtiz.Services;
using ExamenHansOrtiz.ViewModels;
using Microsoft.Maui.Controls;

namespace ExamenHansOrtiz.Views;

public partial class HO_CallesPage : ContentPage
{
    public HO_CallesPage()
    {
        InitializeComponent();
        BindingContext = new HO_CallesViewModel(App.Current.Services.GetService<HO_APIService>());
    }

    private async void OnCalleSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is HO_Calle calleSeleccionada)
        {
            // Navegar a la p�gina de detalles
            await Navigation.PushAsync(new HO_CalleDetailPage(calleSeleccionada));
        }
    }
}