using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class Ddepartamentos
    {
        private int _Iddepartamento;
        private string _Departamento;

        public int Iddepartamento { get => _Iddepartamento; set => _Iddepartamento = value; }
        public string Departamento { get => _Departamento; set => _Departamento = value; }

        //Metodo para mostrar todos los registros de la tabla 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("departamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_departamentos";
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
