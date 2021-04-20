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
        public bool a=true, b=false;
        public string var_pase1 = "",var_pase2="";
        public NGestionEquipos ge = new NGestionEquipos();
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

        private void tabAsignar_Click(object sender, EventArgs e)
        {

        }

     

        private void dtEmpleados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int n = -1;

            if (dtEmpleados.Columns[e.ColumnIndex].Name == "chkAdd")
            {
                
                DataGridViewRow row = dtEmpleados.Rows[e.RowIndex];

                
                DataGridViewCheckBoxCell cellSelecion = row.Cells["chkAdd"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value)&&cellSelecion.RowIndex!=n)
                {
                    n = cellSelecion.RowIndex;

                    var_pase1 = row.Cells[1].Value.ToString();
                    lbNombreE.Text = (row.Cells[2].Value.ToString());
                    a = true;
                }
                else {

                    n = cellSelecion.RowIndex;
                    if (n == cellSelecion.RowIndex) {

                        lbNombreE.Text = "";
                        var_pase1 = "";
                        a = false;
                    }
                    
                }

            }
        }

        private void dtEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtEmpleados.Columns["chkAdd"].Index)
            {
                DataGridViewCheckBoxCell ChkSeleccion = (DataGridViewCheckBoxCell)dtEmpleados.Rows[e.RowIndex].Cells["chkAdd"];
                ChkSeleccion.Value = !Convert.ToBoolean(ChkSeleccion.Value);
            }
        }
        

        private void dtequipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtequipos.Columns["chkSel"].Index)
            {
                DataGridViewCheckBoxCell ChkSeleccion = (DataGridViewCheckBoxCell)dtequipos.Rows[e.RowIndex].Cells["chkSel"];
                ChkSeleccion.Value = !Convert.ToBoolean(ChkSeleccion.Value);
            }
        }

        private void dtequipos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int n = -1;

            if (dtequipos.Columns[e.ColumnIndex].Name == "chkSel")
            {

                DataGridViewRow row = dtequipos.Rows[e.RowIndex];


                DataGridViewCheckBoxCell cellSelecion = row.Cells["chkSel"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value) && cellSelecion.RowIndex != n)
                {
                    n = cellSelecion.RowIndex;

                    var_pase2 = row.Cells[1].Value.ToString();
                    lbEquipo.Text = (row.Cells[2].Value.ToString());
                    b = true;
                   
                }
                else
                {

                    n = cellSelecion.RowIndex;
                    if (n == cellSelecion.RowIndex)
                    {
                        var_pase2 = "";
                        b = false;
                        lbEquipo.Text = "";
                    }

                }

            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (a == true && b == true)
            {
                errorProvider1.SetError(cbdepartamento, "");
                
                //MessageBox.Show(" ,id_equipo=" + var_pase2+ "OK  id_empleado=" + var_pase1+", Encabezado= 1, Descripcion= sdasdada , Departamento "+cbdepartamento.SelectedValue +", Fecha Asignacion:"+DateTime.Now+"IdUsuario="+1+", Estado= "+1);
                MessageBox.Show(ge.AsignarEquipos(Convert.ToInt32(var_pase2), Convert.ToInt32(var_pase1), 1, "ASIGNACION DE EQUIPO A EMPLEADO", Convert.ToInt32(cbdepartamento.SelectedValue), DateTime.Now, 1, 1));
            }
            else {
                errorProvider1.SetError(cbdepartamento,"SELECCIONE DATOS DE LAS TABLAS");
            }
        }
    }
}
