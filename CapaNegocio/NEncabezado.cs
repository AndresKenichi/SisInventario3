using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
   public class NEncabezado
    {

        //Método Mostrar que llama al Método mostrar de la clase DEncabezado
        //De la CapaDatos

        public static DataTable Mostrar()
        {
            return new DEncabezado().Mostrar();
        }



    }
}
