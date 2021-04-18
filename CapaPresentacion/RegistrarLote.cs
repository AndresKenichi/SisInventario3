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
    public partial class RegistrarLote : Form
    {
        public ArrayList L = new ArrayList();
        string x;
        public RegistrarLote()
        {
            InitializeComponent();
            dtpFechaIngreso.MaxDate = DateTime.Today;
            dtpFechaIngreso.CustomFormat = "MMMM dd, yyyy - dddd";
            
        }

        private void RegistrarLote_Load(object sender, EventArgs e)
        {
          
        }
       
        private void btnAceptarL_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila.CreateCells(gridLotes);

            fila.Cells[0].Value = txtCodigoL.Text;
            fila.Cells[1].Value = dtpFechaIngreso.Value.Date;
            fila.Cells[2].Value = textBox1.Text;
            fila.Cells[3].Value = textBox2.Text;

            gridLotes.Rows.Add(fila);


            /*var filasBorrar = gridLotes.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToBoolean(x.Cells["Eliminar"].Value) == true).ToList();

            foreach (var row in filasBorrar)
            {
                //Borramos todos los necesarios en la capa de negocio
                nReporte.EliminarAsistenciaPasantes(Convert.ToInt16(row.Cells["idAsistencia"].Value));
                //Borramos la row del datagridview
                dataGridView1.Rows.Remove(row);
            }*/
        }

        private void gridLotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            // Detecta si se ha seleccionado el header de la grilla
            //
            if (e.RowIndex == -1)
                return;

            if (gridLotes.Columns[e.ColumnIndex].Name == "ChOption")
            {
                
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = gridLotes.Rows[e.RowIndex];

                //
                // Se selecciona la celda del checkbox
                //
                DataGridViewCheckBoxCell cellSelecion = row.Cells["ChOption"] as DataGridViewCheckBoxCell;


                if (Convert.ToBoolean(cellSelecion.Value))
                {
                    //gridLotes.Rows.Remove(row);
                    L.Remove(row.Cells[0].Value.ToString());
                    
                    string mensaje = string.Format("Evento CellContentClick.\n\nSe ha seccionado, \nCodigo: '{0}', \nFecha: '{1}', \nCantidad Equipos: '{2}',\nCGestion: '{3}''",
                                                        row.Cells[0].Value,
                                                        row.Cells[1].Value,
                                                        row.Cells[2].Value,
                                                        row.Cells[3].Value);

                    MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                { 
                    L.Add(row.Cells[0].Value.ToString());
                    string mensaje = string.Format("Evento CellContentClick.\n\nSe ha deseleccionado, \nCodigo: '{0}', \nFecha: '{1}', \nCantidad Equipos: '{2}',\nCGestion: '{3}''",
                                                        row.Cells[0].Value,
                                                        row.Cells[1].Value,
                                                        row.Cells[2].Value,
                                                        row.Cells[3].Value);

                    MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }*/
        }

        private void gridLotes_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            //
            
            /*//
            // Solo se trabaja ante los cambios en la columan de los checkbox 
            //
            if (gridLotes.Columns[e.ColumnIndex].Name == "ChOption")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = gridLotes.Rows[e.RowIndex];

                //
                // Se selecciona la celda del checkbox
                //
                DataGridViewCheckBoxCell cellSelecion = row.Cells["ChOption"] as DataGridViewCheckBoxCell;

                //
                // Se valida si esta checkeada
                //
                if (Convert.ToBoolean(cellSelecion.Value))
                {

                    string mensaje = string.Format("Evento CellValueChanged.\n\nSe ha seccionado, \nCodigo: '{0}', \nFecha Ingreso: '{1}', \nCantidad Equipos: '{2}',\nGestion: '{3}'",
                                                        row.Cells[0].Value,
                                                        row.Cells[1].Value,
                                                        row.Cells[2].Value,
                                                        row.Cells[3].Value);

                    MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }*/
        }

        private void btnEliminarL_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in gridLotes.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value))
                {
                    gridLotes.Rows.Remove(row);

                }

            }
        }
        private void MensajeOK(String mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Mostrar Mensaje de Error
        private void MensajeError(String mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
