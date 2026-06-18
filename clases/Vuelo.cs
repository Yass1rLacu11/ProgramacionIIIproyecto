using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppProyectoProyecto3A.clases
{
    public class Vuelo
    {
        public int idVuelo { get; set; }
        public string fechaSalida { get; set; }
        public string horaSalida { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string piloto { get; set; }
        public string avion { get; set; }
        public decimal precio { get; set; }


        public int idPiloto { get; set; }
        public int idAvion { get; set; }
        public int idAeropuertoOrigen { get; set; }
        public int idAeropuertoDestino { get; set; }
    }
}
