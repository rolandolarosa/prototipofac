namespace EfideFactoring.FormulaBase
{
    partial class frmMenuLoad
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
            this.barToolMain = new DevComponents.DotNetBar.Bar();
            this.barStatusMain = new DevComponents.DotNetBar.Bar();
            this.lbluserimg = new DevComponents.DotNetBar.LabelItem();
            this.lblusuario = new DevComponents.DotNetBar.LabelItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.lblFecha = new DevComponents.DotNetBar.LabelItem();
            this.mnuCatalogo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCargaDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOIconos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDesktop = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.barToolMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatusMain)).BeginInit();
            this.mnuDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // barToolMain
            // 
            this.barToolMain.AntiAlias = true;
            this.barToolMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.barToolMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.barToolMain.Location = new System.Drawing.Point(0, 28);
            this.barToolMain.Name = "barToolMain";
            this.barToolMain.Size = new System.Drawing.Size(778, 25);
            this.barToolMain.Stretch = true;
            this.barToolMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barToolMain.TabIndex = 48;
            this.barToolMain.TabStop = false;
            this.barToolMain.Text = "bar1";
            // 
            // barStatusMain
            // 
            this.barStatusMain.AccessibleDescription = "DotNetBar Bar (barStatusMain)";
            this.barStatusMain.AccessibleName = "DotNetBar Bar";
            this.barStatusMain.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.barStatusMain.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.barStatusMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barStatusMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.barStatusMain.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
            this.barStatusMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbluserimg,
            this.lblusuario,
            this.labelItem1,
            this.lblFecha});
            this.barStatusMain.Location = new System.Drawing.Point(0, 449);
            this.barStatusMain.Name = "barStatusMain";
            this.barStatusMain.Size = new System.Drawing.Size(778, 24);
            this.barStatusMain.Stretch = true;
            this.barStatusMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.barStatusMain.TabIndex = 49;
            this.barStatusMain.TabStop = false;
            this.barStatusMain.Text = "Bar3";
            // 
            // lbluserimg
            // 
            this.lbluserimg.Name = "lbluserimg";
            // 
            // lblusuario
            // 
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Text = "lblusuario";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "     ";
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Text = "Fecha";
            // 
            // mnuCatalogo
            // 
            this.mnuCatalogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCargaDatos,
            this.mnuConsultaDatos,
            this.toolStripSeparator17,
            this.mnuSalir});
            this.mnuCatalogo.Name = "mnuCatalogo";
            this.mnuCatalogo.Size = new System.Drawing.Size(57, 24);
            this.mnuCatalogo.Text = "Inicio";
            // 
            // mnuCargaDatos
            // 
            this.mnuCargaDatos.Name = "mnuCargaDatos";
            this.mnuCargaDatos.Size = new System.Drawing.Size(199, 24);
            this.mnuCargaDatos.Text = "Carga de Datos";
            this.mnuCargaDatos.Click += new System.EventHandler(this.mnuCargaDatos_Click);
            // 
            // mnuConsultaDatos
            // 
            this.mnuConsultaDatos.Name = "mnuConsultaDatos";
            this.mnuConsultaDatos.Size = new System.Drawing.Size(199, 24);
            this.mnuConsultaDatos.Text = "Consulta de Datos";
            this.mnuConsultaDatos.Click += new System.EventHandler(this.mnuConsultaDatos_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(196, 6);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(199, 24);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuVentana
            // 
            this.mnuVentana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCascada,
            this.mnuMHorizontal,
            this.mnuMVertical,
            this.mnuOIconos});
            this.mnuVentana.Name = "mnuVentana";
            this.mnuVentana.Size = new System.Drawing.Size(74, 24);
            this.mnuVentana.Text = "Ventana";
            // 
            // mnuCascada
            // 
            this.mnuCascada.Name = "mnuCascada";
            this.mnuCascada.Size = new System.Drawing.Size(208, 24);
            this.mnuCascada.Tag = "0";
            this.mnuCascada.Text = "Cascada";
            // 
            // mnuMHorizontal
            // 
            this.mnuMHorizontal.Name = "mnuMHorizontal";
            this.mnuMHorizontal.Size = new System.Drawing.Size(208, 24);
            this.mnuMHorizontal.Tag = "1";
            this.mnuMHorizontal.Text = "Mosaico Horizontal";
            // 
            // mnuMVertical
            // 
            this.mnuMVertical.Name = "mnuMVertical";
            this.mnuMVertical.Size = new System.Drawing.Size(208, 24);
            this.mnuMVertical.Tag = "2";
            this.mnuMVertical.Text = "Mosaico Vertical";
            // 
            // mnuOIconos
            // 
            this.mnuOIconos.Name = "mnuOIconos";
            this.mnuOIconos.Size = new System.Drawing.Size(208, 24);
            this.mnuOIconos.Tag = "3";
            this.mnuOIconos.Text = "OrganizarIconos";
            // 
            // mnuDesktop
            // 
            this.mnuDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.mnuDesktop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCatalogo,
            this.mnuVentana});
            this.mnuDesktop.Location = new System.Drawing.Point(0, 0);
            this.mnuDesktop.Name = "mnuDesktop";
            this.mnuDesktop.Size = new System.Drawing.Size(778, 28);
            this.mnuDesktop.TabIndex = 3;
            this.mnuDesktop.Text = "menuStrip1";
            // 
            // frmMenuLoad
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::EfideFactoring.Properties.Resources.logo_final_Efide;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(778, 473);
            this.Controls.Add(this.barStatusMain);
            this.Controls.Add(this.barToolMain);
            this.Controls.Add(this.mnuDesktop);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.IsMdiContainer = true;
            this.Name = "frmMenuLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Sistema Carga de Datos ::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barToolMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barStatusMain)).EndInit();
            this.mnuDesktop.ResumeLayout(false);
            this.mnuDesktop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Bar barToolMain;
        internal DevComponents.DotNetBar.Bar barStatusMain;
        internal DevComponents.DotNetBar.LabelItem lbluserimg;
        internal DevComponents.DotNetBar.LabelItem lblusuario;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem lblFecha;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalogo;
        private System.Windows.Forms.ToolStripMenuItem mnuCargaDatos;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaDatos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuVentana;
        private System.Windows.Forms.ToolStripMenuItem mnuCascada;
        private System.Windows.Forms.ToolStripMenuItem mnuMHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuMVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuOIconos;
        private System.Windows.Forms.MenuStrip mnuDesktop;
    }
}