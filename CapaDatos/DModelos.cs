using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DModelos
    {
        private int _IdModelo;
        private string _Modelo;
        private int _IdMarca;

        public int IdModelo { get => _IdModelo; set => _IdModelo = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public int IdMarca { get => _IdMarca; set => _IdMarca = value; }

        public DModelos()
        {
        }

        public DModelos(int idModelo, string modelo, int idMarca)
        {
            this.IdModelo = idModelo;
            this.Modelo = modelo;
            this.IdMarca = idMarca;

        }

        //Metodo para BuscarNombre
        public DataTable BuscarNombre(DModelos Modelos)
        {
            DataTable DtResultado = new DataTable("modelos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_modeloscb";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdMarca = new SqlParameter();
                ParIdMarca.ParameterName = "@id_marcas";
                ParIdMarca.SqlDbType = SqlDbType.Int;
                ParIdMarca.Value = Modelos.IdMarca;
                SqlCmd.Parameters.Add(ParIdMarca);


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
