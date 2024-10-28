﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.Entidades
{
    public class E_NoSocio : E_Cliente
    {
        public E_NoSocio(string nombre,
            string apellido,
            string tipo,
            int documento,
            string mail,
            int celular,
            bool aptoFisico,
            bool esSocio) : base(nombre, apellido, tipo, documento, mail, celular, aptoFisico) { }

        public E_NoSocio() : base() { }
    }


}