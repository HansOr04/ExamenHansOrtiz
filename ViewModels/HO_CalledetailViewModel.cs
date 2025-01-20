using ExamenHansOrtiz.Models;
using ExamenHansOrtiz.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExamenHansOrtiz.ViewModels
{
    public class HO_CalledetailViewModel
    {
    
    
        // Propiedad para almacenar la calle seleccionada
        public HO_Calle CalleSeleccionada { get; set; }

        // Servicios
        private readonly HO_DatabaseService _databaseService;

        // Comando para guardar la calle en la base de datos local
        public ICommand GuardarCalleCommand { get; }

        public HO_CalledetailViewModel(HO_DatabaseService databaseService)
        {
            _databaseService = databaseService;

            // Inicializar el comando
            GuardarCalleCommand = new Command(GuardarCalle);
        }

        // Método para guardar la calle en SQLite
        private async void GuardarCalle()
        {
            if (CalleSeleccionada == null)
            {
                await App.Current.MainPage.DisplayAlert("Error", "No hay una calle seleccionada.", "OK");
                return;
            }

            // Convertir la calle de la API a un formato compatible con SQLite
            var calleLocal = ConvertToLocal(CalleSeleccionada);

            try
            {
                // Guardar la calle en la base de datos
                await _databaseService.SaveCalleAsync(calleLocal);
                await App.Current.MainPage.DisplayAlert("Éxito", "Calle guardada correctamente.", "OK");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", $"No se pudo guardar la calle: {ex.Message}", "OK");
            }
        }

        // Método para convertir HO_Calle a HO_CalleLocal
        private HO_CalleLocal ConvertToLocal(HO_Calle calle)
        {
            return new HO_CalleLocal
            {
                Id = calle.Id,
                Nombre = calle.Nombre,
                TipoVia = calle.TipoVia,
                UbicacionZona = calle.Ubicacion.Zona,
                UbicacionParroquia = calle.Ubicacion.Parroquia,
                UbicacionSector = calle.Ubicacion.Sector,
                UbicacionDistritoMetropolitano = calle.Ubicacion.DistritoMetropolitano,
                UbicacionCodigoPostal = calle.Ubicacion.CodigoPostal,
                CaracteristicasSentido = calle.Caracteristicas.Sentido,
                CaracteristicasCarriles = calle.Caracteristicas.Carriles,
                CaracteristicasTipoPavimento = calle.Caracteristicas.TipoPavimento,
                CaracteristicasEstadoVia = calle.Caracteristicas.EstadoVia,
                CaracteristicasVelocidadMaxima = calle.Caracteristicas.VelocidadMaxima,
                CaracteristicasTieneCicloruta = calle.Caracteristicas.TieneCicloruta,
                CaracteristicasAnchoAceras = calle.Caracteristicas.AnchoAceras
            };
        }
    }
}
