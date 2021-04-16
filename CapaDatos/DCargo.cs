using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DCargo
    {
        private int _Idcargo;
        private string _Nombre;

        public int Idcargo { get => _Idcargo; set => _Idcargo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }

        //Metodo para mostrar todos los registros de la tabla categoria
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("cargos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_cargos";
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
    }
}
