using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using Loggin;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtCorreo, "Ingrese un Correo");
            this.ttMensaje.SetToolTip(this.txtClave, "Ingrese una Clave");
        }

        private void MensajeError(String mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            //Evaluar si existe el Usuario
            if (this.txtCorreo.Text == string.Empty || txtClave.Text == string.Empty)
            { 
           
                if (this.txtCorreo.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtCorreo, "Ingrese un Correo");
                }

                if (this.txtClave.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos!!!!");
                    errorIcono.SetError(txtClave, "Ingrese una Clave");
                }
            }
            else
            { 
                DataTable Datos = CapaNegocio.NUsuarios.Login(this.txtCorreo.Text, this.txtClave.Text);
                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("No tiene Acceso al Sistema", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                 //   Equipos frmEquipo = new Equipos();
                   // frmEquipo.Idusu = Convert.ToInt32(Datos.Rows[0][0].ToString());


                    Inicio frm = new Inicio();
                    frm.idUsuario = Datos.Rows[0][0].ToString();
                    frm.idEmpleado = Datos.Rows[0][1].ToString();
                    frm.nombres = Datos.Rows[0][2].ToString();
                    frm.Show();
                    this.Hide();
                }
            }

        }
    }
}
