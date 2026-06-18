using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppProyectoProyecto3A.clases
{
    public class Reserva
    {
        public int idReserva { get; set; }
        public DateTime fechaReserva { get; set; }
        public string estado { get; set; }
        public long idUsuario { get; set; }
        public long idVuelo { get; set; }
    }
}
