using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace Loggin
{
    public partial class GestionEquipos : Form
    {
        public GestionEquipos()
        {
            InitializeComponent();
            Mostrar();
            LlenarComboTipo();
            LlenarComboDepa();
            MostrarEmpleado();
        }

        //Método para Mostrar
        private void Mostrar()
        {
            this.dtequipos.DataSource = NEquipos.Mostrar2();
           // this.OcultarColumnas();
          //  lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método para Mostrar
        private void MostrarEmpleado()
        {
            this.dtEmpleados.DataSource = NEmpleados.MostrarConDt();
            // this.OcultarColumnas();
            //lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Metodo para llenar el comboBox presentacion
        private void LlenarComboTipo()
        {
            cbtipo.DataSource = NEquipos.LlenarCmbTipo();
            //cbtipo.ValueMember = "id_marca";
            cbtipo.DisplayMember = "tipo_equipo";
        }

        private void BuscarNombre()
        {
            this.dtEmpleados.DataSource = NEmpleados.BuscarNombreG(this.txtBuscar.Text);
            //this.OcultarColumnas();
            //lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void LlenarComboDepa()
        {
            cbdepartamento.DataSource = NDepartamentos.Mostrar();
            cbdepartamento.ValueMember = "id_departamento";
            cbdepartamento.DisplayMember = "departamento";
        }

        private void GestionEquipos_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }
    }
}
