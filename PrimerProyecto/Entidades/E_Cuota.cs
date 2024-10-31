using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.Entidades
{
    public class E_Cuota
    {
        public int CodPago { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int NCliente { get; set; }
        public decimal Precio { get; set; }

        public E_Cuota() { }
    }
}
