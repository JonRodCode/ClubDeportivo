using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.Entidades
{
    internal class E_Postulante
    {
        public string nombre;
        public string apellido;
        public string tipo;
        public int documento;
        public string mail;
        public int celular;
        public bool aptoFisico;
        public bool esSocio;
        public E_Postulante() { }
        public E_Postulante(string nombre, string apellido, string tipo, int documento, string mail, int celular, bool aptoFisico, bool esSocio)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipo = tipo;
            this.documento = documento;
            this.mail = mail;
            this.celular = celular;
            this.aptoFisico = aptoFisico;
            this.esSocio = esSocio;
        }


        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo { get; set; }
        public int Documento { get; set; }
        public override string ToString()
        {
            return ("Nombre: " + nombre + " Apellido: " + apellido +
                "\nDocumento tipo: " + tipo + " Número: " + documento);
        }
    }
}
