
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarLote));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridLotes = new System.Windows.Forms.DataGridView();
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChOption = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridLotes);
            this.panel1.Location = new System.Drawing.Point(308, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 250);
            this.panel1.TabIndex = 0;
            // 
            // gridLotes
            // 
            this.gridLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fecha,
            this.cantidad,
            this.gestion,
            this.ChOption});
            this.gridLotes.Location = new System.Drawing.Point(0, 0);
            this.gridLotes.Name = "gridLotes";
            this.gridLotes.RowTemplate.Height = 25;
            this.gridLotes.Size = new System.Drawing.Size(567, 231);
            this.gridLotes.TabIndex = 0;
            this.gridLotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLotes_CellContentClick);
            this.gridLotes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLotes_CellValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Equipos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gestion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 23);
            this.textBox2.TabIndex = 4;
            // 
            // btnAceptarL
            // 
            this.btnAceptarL.Location = new System.Drawing.Point(109, 308);
            this.btnAceptarL.Name = "btnAceptarL";
            this.btnAceptarL.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarL.TabIndex = 5;
            this.btnAceptarL.Text = "Aceptar";
            this.btnAceptarL.UseVisualStyleBackColor = true;
            this.btnAceptarL.Click += new System.EventHandler(this.btnAceptarL_Click);
            // 
            // btnEliminarL
            // 
            this.btnEliminarL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarL.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarL.Image")));
            this.btnEliminarL.Location = new System.Drawing.Point(881, 100);
            this.btnEliminarL.Name = "btnEliminarL";
            this.btnEliminarL.Size = new System.Drawing.Size(48, 50);
            this.btnEliminarL.TabIndex = 7;
            this.btnEliminarL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarL.UseVisualStyleBackColor = true;
            this.btnEliminarL.Click += new System.EventHandler(this.btnEliminarL_Click);
            // 
            // btnGuardarL
            // 
            this.btnGuardarL.Location = new System.Drawing.Point(746, 347);
            this.btnGuardarL.Name = "btnGuardarL";
            this.btnGuardarL.Size = new System.Drawing.Size(130, 49);
            this.btnGuardarL.TabIndex = 8;
            this.btnGuardarL.Text = "Guardar";
            this.btnGuardarL.UseVisualStyleBackColor = true;
            this.btnGuardarL.Click += new System.EventHandler(this.btnGuardarL_Click);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(109, 114);
            this.dtpFechaIngreso.MaxDate = new System.DateTime(2021, 4, 16, 0, 0, 0, 0);
            this.dtpFechaIngreso.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(102, 25);
            this.dtpFechaIngreso.TabIndex = 9;
            this.dtpFechaIngreso.Value = new System.DateTime(2021, 4, 16, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
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
            // id
            // 
            this.id.HeaderText = "Codigo";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha Ingreso";
            this.fecha.MaxInputLength = 10;
            this.fecha.Name = "fecha";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // gestion
            // 
            this.gestion.HeaderText = "Gestion";
            this.gestion.Name = "gestion";
            // 
            // ChOption
            // 
            this.ChOption.HeaderText = "";
            this.ChOption.Name = "ChOption";
            // 
            // RegistrarLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 543);
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