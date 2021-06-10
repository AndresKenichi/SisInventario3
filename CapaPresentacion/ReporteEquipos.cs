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
  

    public partial class ReporteEquipos : Form
    {
        public ReporteEquipos()
        {

            

            InitializeComponent();
            LlenarComboDepa();
            LlenarComboMarcas();
            LlenarComboTipo();
            this.LlenarComboModelo(Convert.ToInt32(cbMarca.SelectedValue));

        }

        private void ReporteEquipos_Load(object sender, EventArgs e)
        {
            try
            {
                //TODO: esta línea de código carga datos en la tabla 'dsprocEquipo.sp_reportEquipo' Puede moverla o quitarla según sea necesario.
              this.sp_reportEquipoTableAdapter.Fill(this.dsprocEquipo.sp_reportEquipo, null, null, null, null, null, null);

                
            }
            catch (Exception exe)
            {

            }

            this.reportViewer1.RefreshReport();
            this.cbMarca.Enabled = false;
            this.cbModelo.Enabled = false;
            this.cbTipoE.Enabled = false;
            this.dtFecha_Ini.Enabled = false;
            this.dtFecha_Fin.Enabled = false;
            this.cbdepartamento.Enabled = false;
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            String tipo = null;
            String departamento = null;

            if (this.cbTipoE.Enabled==true)
            {
                tipo = this.cbTipoE.SelectedValue.ToString();
            }
            if (this.cbdepartamento.Enabled==true)
            {
                departamento = this.cbdepartamento.SelectedValue.ToString();
            }

            

            if (this.cbMarca.Enabled == true)
            {



                if (this.dtFecha_Ini.Enabled == true)
                {
                   this.sp_reportEquipoTableAdapter.Fill(this.dsprocEquipo.sp_reportEquipo, tipo, Convert.ToInt32(this.cbMarca.SelectedValue), Convert.ToInt32(this.cbModelo.SelectedValue), Convert.ToDateTime(this.dtFecha_Ini.Value), Convert.ToDateTime(this.dtFecha_Fin.Value), departamento);
                    txtIdempleado.Text = (this.cbTipoE.SelectedValue.ToString() + " " + Convert.ToInt32(this.cbMarca.SelectedValue) + " " + Convert.ToInt32(this.cbModelo.SelectedValue) + " " + Convert.ToString(this.dtFecha_Ini.Value) + " " + Convert.ToString(this.dtFecha_Fin.Value) + " " + this.cbdepartamento.SelectedValue.ToString()).ToString();
                    //Convert.ToDateTime(this.dtFecha_Ini.Value), Convert.ToDateTime(this.dtFecha_Fin.Value)
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    this.sp_reportEquipoTableAdapter.Fill(this.dsprocEquipo.sp_reportEquipo, tipo, Convert.ToInt32(this.cbMarca.SelectedValue), Convert.ToInt32(this.cbModelo.SelectedValue), null, null, departamento);
                    txtIdempleado.Text = (this.cbTipoE.SelectedValue.ToString() + " " + Convert.ToInt32(this.cbMarca.SelectedValue) + " " + Convert.ToInt32(this.cbModelo.SelectedValue) + " " + null + " " + null + " " + this.cbdepartamento.SelectedValue.ToString()).ToString();
                    //Convert.ToDateTime(this.dtFecha_Ini.Value), Convert.ToDateTime(this.dtFecha_Fin.Value)
                    this.reportViewer1.RefreshReport();
                }


                
            }
            else
            {

                if (this.dtFecha_Ini.Enabled == true)
                {
                   this.sp_reportEquipoTableAdapter.Fill(this.dsprocEquipo.sp_reportEquipo, tipo, null, null, Convert.ToDateTime(this.dtFecha_Ini.Value), Convert.ToDateTime(this.dtFecha_Fin.Value), departamento);
                    txtIdempleado.Text = (this.cbTipoE.SelectedValue.ToString() + " " + Convert.ToInt32(this.cbMarca.SelectedValue) + " " + Convert.ToInt32(this.cbModelo.SelectedValue) + " " + Convert.ToString(this.dtFecha_Ini.Value) + " " + Convert.ToString(this.dtFecha_Fin.Value) + " " + this.cbdepartamento.SelectedValue.ToString()).ToString();
                    //Convert.ToDateTime(this.dtFecha_Ini.Value), Convert.ToDateTime(this.dtFecha_Fin.Value)
                    this.reportViewer1.RefreshReport();
                }
                else
                {

                   this.sp_reportEquipoTableAdapter.Fill(this.dsprocEquipo.sp_reportEquipo, tipo, null, null, null, null, departamento);
                    txtIdempleado.Text = (this.cbTipoE.SelectedValue.ToString() + " " + null + " " + null + " " + null + " " + null + " " + this.cbdepartamento.SelectedValue.ToString()).ToString();
                    //Convert.ToDateTime(this.dtFecha_Ini.Value), Convert.ToDateTime(this.dtFecha_Fin.Value)
                    this.reportViewer1.RefreshReport();

                }
              

            }




            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        //Metodo para llenar el comboBox Departamento
        private void LlenarComboDepa()
        {
          
            cbdepartamento.DataSource = NDepartamentos.Mostrar();
            cbdepartamento.ValueMember = "departamento";
            cbdepartamento.DisplayMember = "departamento";
        }

        //Metodo para llenar el comboBox Modelo
        private void LlenarComboModelo(int idmarc)
        {
            cbModelo.DataSource = NModelos.BuscarNombre(idmarc);
            cbModelo.ValueMember = "id_modelo";
            cbModelo.DisplayMember = "modelo";
        }

        //Metodo para llenar el comboBox Marcas
        private void LlenarComboMarcas()
        {
            cbMarca.DataSource = NMarcas.Mostrar();
            cbMarca.ValueMember = "id_marca";
            cbMarca.DisplayMember = "marca";
        }


        //Metodo para llenar el comboBox Tipo
        private void LlenarComboTipo()
        {
            cbTipoE.DataSource = NEquipos.LlenarCmbTipo();
            cbTipoE.ValueMember = "tipo_equipo";
            cbTipoE.DisplayMember = "tipo_equipo";
        }

        //Metodo que nos permite llenar el combo de modelo dependiendo de la marca
        private void cbMarca_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.LlenarComboModelo(Convert.ToInt32(cbMarca.SelectedValue));
            }
            catch (Exception ex)
            {

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkFmarcas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFmarcas.Checked)
            {

                this.cbMarca.Enabled = true;
                this.cbModelo.Enabled = true;
            }

            else
            {

                this.cbMarca.Enabled = false;
                this.cbModelo.Enabled = false;

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
    }
}
