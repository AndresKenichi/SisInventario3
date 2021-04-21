using System;
using System.Collections;
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
        public bool a=true, b=false,c=false;
        public string var_pase1 = "",var_pase2="";
        public NGestionEquipos ge = new NGestionEquipos();

        public GestionEquipos()
        {
            InitializeComponent();
            Mostrar();
            LlenarComboTipo();
            LlenarComboDepa();
            MostrarMov();
            OcultarColumnas();
            MostrarEmpleado();
            LlenarComboEncabezado();
            txtDescripcion.Text = "ASIGNACION DE EQUIPO A EMPLEADO";
        }

        //Método para Mostrar
        private void Mostrar()
        {
            this.dtequipos.DataSource = NEquipos.Mostrar2();
           // this.OcultarColumnas();
          //  lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void MostrarMov() {

            this.gridMovimientos.DataSource = ge.MonstrarMovimientos(textBox1.Text.ToString());
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

        private void LlenarComboEncabezado()
        {
            cbEncabezado.DataSource = NEncabezado.Mostrar();
            cbEncabezado.ValueMember = "id_encabezado";
            cbEncabezado.DisplayMember = "encabezado";

        }

        private void GestionEquipos_Load(object sender, EventArgs e)
        {
            MostrarMov();
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MostrarMov();
            OcultarColumnas();
        }

        private void gridMovimientos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int n = -1;

            if (gridMovimientos.Columns[e.ColumnIndex].Name == "chkOp")
            {

                DataGridViewRow row = gridMovimientos.Rows[e.RowIndex];


                DataGridViewCheckBoxCell cellSelecion = row.Cells["chkOp"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value) && cellSelecion.RowIndex != n)
                {
                    n = cellSelecion.RowIndex;

                    lbCodMov.Text = row.Cells[1].Value.ToString();
                    lbEmpledo.Text = (row.Cells[2].Value.ToString());
                    lbIdEquipo.Text = row.Cells[4].Value.ToString();
                    lbIdDep.Text = row.Cells[6].Value.ToString();
                    lbDepartamentoMov.Text = row.Cells[7].Value.ToString();
                    c = true;

                }
                else
                {

                    n = cellSelecion.RowIndex;
                    if (n == cellSelecion.RowIndex)
                    {
                        lbCodMov.Text = "-";
                        c = false;
                        lbIdDep.Text = "";
                        lbEmpledo.Text = "-";
                    }

                }

            }
        }
        private void OcultarColumnas()
        {
            this.gridMovimientos.Columns[1].Visible = false;
            this.gridMovimientos.Columns[2].Visible = false;
            this.gridMovimientos.Columns[4].Visible = false;
            this.gridMovimientos.Columns[6].Visible = false;
            //this.dataListado.Columns[8].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (c==true)
            {
                errorProvider3.SetError(textBox1, "");

                if (string.IsNullOrWhiteSpace(txtDescripcionMov.Text))
                {
                    
                    errorProvider2.SetError(txtDescripcionMov, "Ingrese una breve descripcion");
                }
                else
                {
                   
                    MessageBox.Show(ge.RecepcionEquipos(Convert.ToInt32(lbCodMov.Text.ToString()),Convert.ToInt32(lbIdEquipo.Text.ToString()),Convert.ToInt32(lbEmpledo.Text.ToString()),Convert.ToInt32(cbEncabezado.SelectedValue.ToString()),txtDescripcionMov.Text.ToString(),Convert.ToInt32(lbIdDep.Text.ToString()), DateTime.Now ,1));
                    errorProvider2.SetError(txtDescripcionMov, "");
                    MostrarMov();
                }
            }
            else
            {
                errorProvider3.SetError(textBox1, "Seleccione un dato de la tabla");
            }
        }

        private void gridMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridMovimientos.Columns["chkOp"].Index)
            {
                DataGridViewCheckBoxCell ChkSeleccion = (DataGridViewCheckBoxCell)gridMovimientos.Rows[e.RowIndex].Cells["chkOp"];
                ChkSeleccion.Value = !Convert.ToBoolean(ChkSeleccion.Value);
                
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            
            if (a == true && b == true)
            {
                String codSql = "";
                codSql = ge.AsignarEquipos(Convert.ToInt32(var_pase2), Convert.ToInt32(var_pase1), 1, txtDescripcion.Text.ToString(), Convert.ToInt32(cbdepartamento.SelectedValue), DateTime.Now, 1, 1);
                errorProvider1.SetError(cbdepartamento, "");

                switch (codSql) {

                    case "-1":

                        MessageBox.Show("Equipo ya asignado a un usuario");
                        break;
                    case "2":

                        MessageBox.Show("Asignado Correctamente");
                        break;
                }
                
            }
            else {

                errorProvider1.SetError(cbdepartamento,"SELECCIONE DATOS DE LAS TABLAS");
            }
        }
























        public void TopSecret() {

            lbCodMov.Visible = false;
            lbIdEquipo.Visible = false;
            lbEmpledo.Visible = false;
        }
    }
}
