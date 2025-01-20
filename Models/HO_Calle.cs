using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenHansOrtiz.Models
{
    public class HO_Calle
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string TipoVia { get; set; }
        public HO_Geometria Geometria { get; set; }
        public HO_Ubicacion Ubicacion { get; set; }
        public HO_Caracteristicas Caracteristicas { get; set; }
        public HO_Servicios Servicios { get; set; }
        public List<HO_PuntoInteres> PuntosInteres { get; set; }
        public HO_Mantenimiento Mantenimiento { get; set; }
        public HO_Metadata Metadata { get; set; }
    }

    
}
