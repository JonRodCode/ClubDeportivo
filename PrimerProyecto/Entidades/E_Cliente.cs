using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.Entidades
{
    public abstract class E_Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo { get; set; }
        public int Documento { get; set; }
        public string Mail { get; set; }

        public int Celular { get; set; }

        public bool AptoFisico { get; set; }
        protected E_Cliente(string nombre, string apellido, string tipo, int documento, string mail, int celular, bool aptoFisico)
        {
            Nombre = nombre;
            Apellido = apellido;
            Tipo = tipo;
            Documento = documento;
            Mail = mail;
            Celular = celular;
            AptoFisico = aptoFisico;
        }
        public E_Cliente() { }

        public override string ToString()
        {
            return ("Nombre: " + Nombre + " Apellido: " + Apellido +
                "\nDocumento tipo: " + Tipo + " Número: " + Documento);
        }
    }
}
