using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;

namespace CapaDatos
{
   public class DEmpleados
    {

        private int _Idempleado;
        private string _Nombre;
        private string _Apellido;
        private string _Telefono;
        private string _Direccion;
        private string _Dui;
        private string _Nit;
        private int _Id_cargo;
        private int _Estado;
        private int _Iddepartamento;

        private string _TextoBuscar;


        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Dui { get => _Dui; set => _Dui = value; }
        public string Nit { get => _Nit; set => _Nit = value; }
        public int Id_cargo { get => _Id_cargo; set => _Id_cargo = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }
        public int Iddepartamento { get => _Iddepartamento; set => _Iddepartamento = value; }

        //Constructores
        public DEmpleados()
        {

        }

        public DEmpleados(int idempleado, string nombre, string apellido, string telefono,
            string direccion, string dui, string nit, int id_cargo, int estado, string textobuscar, int iddepartamento)
        {
            this.Idempleado = idempleado;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Direccion = Direccion;
            this.Dui = dui;
            this.Nit = nit;
            this.Id_cargo = id_cargo;
            this.Estado = estado;
            this.TextoBuscar = textobuscar;
            this.Iddepartamento = iddepartamento;


        }

        //Metodo para insertar datos en la tabla Categoria
        public string Insertar(DEmpleados Empleados)
        {

            string rpta = "";
            //Creamos una instancia de la clase SqlConnection
            SqlConnection SqlCon = new SqlConnection();
            //Declaramos un capturador de errores
            try
            {
                //Codigo para establecer la conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Codigo para realizar la comunicacion con nuestro proc insercion
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "spinsertar_empleado";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Empleados.Nombre;
                sqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = Empleados.Apellido;
                sqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Empleados.Telefono;
                sqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Empleados.Direccion;
                sqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParDui = new SqlParameter();
                ParDui.ParameterName = "@dui";
                ParDui.SqlDbType = SqlDbType.VarChar;
                ParDui.Size = 16;
                ParDui.Value = Empleados.Dui;
                sqlCmd.Parameters.Add(ParDui);


                SqlParameter ParNit = new SqlParameter();
                ParNit.ParameterName = "@nit";
                ParNit.SqlDbType = SqlDbType.VarChar;
                ParNit.Size = 20;
                ParNit.Value = Empleados.Nit;
                sqlCmd.Parameters.Add(ParNit);

                SqlParameter ParId_Cargo = new SqlParameter();
                ParId_Cargo.ParameterName = "@id_cargo";
                ParId_Cargo.SqlDbType = SqlDbType.Int;
                ParId_Cargo.Value = Empleados.Id_cargo;
                sqlCmd.Parameters.Add(ParId_Cargo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Empleados.Estado;
                sqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParIdDepa = new SqlParameter();
                ParIdDepa.ParameterName = "id_departamento";
                ParIdDepa.SqlDbType = SqlDbType.Int;
                ParIdDepa.Value = Empleados.Iddepartamento;
                sqlCmd.Parameters.Add(ParIdDepa);

                //Ejecutamos nuestro Comando

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE INGRESO EL REGISTRO";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;


        }

        //Metodo Editar 
        public string Editar(DEmpleados Empleados)
        {
            string rpta = "";
            //Creamos una instancia de la clase SqlConnection
            SqlConnection SqlCon = new SqlConnection();

            //Declaramos un capturador de errores
            try
            {
                //Codigo para establecer la conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Codigo para realizar la comunicacion con nuestro proc insercion
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "editar_empleado";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@idempleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = Empleados.Idempleado;
                sqlCmd.Parameters.Add(ParIdEmpleado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Empleados.Nombre;
                sqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = Empleados.Apellido;
                sqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Empleados.Telefono;
                sqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Empleados.Direccion;
                sqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParDui = new SqlParameter();
                ParDui.ParameterName = "@dui";
                ParDui.SqlDbType = SqlDbType.VarChar;
                ParDui.Size = 16;
                ParDui.Value = Empleados.Dui;
                sqlCmd.Parameters.Add(ParDui);


                SqlParameter ParNit = new SqlParameter();
                ParNit.ParameterName = "@nit";
                ParNit.SqlDbType = SqlDbType.VarChar;
                ParNit.Size = 20;
                ParNit.Value = Empleados.Nit;
                sqlCmd.Parameters.Add(ParNit);

                SqlParameter ParId_Cargo = new SqlParameter();
                ParId_Cargo.ParameterName = "@id_cargo";
                ParId_Cargo.SqlDbType = SqlDbType.Int;
                ParId_Cargo.Value = Empleados.Id_cargo;
                sqlCmd.Parameters.Add(ParId_Cargo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Empleados.Estado;
                sqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParIdDepa = new SqlParameter();
                ParIdDepa.ParameterName = "id_departamento";
                ParIdDepa.SqlDbType = SqlDbType.Int;
                ParIdDepa.Value = Empleados.Iddepartamento;
                sqlCmd.Parameters.Add(ParIdDepa);


                //Ejecutamos nuestro Comando

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Actualizo el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;


        }

        //Metodo para Eliminar datos
        public string Eliminar(DEmpleados Empleados)
        {
            string rpta = "";
            //Creamos una instancia de la clase SqlConnection
            SqlConnection SqlCon = new SqlConnection();

            //Declaramos un capturador de errores
            try
            {
                //Codigo para establecer la conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Codigo para realizar la comunicacion con nuestro proc insercion
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "speliminar_empleado";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@idempleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = Empleados.Idempleado;
                sqlCmd.Parameters.Add(ParIdEmpleado);


                //Ejecutamos nuestro Comando

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Elimino el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }

        //Metodo para mostrar todos los registros de la tabla categoria
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_empleado";
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

        //Metodo para BuscarNombre
        public DataTable BuscarNombre(DEmpleados Empleados)
        {
            DataTable DtResultado = new DataTable("empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_empleado_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Empleados.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {

                DtResultado = null;
            }
            return DtResultado;

        }

        //Metodo para mostrar todos los registros de la tabla c
        public DataTable MostrarConDt()
        {
            DataTable DtResultado = new DataTable("empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spllenar_MostEmpleado";
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

        //Metodo para Buscar para la gestion
        public DataTable BuscarNombreG(DEmpleados Empleados)
        {
            DataTable DtResultado = new DataTable("empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_BuscarEmpleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Empleados.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {

                DtResultado = null;
            }
            return DtResultado;

        }

        //agregamos ubicacion del reporte
        public void createPDF()
        {


            PdfWriter pdfWriter = new PdfWriter("Reporte.pdf");
            //creamos un PDF document
            PdfDocument pdf = new PdfDocument(pdfWriter);
            //creamos la hoja pdf hasta aca ya esta creado el documento
            Document documento = new Document(pdf, PageSize.LETTER);


            //agregamos margenes al documento
            documento.SetMargins(60, 20, 55, 20);

            //agregamos parrafo de prueba
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);


            documento.Add(new Paragraph("REPORTE DE EMPLEADOS").SetFont(fontColumnas).SetTextAlignment(TextAlignment.CENTER));



            String[] columnas = { "Id", "Tipo de equipo", "Marca", "Modelo", "Codigo", "Ubicacion", "Estado" };

            //tamanio de los encabezados
            float[] tamanios = { 1, 3, 2, 2, 2, 2, 2 };
            //Creamos la tabla y le asignamos el tamanio
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            //imprimiendo las columnas, recoremos todos los indices
            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas).SetBackgroundColor(ColorConstants.CYAN)));
            }

            //creamos la consulta SQL
            string sql = "SELECT dbo.equipos.id_equipo AS ID, dbo.equipos.tipo_equipo AS 'tipo de equipo', dbo.marcas.marca, dbo.modelos.modelo, dbo.equipos.codigo, dbo.departamentos.departamento AS Ubicacion, CASE dbo.equipos.estado WHEN 1 THEN 'Asignado' WHEN 0 THEN 'Disponible' END AS Estado FROM dbo.marcas INNER JOIN dbo.equipos ON dbo.marcas.id_marca = dbo.equipos.id_marca INNER JOIN dbo.modelos ON dbo.marcas.id_marca = dbo.modelos.id_marca AND dbo.equipos.id_modelo = dbo.modelos.id_modelo CROSS JOIN dbo.departamentos";

            //creamos el objetop conexion y abrimos la conexion
            Conexion conexionBD = new Conexion();
            conexionBD.abrir();


            SqlCommand comando = new SqlCommand(sql);
            comando.Connection = conexionBD.Conectarbd;
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Id"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Tipo de equipo"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Marca"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Modelo"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Codigo"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Ubicacion"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Estado"].ToString()).SetFont(fontContenido)));
            }


            //mandamos como parametro la tabla que creamos
            documento.Add(tabla);
            documento.Close();
        }







    }
}
