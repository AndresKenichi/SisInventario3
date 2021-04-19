using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
   public class NEquipos
    {
        //Metodo insertar que llama al método Insertar de la clase DEmpleados de la capaDatos

        public static string Insertar( int idprogramacion, int idmarca, int idmodelo, string codigo, decimal precio, DateTime fecha_cad, string tipo_equipo, int estado,
            int id_usuario, DateTime fecha_modificacion)
        {
            DEquipos Obj = new DEquipos();
            Obj.Idprogramacion = idprogramacion;
            Obj.Idmarca = idmarca;
            Obj.Idmodelo = idmodelo;
            Obj.Codigo = codigo;
            Obj.Precio = precio;
            Obj.Fecha_cad = fecha_cad;
            Obj.Tipo_equipo = tipo_equipo;
            Obj.Estado = estado;
            Obj.Id_usuario = id_usuario;
            Obj.Fecha_modificacion = fecha_modificacion;


            return Obj.Insertar(Obj);

        }

        //Metodo Editar que llama al método Editar de la clase DEmpleados
        //De la CapaDatos

        public static string Editar(int idequipo, int idprogramacion, int idmarca, int idmodelo, string codigo, decimal precio, DateTime fecha_cad, string tipo_equipo, int estado,
            int id_usuario, DateTime fecha_modificacion)
        {

            DEquipos Obj = new DEquipos();
            Obj.Idequipo = idequipo;
            Obj.Idprogramacion = idprogramacion;
            Obj.Idmarca = idmarca;
            Obj.Idmodelo = idmodelo;
            Obj.Codigo = codigo;
            Obj.Precio = precio;
            Obj.Fecha_cad = fecha_cad;
            Obj.Tipo_equipo = tipo_equipo;
            Obj.Estado = estado;
            Obj.Id_usuario = id_usuario;
            Obj.Fecha_modificacion = fecha_modificacion;


            return Obj.Editar(Obj);

        }

        //Metodo Eliminar que llama al método Eliminar de la clase DEmpleados
        //De la CapaDatos

        public static string Eliminar(int idequipo)
        {

            DEquipos Obj = new DEquipos();
            Obj.Idequipo = idequipo;
            return Obj.Eliminar(Obj);

        }

        //Método Mostrar que llama al Método mostrar de la clase DEmpleados
        //De la CapaDatos

        public static DataTable Mostrar()
        {
            return new DEquipos().Mostrar();
        }

        public static DataTable Mostrar2()
        {
            return new DEquipos().Mostrar2();
        }

        public static DataTable LlenarCmbTipo()
        {
            return new DEquipos().LlenarCmbTipo();
        }

        //Método BuscarNombre que llama al método BuscarNombre
        //de la clase DEmpleados de la CapaDatos

        public static DataTable BuscarNombre(string textobuscar)
        {
            DEquipos Obj = new DEquipos();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);

        }
    }
}
