using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenHansOrtiz.Models
{
    public class HO_Caracteristicas
    {
        public string Sentido { get; set; }
        public int Carriles { get; set; }
        public string TipoPavimento { get; set; }
        public string EstadoVia { get; set; }
        public int VelocidadMaxima { get; set; }
        public bool TieneCicloruta { get; set; }
        public double AnchoAceras { get; set; }
    }

    
}
