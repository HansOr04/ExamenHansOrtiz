using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenHansOrtiz.Models
{
    public class HO_Servicios
    {
        public HO_TransportePublico TransportePublico { get; set; }
        public HO_Infraestructura Infraestructura { get; set; }
    }

    public class HO_TransportePublico
    {
        public bool TieneBus { get; set; }
        public bool TieneTrolebus { get; set; }
        public List<string> ParadasBus { get; set; }
    }

    public class HO_Infraestructura
    {
        public bool AlumbradoPublico { get; set; }
        public int Semaforos { get; set; }
        public int CrucesPeatonales { get; set; }
        public bool RampasAccesibilidad { get; set; }
    }

    
}
