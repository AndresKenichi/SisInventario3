using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DEmpleados
    {

        private int _Idempleado;
        private string _Nombre;
        private string _Apellido;
        private string _Telefono;
        private string _Direccion;
        private string _Dui;
        private string _Nit;
        private int _Id_cargo;
        private int _Estado;
        private string _TextoBuscar;



        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Dui { get => _Dui; set => _Dui = value; }
        public string Nit { get => _Nit; set => _Nit = value; }
        public int Id_cargo { get => _Id_cargo; set => _Id_cargo = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        //Constructores
        public DEmpleados()
        {

        }

        public DEmpleados(int idempleado, string nombre, string apellido, string telefono,
            string direccion, string dui, string nit, int id_cargo, int estado, string textobuscar)
        {
            this.Idempleado = idempleado;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Direccion = Direccion;
            this.Dui = dui;
            this.Nit = nit;
            this.Id_cargo = id_cargo;
            this.Estado = estado;
            this.TextoBuscar = textobuscar;


        }

        //Metodo para insertar datos en la tabla Categoria
        public string Insertar(DEmpleados Empleados)
        {

            string rpta = "";
            //Creamos una instancia de la clase SqlConnection
            SqlConnection SqlCon = new SqlConnection();

            //Declaramos un capturador de errores
            try
            {
                //Codigo para establecer la conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Codigo para realizar la comunicacion con nuestro proc insercion
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "spinsertar_empleado";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Empleados.Nombre;
                sqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = Empleados.Apellido;
                sqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Empleados.Telefono;
                sqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Empleados.Direccion;
                sqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParDui = new SqlParameter();
                ParDui.ParameterName = "@dui";
                ParDui.SqlDbType = SqlDbType.VarChar;
                ParDui.Size = 16;
                ParDui.Value = Empleados.Dui;
                sqlCmd.Parameters.Add(ParDui);


                SqlParameter ParNit = new SqlParameter();
                ParNit.ParameterName = "@nit";
                ParNit.SqlDbType = SqlDbType.VarChar;
                ParNit.Size = 20;
                ParNit.Value = Empleados.Nit;
                sqlCmd.Parameters.Add(ParNit);

                SqlParameter ParId_Cargo = new SqlParameter();
                ParId_Cargo.ParameterName = "@id_cargo";
                ParId_Cargo.SqlDbType = SqlDbType.Int;
                ParId_Cargo.Value = Empleados.Id_cargo;
                sqlCmd.Parameters.Add(ParId_Cargo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Empleados.Estado;
                sqlCmd.Parameters.Add(ParEstado);

                //Ejecutamos nuestro Comando

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE INGRESO EL REGISTRO";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;


        }

        //Metodo Editar 
        public string Editar(DEmpleados Empleados)
        {
            string rpta = "";
            //Creamos una instancia de la clase SqlConnection
            SqlConnection SqlCon = new SqlConnection();

            //Declaramos un capturador de errores
            try
            {
                //Codigo para establecer la conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Codigo para realizar la comunicacion con nuestro proc insercion
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "speditar_empleado";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@idempleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = Empleados.Idempleado;
                sqlCmd.Parameters.Add(ParIdEmpleado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Empleados.Nombre;
                sqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = Empleados.Apellido;
                sqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Empleados.Telefono;
                sqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Empleados.Direccion;
                sqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParDui = new SqlParameter();
                ParDui.ParameterName = "@dui";
                ParDui.SqlDbType = SqlDbType.VarChar;
                ParDui.Size = 16;
                ParDui.Value = Empleados.Dui;
                sqlCmd.Parameters.Add(ParDui);


                SqlParameter ParNit = new SqlParameter();
                ParNit.ParameterName = "@nit";
                ParNit.SqlDbType = SqlDbType.VarChar;
                ParNit.Size = 20;
                ParNit.Value = Empleados.Nit;
                sqlCmd.Parameters.Add(ParNit);

                SqlParameter ParId_Cargo = new SqlParameter();
                ParId_Cargo.ParameterName = "@id_cargo";
                ParId_Cargo.SqlDbType = SqlDbType.Int;
                ParId_Cargo.Value = Empleados.Id_cargo;
                sqlCmd.Parameters.Add(ParId_Cargo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Empleados.Estado;
                sqlCmd.Parameters.Add(ParEstado);


                //Ejecutamos nuestro Comando

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Actualizo el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;


        }

        //Metodo para Eliminar datos
        public string Eliminar(DEmpleados Empleados)
        {
            string rpta = "";
            //Creamos una instancia de la clase SqlConnection
            SqlConnection SqlCon = new SqlConnection();

            //Declaramos un capturador de errores
            try
            {
                //Codigo para establecer la conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Codigo para realizar la comunicacion con nuestro proc insercion
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "speliminar_empleado";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@idempleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = Empleados.Idempleado;
                sqlCmd.Parameters.Add(ParIdEmpleado);


                //Ejecutamos nuestro Comando

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Elimino el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }

        //Metodo para mostrar todos los registros de la tabla categoria
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {

                DtResultado = null;
            }
            return DtResultado;

        }

        //Metodo para BuscarNombre
        public DataTable BuscarNombre(DEmpleados Empleados)
        {
            DataTable DtResultado = new DataTable("empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_empleado_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Empleados.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {

                DtResultado = null;
            }
            return DtResultado;

        }










    }
}
