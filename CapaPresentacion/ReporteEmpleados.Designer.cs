
namespace CapaPresentacion
{
    partial class ReporteEmpleados
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
            this.sp_reportesEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsREmpleados = new CapaPresentacion.dsREmpleados();
            this.chkFCargo = new System.Windows.Forms.CheckBox();
            this.chkFDepa = new System.Windows.Forms.CheckBox();
            this.chkFEstado = new System.Windows.Forms.CheckBox();
            this.cbdepartamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_reportesEmpleadosTableAdapter = new CapaPresentacion.dsREmpleadosTableAdapters.sp_reportesEmpleadosTableAdapter();
            this.cbidcargo = new System.Windows.Forms.ComboBox();
            this.cbEncabezado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFEncabezado = new System.Windows.Forms.CheckBox();
            this.txtM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sp_reportesEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsREmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_reportesEmpleadosBindingSource
            // 
            this.sp_reportesEmpleadosBindingSource.DataMember = "sp_reportesEmpleados";
            this.sp_reportesEmpleadosBindingSource.DataSource = this.dsREmpleados;
            // 
            // dsREmpleados
            // 
            this.dsREmpleados.DataSetName = "dsREmpleados";
            this.dsREmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkFCargo
            // 
            this.chkFCargo.AutoSize = true;
            this.chkFCargo.Location = new System.Drawing.Point(597, 106);
            this.chkFCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFCargo.Name = "chkFCargo";
            this.chkFCargo.Size = new System.Drawing.Size(133, 21);
            this.chkFCargo.TabIndex = 63;
            this.chkFCargo.Text = "Filtrar por Cargo";
            this.chkFCargo.UseVisualStyleBackColor = true;
            this.chkFCargo.CheckedChanged += new System.EventHandler(this.chkFCargo_CheckedChanged);
            // 
            // chkFDepa
            // 
            this.chkFDepa.AutoSize = true;
            this.chkFDepa.Location = new System.Drawing.Point(16, 111);
            this.chkFDepa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFDepa.Name = "chkFDepa";
            this.chkFDepa.Size = new System.Drawing.Size(160, 21);
            this.chkFDepa.TabIndex = 61;
            this.chkFDepa.Text = "Filtrar Departamento";
            this.chkFDepa.UseVisualStyleBackColor = true;
            this.chkFDepa.CheckedChanged += new System.EventHandler(this.chkFDepa_CheckedChanged);
            // 
            // chkFEstado
            // 
            this.chkFEstado.AutoSize = true;
            this.chkFEstado.Location = new System.Drawing.Point(16, 51);
            this.chkFEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFEstado.Name = "chkFEstado";
            this.chkFEstado.Size = new System.Drawing.Size(139, 21);
            this.chkFEstado.TabIndex = 60;
            this.chkFEstado.Text = "Filtrar por Estado";
            this.chkFEstado.UseVisualStyleBackColor = true;
            this.chkFEstado.CheckedChanged += new System.EventHandler(this.chkFEstado_CheckedChanged);
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.BackColor = System.Drawing.Color.White;
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(290, 104);
            this.cbdepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(284, 24);
            this.cbdepartamento.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(182, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 17);
            this.label12.TabIndex = 57;
            this.label12.Text = "Departamento:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(1059, 97);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(203, 32);
            this.btnGenerar.TabIndex = 56;
            this.btnGenerar.Text = "&Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(736, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "Cargo:";
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.White;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(284, 48);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(237, 24);
            this.cbEstado.TabIndex = 52;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Estado:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DsEmpleado1";
            reportDataSource1.Value = this.sp_reportesEmpleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 186);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1368, 604);
            this.reportViewer1.TabIndex = 45;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sp_reportesEmpleadosTableAdapter
            // 
            this.sp_reportesEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // cbidcargo
            // 
            this.cbidcargo.BackColor = System.Drawing.Color.White;
            this.cbidcargo.FormattingEnabled = true;
            this.cbidcargo.Location = new System.Drawing.Point(792, 102);
            this.cbidcargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbidcargo.Name = "cbidcargo";
            this.cbidcargo.Size = new System.Drawing.Size(252, 24);
            this.cbidcargo.TabIndex = 64;
            // 
            // cbEncabezado
            // 
            this.cbEncabezado.BackColor = System.Drawing.Color.White;
            this.cbEncabezado.FormattingEnabled = true;
            this.cbEncabezado.Location = new System.Drawing.Point(866, 43);
            this.cbEncabezado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEncabezado.Name = "cbEncabezado";
            this.cbEncabezado.Size = new System.Drawing.Size(237, 24);
            this.cbEncabezado.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(769, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Encabezado:";
            // 
            // chkFEncabezado
            // 
            this.chkFEncabezado.AutoSize = true;
            this.chkFEncabezado.Location = new System.Drawing.Point(589, 50);
            this.chkFEncabezado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFEncabezado.Name = "chkFEncabezado";
            this.chkFEncabezado.Size = new System.Drawing.Size(174, 21);
            this.chkFEncabezado.TabIndex = 67;
            this.chkFEncabezado.Text = "Filtrar por Encabezado";
            this.chkFEncabezado.UseVisualStyleBackColor = true;
            this.chkFEncabezado.CheckedChanged += new System.EventHandler(this.chkFEncabezado_CheckedChanged);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(309, 13);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(337, 22);
            this.txtM.TabIndex = 68;
            this.txtM.Visible = false;
            // 
            // ReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 815);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.chkFEncabezado);
            this.Controls.Add(this.cbEncabezado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbidcargo);
            this.Controls.Add(this.chkFCargo);
            this.Controls.Add(this.chkFDepa);
            this.Controls.Add(this.chkFEstado);
            this.Controls.Add(this.cbdepartamento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEmpleados";
            this.Text = "ReporteEmpleados";
            this.Load += new System.EventHandler(this.ReporteEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_reportesEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsREmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFCargo;
        private System.Windows.Forms.CheckBox chkFDepa;
        private System.Windows.Forms.CheckBox chkFEstado;
        private System.Windows.Forms.ComboBox cbdepartamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label7;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_reportesEmpleadosBindingSource;
        private dsREmpleados dsREmpleados;
        private dsREmpleadosTableAdapters.sp_reportesEmpleadosTableAdapter sp_reportesEmpleadosTableAdapter;
        private System.Windows.Forms.ComboBox cbidcargo;
        private System.Windows.Forms.ComboBox cbEncabezado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFEncabezado;
        private System.Windows.Forms.TextBox txtM;
    }
}