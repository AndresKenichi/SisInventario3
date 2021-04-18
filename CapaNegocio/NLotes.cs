using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    class NLotes
    {
        private int codigo, cantidad;
        private string gestion;
        private DateTime fecha;

        public int Codigo { get => codigo; set => codigo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Gestion { get => gestion; set => gestion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
