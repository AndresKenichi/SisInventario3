using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
   public class NEmpleados
    {
        //Metodo insertar que llama al método Insertar de la clase DEmpleados de la capaDatos
        
        public static string Insertar(string nombre, string apellido, string telefono,
            string direccion, string dui, string nit, int id_cargo, int estado, int iddepa)
        {
            DEmpleados Obj = new DEmpleados();

            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Telefono = telefono;
            Obj.Direccion = direccion;
            Obj.Dui = dui;
            Obj.Nit = nit;
            Obj.Id_cargo = id_cargo;
            Obj.Estado = estado;
            Obj.Iddepartamento = iddepa;
            

            return Obj.Insertar(Obj);

        }

        //Metodo Editar que llama al método Editar de la clase DEmpleados
        //De la CapaDatos

        public static string Editar(int idempleado, string nombre, string apellido, string telefono,
            string direccion, string dui, string nit, int id_cargo, int estado, int iddepa)
        {

            DEmpleados Obj = new DEmpleados();
            Obj.Idempleado = idempleado;
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Telefono = telefono;
            Obj.Direccion = direccion;
            Obj.Dui = dui;
            Obj.Nit = nit;
            Obj.Id_cargo = id_cargo;
            Obj.Estado = estado;
            Obj.Iddepartamento = iddepa;

            return Obj.Editar(Obj);

        }

        //Metodo Eliminar que llama al método Eliminar de la clase DEmpleados
        //De la CapaDatos

        public static string Eliminar(int idempleados)
        {

            DEmpleados Obj = new DEmpleados();
            Obj.Idempleado = idempleados;
            return Obj.Eliminar(Obj);

        }

        //Método Mostrar que llama al Método mostrar de la clase DEmpleados
        //De la CapaDatos

        public static DataTable Mostrar()
        {
            return new DEmpleados().Mostrar();
        }

        //Método BuscarNombre que llama al método BuscarNombre
        //de la clase DEmpleados de la CapaDatos

        public static DataTable BuscarNombre(string textobuscar)
        {
            DEmpleados Obj = new DEmpleados();
            Obj.TextoBuscar = textobuscar;

            return Obj.BuscarNombre(Obj);

        }

        public static DataTable BuscarNombreG(string textobuscar)
        {
            DEmpleados Obj = new DEmpleados();
            Obj.TextoBuscar = textobuscar;

            return Obj.BuscarNombreG(Obj);

        }


        public static DataTable MostrarConDt()
        {
            return new DEmpleados().MostrarConDt();
        }



    }
}
