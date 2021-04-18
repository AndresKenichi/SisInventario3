using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
   public class NModelos
    {
        //Método BuscarNombre que llama al método BuscarNombre
        //de la clase DModelo de la CapaDatos

        public static DataTable BuscarNombre(int idmarca)
        {
            DModelos Obj = new DModelos();
            Obj.IdMarca = idmarca;
            return Obj.BuscarNombre(Obj);

        }

    }
}
