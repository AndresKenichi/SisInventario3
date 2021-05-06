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
   public class DEquipos
    {
       private int _Idequipo;
       private int _Idprogramacion;
       private int _Idmarca;
       private int _Idmodelo;
       private string _Codigo;
       private decimal _Precio;
       private DateTime _Fecha_cad;
       private string _Tipo_equipo;
       private int _Estado;
       private int _id_usuario;
       private DateTime _fecha_modificacion;
       private string _TextoBuscar;

        public int Idequipo { get => _Idequipo; set => _Idequipo = value; }
        public int Idprogramacion { get => _Idprogramacion; set => _Idprogramacion = value; }
        public int Idmarca { get => _Idmarca; set => _Idmarca = value; }
        public int Idmodelo { get => _Idmodelo; set => _Idmodelo = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public decimal Precio { get => _Precio; set => _Precio = value; }
        public DateTime Fecha_cad { get => _Fecha_cad; set => _Fecha_cad = value; }
        public string Tipo_equipo { get => _Tipo_equipo; set => _Tipo_equipo = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public int Id_usuario { get => _id_usuario; set => _id_usuario = value; }
        public DateTime Fecha_modificacion { get => _fecha_modificacion; set => _fecha_modificacion = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public DEquipos(int idequipo, int idprogramacion, int idmarca, int idmodelo, string codigo, decimal precio, DateTime fecha_cad, string tipo_equipo, int estado,
            int id_usuario, DateTime fecha_modificacion, string textobuscar)
        {
            this.Idequipo = idequipo;
            this.Idprogramacion = idprogramacion;
            this.Idmarca = idmarca;
            this.Idmodelo = idmodelo;
            this.Codigo = codigo;
            this.Precio = precio;
            this.Fecha_cad = fecha_cad;
            this.Tipo_equipo = tipo_equipo;
            this.Estado = estado;
            this.Id_usuario = id_usuario;
            this.Fecha_modificacion = fecha_modificacion;
            this.TextoBuscar = textobuscar;

        }

        public DEquipos()
        {

        }

        //Metodo para insertar datos en la tabla Categoria
        public string Insertar(DEquipos Equipos)
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
                sqlCmd.CommandText = "spinsertar_equipos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddequipo = new SqlParameter();
                ParIddequipo.ParameterName = "@idequipo";
                ParIddequipo.SqlDbType = SqlDbType.Int;
                ParIddequipo.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(ParIddequipo);


                SqlParameter ParIdprogramacion = new SqlParameter();
                ParIdprogramacion.ParameterName = "@idprogramacion";
                ParIdprogramacion.SqlDbType = SqlDbType.Int;
                ParIdprogramacion.Value =Equipos.Idprogramacion;
                sqlCmd.Parameters.Add(ParIdprogramacion);

                SqlParameter ParIdmarca = new SqlParameter();
                ParIdmarca.ParameterName = "@idmarca";
                ParIdmarca.SqlDbType = SqlDbType.Int;
                ParIdmarca.Value = Equipos.Idmarca;
                sqlCmd.Parameters.Add(ParIdmarca);

                SqlParameter ParIdmodelo = new SqlParameter();
                ParIdmodelo.ParameterName = "@idmodelo";
                ParIdmodelo.SqlDbType = SqlDbType.Int;
                ParIdmodelo.Value = Equipos.Idmodelo;
                sqlCmd.Parameters.Add(ParIdmodelo);


                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Equipos.Codigo;
                sqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.Decimal;
                ParPrecio.Value = Equipos.Precio;
                sqlCmd.Parameters.Add(ParPrecio);

                SqlParameter ParFecha_cad = new SqlParameter();
                ParFecha_cad.ParameterName = "@fecha_cad";
                ParFecha_cad.SqlDbType = SqlDbType.Date;
                ParFecha_cad.Value = Equipos.Fecha_cad;
                sqlCmd.Parameters.Add(ParFecha_cad);

                SqlParameter ParTipo_equipo = new SqlParameter();
                ParTipo_equipo.ParameterName = "@tipo_equipo";
                ParTipo_equipo.SqlDbType = SqlDbType.VarChar;
                ParTipo_equipo.Size = 10;
                ParTipo_equipo.Value = Equipos.Tipo_equipo;
                sqlCmd.Parameters.Add(ParTipo_equipo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Equipos.Estado;
                sqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParIdUsu = new SqlParameter();
                ParIdUsu.ParameterName = "@id_usuario";
                ParIdUsu.SqlDbType = SqlDbType.Int;
                ParIdUsu.Value = Equipos.Id_usuario;
                sqlCmd.Parameters.Add(ParIdUsu);

                SqlParameter ParFecha_m = new SqlParameter();
                ParFecha_m.ParameterName = "@fecha_modificacion";
                ParFecha_m.SqlDbType = SqlDbType.Date;
                ParFecha_m.Value = Equipos.Fecha_modificacion;
                sqlCmd.Parameters.Add(ParFecha_m);



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
        public string Editar(DEquipos Equipos)
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
                sqlCmd.CommandText = "editar_equipos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddequipo = new SqlParameter();
                ParIddequipo.ParameterName = "@idequipo";
                ParIddequipo.SqlDbType = SqlDbType.Int;
                ParIddequipo.Value = Equipos.Idequipo;
                sqlCmd.Parameters.Add(ParIddequipo);


                SqlParameter ParIdprogramacion = new SqlParameter();
                ParIdprogramacion.ParameterName = "@idprogramacion";
                ParIdprogramacion.SqlDbType = SqlDbType.Int;
                ParIdprogramacion.Value = Equipos.Idprogramacion;
                sqlCmd.Parameters.Add(ParIdprogramacion);

                SqlParameter ParIdmarca = new SqlParameter();
                ParIdmarca.ParameterName = "@idmarca";
                ParIdmarca.SqlDbType = SqlDbType.Int;
                ParIdmarca.Value = Equipos.Idmarca;
                sqlCmd.Parameters.Add(ParIdmarca);

                SqlParameter ParIdmodelo = new SqlParameter();
                ParIdmodelo.ParameterName = "@idmodelo";
                ParIdmodelo.SqlDbType = SqlDbType.Int;
                ParIdmodelo.Value = Equipos.Idmodelo;
                sqlCmd.Parameters.Add(ParIdmodelo);


                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Equipos.Codigo;
                sqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.Decimal;
                ParPrecio.Value = Equipos.Precio;
                sqlCmd.Parameters.Add(ParPrecio);

                SqlParameter ParFecha_cad = new SqlParameter();
                ParFecha_cad.ParameterName = "@fecha_cad";
                ParFecha_cad.SqlDbType = SqlDbType.Date;
                ParFecha_cad.Size = 10;
                ParFecha_cad.Value = Equipos.Fecha_cad;
                sqlCmd.Parameters.Add(ParFecha_cad);

                SqlParameter ParTipo_equipo = new SqlParameter();
                ParTipo_equipo.ParameterName = "@tipo_equipo";
                ParTipo_equipo.SqlDbType = SqlDbType.VarChar;
                ParTipo_equipo.Size = 10;
                ParTipo_equipo.Value = Equipos.Tipo_equipo;
                sqlCmd.Parameters.Add(ParTipo_equipo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Equipos.Estado;
                sqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParIdUsu = new SqlParameter();
                ParIdUsu.ParameterName = "@id_usuario";
                ParIdUsu.SqlDbType = SqlDbType.Int;
                ParIdUsu.Value = Equipos.Id_usuario;
                sqlCmd.Parameters.Add(ParIdUsu);

                SqlParameter ParFecha_m = new SqlParameter();
                ParFecha_m.ParameterName = "@fecha_modificacion";
                ParFecha_m.SqlDbType = SqlDbType.Date;
                ParFecha_m.Value = Equipos.Fecha_modificacion;
                sqlCmd.Parameters.Add(ParFecha_m);



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
        public string Eliminar(DEquipos Equipos)
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
                sqlCmd.CommandText = "speliminar_equipos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddequipo = new SqlParameter();
                ParIddequipo.ParameterName = "@idequipo";
                ParIddequipo.SqlDbType = SqlDbType.Int;
                ParIddequipo.Value = Equipos.Idequipo;
                sqlCmd.Parameters.Add(ParIddequipo);


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

        //Metodo para mostrar todos los registros de la tabla 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("equipos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_equipos";
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

        //Metodo para mostrar todos los registros de la tabla 
        public DataTable MostrarTipo()
        {
            DataTable DtResultado = new DataTable("equipos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spequipo_tipo";
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
        public DataTable BuscarNombre(DEquipos Equipos)
        {
            DataTable DtResultado = new DataTable("equipos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_equipo_tipo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Equipos.TextoBuscar;
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

        //Metodo para mostrar todos los registros de la tabla 
        public DataTable Mostrar2()
        {
            DataTable DtResultado = new DataTable("equipos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spllenado_equipo";
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

        //Metodo para mostrar todos los registros de la tabla 
        public DataTable LlenarCmbTipo()
        {
            DataTable DtResultado = new DataTable("equipos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spequipo_tipo";
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


            documento.Add(new Paragraph("REPORTE DE EQUIPOS \n DEPARTAMENTO DE SOPORTE TECNICO.").SetFont(fontColumnas).SetTextAlignment(TextAlignment.CENTER));



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
