using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class NLotes
    {
        private int cantidad;
        private string gestion;
        private DateTime fecha;

        public NLotes(int codigo, int cantidad, string gestion, DateTime fecha)
        {
            this.cantidad = cantidad;
            this.gestion = gestion;
            this.fecha = fecha;
        }

        public NLotes()
        {
            
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Gestion { get => gestion; set => gestion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public string ingresarLote(DateTime fecha,int cantidad, string gestion) {

            DLotes k = new DLotes();

            k.Fecha_ingreso = fecha;
            k.Cantidad = cantidad;
            k.Gestion = gestion;

            return k.insertarLote(k);

        }
        public int idL() {

            DLotes s = new DLotes();

            return s.lastId();
        }
    }

}
