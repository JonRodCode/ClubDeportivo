using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    internal class Cliente
    {
        public string nombre;
        public string apellido;
        public string tipo;
        public int documento;

        public Cliente() { }
        public Cliente(string nombre, string apellido, string tipo, int documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipo = tipo;
            this.documento = documento;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }
        public int Documento { get { return documento; } set { documento = value; } }
        public override string ToString()
        {
            return ("Nombre: " + nombre + " Apellido: " + apellido +
                "\nDocumento tipo: " + tipo + " Número: " + documento);
        }
    }
}
