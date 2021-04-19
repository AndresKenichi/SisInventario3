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
using CapaPresentacion;
namespace Loggin
{
    public partial class RegistrarLote : Form
    {
        public ArrayList L = new ArrayList();
        private NLotes j = new NLotes();
        private int n=0;

        CapaPresentacion.Class1 ew = new CapaPresentacion.Class1();
        public RegistrarLote()
        {
            InitializeComponent();
            dtpFechaIngreso.MaxDate = DateTime.Today;
            dtpFechaIngreso.CustomFormat = "yyyy / MM / dd";
            n = j.idL();

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

            if (okey)
            {
                n = n + 1;
                fila.CreateCells(gridLotes);
                fila.Cells[0].Value = n;
                fila.Cells[1].Value = dtpFechaIngreso.Value.Date;
                fila.Cells[2].Value = textBox1.Text;
                fila.Cells[3].Value = textBox2.Text;

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
                if (Convert.ToBoolean(row.Cells[4].Value))
                {
                    gridLotes.Rows.Remove(row);

                }

            }
        }

        public void añadirLot() {

            
            string mss = "";
            
            foreach (DataGridViewRow dv in gridLotes.Rows)
            {

                mss = j.ingresarLote(Convert.ToDateTime(dv.Cells[1].Value), Convert.ToInt32(dv.Cells[2].Value), Convert.ToString(dv.Cells[3].Value));

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
