using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DGestionEquipos
    {

        int id_movimiento, id_usuario, id_equipo, id_departamento, id_encabezado, id_empleado, estado;
        string descripcion;
        DateTime fecha_movimiento;

        public DGestionEquipos()
        {

        }
        public DGestionEquipos(int id_movimiento, int id_usuario, int id_equipo, int id_departamento, int id_encabezado, int id_empleado, int estado, string descripcion, DateTime fecha_movimiento)
        {
            this.id_movimiento = id_movimiento;
            this.id_usuario = id_usuario;
            this.id_equipo = id_equipo;
            this.id_departamento = id_departamento;
            this.id_encabezado = id_encabezado;
            this.id_empleado = id_empleado;
            this.estado = estado;
            this.descripcion = descripcion;
            this.fecha_movimiento = fecha_movimiento;
        }

        public int Id_movimiento { get => id_movimiento; set => id_movimiento = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_equipo { get => id_equipo; set => id_equipo = value; }
        public int Id_departamento { get => id_departamento; set => id_departamento = value; }
        public int Id_encabezado { get => id_encabezado; set => id_encabezado = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha_movimiento { get => fecha_movimiento; set => fecha_movimiento = value; }

        public string AsignarEquipos(DGestionEquipos ges)
        {

            string rpta = "";

            Conexion SqlCon = new Conexion();

            try
            {

                SqlCon.abrir();

                SqlCommand sqlCmd = new SqlCommand();

                sqlCmd.Connection = SqlCon.Conectarbd;
                sqlCmd.CommandText = "sp_AsignarEquipos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter IdEquipo = new SqlParameter();
                //Nombre de La variable y tipo en SP
                IdEquipo.ParameterName = "@id_equipo";
                IdEquipo.SqlDbType = SqlDbType.Int;
                //Enviamos el valor de la variable local
                IdEquipo.Value = ges.Id_equipo;
                //Enviamos el objeto con la informacion
                sqlCmd.Parameters.Add(IdEquipo);

                SqlParameter IdEmpleado = new SqlParameter();
                IdEmpleado.ParameterName = "@id_empleado";
                IdEmpleado.SqlDbType = SqlDbType.Int;
                IdEmpleado.Value = ges.Id_empleado;
                sqlCmd.Parameters.Add(IdEmpleado);

                SqlParameter IdEncabezdo = new SqlParameter();
                IdEncabezdo.ParameterName = "@id_encabezado";
                IdEncabezdo.SqlDbType = SqlDbType.Int;
                IdEncabezdo.Value = ges.Id_encabezado;
                sqlCmd.Parameters.Add(IdEncabezdo);

                SqlParameter Description = new SqlParameter();
                Description.ParameterName = "@descripcion";
                Description.SqlDbType = SqlDbType.VarChar;
                Description.Size = 50;
                Description.Value = ges.Descripcion;
                sqlCmd.Parameters.Add(Description);

                SqlParameter IdDepartament = new SqlParameter();
                IdDepartament.ParameterName = "@id_departamento";
                IdDepartament.SqlDbType = SqlDbType.Int;
                IdDepartament.Value = ges.Id_departamento;
                sqlCmd.Parameters.Add(IdDepartament);

                SqlParameter Fecha_Asig = new SqlParameter();
                Fecha_Asig.ParameterName = "@fecha";
                Fecha_Asig.SqlDbType = SqlDbType.DateTime;
                Fecha_Asig.Value = ges.Fecha_movimiento;
                sqlCmd.Parameters.Add(Fecha_Asig);
                //Ejecutamos nuestro Comando

                SqlParameter IdUser = new SqlParameter();
                IdUser.ParameterName = "@id_usuario";
                IdUser.SqlDbType = SqlDbType.Int;
                IdUser.Value = ges.Id_usuario;
                sqlCmd.Parameters.Add(IdUser);

                SqlParameter State = new SqlParameter();
                State.ParameterName = "@estado";
                State.SqlDbType = SqlDbType.Int;
                State.Value = ges.Estado;
                sqlCmd.Parameters.Add(State);


                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE INGRESO EL REGISTRO";

            }
            catch (Exception e)
            {

                rpta = e.ToString();
            }
            return rpta;

        }
    }
}
