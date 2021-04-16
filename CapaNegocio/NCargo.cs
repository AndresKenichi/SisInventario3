using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
  public class NCargo
    {
        //Método Mostrar que llama al Método mostrar de la clase DCargos
        //De la CapaDatos

        public static DataTable Mostrar()
        {
            return new DCargo().Mostrar();
        }
    }
}
