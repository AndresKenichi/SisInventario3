using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace CapaDatos
{
   public class DUsuarios
    {
        Conexion conexion = new Conexion();
        private int _Idusuario;
        private int _Idempleado;
        private int _Nombre;
        private string _Telefono;
        private string _Correo;
        private string _Clave;
        private int _Tipo;

        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }
        public int Nombre { get => _Nombre; set => _Nombre = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public int Tipo { get => _Tipo; set => _Tipo = value; }

        public DUsuarios()
        {
        }

        public DUsuarios(int idusuario, int idempleado, int nombre, string telefono, string correo, string clave, int tipo)
        {
            this.Idusuario = idusuario;
            this.Idempleado = idempleado;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Clave = clave;
            this.Tipo = tipo;
            
        }




        //Metodo para poder loguearse
        public DataTable Login(DUsuarios Usuarios)
        {
            DataTable DtResultado = new DataTable("usuarios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "splogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 50;
                ParCorreo.Value = Usuarios.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.VarChar;
                ParClave.Size = 20;
                ParClave.Value = Usuarios.Clave;
                SqlCmd.Parameters.Add(ParClave);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {

                DtResultado = null;
            }
            return DtResultado;

        }
        public string Insertar(DUsuarios usuarios)
        {
            conexion.abrir();
            string rpta = "";
            string cad = "INSERT INTO usuarios(id_empleado,correo,clave,tipo) VALUES(" + _Idusuario + ",'" + _Correo + "','" + _Clave + "'," + _Tipo + ")";
            //Declaramos un capturador de errores
            try
            {

                //Codigo para realizar la comunicacion con nuestro proc insercion
                SqlCommand sqlCmd = new SqlCommand(cad);
                sqlCmd.Connection = conexion.Conectarbd;

               
                //Ejecutamos nuestro Comando
                
                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "INGRESADO" : "NO SE INGRESO EL REGISTRO";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (conexion.Conectarbd.State == ConnectionState.Open) conexion.Conectarbd.Close();
            }

            return rpta;

        }
        public string Eliminar(DUsuarios usuarios)
        {
            conexion.abrir();
            string m = "";
            try
            {
                String cad = "DELETE FROM usuarios where id_empleado = " + _Idusuario + "";

                SqlCommand comd = new SqlCommand(cad);
                comd.Connection = conexion.Conectarbd;

                m = comd.ExecuteNonQuery() == 1 ? "ELIMINADO" : "NO SE ELIMINO EL REGISTRO";

            }
            catch (Exception ex)
            {
                m = ex.Message;
                return m;
            }
            finally
            {
                if (conexion.Conectarbd.State == ConnectionState.Open) conexion.Conectarbd.Close();
            }

            return m;
        }
        public int validateUser(int id)
        {

            conexion.abrir();
            int m = -1;
            try
            {
                //El la consulta solo traeremos concatenado el nombre y apellido, junto con el cargo. Serán dos columas
                String cad = "SELECT count(id_usuario) AS Num FROM usuarios where id_empleado=" + Idempleado + "";

                SqlCommand comd = new SqlCommand(cad);
                comd.Connection = conexion.Conectarbd;

                SqlDataReader d = comd.ExecuteReader();

                if (d.Read())
                {

                    m = Int32.Parse(d["Num"].ToString());
                }

            }
            catch (Exception ex)
            {
                return 666;
            }
            finally
            {
                if (conexion.Conectarbd.State == ConnectionState.Open) conexion.Conectarbd.Close();
            }

            return m;
        }
        public ArrayList UserInfo(DUsuarios usuarios)
        {
            //La dinamica es guardar en un ArrayList el nombre y el cargo, luego de la busqueda en Usuarios cuando precionemos
            //el boton "Buscar"
            conexion.abrir();

            ArrayList us = new ArrayList();

            try
            {
                //El la consulta solo traeremos concatenado el nombre y apellido, junto con el cargo. Serán dos columas
                String cad = "SELECT (e.nombre +' '+ e.apellido) AS Nombre,c.cargo FROM empleados e INNER JOIN cargos c ON e.id_cargo = c.id_cargo where e.id_empleado = " + _Idusuario + "";

                SqlCommand comd = new SqlCommand(cad);
                comd.Connection = conexion.Conectarbd;

                SqlDataReader rd = comd.ExecuteReader();
                //Leemos las filas
                if (rd.HasRows)
                {
                    //Leemos columnas
                    while (rd.Read())
                    {
                        //Asignamos cada columna al ArrayList, al final lo retornaremos
                        us.Add(rd.GetString(0));
                        us.Add(rd.GetString(1));
                    }
                }

                rd.Close();
            }
            catch (Exception ex)
            {
                us.Add(ex.Message);
            }
            finally
            {
                if (conexion.Conectarbd.State == ConnectionState.Open) conexion.Conectarbd.Close();
            }

            return us;
        }

        public string Modificar(DUsuarios usuarios)
        {
            conexion.abrir();
            string rpta = "";
            string cad = "UPDATE usuarios SET correo = '" + _Correo + "',clave='" + _Clave + "',tipo='" + _Tipo + "' WHERE id_empleado=" + _Idusuario + "";
            //Declaramos un capturador de errores
            try
            {

                //Codigo para realizar la comunicacion con nuestro proc insercion
                SqlCommand sqlCmd = new SqlCommand(cad);
                sqlCmd.Connection = conexion.Conectarbd;

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "MODIFICADO" : "NO SE ACTUALIZO EL REGISTRO";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (conexion.Conectarbd.State == ConnectionState.Open) conexion.Conectarbd.Close();
            }

            return rpta;

        }


    }
}
