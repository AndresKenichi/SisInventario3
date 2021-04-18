using System;

namespace CapaPresentacion
{
    public class Class1
    {
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

        /*var filasBorrar = gridLotes.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToBoolean(x.Cells["Eliminar"].Value) == true).ToList();

            foreach (var row in filasBorrar)
            {
                //Borramos todos los necesarios en la capa de negocio
                nReporte.EliminarAsistenciaPasantes(Convert.ToInt16(row.Cells["idAsistencia"].Value));
                //Borramos la row del datagridview
                dataGridView1.Rows.Remove(row);
            }*/
    }
}
