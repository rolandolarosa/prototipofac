namespace Efide.Tesoreria.WinAdeudosInversiones.frmBase
{
    partial class frmBusquedaBase
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
            this.pnlFiltro = new DevComponents.DotNetBar.PanelEx();
            this.toolBar = new DevComponents.DotNetBar.RibbonBar();
            this.btnSeleccionar = new DevComponents.DotNetBar.ButtonItem();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonItem();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.SuspendLayout();
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlFiltro.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlFiltro.Location = new System.Drawing.Point(1, 45);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(779, 104);
            this.pnlFiltro.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlFiltro.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlFiltro.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlFiltro.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlFiltro.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlFiltro.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlFiltro.Style.GradientAngle = 90;
            this.pnlFiltro.TabIndex = 0;
            // 
            // toolBar
            // 
            this.toolBar.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.toolBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.toolBar.ContainerControlProcessDialogKey = true;
            this.toolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSeleccionar,
            this.btnBuscar,
            this.btnSalir});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(780, 39);
            this.toolBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.toolBar.TabIndex = 22;
            // 
            // 
            // 
            this.toolBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSeleccionar.Image = global::Efide.Tesoreria.WinAdeudosInversiones.Properties.Resources.modifica;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.SubItemsExpandWidth = 14;
            this.btnSeleccionar.Text = "Seleccionar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnBuscar.Image = global::Efide.Tesoreria.WinAdeudosInversiones.Properties.Resources.buscar;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.SubItemsExpandWidth = 14;
            this.btnBuscar.Text = "Buscar";
            // 
            // btnSalir
            // 
            this.btnSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSalir.Image = global::Efide.Tesoreria.WinAdeudosInversiones.Properties.Resources.cerrar;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.SubItemsExpandWidth = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmBusquedaBase
            // 
            this.ClientSize = new System.Drawing.Size(780, 378);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.pnlFiltro);
            this.DoubleBuffered = true;
            this.Name = "frmBusquedaBase";
            this.Text = "frmBusquedaBase";
            this.Load += new System.EventHandler(this.frmBusquedaBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.PanelEx pnlFiltro;
        public DevComponents.DotNetBar.RibbonBar toolBar;
        public DevComponents.DotNetBar.ButtonItem btnSeleccionar;
        public DevComponents.DotNetBar.ButtonItem btnSalir;
        public DevComponents.DotNetBar.ButtonItem btnBuscar;
    }
}