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
            /*
            Inicio frm = new Inicio();
            frm.Show();
            this.Hide();
            */
            if (Datos.Rows.Count==0)
            {
                MessageBox.Show("No tiene Acceso al Sistema","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Inicio frm = new Inicio();
                frm.Show();
                this.Hide();
            }

        }
    }
}
