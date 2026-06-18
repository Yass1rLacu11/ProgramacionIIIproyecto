using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppProyectoProyecto3A.clases
{
    public class DetalleVuelo
    {
        public int idVuelo { get; set; }
        public string fechaSalida { get; set; }
        public string horaSalida { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string piloto { get; set; }
        public string avion { get; set; }
        public int capacidad { get; set; }
        public decimal precio { get; set; }
    }
}
