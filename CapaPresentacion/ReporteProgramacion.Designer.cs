
namespace CapaPresentacion
{
    partial class ReporteProgramacion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_reportPrograBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventario2DataSet = new CapaPresentacion.inventario2DataSet();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chkFtipo = new System.Windows.Forms.CheckBox();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.chkFDepa = new System.Windows.Forms.CheckBox();
            this.chkFmarcas = new System.Windows.Forms.CheckBox();
            this.txtIdempleado = new System.Windows.Forms.TextBox();
            this.cbdepartamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtFecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.dtFecha_Ini = new System.Windows.Forms.DateTimePicker();
            this.cbTipoE = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sp_reportPrograTableAdapter = new CapaPresentacion.inventario2DataSetTableAdapters.sp_reportPrograTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_reportPrograBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_reportPrograBindingSource
            // 
            this.sp_reportPrograBindingSource.DataMember = "sp_reportProgra";
            this.sp_reportPrograBindingSource.DataSource = this.inventario2DataSet;
            // 
            // inventario2DataSet
            // 
            this.inventario2DataSet.DataSetName = "inventario2DataSet";
            this.inventario2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "dsrprogram";
            reportDataSource2.Value = this.sp_reportPrograBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportPro.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 186);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1422, 629);
            this.reportViewer2.TabIndex = 0;
            // 
            // chkFtipo
            // 
            this.chkFtipo.AutoSize = true;
            this.chkFtipo.Location = new System.Drawing.Point(602, 121);
            this.chkFtipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFtipo.Name = "chkFtipo";
            this.chkFtipo.Size = new System.Drawing.Size(123, 21);
            this.chkFtipo.TabIndex = 62;
            this.chkFtipo.Text = "Filtrar por Tipo";
            this.chkFtipo.UseVisualStyleBackColor = true;
            this.chkFtipo.CheckedChanged += new System.EventHandler(this.chkFtipo_CheckedChanged);
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Location = new System.Drawing.Point(602, 52);
            this.chkFechas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(141, 21);
            this.chkFechas.TabIndex = 61;
            this.chkFechas.Text = "Filtrar por Fechas";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // chkFDepa
            // 
            this.chkFDepa.AutoSize = true;
            this.chkFDepa.Location = new System.Drawing.Point(12, 118);
            this.chkFDepa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFDepa.Name = "chkFDepa";
            this.chkFDepa.Size = new System.Drawing.Size(160, 21);
            this.chkFDepa.TabIndex = 60;
            this.chkFDepa.Text = "Filtrar Departamento";
            this.chkFDepa.UseVisualStyleBackColor = true;
            this.chkFDepa.CheckedChanged += new System.EventHandler(this.chkFDepa_CheckedChanged);
            // 
            // chkFmarcas
            // 
            this.chkFmarcas.AutoSize = true;
            this.chkFmarcas.Location = new System.Drawing.Point(12, 45);
            this.chkFmarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFmarcas.Name = "chkFmarcas";
            this.chkFmarcas.Size = new System.Drawing.Size(109, 21);
            this.chkFmarcas.TabIndex = 59;
            this.chkFmarcas.Text = "Filtrar Marca";
            this.chkFmarcas.UseVisualStyleBackColor = true;
            this.chkFmarcas.CheckedChanged += new System.EventHandler(this.chkFmarcas_CheckedChanged);
            // 
            // txtIdempleado
            // 
            this.txtIdempleado.BackColor = System.Drawing.Color.White;
            this.txtIdempleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdempleado.Location = new System.Drawing.Point(752, 22);
            this.txtIdempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdempleado.Name = "txtIdempleado";
            this.txtIdempleado.ReadOnly = true;
            this.txtIdempleado.Size = new System.Drawing.Size(307, 22);
            this.txtIdempleado.TabIndex = 58;
            this.txtIdempleado.Visible = false;
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.BackColor = System.Drawing.Color.White;
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(293, 118);
            this.cbdepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(284, 24);
            this.cbdepartamento.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(185, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 17);
            this.label12.TabIndex = 56;
            this.label12.Text = "Departamento:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(1133, 110);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(152, 32);
            this.btnGenerar.TabIndex = 55;
            this.btnGenerar.Text = "&Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtFecha_Fin
            // 
            this.dtFecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha_Fin.Location = new System.Drawing.Point(843, 80);
            this.dtFecha_Fin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFecha_Fin.Name = "dtFecha_Fin";
            this.dtFecha_Fin.Size = new System.Drawing.Size(207, 22);
            this.dtFecha_Fin.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Fecha Fin:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(749, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Tipo Equipo:";
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.White;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(293, 41);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(237, 24);
            this.cbMarca.TabIndex = 50;
            // 
            // dtFecha_Ini
            // 
            this.dtFecha_Ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha_Ini.Location = new System.Drawing.Point(843, 48);
            this.dtFecha_Ini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFecha_Ini.Name = "dtFecha_Ini";
            this.dtFecha_Ini.Size = new System.Drawing.Size(207, 22);
            this.dtFecha_Ini.TabIndex = 49;
            // 
            // cbTipoE
            // 
            this.cbTipoE.BackColor = System.Drawing.Color.White;
            this.cbTipoE.FormattingEnabled = true;
            this.cbTipoE.Location = new System.Drawing.Point(843, 118);
            this.cbTipoE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoE.Name = "cbTipoE";
            this.cbTipoE.Size = new System.Drawing.Size(284, 24);
            this.cbTipoE.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(749, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Fecha Inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Marca:";
            // 
            // sp_reportPrograTableAdapter
            // 
            this.sp_reportPrograTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProgramacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 817);
            this.Controls.Add(this.chkFtipo);
            this.Controls.Add(this.chkFechas);
            this.Controls.Add(this.chkFDepa);
            this.Controls.Add(this.chkFmarcas);
            this.Controls.Add(this.txtIdempleado);
            this.Controls.Add(this.cbdepartamento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtFecha_Fin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.dtFecha_Ini);
            this.Controls.Add(this.cbTipoE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reportViewer2);
            this.Name = "ReporteProgramacion";
            this.Text = "ReporteProgramacion";
            this.Load += new System.EventHandler(this.ReporteProgramacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_reportPrograBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.CheckBox chkFtipo;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.CheckBox chkFDepa;
        private System.Windows.Forms.CheckBox chkFmarcas;
        private System.Windows.Forms.TextBox txtIdempleado;
        private System.Windows.Forms.ComboBox cbdepartamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DateTimePicker dtFecha_Fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.DateTimePicker dtFecha_Ini;
        private System.Windows.Forms.ComboBox cbTipoE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource sp_reportPrograBindingSource;
        private inventario2DataSet inventario2DataSet;
        private inventario2DataSetTableAdapters.sp_reportPrograTableAdapter sp_reportPrograTableAdapter;
    }
}