using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppProyectoProyecto3A.clases
{
    public class ComprobanteReserva
    {
        public int idReserva { get; set; }
        public string fechaReserva { get; set; }
        public string estado { get; set; }
        public string nombreUsuario { get; set; }
        public string correo { get; set; }
        public string fechaSalida { get; set; }
        public string horaSalida { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string avion { get; set; }
        public decimal precio { get; set; }
    }
}
