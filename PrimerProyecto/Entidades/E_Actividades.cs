using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.Entidades
{
    internal class E_Actividades
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int NProfesor { get; set; }
        public E_Actividades() { }
    }
}
