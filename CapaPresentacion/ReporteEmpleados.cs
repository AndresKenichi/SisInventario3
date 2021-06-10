using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class ReporteEmpleados : Form
    {
        public ReporteEmpleados()
        {
            InitializeComponent();
            LlenarComboDepa();
            LlenarComboPresentacion();
            LlenarComboEncabezado();
            LlenarComboEstado();
           // LlenarComboTipo();
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            
            try { 
            // TODO: esta línea de código carga datos en la tabla 'dsREmpleados.sp_reportesEmpleados' Puede moverla o quitarla según sea necesario.
            this.sp_reportesEmpleadosTableAdapter.Fill(this.dsREmpleados.sp_reportesEmpleados,null,null,null,null);
            

            }
            catch (Exception exe)
            {

            }
            this.reportViewer1.RefreshReport();
            this.cbEncabezado.Enabled = false;
            this.cbEstado.Enabled = false;
            this.cbidcargo.Enabled = false;
            this.cbdepartamento.Enabled = false;

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }


        //Metodo para llenar el comboBox Departamento
        private void LlenarComboDepa()
        {

            cbdepartamento.DataSource = NDepartamentos.Mostrar();
            cbdepartamento.ValueMember = "id_departamento";
            cbdepartamento.DisplayMember = "departamento";
        }

        //Metodo para llenar el comboBox presentacion
        private void LlenarComboPresentacion()
        {
            cbidcargo.DataSource = NCargo.Mostrar();
            cbidcargo.ValueMember = "cargo";
            cbidcargo.DisplayMember = "cargo";
        }

        //Metodo para llenar el comboBox Encabezado
        private void LlenarComboEncabezado()
        {

            cbEncabezado.DataSource = NEncabezado.Mostrar();
            cbEncabezado.ValueMember = "encabezado";
            cbEncabezado.DisplayMember = "encabezado";
        }

        //Metodo para llenar el comboBox Estado
        private void LlenarComboEstado()
        {
            cbEstado.DataSource = NGestionEquipos.MostrarE();
            cbEstado.ValueMember = "idEstado";
            cbEstado.DisplayMember = "Estado";
        }

        private void chkFEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFEstado.Checked)
            {

                this.cbEstado.Enabled = true;
            }

            else
            {

                this.cbEstado.Enabled = false;


            }
        }

        private void chkFDepa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFDepa.Checked)
            {

                this.cbdepartamento.Enabled = true;

            }

            else
            {

                this.cbdepartamento.Enabled = false;


            }
        }

        private void chkFEncabezado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFEncabezado.Checked)
            {

                this.cbEncabezado.Enabled = true;

            }

            else
            {

                this.cbEncabezado.Enabled = false;


            }
        }

        private void chkFCargo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFCargo.Checked)
            {

                this.cbidcargo.Enabled = true;

            }

            else
            {

                this.cbidcargo.Enabled = false;


            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            String cargo = null;
            String encabezado = null;
           

            if (this.cbidcargo.Enabled == true)
            {
                cargo = this.cbidcargo.SelectedValue.ToString();
            }
            if (this.cbEncabezado.Enabled == true)
            {
                encabezado = this.cbEncabezado.SelectedValue.ToString();
            }

            if (cbdepartamento.Enabled==true)
            {
                if (cbEstado.Enabled == true) {

                    try
                    {
                        // TODO: esta línea de código carga datos en la tabla 'dsREmpleados.sp_reportesEmpleados' Puede moverla o quitarla según sea necesario.
                        this.sp_reportesEmpleadosTableAdapter.Fill(this.dsREmpleados.sp_reportesEmpleados, Convert.ToInt32(this.cbdepartamento.SelectedValue), encabezado, cargo, Convert.ToInt32(this.cbEstado.SelectedValue));
                        txtM.Text = (Convert.ToInt32(this.cbdepartamento.SelectedValue) + " " + encabezado + " " + cargo + " " + this.cbEstado.SelectedValue.ToString()).ToString();
                    }
                    catch (Exception rec)
                    {

                    }
                  //  this.sp_reportesEmpleadosTableAdapter.Fill(this.dsREmpleados.sp_reportesEmpleados,);

                   this.reportViewer1.RefreshReport();
                }

                else
                {
                    
                        // TODO: esta línea de código carga datos en la tabla 'dsREmpleados.sp_reportesEmpleados' Puede moverla o quitarla según sea necesario.
                        this.sp_reportesEmpleadosTableAdapter.Fill(this.dsREmpleados.sp_reportesEmpleados, Convert.ToInt32(this.cbdepartamento.SelectedValue), encabezado, cargo,null);
                    txtM.Text = (Convert.ToInt32(this.cbdepartamento.SelectedValue) + " " + encabezado + " " + cargo + " , null").ToString();



                    this.reportViewer1.RefreshReport();
                }


            }
            else
            {

                if (cbEstado.Enabled == true)
                {
                    
                        // TODO: esta línea de código carga datos en la tabla 'dsREmpleados.sp_reportesEmpleados' Puede moverla o quitarla según sea necesario.
                        this.sp_reportesEmpleadosTableAdapter.Fill(this.dsREmpleados.sp_reportesEmpleados, null, encabezado, cargo, Convert.ToInt32(this.cbEstado.SelectedValue));
                    txtM.Text = (" null, " + encabezado + " " + cargo + " " + this.cbEstado.SelectedValue.ToString()).ToString();



                    this.reportViewer1.RefreshReport();
                }

                else
                {
                    
                        // TODO: esta línea de código carga datos en la tabla 'dsREmpleados.sp_reportesEmpleados' Puede moverla o quitarla según sea necesario.
                        this.sp_reportesEmpleadosTableAdapter.Fill(this.dsREmpleados.sp_reportesEmpleados, null, encabezado, cargo, null);
                    txtM.Text = (" null, " + encabezado + " " + cargo + " ,null ").ToString();


                    this.reportViewer1.RefreshReport();
                }



            }








        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
