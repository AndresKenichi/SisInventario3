using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
            DataTable Datos = CapaNegocio.NUsuarios.Login(this.txtCorreo.Text, this.txtClave.Text);
            //Evaluar si existe el Usuario
            if (Datos.Rows.Count==0)
            {
                MessageBox.Show("No tiene Acceso al Sistema","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                frmEmpleados frm = new frmEmpleados();
                frm.Show();
                this.Hide();


            }



        }
    }
}
