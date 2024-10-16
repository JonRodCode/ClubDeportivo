using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.Entidades
{
    public class E_Postulante
    {
        public E_Postulante() { }
        public E_Postulante(string nombre, string apellido, string tipo, int documento, string mail, int celular, bool aptoFisico, bool esSocio)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Tipo = tipo;
            this.Documento = documento;
            this.Mail = mail;
            this.Celular = celular;
            this.AptoFisico = aptoFisico;
            this.EsSocio = esSocio;
        }


        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo { get; set; }
        public int Documento { get; set; }
        public string Mail { get; set; }

        public int Celular { get; set; }

        public bool AptoFisico { get; set; }
        public bool EsSocio { get; set; }


        public override string ToString()
        {
            return ("Nombre: " + Nombre + " Apellido: " + Apellido +
                "\nDocumento tipo: " + Tipo + " Número: " + Documento);
        }
    }
}
