﻿
namespace Loggin
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Empleados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MantenimientoM = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpleadosF = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosF = new System.Windows.Forms.ToolStripMenuItem();
            this.EquiposF = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcesosM = new System.Windows.Forms.ToolStripMenuItem();
            this.RegLoteF = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionEquiposF = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesM = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaDeM = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirM = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Empleados
            // 
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(204, 22);
            this.Empleados.Text = "Empleados";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem5.Text = "Usuarios";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem6.Text = "Equipos";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem7.Text = "Marcas y Modelos";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem8.Text = "Cargos y Departamentos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MantenimientoM,
            this.ProcesosM,
            this.ReportesM,
            this.AcercaDeM,
            this.SalirM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MantenimientoM
            // 
            this.MantenimientoM.Checked = true;
            this.MantenimientoM.CheckOnClick = true;
            this.MantenimientoM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MantenimientoM.DoubleClickEnabled = true;
            this.MantenimientoM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmpleadosF,
            this.UsuariosF,
            this.EquiposF});
            this.MantenimientoM.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MantenimientoM.Name = "MantenimientoM";
            this.MantenimientoM.Size = new System.Drawing.Size(117, 23);
            this.MantenimientoM.Text = "Mantenimiento";
            // 
            // EmpleadosF
            // 
            this.EmpleadosF.BackColor = System.Drawing.Color.LightGray;
            this.EmpleadosF.Name = "EmpleadosF";
            this.EmpleadosF.Size = new System.Drawing.Size(145, 24);
            this.EmpleadosF.Text = "Empleados";
            this.EmpleadosF.Click += new System.EventHandler(this.EmpleadosF_Click);
            // 
            // UsuariosF
            // 
            this.UsuariosF.BackColor = System.Drawing.Color.LightGray;
            this.UsuariosF.Name = "UsuariosF";
            this.UsuariosF.Size = new System.Drawing.Size(145, 24);
            this.UsuariosF.Text = "Usuarios";
            this.UsuariosF.Click += new System.EventHandler(this.UsuariosF_Click);
            // 
            // EquiposF
            // 
            this.EquiposF.BackColor = System.Drawing.Color.LightGray;
            this.EquiposF.Name = "EquiposF";
            this.EquiposF.Size = new System.Drawing.Size(145, 24);
            this.EquiposF.Text = "Equipos";
            this.EquiposF.Click += new System.EventHandler(this.EquiposF_Click);
            // 
            // ProcesosM
            // 
            this.ProcesosM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegLoteF,
            this.GestionEquiposF});
            this.ProcesosM.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProcesosM.Name = "ProcesosM";
            this.ProcesosM.Size = new System.Drawing.Size(76, 23);
            this.ProcesosM.Text = "Procesos";
            // 
            // RegLoteF
            // 
            this.RegLoteF.BackColor = System.Drawing.Color.LightGray;
            this.RegLoteF.Name = "RegLoteF";
            this.RegLoteF.Size = new System.Drawing.Size(179, 24);
            this.RegLoteF.Text = "Registrar Lote";
            this.RegLoteF.Click += new System.EventHandler(this.RegLoteF_Click);
            // 
            // GestionEquiposF
            // 
            this.GestionEquiposF.BackColor = System.Drawing.Color.LightGray;
            this.GestionEquiposF.Name = "GestionEquiposF";
            this.GestionEquiposF.Size = new System.Drawing.Size(179, 24);
            this.GestionEquiposF.Text = "Gestion Equipos";
            this.GestionEquiposF.Click += new System.EventHandler(this.GestionEquiposF_Click);
            // 
            // ReportesM
            // 
            this.ReportesM.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReportesM.Name = "ReportesM";
            this.ReportesM.Size = new System.Drawing.Size(76, 23);
            this.ReportesM.Text = "Reportes";
            // 
            // AcercaDeM
            // 
            this.AcercaDeM.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AcercaDeM.Name = "AcercaDeM";
            this.AcercaDeM.Size = new System.Drawing.Size(84, 23);
            this.AcercaDeM.Text = "Acerca De";
            this.AcercaDeM.Click += new System.EventHandler(this.AcercaDeM_Click);
            // 
            // SalirM
            // 
            this.SalirM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit});
            this.SalirM.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalirM.Name = "SalirM";
            this.SalirM.Size = new System.Drawing.Size(122, 23);
            this.SalirM.Text = "Cierre de Sesion";
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(106, 24);
            this.exit.Text = "Salir";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 535);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(100, 100);
            this.MinimumSize = new System.Drawing.Size(800, 582);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem Mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem Procesos;
        private System.Windows.Forms.ToolStripMenuItem Reportes;
        private System.Windows.Forms.ToolStripMenuItem Empleados;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MantenimientoM;
        private System.Windows.Forms.ToolStripMenuItem EmpleadosF;
        private System.Windows.Forms.ToolStripMenuItem UsuariosF;
        private System.Windows.Forms.ToolStripMenuItem EquiposF;
        private System.Windows.Forms.ToolStripMenuItem ProcesosM;
        private System.Windows.Forms.ToolStripMenuItem RegLoteF;
        private System.Windows.Forms.ToolStripMenuItem GestionEquiposF;
        private System.Windows.Forms.ToolStripMenuItem ReportesM;
        private System.Windows.Forms.ToolStripMenuItem AcercaDeM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem SalirM;
        private System.Windows.Forms.ToolStripMenuItem exit;
    }
}