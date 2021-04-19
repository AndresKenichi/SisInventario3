using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DLotes
    {
        Conexion con = new Conexion();

        int id_lote, cantidad,id_usuario;
        string gestion;
        DateTime fecha_ingreso,fecha_modificacion;

        public DLotes()
        {

        }

        public DLotes(DateTime fecha_ingreso , int cantidad, string gestion, int id_usuario, DateTime fecha_modificacion)
        {
            
            this.cantidad = cantidad;
            this.id_usuario = id_usuario;
            this.gestion = gestion;
            this.fecha_ingreso = fecha_ingreso;
            this.fecha_modificacion = fecha_modificacion;
        }

        public int Id_lote { get => id_lote; set => id_lote = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Gestion { get => gestion; set => gestion = value; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public DateTime Fecha_modificacion { get => fecha_modificacion; set => fecha_modificacion = value; }

        public string insertarLote(DLotes l) {

            con.abrir();

            string mss = "";
            try
            {
                SqlCommand add = new SqlCommand("INSERT INTO programacion(fecha,cant_equipos,gestion,estado) VALUES(@fec,@cant,@gest,1)");
                add.Connection = con.Conectarbd;

                add.Parameters.AddWithValue("@fec", Convert.ToDateTime(Fecha_ingreso));
                add.Parameters.AddWithValue("@cant", Convert.ToInt32(Cantidad));
                add.Parameters.AddWithValue("@gest", Convert.ToString(Gestion));
                add.Parameters.AddWithValue("@idu", Convert.ToString(Gestion));
                add.ExecuteNonQuery();

                mss = "OK";
            }
            catch (Exception e) { return e.ToString(); }
            con.cerrar();

            return mss;
        }

        public int lastId() {

            int n = 666;

            con.abrir();
            try
            {
                //El la consulta solo traeremos concatenado el nombre y apellido, junto con el cargo. Serán dos columas
                String cad = "SELECT TOP 1 (id_programacion) AS lastId FROM programacion ORDER BY id_programacion DESC;";

                SqlCommand comd = new SqlCommand(cad);
                comd.Connection = con.Conectarbd;

                SqlDataReader d = comd.ExecuteReader();

                if (d.Read())
                {
                    n = Int32.Parse(d["lastId"].ToString());
                }

            }
            catch (Exception ex)
            {
                return n;
            }
            finally
            {
                if (con.Conectarbd.State == ConnectionState.Open) con.Conectarbd.Close();
            }


            return n;
        }
    }
}
