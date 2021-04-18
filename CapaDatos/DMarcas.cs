using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DMarcas
    {

        private int _IdMarca;
        private string _Marca;

        public int IdMarca { get => _IdMarca; set => _IdMarca = value; }
        public string Marca { get => _Marca; set => _Marca = value; }


        //Metodo para mostrar todos los registros de la tabla 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("marcas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_marcas";
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
