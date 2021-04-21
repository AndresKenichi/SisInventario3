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

                //== 1 ? "OK" : "NO SE INGRESO EL REGISTRO"
                rpta = sqlCmd.ExecuteNonQuery().ToString();

            }
            catch (Exception e)
            {

                rpta = e.ToString();
            }
            return rpta;

        }
        public string RecepcionEquipos(DGestionEquipos ges)
        {

            string rpta = "";

            Conexion SqlCon = new Conexion();
            SqlCon.abrir();
            try
            {

                

                SqlCommand sqlCmd = new SqlCommand();
               
                sqlCmd.Connection = SqlCon.Conectarbd;
                sqlCmd.CommandText = "sp_RecepcionMov";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                /*SqlParameter IdMov = new SqlParameter();
                IdMov.ParameterName = "@idmov";
                IdMov.SqlDbType = SqlDbType.Int;
                IdMov.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(IdMov);*/

                SqlParameter IdMov = new SqlParameter();
                IdMov.ParameterName = "@idmov";
                IdMov.SqlDbType = SqlDbType.Int;
                IdMov.Value = ges.Id_movimiento;
                sqlCmd.Parameters.Add(IdMov);

                SqlParameter IdEquipo = new SqlParameter();
                //Nombre de La variable y tipo en SP
                IdEquipo.ParameterName = "@ideq";
                IdEquipo.SqlDbType = SqlDbType.Int;
                //Enviamos el valor de la variable local
                IdEquipo.Value = ges.Id_equipo;
                //Enviamos el objeto con la informacion
                sqlCmd.Parameters.Add(IdEquipo);

                SqlParameter IdEmpleado = new SqlParameter();
                IdEmpleado.ParameterName = "@idemp";
                IdEmpleado.SqlDbType = SqlDbType.Int;
                IdEmpleado.Value = ges.Id_empleado;
                sqlCmd.Parameters.Add(IdEmpleado);

                SqlParameter IdEncabezdo = new SqlParameter();
                IdEncabezdo.ParameterName = "@idenc";
                IdEncabezdo.SqlDbType = SqlDbType.Int;
                IdEncabezdo.Value = ges.Id_encabezado;
                sqlCmd.Parameters.Add(IdEncabezdo);

                SqlParameter Description = new SqlParameter();
                Description.ParameterName = "@descrip";
                Description.SqlDbType = SqlDbType.VarChar;
                Description.Size = 50;
                Description.Value = ges.Descripcion;
                sqlCmd.Parameters.Add(Description);

                SqlParameter IdDepartament = new SqlParameter();
                IdDepartament.ParameterName = "@iddep";
                IdDepartament.SqlDbType = SqlDbType.Int;
                IdDepartament.Value = ges.Id_departamento;
                sqlCmd.Parameters.Add(IdDepartament);

                SqlParameter Fecha_Asig = new SqlParameter();
                Fecha_Asig.ParameterName = "@fech";
                Fecha_Asig.SqlDbType = SqlDbType.DateTime;
                Fecha_Asig.Value = ges.Fecha_movimiento;
                sqlCmd.Parameters.Add(Fecha_Asig);
                //Ejecutamos nuestro Comando

                SqlParameter IdUser = new SqlParameter();
                IdUser.ParameterName = "@idus";
                IdUser.SqlDbType = SqlDbType.Int;
                IdUser.Value = ges.Id_usuario;
                sqlCmd.Parameters.Add(IdUser);


                //== 1 ? "OK" : "NO SE INGRESO EL REGISTRO"
                rpta = sqlCmd.ExecuteNonQuery().ToString();

            }
            catch (Exception e)
            {

                rpta = e.ToString();
            }
            SqlCon.cerrar();
            return rpta;

        }
        public DataTable MostrarMovimientos(string nam)
        {
            DataTable DtResultado = new DataTable("movimientos");

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "select movimientos_enquipos.id_mov,empleados.id_empleado,(empleados.nombre+' '+empleados.apellido) AS Nombre_Empleado, equipos.id_equipo,(marcas.marca+' '+modelos.modelo) AS Equipodepartamentos, departamentos.id_departamento,departamentos.departamento,(encabezado_movimientos.encabezado) AS Ultimo_Movimiento from movimientos_enquipos INNER JOIN equipos ON movimientos_enquipos.id_equipo=equipos.id_equipo INNER JOIN empleados ON movimientos_enquipos.id_empleado=empleados.id_empleado INNER JOIN marcas ON equipos.id_marca=marcas.id_marca INNER JOIN modelos ON modelos.id_modelo = equipos.id_modelo INNER JOIN departamentos ON movimientos_enquipos.id_departamento=departamentos.id_departamento INNER JOIN encabezado_movimientos ON encabezado_movimientos.id_encabezado=movimientos_enquipos.id_encabezado where empleados.nombre like '"+nam+"%' and movimientos_enquipos.estado=1";


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {

                DtResultado = null;
            }
            SqlCon.Close();
            return DtResultado;

        }
    }
}
