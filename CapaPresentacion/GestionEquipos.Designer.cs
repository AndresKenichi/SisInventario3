
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gridEmpleadosGE = new System.Windows.Forms.DataGridView();
            this.btnMatch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.chkEquipo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkEmpGE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosGE)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(553, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 218);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridEmpleadosGE);
            this.panel2.Location = new System.Drawing.Point(33, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 218);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkEquipo,
            this.id_equipo,
            this.Equipo,
            this.codigo});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(468, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // gridEmpleadosGE
            // 
            this.gridEmpleadosGE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEmpleadosGE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleadosGE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkEmpGE,
            this.id_empleado,
            this.nombre,
            this.cargo});
            this.gridEmpleadosGE.Location = new System.Drawing.Point(0, 0);
            this.gridEmpleadosGE.Name = "gridEmpleadosGE";
            this.gridEmpleadosGE.RowTemplate.Height = 25;
            this.gridEmpleadosGE.Size = new System.Drawing.Size(468, 198);
            this.gridEmpleadosGE.TabIndex = 1;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(507, 163);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(40, 37);
            this.btnMatch.TabIndex = 2;
            this.btnMatch.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(293, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(272, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 23);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Departamento";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(589, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(206, 23);
            this.comboBox2.TabIndex = 8;
            // 
            // chkEquipo
            // 
            this.chkEquipo.FillWeight = 25F;
            this.chkEquipo.HeaderText = " ";
            this.chkEquipo.Name = "chkEquipo";
            // 
            // id_equipo
            // 
            this.id_equipo.FillWeight = 30F;
            this.id_equipo.HeaderText = "Id";
            this.id_equipo.Name = "id_equipo";
            this.id_equipo.ReadOnly = true;
            // 
            // Equipo
            // 
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.Name = "Equipo";
            this.Equipo.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // chkEmpGE
            // 
            this.chkEmpGE.FillWeight = 25F;
            this.chkEmpGE.HeaderText = "";
            this.chkEmpGE.Name = "chkEmpGE";
            // 
            // id_empleado
            // 
            this.id_empleado.FillWeight = 45F;
            this.id_empleado.HeaderText = "Id";
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo";
            // 
            // GestionEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1048, 543);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "d";
            this.Load += new System.EventHandler(this.GestionEquipos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridEmpleadosGE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkEmpGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
    }
}