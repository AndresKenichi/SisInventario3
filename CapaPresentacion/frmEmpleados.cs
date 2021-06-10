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
    public partial class frmEmpleados : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public frmEmpleados()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el nombre del Empleado");
            this.ttMensaje.SetToolTip(this.cbidcargo, "Seleccione un cargo");

            this.LlenarComboPresentacion();
            this.LlenarComboDepa();
        }



        //Mostrar Mensaje de Confirmacion
        private void MensajeOK(String mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Mostrar Mensaje de Error
        private void MensajeError(String mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Metodo para limpiar todos los controles del formulario
        private void Limpiar()
        {
           
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtDui.Text = string.Empty;
            this.txtNit.Text = string.Empty;
            this.txtEstado.Text = string.Empty;
            this.txtIdempleado.Text = string.Empty;

        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.txtDui.ReadOnly = !valor;
            this.txtNit.ReadOnly = !valor;
            this.txtEstado.ReadOnly = !valor;
            this.cbidcargo.Enabled = valor;
            this.txtIdempleado.ReadOnly = valor;

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
            this.dataListado.Columns[8].Visible = false;
        }

        //Método para Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NEmpleados.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarNombre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NEmpleados.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Metodo para llenar el comboBox presentacion
        private void LlenarComboPresentacion()
        {
            cbidcargo.DataSource = NCargo.Mostrar();
            cbidcargo.ValueMember = "id_cargo";
            cbidcargo.DisplayMember = "cargo";
        }


        //Metodo para llenar el comboBox presentacion
        private void LlenarComboDepa()
        {
            cbdepartamento.DataSource = NDepartamentos.Mostrar();
            cbdepartamento.ValueMember = "id_departamento";
            cbdepartamento.DisplayMember = "departamento";
        }


        private void frmEmpleados_Load(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

                this.IsNuevo = true;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                this.Habilitar(true);
                this.txtNombre.Focus();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NEmpleados.Insertar(this.txtNombre.Text.Trim().ToUpper(), this.txtApellido.Text.ToUpper(), this.txtTelefono.Text.Trim().ToUpper(), this.txtDireccion.Text.Trim().ToUpper(),
                            this.txtDui.Text.Trim().ToUpper(),this.txtNit.Text.Trim().ToUpper(), Convert.ToInt32(this.cbidcargo.SelectedValue) , Convert.ToInt32(this.txtEstado.Text.Trim().ToUpper()), Convert.ToInt32(this.cbdepartamento.SelectedValue));
                    }
                    else
                    {
                        rpta = NEmpleados.Editar(Convert.ToInt32(this.txtIdempleado.Text),this.txtNombre.Text.Trim().ToUpper(), this.txtApellido.Text.ToUpper(), this.txtTelefono.Text.Trim().ToUpper(), this.txtDireccion.Text.Trim().ToUpper(),
                            this.txtDui.Text.Trim().ToUpper(), this.txtNit.Text.Trim().ToUpper(), Convert.ToInt32(this.cbidcargo.SelectedValue), Convert.ToInt32(this.txtEstado.Text.Trim().ToUpper()), Convert.ToInt32(this.cbdepartamento.SelectedValue));
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdempleado.Text.Equals(""))
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

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea Eliminar los registros", "Sistema de Inventario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NEmpleados.Eliminar(Convert.ToInt32(Codigo));

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

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdempleado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id_empleado"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtApellido.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["apellido"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txtDui.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["dui"].Value);
            this.txtNit.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nit"].Value);
            this.cbidcargo.SelectedValue = Convert.ToString(this.dataListado.CurrentRow.Cells["id_cargo"].Value);
            this.txtEstado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado"].Value);
            this.cbidcargo.Enabled = true;
            this.tabControl1.SelectedIndex = 1;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cbidcargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
