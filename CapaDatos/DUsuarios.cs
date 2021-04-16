using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DUsuarios
    {

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



    }
}
