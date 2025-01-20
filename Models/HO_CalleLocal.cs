using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ExamenHansOrtiz.Models
{
    public class HO_CalleLocal
    {
        [PrimaryKey, AutoIncrement]
        public int LocalId { get; set; }
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string TipoVia { get; set; }
        public string UbicacionZona { get; set; }
        public string UbicacionParroquia { get; set; }
        public string UbicacionSector { get; set; }
        public string UbicacionDistritoMetropolitano { get; set; }
        public string UbicacionCodigoPostal { get; set; }
        public string CaracteristicasSentido { get; set; }
        public int CaracteristicasCarriles {  get; set; }
        public string CaracteristicasTipoPavimento { get; set; }
        public string CaracteristicasEstadoVia { get; set; }
        public int CaracteristicasVelocidadMaxima { get; set; }
        public bool CaracteristicasTieneCicloVia { get; set; }
        public double CaracteristicasAnchoAceras {  get; set; }

    }
}
