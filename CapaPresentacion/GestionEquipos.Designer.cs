
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
            this.cbEncabezado = new System.Windows.Forms.ComboBox();
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
            this.tabControl1.Location = new System.Drawing.Point(3, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1203, 697);
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
            this.tabAsignar.Location = new System.Drawing.Point(4, 29);
            this.tabAsignar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAsignar.Name = "tabAsignar";
            this.tabAsignar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAsignar.Size = new System.Drawing.Size(1195, 664);
            this.tabAsignar.TabIndex = 1;
            this.tabAsignar.Text = "Asignar Equipo";
            this.tabAsignar.UseVisualStyleBackColor = true;
            this.tabAsignar.Click += new System.EventHandler(this.tabAsignar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(538, 508);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(268, 93);
            this.txtDescripcion.TabIndex = 31;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsignar.Location = new System.Drawing.Point(848, 515);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(130, 53);
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
            this.dtequipos.Location = new System.Drawing.Point(622, 109);
            this.dtequipos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtequipos.Name = "dtequipos";
            this.dtequipos.RowHeadersWidth = 51;
            this.dtequipos.RowTemplate.Height = 25;
            this.dtequipos.Size = new System.Drawing.Size(545, 291);
            this.dtequipos.TabIndex = 29;
            this.dtequipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtequipos_CellContentClick);
            this.dtequipos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtequipos_CellValueChanged);
            // 
            // chkSel
            // 
            this.chkSel.HeaderText = " ";
            this.chkSel.MinimumWidth = 6;
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
            this.dtEmpleados.Location = new System.Drawing.Point(27, 109);
            this.dtEmpleados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtEmpleados.MultiSelect = false;
            this.dtEmpleados.Name = "dtEmpleados";
            this.dtEmpleados.RowHeadersWidth = 51;
            this.dtEmpleados.RowTemplate.Height = 25;
            this.dtEmpleados.Size = new System.Drawing.Size(518, 291);
            this.dtEmpleados.TabIndex = 28;
            this.dtEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEmpleados_CellContentClick);
            this.dtEmpleados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEmpleados_CellValueChanged);
            // 
            // chkAdd
            // 
            this.chkAdd.FillWeight = 20F;
            this.chkAdd.HeaderText = " ";
            this.chkAdd.MinimumWidth = 6;
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkAdd.Width = 30;
            // 
            // lbEquipo
            // 
            this.lbEquipo.AutoSize = true;
            this.lbEquipo.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEquipo.Location = new System.Drawing.Point(273, 545);
            this.lbEquipo.Name = "lbEquipo";
            this.lbEquipo.Size = new System.Drawing.Size(17, 23);
            this.lbEquipo.TabIndex = 27;
            this.lbEquipo.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Equipo a Asignar:";
            // 
            // lbNombreE
            // 
            this.lbNombreE.AutoSize = true;
            this.lbNombreE.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombreE.Location = new System.Drawing.Point(271, 481);
            this.lbNombreE.Name = "lbNombreE";
            this.lbNombreE.Size = new System.Drawing.Size(19, 25);
            this.lbNombreE.TabIndex = 25;
            this.lbNombreE.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nombre del Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tipo";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(310, 31);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(310, 57);
            this.cbdepartamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(235, 28);
            this.cbdepartamento.TabIndex = 14;
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Location = new System.Drawing.Point(622, 57);
            this.cbtipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(235, 28);
            this.cbtipo.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(450, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "DATOS DEL MOVIMIENTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(27, 57);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(203, 27);
            this.txtBuscar.TabIndex = 16;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(552, 219);
            this.btnMatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(63, 67);
            this.btnMatch.TabIndex = 13;
            this.btnMatch.UseVisualStyleBackColor = true;
            // 
            // tabRecepcion
            // 
            this.tabRecepcion.Controls.Add(this.button1);
            this.tabRecepcion.Controls.Add(this.txtDescripcionMov);
            this.tabRecepcion.Controls.Add(this.label10);
            this.tabRecepcion.Controls.Add(this.label9);
            this.tabRecepcion.Controls.Add(this.cbEncabezado);
            this.tabRecepcion.Controls.Add(this.label8);
            this.tabRecepcion.Controls.Add(this.textBox1);
            this.tabRecepcion.Controls.Add(this.gridMovimientos);
            this.tabRecepcion.Location = new System.Drawing.Point(4, 29);
            this.tabRecepcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRecepcion.Name = "tabRecepcion";
            this.tabRecepcion.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRecepcion.Size = new System.Drawing.Size(1195, 664);
            this.tabRecepcion.TabIndex = 0;
            this.tabRecepcion.Text = "Recepcion Equipos";
            this.tabRecepcion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(821, 443);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 67);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionMov
            // 
            this.txtDescripcionMov.Location = new System.Drawing.Point(688, 301);
            this.txtDescripcionMov.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcionMov.Multiline = true;
            this.txtDescripcionMov.Name = "txtDescripcionMov";
            this.txtDescripcionMov.Size = new System.Drawing.Size(367, 83);
            this.txtDescripcionMov.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(688, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Descripcion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(688, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Movimiento:";
            // 
            // cbEncabezado
            // 
            this.cbEncabezado.FormattingEnabled = true;
            this.cbEncabezado.Location = new System.Drawing.Point(688, 189);
            this.cbEncabezado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEncabezado.Name = "cbEncabezado";
            this.cbEncabezado.Size = new System.Drawing.Size(202, 28);
            this.cbEncabezado.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre Empleado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 27);
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
            this.gridMovimientos.Location = new System.Drawing.Point(30, 147);
            this.gridMovimientos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridMovimientos.MultiSelect = false;
            this.gridMovimientos.Name = "gridMovimientos";
            this.gridMovimientos.RowHeadersWidth = 51;
            this.gridMovimientos.RowTemplate.Height = 25;
            this.gridMovimientos.Size = new System.Drawing.Size(635, 427);
            this.gridMovimientos.TabIndex = 0;
            this.gridMovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMovimientos_CellContentClick);
            this.gridMovimientos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMovimientos_CellValueChanged);
            // 
            // chkOp
            // 
            this.chkOp.FillWeight = 25F;
            this.chkOp.HeaderText = "";
            this.chkOp.MinimumWidth = 6;
            this.chkOp.Name = "chkOp";
            this.chkOp.Width = 25;
            // 
            // tablReportes
            // 
            this.tablReportes.Location = new System.Drawing.Point(4, 29);
            this.tablReportes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tablReportes.Name = "tablReportes";
            this.tablReportes.Size = new System.Drawing.Size(1195, 664);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1198, 1073);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.ComboBox cbEncabezado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkOp;
        private System.Windows.Forms.Button button1;
    }
}