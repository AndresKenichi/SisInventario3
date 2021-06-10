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
    public partial class ReporteProgramacion : Form
    {
        public ReporteProgramacion()
        {
            InitializeComponent();
            LlenarComboDepa();
            LlenarComboMarcas();
            LlenarComboTipo();
        }

        private void ReporteProgramacion_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'inventario2DataSet.sp_reportProgra' Puede moverla o quitarla según sea necesario.
                this.sp_reportPrograTableAdapter.Fill(this.inventario2DataSet.sp_reportProgra, null, null, null, null, null);

            }
            catch (Exception exe)
            {

            }


            this.reportViewer2.RefreshReport();
            this.cbMarca.Enabled = false;
            this.cbTipoE.Enabled = false;
            this.dtFecha_Ini.Enabled = false;
            this.dtFecha_Fin.Enabled = false;
            this.cbdepartamento.Enabled = false;


        }

        private void chkFmarcas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFmarcas.Checked)
            {

                this.cbMarca.Enabled = true;
             
            }

            else
            {

                this.cbMarca.Enabled = false;
               
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

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {

            if (chkFechas.Checked)
            {

                this.dtFecha_Ini.Enabled = true;
                this.dtFecha_Fin.Enabled = true;
            }

            else
            {

                this.dtFecha_Ini.Enabled = false;
                this.dtFecha_Fin.Enabled = false;


            }

        }

        private void chkFtipo_CheckedChanged(object sender, EventArgs e)
        {

            if (chkFtipo.Checked)
            {

                this.cbTipoE.Enabled = true;
            }

            else
            {

                this.cbTipoE.Enabled = false;


            }

        }


        //Metodo para llenar el comboBox Departamento
        private void LlenarComboDepa()
        {

            cbdepartamento.DataSource = NDepartamentos.Mostrar();
            cbdepartamento.ValueMember = "departamento";
            cbdepartamento.DisplayMember = "departamento";
        }


        //Metodo para llenar el comboBox Marcas
        private void LlenarComboMarcas()
        {
            cbMarca.DataSource = NMarcas.Mostrar();
            cbMarca.ValueMember = "marca";
            cbMarca.DisplayMember = "marca";
        }


        //Metodo para llenar el comboBox Tipo
        private void LlenarComboTipo()
        {
            cbTipoE.DataSource = NEquipos.LlenarCmbTipo();
            cbTipoE.ValueMember = "tipo_equipo";
            cbTipoE.DisplayMember = "tipo_equipo";
        }



        private void btnGenerar_Click(object sender, EventArgs e)
        {
            String tipo = null;
            String departamento = null;

            if (this.cbTipoE.Enabled == true)
            {
                tipo = this.cbTipoE.SelectedValue.ToString();
            }
            if (this.cbdepartamento.Enabled == true)
            {
                departamento = this.cbdepartamento.SelectedValue.ToString();
            }



            if (this.cbMarca.Enabled == true)
            {



                if (this.dtFecha_Ini.Enabled == true)
                {
                    try { 
                    this.sp_reportPrograTableAdapter.Fill(this.inventario2DataSet.sp_reportProgra, tipo, this.cbMarca.SelectedValue.ToString(), Convert.ToDateTime(this.dtFecha_Ini.Value), Convert.ToDateTime(this.dtFecha_Fin.Value), departamento);
                    txtIdempleado.Text = (this.cbTipoE.SelectedValue.ToString() + " " + Convert.ToInt32(this.cbMarca.SelectedValue) + " " + Convert.ToString(this.dtFecha_Ini.Value) + " " + Convert.ToString(this.dtFecha_Fin.Value) + " " + this.cbdepartamento.SelectedValue.ToString()).ToString();
                    //Convert.ToDateTime(this.dtFecha_Ini.Value), Convert.ToDateTime(this.dtFecha_Fin.Value)
                }
            catch (Exception exe)
                {

                }

                this.reportViewer2.RefreshReport();
                }
                else
                {
                    this.sp_reportPrograTableAdapter.Fill(this.inventario2DataSet.sp_reportProgra, tipo, this.cbMarca.SelectedValue.ToString(), null, null, departamento);
                    txtIdempleado.Text = (this.cbTipoE.SelectedValue.ToString() + " " + this.cbMarca.SelectedValue.ToString() + " " + null + " " + null + " " + this.cbdepartamento.SelectedValue.ToString()).ToString();
                    //Convert.ToDateTime(this.dtFecha_Ini.Value), Convert.ToDateTime(this.dtFecha_Fin.Value)
                    this.reportViewer2.RefreshReport();
                }



            }
            else
            {

                if (this.dtFecha_Ini.Enabled == true)
                {
                    try
                    {
                        this.sp_reportPrograTableAdapter.Fill(this.inventario2DataSet.sp_reportProgra, tipo, null, Convert.ToDateTime(this.dtFecha_Ini.Value), Convert.ToDateTime(this.dtFecha_Fin.Value), departamento);
                        txtIdempleado.Text = (this.cbTipoE.SelectedValue.ToString() + " " + Convert.ToInt32(this.cbMarca.SelectedValue) + " " + Convert.ToString(this.dtFecha_Ini.Value) + " " + Convert.ToString(this.dtFecha_Fin.Value) + " " + this.cbdepartamento.SelectedValue.ToString()).ToString();
                        //Convert.ToDateTime(this.dtFecha_Ini.Value), Convert.ToDateTime(this.dtFecha_Fin.Value)
                    }
                    catch (Exception exs)
                    {

                    }
                    
                    this.reportViewer2.RefreshReport();
                }
                else
                {

                    this.sp_reportPrograTableAdapter.Fill(this.inventario2DataSet.sp_reportProgra, tipo, null, null, null, departamento);
                    txtIdempleado.Text = (this.cbTipoE.SelectedValue.ToString() + " " + null + " " + null + " " + null + " " + this.cbdepartamento.SelectedValue.ToString()).ToString();
                    //Convert.ToDateTime(this.dtFecha_Ini.Value), Convert.ToDateTime(this.dtFecha_Fin.Value)
                    this.reportViewer2.RefreshReport();

                }


            }





        }

    }
}
