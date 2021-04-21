
namespace Loggin
{
    partial class GestionEquipos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAsignar = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.dtequipos = new System.Windows.Forms.DataGridView();
            this.chkSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtEmpleados = new System.Windows.Forms.DataGridView();
            this.chkAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbEquipo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNombreE = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbdepartamento = new System.Windows.Forms.ComboBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.tabRecepcion = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescripcionMov = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gridMovimientos = new System.Windows.Forms.DataGridView();
            this.chkOp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tablReportes = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabAsignar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtequipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpleados)).BeginInit();
            this.tabRecepcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAsignar);
            this.tabControl1.Controls.Add(this.tabRecepcion);
            this.tabControl1.Controls.Add(this.tablReportes);
            this.tabControl1.Location = new System.Drawing.Point(3, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 523);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabAsignar
            // 
            this.tabAsignar.Controls.Add(this.label7);
            this.tabAsignar.Controls.Add(this.txtDescripcion);
            this.tabAsignar.Controls.Add(this.btnAsignar);
            this.tabAsignar.Controls.Add(this.dtequipos);
            this.tabAsignar.Controls.Add(this.dtEmpleados);
            this.tabAsignar.Controls.Add(this.lbEquipo);
            this.tabAsignar.Controls.Add(this.label6);
            this.tabAsignar.Controls.Add(this.lbNombreE);
            this.tabAsignar.Controls.Add(this.label5);
            this.tabAsignar.Controls.Add(this.label2);
            this.tabAsignar.Controls.Add(this.label3);
            this.tabAsignar.Controls.Add(this.checkBox1);
            this.tabAsignar.Controls.Add(this.cbdepartamento);
            this.tabAsignar.Controls.Add(this.cbtipo);
            this.tabAsignar.Controls.Add(this.label4);
            this.tabAsignar.Controls.Add(this.label1);
            this.tabAsignar.Controls.Add(this.txtBuscar);
            this.tabAsignar.Controls.Add(this.btnMatch);
            this.tabAsignar.Location = new System.Drawing.Point(4, 24);
            this.tabAsignar.Name = "tabAsignar";
            this.tabAsignar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsignar.Size = new System.Drawing.Size(1045, 495);
            this.tabAsignar.TabIndex = 1;
            this.tabAsignar.Text = "Asignar Equipo";
            this.tabAsignar.UseVisualStyleBackColor = true;
            this.tabAsignar.Click += new System.EventHandler(this.tabAsignar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(471, 381);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(235, 71);
            this.txtDescripcion.TabIndex = 31;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsignar.Location = new System.Drawing.Point(742, 386);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(114, 40);
            this.btnAsignar.TabIndex = 30;
            this.btnAsignar.Text = "ASIGNAR";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // dtequipos
            // 
            this.dtequipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtequipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSel});
            this.dtequipos.Location = new System.Drawing.Point(544, 82);
            this.dtequipos.Name = "dtequipos";
            this.dtequipos.RowTemplate.Height = 25;
            this.dtequipos.Size = new System.Drawing.Size(477, 218);
            this.dtequipos.TabIndex = 29;
            this.dtequipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtequipos_CellContentClick);
            this.dtequipos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtequipos_CellValueChanged);
            // 
            // chkSel
            // 
            this.chkSel.HeaderText = " ";
            this.chkSel.Name = "chkSel";
            this.chkSel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chkSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkSel.Width = 30;
            // 
            // dtEmpleados
            // 
            this.dtEmpleados.AllowUserToDeleteRows = false;
            this.dtEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkAdd});
            this.dtEmpleados.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtEmpleados.Location = new System.Drawing.Point(24, 82);
            this.dtEmpleados.MultiSelect = false;
            this.dtEmpleados.Name = "dtEmpleados";
            this.dtEmpleados.RowTemplate.Height = 25;
            this.dtEmpleados.Size = new System.Drawing.Size(453, 218);
            this.dtEmpleados.TabIndex = 28;
            this.dtEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEmpleados_CellContentClick);
            this.dtEmpleados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEmpleados_CellValueChanged);
            // 
            // chkAdd
            // 
            this.chkAdd.FillWeight = 20F;
            this.chkAdd.HeaderText = " ";
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkAdd.Width = 30;
            // 
            // lbEquipo
            // 
            this.lbEquipo.AutoSize = true;
            this.lbEquipo.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEquipo.Location = new System.Drawing.Point(239, 409);
            this.lbEquipo.Name = "lbEquipo";
            this.lbEquipo.Size = new System.Drawing.Size(13, 17);
            this.lbEquipo.TabIndex = 27;
            this.lbEquipo.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Equipo a Asignar:";
            // 
            // lbNombreE
            // 
            this.lbNombreE.AutoSize = true;
            this.lbNombreE.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombreE.Location = new System.Drawing.Point(237, 361);
            this.lbNombreE.Name = "lbNombreE";
            this.lbNombreE.Size = new System.Drawing.Size(15, 19);
            this.lbNombreE.TabIndex = 25;
            this.lbNombreE.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nombre del Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tipo";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(271, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(271, 43);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(206, 23);
            this.cbdepartamento.TabIndex = 14;
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Location = new System.Drawing.Point(544, 43);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(206, 23);
            this.cbtipo.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(394, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "DATOS DEL MOVIMIENTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(24, 43);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(178, 23);
            this.txtBuscar.TabIndex = 16;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(483, 164);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(55, 50);
            this.btnMatch.TabIndex = 13;
            this.btnMatch.UseVisualStyleBackColor = true;
            // 
            // tabRecepcion
            // 
            this.tabRecepcion.Controls.Add(this.button1);
            this.tabRecepcion.Controls.Add(this.txtDescripcionMov);
            this.tabRecepcion.Controls.Add(this.label10);
            this.tabRecepcion.Controls.Add(this.label9);
            this.tabRecepcion.Controls.Add(this.comboBox1);
            this.tabRecepcion.Controls.Add(this.label8);
            this.tabRecepcion.Controls.Add(this.textBox1);
            this.tabRecepcion.Controls.Add(this.gridMovimientos);
            this.tabRecepcion.Location = new System.Drawing.Point(4, 24);
            this.tabRecepcion.Name = "tabRecepcion";
            this.tabRecepcion.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecepcion.Size = new System.Drawing.Size(1045, 495);
            this.tabRecepcion.TabIndex = 0;
            this.tabRecepcion.Text = "Recepcion Equipos";
            this.tabRecepcion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionMov
            // 
            this.txtDescripcionMov.Location = new System.Drawing.Point(602, 226);
            this.txtDescripcionMov.Multiline = true;
            this.txtDescripcionMov.Name = "txtDescripcionMov";
            this.txtDescripcionMov.Size = new System.Drawing.Size(322, 63);
            this.txtDescripcionMov.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(602, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Descripcion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(602, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Movimiento:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(602, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre Empleado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gridMovimientos
            // 
            this.gridMovimientos.AllowUserToResizeRows = false;
            this.gridMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkOp});
            this.gridMovimientos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridMovimientos.Location = new System.Drawing.Point(26, 110);
            this.gridMovimientos.MultiSelect = false;
            this.gridMovimientos.Name = "gridMovimientos";
            this.gridMovimientos.RowTemplate.Height = 25;
            this.gridMovimientos.Size = new System.Drawing.Size(556, 320);
            this.gridMovimientos.TabIndex = 0;
            this.gridMovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMovimientos_CellContentClick);
            this.gridMovimientos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMovimientos_CellValueChanged);
            // 
            // chkOp
            // 
            this.chkOp.FillWeight = 25F;
            this.chkOp.HeaderText = "";
            this.chkOp.Name = "chkOp";
            this.chkOp.Width = 25;
            // 
            // tablReportes
            // 
            this.tablReportes.Location = new System.Drawing.Point(4, 24);
            this.tablReportes.Name = "tablReportes";
            this.tablReportes.Size = new System.Drawing.Size(1045, 495);
            this.tablReportes.TabIndex = 2;
            this.tablReportes.Text = "Reportes";
            this.tablReportes.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GestionEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1048, 805);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "d";
            this.Load += new System.EventHandler(this.GestionEquipos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAsignar.ResumeLayout(false);
            this.tabAsignar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtequipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpleados)).EndInit();
            this.tabRecepcion.ResumeLayout(false);
            this.tabRecepcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAsignar;
        private System.Windows.Forms.TabPage tabRecepcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbdepartamento;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Label lbEquipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNombreE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtEmpleados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkAdd;
        private System.Windows.Forms.DataGridView dtequipos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSel;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tablReportes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView gridMovimientos;
        private System.Windows.Forms.TextBox txtDescripcionMov;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkOp;
        private System.Windows.Forms.Button button1;
    }
}