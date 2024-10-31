using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.Datos
{
    public static class Validaciones
    {
        public static bool soloNumeros(string texto)
        {
            foreach (char letra in texto)
            {
                if (!char.IsNumber(letra))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
