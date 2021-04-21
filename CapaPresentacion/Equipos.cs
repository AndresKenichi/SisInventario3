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
    public partial class Equipos : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public int Idusu = 1;





        public Equipos()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtIdprogramacion, "Ingrese el nombre del Empleado");
            this.ttMensaje.SetToolTip(this.cbTipoE, "Seleccione un cargo");
            this.txtIdequipo.ReadOnly = true;
            
            this.LlenarComboMarcas();
            this.LlenarComboModelo(Convert.ToInt32(cbMarca.SelectedValue));



        }


        //Mostrar Mensaje de Confirmacion
        private void MensajeOK(String mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Mostrar Mensaje de Error
        private void MensajeError(String mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Metodo para limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtIdequipo.Text = string.Empty;
            this.txtIdprogramacion.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtPrecio.Text = string.Empty;
            this.txtEstado.Text = string.Empty;

        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtIdprogramacion.ReadOnly = !valor;
            this.txtCodigo.ReadOnly = !valor;
            this.cbMarca.Enabled = valor;
            this.cbModelo.Enabled = valor;
            this.txtCodigo.ReadOnly = !valor;
            this.txtPrecio.ReadOnly = !valor;
            this.cbTipoE.Enabled = valor;
            this.txtEstado.ReadOnly = !valor;
            

        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;

            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;

            }

        }

        //Método para Ocultar Columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[2].Visible = false;
            this.dataListado.Columns[3].Visible = false;
            this.dataListado.Columns[4].Visible = false;
            this.dataListado.Columns[6].Visible = false;

            this.dataListado.Columns[13].Visible = false;

            this.dataListado.Columns[12].Visible = false;

        }

        //Método para Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NEquipos.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarNombre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NEquipos.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Metodo para llenar el comboBox presentacion
        private void LlenarComboModelo(int idmarc)
        {
            cbModelo.DataSource = NModelos.BuscarNombre(idmarc);
            cbModelo.ValueMember = "id_modelo";
            cbModelo.DisplayMember = "modelo";
        }

        //Metodo para llenar el comboBox presentacion
        private void LlenarComboMarcas()
        {
            cbMarca.DataSource = NMarcas.Mostrar();
            cbMarca.ValueMember = "id_marca";
            cbMarca.DisplayMember = "marca";
        }

       



        private void Equipos_Load(object sender, EventArgs e)
        {

            this.Top = 0;
            this.Left = 0;

            this.Habilitar(false);
            this.Botones();
            this.Mostrar();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtIdprogramacion.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {

                this.dataListado.Columns[0].Visible = true;

            }

            else
            {

                this.dataListado.Columns[0].Visible = false;

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdequipo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar primero el registro a Modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea Eliminar los registros", "Sistema de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NEquipos.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se Eliminó correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }

                        }

                    }
                    this.Mostrar();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           // Inicio frm = new Inicio();
            //Idusu = Convert.ToInt32(frm.gIdUsuario());
            try
            {
                string rpta = "";
                if (this.txtIdprogramacion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtIdprogramacion, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NEquipos.Insertar(Convert.ToInt32(this.txtIdprogramacion.Text.Trim()), Convert.ToInt32(this.cbMarca.SelectedValue), Convert.ToInt32(this.cbModelo.SelectedValue), this.txtCodigo.Text.Trim().ToUpper(), Convert.ToDecimal(this.txtPrecio.Text),
                            Convert.ToDateTime(this.dtFecha_Cad.Value), this.cbTipoE.SelectedItem.ToString() , Convert.ToInt32(this.txtEstado.Text.Trim()), Idusu, DateTime.Now);
                    }
                    else
                    {
                        rpta = NEquipos.Editar(Convert.ToInt32(this.txtIdequipo.Text.Trim()), Convert.ToInt32(this.txtIdprogramacion.Text.Trim()), Convert.ToInt32(this.cbMarca.SelectedValue), Convert.ToInt32(this.cbModelo.SelectedValue), this.txtCodigo.Text.Trim().ToUpper(), Convert.ToDecimal(this.txtPrecio.Text),
                            this.dtFecha_Cad.Value, this.cbTipoE.SelectedItem.ToString(), Convert.ToInt32(this.txtEstado.Text.Trim().ToUpper()), 1, DateTime.Now);

                    }
                }
                if (rpta.Equals("OK"))
                {
                    if (this.IsNuevo)
                    {
                        this.MensajeOK("Se insertó correctamente el registro");
                    }
                    else
                    {
                        this.MensajeOK("Se Actualizó correctamente el registro");
                    }

                }
                else
                {
                    this.MensajeError(rpta);
                }

                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                this.Mostrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

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

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdequipo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id_equipo"].Value);
            this.txtIdprogramacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id_programacion"].Value);
            this.cbMarca.SelectedValue = Convert.ToString(this.dataListado.CurrentRow.Cells["id_marca"].Value);
            this.cbModelo.SelectedValue = Convert.ToString(this.dataListado.CurrentRow.Cells["id_modelo"].Value);
            this.txtCodigo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["codigo"].Value);
            this.txtPrecio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["precio_eq"].Value);
            this.dtFecha_Cad.Value= Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha_cad"].Value);
            this.cbTipoE.SelectedItem = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_equipo"].Value);
            this.txtEstado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            createPDF();
        }

        public void createPDF()
        {
            NEquipos Obj = new NEquipos();
            Obj.createPDF();
        }
    }
}
