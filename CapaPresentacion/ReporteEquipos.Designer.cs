
namespace CapaPresentacion
{
    partial class ReporteEquipos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label10 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.dtFecha_Ini = new System.Windows.Forms.DateTimePicker();
            this.cbTipoE = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cbdepartamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.txtIdempleado = new System.Windows.Forms.TextBox();
            this.chkFmarcas = new System.Windows.Forms.CheckBox();
            this.chkFDepa = new System.Windows.Forms.CheckBox();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.chkFtipo = new System.Windows.Forms.CheckBox();
            this.sp_reportEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsprocEquipo = new CapaPresentacion.dsprocEquipo();
            this.sp_reportEquipoTableAdapter = new CapaPresentacion.dsprocEquipoTableAdapters.sp_reportEquipoTableAdapter();
            this.dsprocEquipo2 = new CapaPresentacion.dsprocEquipo2();
            ((System.ComponentModel.ISupportInitialize)(this.sp_reportEquipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsprocEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsprocEquipo2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DsEquipo";
            reportDataSource1.Value = this.sp_reportEquipoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteEquipo2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 149);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1398, 694);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(749, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Tipo Equipo:";
            // 
            // cbModelo
            // 
            this.cbModelo.BackColor = System.Drawing.Color.White;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(293, 63);
            this.cbModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(237, 24);
            this.cbModelo.TabIndex = 33;
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.White;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(293, 27);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(237, 24);
            this.cbMarca.TabIndex = 32;
            this.cbMarca.SelectedValueChanged += new System.EventHandler(this.cbMarca_SelectedValueChanged);
            // 
            // dtFecha_Ini
            // 
            this.dtFecha_Ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha_Ini.Location = new System.Drawing.Point(843, 34);
            this.dtFecha_Ini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFecha_Ini.Name = "dtFecha_Ini";
            this.dtFecha_Ini.Size = new System.Drawing.Size(207, 22);
            this.dtFecha_Ini.TabIndex = 31;
            // 
            // cbTipoE
            // 
            this.cbTipoE.BackColor = System.Drawing.Color.White;
            this.cbTipoE.FormattingEnabled = true;
            this.cbTipoE.Location = new System.Drawing.Point(843, 104);
            this.cbTipoE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoE.Name = "cbTipoE";
            this.cbTipoE.Size = new System.Drawing.Size(284, 24);
            this.cbTipoE.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(749, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Fecha Inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Modelo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Fecha Fin:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtFecha_Fin
            // 
            this.dtFecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha_Fin.Location = new System.Drawing.Point(843, 66);
            this.dtFecha_Fin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFecha_Fin.Name = "dtFecha_Fin";
            this.dtFecha_Fin.Size = new System.Drawing.Size(207, 22);
            this.dtFecha_Fin.TabIndex = 36;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(1133, 95);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(152, 32);
            this.btnGenerar.TabIndex = 37;
            this.btnGenerar.Text = "&Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.BackColor = System.Drawing.Color.White;
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(293, 104);
            this.cbdepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(284, 24);
            this.cbdepartamento.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(185, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "Departamento:";
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // txtIdempleado
            // 
            this.txtIdempleado.BackColor = System.Drawing.Color.White;
            this.txtIdempleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdempleado.Location = new System.Drawing.Point(752, 8);
            this.txtIdempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdempleado.Name = "txtIdempleado";
            this.txtIdempleado.ReadOnly = true;
            this.txtIdempleado.Size = new System.Drawing.Size(307, 22);
            this.txtIdempleado.TabIndex = 40;
            this.txtIdempleado.Visible = false;
            // 
            // chkFmarcas
            // 
            this.chkFmarcas.AutoSize = true;
            this.chkFmarcas.Location = new System.Drawing.Point(12, 31);
            this.chkFmarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFmarcas.Name = "chkFmarcas";
            this.chkFmarcas.Size = new System.Drawing.Size(170, 21);
            this.chkFmarcas.TabIndex = 41;
            this.chkFmarcas.Text = "Filtrar Marca y modelo";
            this.chkFmarcas.UseVisualStyleBackColor = true;
            this.chkFmarcas.CheckedChanged += new System.EventHandler(this.chkFmarcas_CheckedChanged);
            // 
            // chkFDepa
            // 
            this.chkFDepa.AutoSize = true;
            this.chkFDepa.Location = new System.Drawing.Point(12, 104);
            this.chkFDepa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFDepa.Name = "chkFDepa";
            this.chkFDepa.Size = new System.Drawing.Size(160, 21);
            this.chkFDepa.TabIndex = 42;
            this.chkFDepa.Text = "Filtrar Departamento";
            this.chkFDepa.UseVisualStyleBackColor = true;
            this.chkFDepa.CheckedChanged += new System.EventHandler(this.chkFDepa_CheckedChanged);
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Location = new System.Drawing.Point(602, 38);
            this.chkFechas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(141, 21);
            this.chkFechas.TabIndex = 43;
            this.chkFechas.Text = "Filtrar por Fechas";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // chkFtipo
            // 
            this.chkFtipo.AutoSize = true;
            this.chkFtipo.Location = new System.Drawing.Point(602, 107);
            this.chkFtipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFtipo.Name = "chkFtipo";
            this.chkFtipo.Size = new System.Drawing.Size(123, 21);
            this.chkFtipo.TabIndex = 44;
            this.chkFtipo.Text = "Filtrar por Tipo";
            this.chkFtipo.UseVisualStyleBackColor = true;
            this.chkFtipo.CheckedChanged += new System.EventHandler(this.chkFtipo_CheckedChanged);
            // 
            // sp_reportEquipoBindingSource
            // 
            this.sp_reportEquipoBindingSource.DataMember = "sp_reportEquipo";
            this.sp_reportEquipoBindingSource.DataSource = this.dsprocEquipo;
            // 
            // dsprocEquipo
            // 
            this.dsprocEquipo.DataSetName = "dsprocEquipo";
            this.dsprocEquipo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_reportEquipoTableAdapter
            // 
            this.sp_reportEquipoTableAdapter.ClearBeforeFill = true;
            // 
            // dsprocEquipo2
            // 
            this.dsprocEquipo2.DataSetName = "dsprocEquipo2";
            this.dsprocEquipo2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 847);
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
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.dtFecha_Ini);
            this.Controls.Add(this.cbTipoE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEquipos";
            this.Text = "ReporteEquipos";
            this.Load += new System.EventHandler(this.ReporteEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_reportEquipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsprocEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsprocEquipo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.DateTimePicker dtFecha_Ini;
        private System.Windows.Forms.ComboBox cbTipoE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFecha_Fin;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cbdepartamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource sp_reportEquipoBindingSource;
        private dsprocEquipo dsprocEquipo;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.TextBox txtIdempleado;
        private System.Windows.Forms.CheckBox chkFmarcas;
        private System.Windows.Forms.CheckBox chkFDepa;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.CheckBox chkFtipo;
        private dsprocEquipoTableAdapters.sp_reportEquipoTableAdapter sp_reportEquipoTableAdapter;
        private dsprocEquipo2 dsprocEquipo2;
    }
}