using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEncabezado
    {
        private int _Id_encabezado;
        private string _Encabezado;

        public int Id_encabezado { get => _Id_encabezado; set => _Id_encabezado = value; }
        public string Encabezado { get => _Encabezado; set => _Encabezado = value; }



        //Metodo para mostrar todos los registros de la tabla 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("encabezado_movimientos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spllenar_encMovimiento";
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
