using ExamenHansOrtiz.Models;
using ExamenHansOrtiz.Services;
using ExamenHansOrtiz.ViewModels;
using ExamenHansOrtiz.Views;
using Microsoft.Maui.Controls;
 
namespace ExamenHansOrtiz.Views
{
    public partial class HO_SavedCallesPage : ContentPage
    {
        public HO_SavedCallesPage()
        {
            InitializeComponent();
            BindingContext = new HO_SavedCallesViewModel(App.Current.Handler.MauiContext.Services.GetService<HO_DatabaseService>());
        }

        private async void OnCalleSeleccionada(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is HO_CalleLocal calleSeleccionada)
            {
                // Convertir HO_CalleLocal a HO_Calle (si es necesario)
                var calle = new HO_Calle
                {
                    Id = calleSeleccionada.Id,
                    Nombre = calleSeleccionada.Nombre,
                    TipoVia = calleSeleccionada.TipoVia,
                    Ubicacion = new HO_Ubicacion
                    {
                        Zona = calleSeleccionada.UbicacionZona,
                        Parroquia = calleSeleccionada.UbicacionParroquia,
                        Sector = calleSeleccionada.UbicacionSector,
                        DistritoMetropolitano = calleSeleccionada.UbicacionDistritoMetropolitano,
                        CodigoPostal = calleSeleccionada.UbicacionCodigoPostal
                    },
                    Caracteristicas = new HO_Caracteristicas
                    {
                        Sentido = calleSeleccionada.CaracteristicasSentido,
                        Carriles = calleSeleccionada.CaracteristicasCarriles,
                        TipoPavimento = calleSeleccionada.CaracteristicasTipoPavimento,
                        EstadoVia = calleSeleccionada.CaracteristicasEstadoVia,
                        VelocidadMaxima = calleSeleccionada.CaracteristicasVelocidadMaxima,
                        TieneCicloruta = calleSeleccionada.CaracteristicasTieneCicloruta,
                        AnchoAceras = calleSeleccionada.CaracteristicasAnchoAceras
                    }
                };

                // Navegar a la página de detalles
                await Navigation.PushAsync(new HO_CalleDetailPage(calle));
            }
        }

        private async void OnVolverACallesClicked(object sender, System.EventArgs e)
        {
            // Navegar de regreso a la página de calles
            await Navigation.PopAsync();
        }
    }
}