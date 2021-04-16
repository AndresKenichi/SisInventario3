using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    class Conexion
    {
        public static string Cn = @"Data Source=DESKTOP-I39N25J\JOSHEP; Initial Catalog=inventario2; Integrated Security=true";
        public SqlConnection Conectarbd = new SqlConnection();

        //Constructor
        public Conexion()
        {
            Conectarbd.ConnectionString = Cn;
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD ", ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }
    }


}
