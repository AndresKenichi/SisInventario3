using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaPresentacion;
namespace Loggin
{
    public partial class Inicio : Form
    {

        public string idUsuario="";
        public string idEmpleado="";
        public string nombres="";


     

        public Inicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Width = 1080;
            this.Height = 620;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        

       private void EmpleadosF_Click(object sender, EventArgs e)
       {
            frmEmpleados m = new frmEmpleados();
           
            openChildForm(m);
       }

        private void EquiposF_Click(object sender, EventArgs e)
        {
            Equipos ee = new Equipos();
            
            openChildForm(ee);
        }

        private void UsuariosF_Click(object sender, EventArgs e)
        {
            Usuarios uu = new Usuarios();
            
            openChildForm(uu);
        }

        private void RegLoteF_Click(object sender, EventArgs e)
        {
            RegistrarLote rgl = new RegistrarLote();
            
            openChildForm(rgl);
        }

        private void RegEquiposF_Click(object sender, EventArgs e)
        {
            RegistrarEquipos rge = new RegistrarEquipos();
            
           
            openChildForm(rge);
        }

        private void GestionEquiposF_Click(object sender, EventArgs e)
        {
            
            GestionEquipos gse = new GestionEquipos();
            

            openChildForm(gse);
        }
        private Form activeForm = null;



        private void openChildForm(Form child) {

            if (activeForm != null)
                activeForm.Close();

            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel1.Controls.Add(child);
            panel1.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
