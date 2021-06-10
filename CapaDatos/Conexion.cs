using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    class Conexion
    {
        //Server=tcp:inventariocetu.database.windows.net,1433;Initial Catalog = inventario2; Persist Security Info=False;User ID = pasca; Password=password.12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;
        //public static string Cn = @"Data Source=KEVIN; Initial Catalog=inventario2; Integrated Security=true";
       // public static string Cn = @"Data Source=DESKTOP-T3VRL82\SQLEXPRESS; Initial Catalog=inventario2; Integrated Security=true";
        //public static string Cn = @"Data Source=DESKTOP-I39N25J\JOSHEP; Initial Catalog=inventario2; Integrated Security=true";
        public static string Cn = "Server=tcp:inventariocetu2.database.windows.net,1433;Initial Catalog=inventario2;Persist Security Info=False;User ID=pasca;Password=password.12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public SqlConnection Conectarbd = new SqlConnection();

        //Constructor
        public Conexion()
        {
            Conectarbd.ConnectionString = Cn;
        }
        public static SqlConnection getConnection() {

            return new SqlConnection("Data Source=DESKTOP-I39N25J\\JOSHEP; Initial Catalog=inventario2; Integrated Security=true");
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
