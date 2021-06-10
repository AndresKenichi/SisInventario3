
namespace Loggin
{
    partial class RegistrarLote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridLotes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChOption = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAceptarL = new System.Windows.Forms.Button();
            this.btnEliminarL = new System.Windows.Forms.Button();
            this.btnGuardarL = new System.Windows.Forms.Button();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridLotes);
            this.panel1.Location = new System.Drawing.Point(327, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 296);
            this.panel1.TabIndex = 0;
            // 
            // gridLotes
            // 
            this.gridLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLotes.BackgroundColor = System.Drawing.Color.White;
            this.gridLotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLotes.ColumnHeadersHeight = 29;
            this.gridLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fecha,
            this.cantidad,
            this.gestion,
            this.ChOption});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridLotes.EnableHeadersVisualStyles = false;
            this.gridLotes.GridColor = System.Drawing.Color.SteelBlue;
            this.gridLotes.Location = new System.Drawing.Point(0, 0);
            this.gridLotes.Name = "gridLotes";
            this.gridLotes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridLotes.RowHeadersWidth = 51;
            this.gridLotes.RowTemplate.Height = 25;
            this.gridLotes.Size = new System.Drawing.Size(709, 272);
            this.gridLotes.TabIndex = 0;
            this.gridLotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLotes_CellContentClick);
            this.gridLotes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLotes_CellValueChanged_1);
            // 
            // id
            // 
            this.id.HeaderText = "Codigo";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha Ingreso";
            this.fecha.MaxInputLength = 10;
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            // 
            // gestion
            // 
            this.gestion.HeaderText = "Gestion";
            this.gestion.MinimumWidth = 6;
            this.gestion.Name = "gestion";
            // 
            // ChOption
            // 
            this.ChOption.HeaderText = "";
            this.ChOption.MinimumWidth = 6;
            this.ChOption.Name = "ChOption";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Equipos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gestion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 22);
            this.textBox2.TabIndex = 4;
            // 
            // btnAceptarL
            // 
            this.btnAceptarL.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAceptarL.FlatAppearance.BorderSize = 0;
            this.btnAceptarL.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnAceptarL.ForeColor = System.Drawing.Color.White;
            this.btnAceptarL.Location = new System.Drawing.Point(125, 329);
            this.btnAceptarL.Name = "btnAceptarL";
            this.btnAceptarL.Size = new System.Drawing.Size(116, 40);
            this.btnAceptarL.TabIndex = 5;
            this.btnAceptarL.Text = "Aceptar";
            this.btnAceptarL.UseVisualStyleBackColor = false;
            this.btnAceptarL.Click += new System.EventHandler(this.btnAceptarL_Click);
            // 
            // btnEliminarL
            // 
            this.btnEliminarL.AutoSize = true;
            this.btnEliminarL.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.errorProvider2.SetIconAlignment(this.btnEliminarL, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.btnEliminarL.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btnEliminarL.Location = new System.Drawing.Point(1045, 107);
            this.btnEliminarL.Name = "btnEliminarL";
            this.btnEliminarL.Size = new System.Drawing.Size(102, 102);
            this.btnEliminarL.TabIndex = 7;
            this.btnEliminarL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarL.UseVisualStyleBackColor = true;
            this.btnEliminarL.Click += new System.EventHandler(this.btnEliminarL_Click);
            // 
            // btnGuardarL
            // 
            this.btnGuardarL.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardarL.FlatAppearance.BorderSize = 0;
            this.btnGuardarL.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardarL.ForeColor = System.Drawing.Color.White;
            this.btnGuardarL.Location = new System.Drawing.Point(858, 433);
            this.btnGuardarL.Name = "btnGuardarL";
            this.btnGuardarL.Size = new System.Drawing.Size(142, 42);
            this.btnGuardarL.TabIndex = 8;
            this.btnGuardarL.Text = "Guardar";
            this.btnGuardarL.UseVisualStyleBackColor = false;
            this.btnGuardarL.Click += new System.EventHandler(this.btnGuardarL_Click);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(125, 122);
            this.dtpFechaIngreso.MaxDate = new System.DateTime(2021, 4, 16, 0, 0, 0, 0);
            this.dtpFechaIngreso.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(116, 30);
            this.dtpFechaIngreso.TabIndex = 9;
            this.dtpFechaIngreso.Value = new System.DateTime(2021, 4, 16, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha Ingreso";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // RegistrarLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 579);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.btnGuardarL);
            this.Controls.Add(this.btnEliminarL);
            this.Controls.Add(this.btnAceptarL);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "w";
            this.Load += new System.EventHandler(this.RegistrarLote_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAceptarL;
        private System.Windows.Forms.Button btnEliminarL;
        private System.Windows.Forms.Button btnGuardarL;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridLotes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChOption;
    }
}