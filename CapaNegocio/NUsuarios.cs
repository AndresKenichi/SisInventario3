using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
   public class NUsuarios
    {

        //Método Login que llama al método Login
        //de la clase DUsuarios de la CapaDatos

        public static DataTable Login(string correo, string clave)
        {
            DUsuarios Obj = new DUsuarios();
            Obj.Correo = correo;
            Obj.Clave = clave;
            return Obj.Login(Obj);

        }


    }
}
