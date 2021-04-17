using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;
using System.Collections;

namespace CapaNegocio
{
   public class NUsuarios
    {

        //Método Login que llama al método Login
        //de la clase DUsuarios de la CapaDatos
        private DUsuarios Obj = new DUsuarios();

        public static DataTable Login(string correo, string clave)
        {
            DUsuarios Obj = new DUsuarios();
            Obj.Correo = correo;
            Obj.Clave = clave;
            return Obj.Login(Obj);

        }
        public string Insertar(int id, string correo, string clave, int tipo)
        {
            Obj.Idusuario = id;
            Obj.Correo = correo;
            Obj.Clave = clave;
            Obj.Tipo = tipo;

            return Obj.Insertar(Obj);

        }
        public string Modificar(int id, string correo, string clave, int tipo)
        {
            Obj.Idusuario = id;
            Obj.Correo = correo;
            Obj.Clave = clave;
            Obj.Tipo = tipo;

            return Obj.Modificar(Obj);

        }
        public string Eliminar(int id)
        {

            Obj.Idusuario = id;

            return Obj.Eliminar(Obj);
        }
        public ArrayList UsuarioInfo(int id)
        {

            ArrayList info = new ArrayList();
            Obj.Idusuario = id;

            info = Obj.UserInfo(Obj);

            return info;

        }
        public ArrayList UsuarioCredenciales(int id)
        {

            ArrayList info = new ArrayList();
            Obj.Idusuario = id;

            info = Obj.UserCredentials(Obj);

            return info;

        }
        public int validateUser(int id)
        {

            int n = -1;

            Obj.Idusuario = id;
            n = Obj.validateUser(Obj);

            return n;

        }

        

   }
}
