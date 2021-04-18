using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;

namespace Loggin
{
    public partial class RegistrarLote : Form
    {
        public ArrayList L = new ArrayList();
        
        public RegistrarLote()
        {
            InitializeComponent();
            dtpFechaIngreso.MaxDate = DateTime.Today;
            dtpFechaIngreso.CustomFormat = "yyyy / MM / dd";
            
        }

        private void RegistrarLote_Load(object sender, EventArgs e)
        {
          
        }
       
        private void btnAceptarL_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();

            bool okey = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                okey = false;
                errorProvider1.SetError(textBox1, "Introduzca la cantidad de Equipos");
            }
            else { errorProvider1.SetError(textBox1, ""); okey = true; }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                okey = false;
                errorProvider2.SetError(textBox2, "Introduzca la Gestion del equipo");
            }
            else {
                okey = true;
                errorProvider2.SetError(textBox2, ""); }
            
            if(okey)
            {
                fila.CreateCells(gridLotes);

                fila.Cells[0].Value = dtpFechaIngreso.Value.Date;
                fila.Cells[1].Value = textBox1.Text;
                fila.Cells[2].Value = textBox2.Text;

                gridLotes.Rows.Add(fila);

                textBox1.Text = "";
                textBox2.Text = "";

            }
            
        }

        private void gridLotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gridLotes_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnEliminarL_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in gridLotes.Rows)
            {
                if (Convert.ToBoolean(row.Cells[3].Value))
                {
                    gridLotes.Rows.Remove(row);

                }

            }
        }

        public void añadirLot() {

            NLotes j = new NLotes();
            string mss = "";

            foreach (DataGridViewRow dv in gridLotes.Rows)
            {

                mss = j.ingresarLote(Convert.ToDateTime(dv.Cells[0].Value), Convert.ToInt32(dv.Cells[1].Value), Convert.ToString(dv.Cells[2].Value));

            }

            MessageBox.Show("lotes Agregados con Exito");
        }

        private void btnGuardarL_Click(object sender, EventArgs e)
        {
           if (gridLotes.Rows.Count < 2)
            {
                MessageBox.Show("INGRESE DATOS A LA TABLA");

            }
            else {

                añadirLot();
                LimpiarTodo();
            }
            
        }

        public void LimpiarTodo() {

            textBox1.Text = "";
            textBox2.Text = "";
            gridLotes.Rows.Clear();
        }
    }
}
